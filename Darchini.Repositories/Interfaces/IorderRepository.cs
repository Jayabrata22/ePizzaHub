using Darchini.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFoodOrder.Repositories.Interfaces
{
    public interface IorderRepository
    {

        IEnumerable<Order> GetAllOrders(int userId);
    }
}
