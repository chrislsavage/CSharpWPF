using InterfaceProduct.Common.Model;
using System.Collections.Generic;

namespace InterfaceProduct.Common.Contracts
{
    public interface IInventoryStoraService
    {
        void Add(Product product);
        int Quantity(string name);
        Product GetItem(string name);
        void Remove(Product product);

        IEnumerable<Product> GetItems();
    }
}
