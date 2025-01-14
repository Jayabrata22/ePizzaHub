using Darchini.Entities;
using Darchini.Repositories;
using eFoodOrder.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace eFoodOrder.Repositories.implementation
{
    public class OrderRepository : Repositoryy<Order>, IorderRepository
    {
        private AppDBContext appDBContext
        {
            get
            {
                return _appDBContext as AppDBContext;
            }
        } 
        public OrderRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Order> GetAllOrders(int userId)
        {
            return appDBContext.Orders.Include(o => o.OrderItems).Where(x => x.UserId == userId).ToList();
        }
    }
}
