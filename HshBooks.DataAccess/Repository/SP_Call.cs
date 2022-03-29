using HshBooks.DataAccess.Repository.IRepository;
using HshBookStore.DataAccess.Data;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HshBooks.DataAccess.Repository
{
    public class SP_Call : ISP_Call
    {
        private readonly ApplicationDbContext _db;
        private static string Connectionstring = "";

        public SP_Call(ApplicationDbContext db)
        {
            _db = db;
            Connectionstring = db.Database.GetDbConnection().ConnectionString;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Execute(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> List<T>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }

        public Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }

        public T OneRecord<T>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }

        public T Single<T>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }
    }
}
