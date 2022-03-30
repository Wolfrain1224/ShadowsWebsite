using System.Collections.Generic;
using System.Threading.Tasks;
using ShadowsWebsite.Common.Domain;

namespace ShadowsWebsite.Common.SQLAcsess
{
    public class UserData
    {
        private readonly ISqlDataAccess _db;

        public UserData(ISqlDataAccess db)
        {
            _db = db;
        }

        /*public Task InsertPersion(RegisterModel user)
        {
           string sql = @"" 
        }*/
    }
}