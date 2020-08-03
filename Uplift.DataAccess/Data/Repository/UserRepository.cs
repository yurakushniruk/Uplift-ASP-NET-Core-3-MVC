using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using Uplift.DataAccess.Data.Repository.IRepository;
using Uplift.Models;

namespace Uplift.DataAccess.Data.Repository
{
    public class UserRepository : Repository<ApplicationUser>, IUserRepository
    {
        private readonly ApplicationDbContext _db;

        public UserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        void IUserRepository.LockUser(string userId)
        {
            var userFormDb = _db.ApplicationUser.FirstOrDefault(u => u.Id == userId);
            userFormDb.LockoutEnd = DateTime.Now.AddYears(1000);
            _db.SaveChanges();
        }

        void IUserRepository.UnlockUser(string userId)
        {
            var userFormDb = _db.ApplicationUser.FirstOrDefault(u => u.Id == userId);
            userFormDb.LockoutEnd = DateTime.Now;
            _db.SaveChanges();
        }
    }
}
