using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using travel.Models;

namespace travel.Repositories
{
    public class VacationsRepository
    {
        public readonly IDbConnection _db;
        public VacationsRepository(IDbConnection db)
        {
            _db = db;
        }
        internal IEnumerable<Vacation> GetAll()
        {
            string sql = "SELECT * FROM trip, cruise;";
            return _db.Query<Vacation>(sql);
        }
    }
}