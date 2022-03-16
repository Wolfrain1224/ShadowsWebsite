using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using ShadowsWebsite.Common.Domain;
using Microsoft.Data.SqlClient;
using ShadowsWebsite.Common.Configuartion;

namespace ShadowsWebsite.api.Repository
{
    public class ErrorLogRepository
    {
        private readonly SqlConnectionConfiguration _config;
        private IDbConnection Con => new SqlConnection(_config.Value);

        public ErrorLogRepository(SqlConnectionConfiguration config)
        {
            _config = config;
        }
        public async Task<IEnumerable<ErrorLogModle>> GetAllErrorLogs()
        {
            IEnumerable<ErrorLogModle> errorLogs = new List<ErrorLogModle>();

            using (IDbConnection conn = Con)
            {
                try
                {
                    var sql = @"SELECT TOP (100) [ID],[Username],[Password],[RealFirstname],[RealLastname],[Email],[Phone] FROM [ShadowsWebsite].[dbo].[PersonLogin]";
                    errorLogs = conn.QueryAsync<ErrorLogModle>(sql).Result.ToList();
                }
                catch (Exception ex)
                {
                    throw;
                }

                return errorLogs;
            }
        }
        
    }
}