using InterfaceProduct.Common.Contracts;
using InterfaceProduct.Common.Model;
using System.Collections.Generic;
using System.Linq;
using System;

namespace InterfaceProduct.Common.Services
{
    public class SimpleInventoryStoraService : IInventoryStoraService
    {
        private List<Product> _items;

        //Quantity  and GetItem

        public SimpleInventoryStoraService()
        {
            _items = new List<Product>();
             _items.Add(
                new Product() {Name= "Container", Price = 0}
            );
        }

        public int Quantity(string name)
        {
            return _items.Count(s => s.Name == name);
        }

        public Product GetItem(string name)
        {
           return _items.FirstOrDefault(s => s.Name == name);
        }

        public void Add(Product item)
        {
             _items.Add(item);
            
            //List();
        }

        public void Remove(Product item)
        {
            _items.Remove(item);

            //List();
        }

        public IEnumerable<Product> GetItems()
        {
            return _items;
        }
    }
}
