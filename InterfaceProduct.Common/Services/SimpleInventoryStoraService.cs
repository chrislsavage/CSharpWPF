using InterfaceProduct.Common.Contracts;
using InterfaceProduct.Common.Model;
using System.Collections.Generic;
using System.Linq;

namespace InterfaceProduct.Common.Services
{
    public class SimpleInventoryStoraService : IInventoryStoraService
    {
       private List<Product> _inventory;

        public SimpleInventoryStoraService( )
        {
            _inventory = new List<Product>();
            _inventory.Add(new Product()
            {
                Name = "Coke",
                Price = 2.5
            });
            _inventory.Add(new Product()
            {
                Name = "Sprite",
                Price = 2.5
            });
        }

        public int Quantity( string name)
        {
            return _inventory.Count(s => s.Name == name);
        }

        public Product GetItem( string name)
        {
            return _inventory.FirstOrDefault(s => s.Name == name);
        }

        public void Add( Product item)
        {
            _inventory.Add(item);
        }

        public void Remove(Product item)
        {
            _inventory.Remove(item);
        }

        public IEnumerable<Product> GetItems()
        {
            return _inventory.AsEnumerable();
        }

        
    }
}
