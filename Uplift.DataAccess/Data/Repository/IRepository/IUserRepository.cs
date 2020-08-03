using System;
using System.Collections.Generic;
using System.Text;
using Uplift.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Uplift.DataAccess.Data.Repository.IRepository
{
    public interface IUserRepository : IRepository<ApplicationUser>
    {
        void LockUser(string userId);
        void UnlockUser(string userId);

    }
}
