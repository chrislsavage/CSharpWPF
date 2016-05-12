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
        private List<Product> _inventory;

        public SimpleCommerceService(IInventoryStoraService inventoryStoraService)
        {
            _inventoryStoraService = inventoryStoraService;
            _inventory = new List<Product> {new Product() {Name = "Container", Price = 1.00}};
            // _notificationService = notificationService;
        }

        public void Add(Product product)
        {
            //business logic and validation
            _inventoryStoraService.Add(_inventory, product);
           // _notificationService.NotifyMessage("Product Added");
        }

        public void Remove(string name)
        {
            Product product= _inventoryStoraService.GetItem(name);
            Console.WriteLine($"Is {product.Name}, Price {product.Price} the correct item to remove?");
            Console.WriteLine("Type 'Y' for Yes and 'N' for No.");
            int response = Console.Read();
            if (response == 89 || response == 121)
            {
                _inventoryStoraService.Remove(product);
              //  _notificationService.NotifyMessage("Product Removed");
            }
            else
            {
               // _notificationService.NotifyMessage("Incorrect xxx");
            }
        }
        public void List()
        {
            foreach (var item in this._inventoryStoraService.GetItems())
            {
                //int counter = 1;
                Console.WriteLine($"{item.Name}, Price: {item.Price}");
                //++counter;
            }
        }
    }
}
