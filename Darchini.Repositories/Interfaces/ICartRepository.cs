using Darchini.Entities;

namespace eFoodOrder.Repositories.Interfaces
{
    public interface ICartRepository : IRepositoryy<Cart>
    {
        Cart GetCart(Guid Cartid);
        int DeleteCart(Guid Cartid, int itemId);
        int UpdateCart(Guid CartId, int UserId);
        int updateQuantity(Guid cartId, int ItemId,int quantity);
    }
}
