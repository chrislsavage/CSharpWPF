using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using InterfaceProduct.Common.Contracts;
using InterfaceProduct.Common.Model;
using InterfaceProduct.DesktopApp.Annotations;
using InterfaceProduct.DesktopApp.Views;

namespace InterfaceProduct.DesktopApp.ViewModel
{
    public class ProductListViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private Product selectedProduct;
        private ICommerceService _commerceService;
        private IInventoryStoraService _inventoryStoraService;
        public event PropertyChangedEventHandler PropertyChanged;

        public ProductListViewModel()
        {
            
        }

    
    }
}
