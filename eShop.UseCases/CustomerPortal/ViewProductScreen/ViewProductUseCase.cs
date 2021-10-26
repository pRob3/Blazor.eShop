using eShop.CoreBusiness.Models;
using eShop.UseCases.CustomerPortal.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.UseCases.CustomerPortal.ViewProductScreen
{
    public class ViewProductUseCase : IViewProductUseCase
    {
        private readonly IProductRepository productRepository;

        public ViewProductUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public Product Execute(int id)
        {
            return productRepository.GetProduct(id);
        }
    }
}
