using eShop.CoreBusiness.Models;

namespace eShop.UseCases.CustomerPortal.ViewProductScreen
{
    public interface IViewProductUseCase
    {
        Product Execute(int id);
    }
}