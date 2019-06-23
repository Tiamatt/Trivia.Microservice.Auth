using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Auth.Contracts;
using Auth.Contracts.Entities;
using Microsoft.Extensions.Options;
using System.Linq;
using Dapper;

namespace Auth.DataAccess
{
    public class MainDataAccess: IMainDataAccess
    {
        private readonly IOptions<AuthConfig> _configuration;
        private readonly string _connectionString;

        public MainDataAccess(IOptions<AuthConfig> configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.Value.ConnectionString;
        }

        public IEnumerable<loginType> GetLoginTypes(bool? isActive)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string query = @"
                    SELECT * FROM dbo.loginType 
                    WHERE(isActive IS NULL OR isActive = @IsActive)
                ";
                var results = db.Query<loginType>(query, new { IsActive = isActive }).ToList();
                return (results.Count > 0) ? results : null;
            }
        }
    }
}
