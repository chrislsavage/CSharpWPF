using InterfaceProduct.Common.Contracts;
using InterfaceProduct.Common.Model;
using System.Collections.Generic;
using System.Linq;

namespace InterfaceProduct.Common.Services
{
    public class SimpleInventoryStoraService : IInventoryStoraService
    {
       private List<Product> _inventory;

        //Quantity  and GetItem

        public SimpleInventoryStoraService(List<Product> inventory )
        {
            _inventory = inventory;
        }

        public int Quantity(List<Product> _inventory, string name)
        {
            return _inventory.Count(s => s.Name == name);
        }

        public Product GetItem(List<Product> _inventory, string name)
        {
            return _inventory.FirstOrDefault(s => s.Name == name);
        }

        public void Add(List<Product> _inventory, Product item)
        {
            _inventory.Add(item);

            //List();
        }

        public void Remove(List<Product> _inventory, Product item)
        {
            _inventory.Remove(item);

            //List();
        }

        public IEnumerable<Product> GetItems()
        {
            return _inventory.AsEnumerable();
        }

        
    }
}
