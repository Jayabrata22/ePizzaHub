using Darchini.Entities;
using Darchini.Repositories;
using eFoodOrder.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace eFoodOrder.Repositories.implementation
{
    public class CartRepository : Repositoryy<Cart>, ICartRepository
    {
        private AppDBContext dbContext
        {
            get
            {
                return _appDBContext as AppDBContext;
            }
        }
        public CartRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public int DeleteCart(Guid Cartid, int itemId)
        {
            var item = dbContext.CartItems.Where(x => x.CartId == Cartid && x.ItemId == itemId).FirstOrDefault();
            if (item != null)
            {
                dbContext.CartItems.Remove(item);
                return dbContext.SaveChanges();

            }
            else
            {
                return 0;
            }
            

        }

        public Cart GetCart(Guid Cartid)
        {
            return dbContext.Carts.Include("Items").Where(c => c.Id == Cartid && c.IsActive == true).FirstOrDefault();
        }

        public int UpdateCart(Guid CartId, int UserId)
        {
            Cart cart = GetCart(CartId);
            cart.UserId = UserId;
            return dbContext.SaveChanges();
        }

        public int updateQuantity(Guid cartId, int ItemId, int quantity)
        {
            bool flag = false;
            var cart = GetCart(cartId);
            if(cart != null)
            {
                for(int i = 0; i < cart.Items.Count; i++)
                {
                    if(cart.Items[i].Id == cartId)
                    {
                        flag = true;
                        if(quantity < 0 && cart.Items[i].Quantity > 1)
                            cart.Items[i].Quantity += quantity;
                        else if (quantity >0)
                            cart.Items[i].Quantity += quantity;
                        break;
                    }
                }
                if (flag)
                    return dbContext.SaveChanges();
            }
            return 0;
        }
    }
}
