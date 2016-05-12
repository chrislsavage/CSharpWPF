using System.Collections.Generic;
using InterfaceProduct.Common.Model;

namespace InterfaceProduct.Common.Contracts
{
    public interface ICommerceService
    {
        void Add(Product product);
        void Remove(Product product);
        IEnumerable<Product> List();
    }
}
