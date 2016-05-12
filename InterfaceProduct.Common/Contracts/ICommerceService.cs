using InterfaceProduct.Common.Model;

namespace InterfaceProduct.Common.Contracts
{
    public interface ICommerceService
    {
        void Add(Product product);
        void Remove(string name);
        void List();
    }
}
