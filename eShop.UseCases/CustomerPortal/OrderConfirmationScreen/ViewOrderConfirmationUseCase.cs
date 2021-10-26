using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eShop.CoreBusiness.Models;
using eShop.UseCases.CustomerPortal.PluginInterfaces.DataStore;

namespace eShop.UseCases.CustomerPortal.OrderConfirmationScreen
{
    public class ViewOrderConfirmationUseCase : IViewOrderConfirmationUseCase
    {
        private readonly IOrderRepository orderRepository;

        public ViewOrderConfirmationUseCase(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public Order Execute(string uniqueId)
        {
            return orderRepository.GetOrderByUniqueId(uniqueId);
        }
    }
}
