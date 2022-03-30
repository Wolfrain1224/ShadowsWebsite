using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ShadowsWebsite.Common.StateManagement;

namespace ShadowsWebsite.Common.SQLAcsess
{
    public class SqlDataAccsess
    {
        private readonly IConfiguration _Config;

        public string ConnectionStringName { get; set; } = "Default";

        public SqlDataAccsess(IConfiguration config)
        {
            _Config = config;
        }

        public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
        {
            string connectionString = _Config.GetConnectionString(ConnectionStringName);
            using (IDbConnection connection = new  SqlConnection(connectionString))
            {
                var data = await connection.QueryAsync<T>(sql, parameters);
                return data.ToList();
            }
        }

        public async Task SaveData<T>(string sql, T parameters)
        {
            string connectionString = _Config.GetConnectionString(ConnectionStringName);
            using (IDbConnection connection = new  SqlConnection(connectionString))
            {
                await connection.ExecuteAsync(sql, parameters);
                
            }
        }
    }
}