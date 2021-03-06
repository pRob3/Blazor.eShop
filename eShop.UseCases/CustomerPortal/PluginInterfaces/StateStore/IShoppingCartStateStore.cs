using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.CustomerPortal.PluginInterfaces.StateStore
{
    public interface IShoppingCartStateStore : IStateStore
    {
        Task<int> GetLineItemsCount();
        void LineItemsCountUpdated();
        void ProductQuantityUpdated();
    }
}
