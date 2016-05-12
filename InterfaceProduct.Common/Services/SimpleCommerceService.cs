using InterfaceProduct.Common.Contracts;
using InterfaceProduct.Common.Model;
using System;
using System.Collections.Generic;

namespace InterfaceProduct.Common.Services
{
    public class SimpleCommerceService : ICommerceService
    {
        private readonly IInventoryStoraService _inventoryStoraService;
       // private readonly INotificationService _notificationService;

        public SimpleCommerceService(IInventoryStoraService inventoryStoraService)
        {
            _inventoryStoraService = inventoryStoraService;
            // _notificationService = notificationService;
        }

        public void Add(Product product)
        {
            //business logic and validation
            _inventoryStoraService.Add( product );
           // _notificationService.NotifyMessage("Product Added");
        }

        public void Remove(Product product)
        {
            _inventoryStoraService.Remove(product);
            //  //  _notificationService.NotifyMessage("Product Removed");
            //}
            //else
            //{
            //   // _notificationService.NotifyMessage("Incorrect xxx");
            //}
        }
        public IEnumerable<Product> List()
        {
            return this._inventoryStoraService.GetItems();
        }
    }
}
