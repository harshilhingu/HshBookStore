
using HshBooks.DataAccess.Repository.IRepository;
using HshBookStore.DataAccess.Data;
using HshBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HshBooks.DataAccess.Repository
{
    public class UnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
        }
        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }

    }
}
