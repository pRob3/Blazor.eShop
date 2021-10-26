using eShop.CoreBusiness.Models;
using System.Threading.Tasks;

namespace eShop.UseCases.CustomerPortal.ShoppingCartScreen
{
    public interface IDeleteProductUseCase
    {
        Task<Order> Execute(int productId);
    }
}