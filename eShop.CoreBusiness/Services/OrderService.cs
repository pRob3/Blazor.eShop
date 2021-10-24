using eShop.CoreBusiness.Models;

namespace eShop.CoreBusiness.Services
{
    public class OrderService : IOrderService
    {
        public bool ValidateCustomerInformation(
            string name,
            string adress,
            string city,
            string province,
            string country)
        {
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(adress) ||
                string.IsNullOrWhiteSpace(city) ||
                string.IsNullOrWhiteSpace(province) ||
                string.IsNullOrWhiteSpace(country)) return false;

            return true;
        }

        public bool ValidateCreateOrder(Order order)
        {
            // Order has to exists
            if (order == null)
                return false;

            // Order has to have order line items
            if (order.LineItems == null || order.LineItems.Count <= 0)
                return false;

            // Validate line items
            foreach (var item in order.LineItems)
            {
                if (item.ProductId <= 0 ||
                    item.Price < 0 ||
                    item.Quantity <= 0) return false;
            }

            // Validate customer info
            if (!ValidateCustomerInformation(
                order.CustomerName,
                order.CustomerAddress,
                order.CustomerCity,
                order.CustomerStateProvince,
                order.CustomerCountry)) return false;

            return true;
        }

        public bool ValidateUpdateOrder(Order order)
        {
            // Order has to exists
            if (order == null)
                return false;

            // Order has to have order line items
            if (order.LineItems == null || order.LineItems.Count <= 0)
                return false;

            // Placed date has to be populated
            if (!order.DatePlaced.HasValue)
                return false;

            // Other dates check
            if (order.DateProcessed.HasValue || order.DateProcessing.HasValue)
                return false;

            // Validate uniqueId
            if (string.IsNullOrWhiteSpace(order.UniqueId)) return false;

            // Validating line items
            foreach (var item in order.LineItems)
            {
                if (item.ProductId <= 0 ||
                    item.Price < 0 ||
                    item.Quantity <= 0) return false;
            }

            // Validate customer info
            if (!ValidateCustomerInformation(
                order.CustomerName,
                order.CustomerAddress,
                order.CustomerCity,
                order.CustomerStateProvince,
                order.CustomerCountry)) return false;

            return true;
        }

        public bool ValidateProcessOrder(Order order)
        {
            if (!order.DateProcessed.HasValue ||
                string.IsNullOrWhiteSpace(order.AdminUser)) return false;

            return true;
        }
    }
}