using eShop.UseCases.CustomerPortal.PluginInterfaces.DataStore;
using eShop.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.AdminPortal.OrderDetailScreen
{
    public class ViewOrderDetailUseCase : IViewOrderDetailUseCase
    {
        private readonly IOrderRepository orderRepository;

        public ViewOrderDetailUseCase(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public Order Execute(int orderId)
        {
            return orderRepository.GetOrder(orderId);

        }
    }
}
