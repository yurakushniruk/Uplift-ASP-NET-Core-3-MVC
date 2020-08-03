using System;
using System.Collections.Generic;
using System.Text;
using Uplift.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Uplift.DataAccess.Data.Repository.IRepository
{
    public interface IOrderHeaderRepository : IRepository<OrderHeader>
    {
        void ChangeOrderStatus(int orderHeaderId, string status);
    }
}
