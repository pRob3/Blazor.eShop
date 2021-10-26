using eShop.CoreBusiness.Models;
using System.Threading.Tasks;

namespace eShop.UseCases.CustomerPortal.PlaceOrderScreen
{
    public interface IPlaceOrderUseCase
    {
        Task<string> Execute(Order order);
    }
}