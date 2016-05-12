using InterfaceProduct.Common.Contracts;
using InterfaceProduct.Common.Model;
using System.Collections.Generic;
using System.Linq;
using System;

namespace InterfaceProduct.Common.Services
{
    public class FileInventoryStorageService : IInventoryStoraService
    {

        private List<Product> _inventory;

        //Quantity  and GetItem


        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public int Quantity(string name)
        {
            throw new NotImplementedException();
        }

        public Product GetItem(string name)
        {
            throw new NotImplementedException();
        }

        public void Remove(Product product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetItems()
        {
            throw new NotImplementedException();
        }
    }
}
