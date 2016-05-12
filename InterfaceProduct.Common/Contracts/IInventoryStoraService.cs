using InterfaceProduct.Common.Model;
using System.Collections.Generic;

namespace InterfaceProduct.Common.Contracts
{
    public interface IInventoryStoraService
    {
        void Add(List<Product> inventory, Product product);
        int Quantity(List<Product> inventory, string name);
        Product GetItem(List<Product> inventory, string name);
        void Remove(List<Product> inventory, Product product);

        IEnumerable<Product> GetItems();
    }
}
