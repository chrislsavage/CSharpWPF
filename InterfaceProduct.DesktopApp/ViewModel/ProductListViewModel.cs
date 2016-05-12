using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using InterfaceProduct.Common.Contracts;
using InterfaceProduct.Common.Model;
using InterfaceProduct.Common.Services;
using InterfaceProduct.DesktopApp.Annotations;
using InterfaceProduct.DesktopApp.Messages;
using InterfaceProduct.DesktopApp.Views;
using RelayCommand = GalaSoft.MvvmLight.Command.RelayCommand;

namespace InterfaceProduct.DesktopApp.ViewModel
{
    public class ProductListViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private Product selectedProduct;
        private ICommerceService _commerceService;
        private ICommand _addProductCommand;
        private ICommand _editProductCommand;
      //  public event PropertyChangedEventHandler PropertyChanged;

        public ProductListViewModel(ICommerceService commerceService)
        {
            _commerceService = commerceService;

            Products = new ObservableCollection<Product>(_commerceService.List());
        }

    
        public ObservableCollection<Product> Products { get; private set; }


        public ICommand AddProductCommand
        {
            get
            {
                _addProductCommand = _addProductCommand ?? new RelayCommand(()=>
                {
                    Messenger.Default.Send(new EditProductMessage(this));
                });

                return _addProductCommand;
            }
        }

        public ICommand EditProductCommand
        {
            get
            {
                _editProductCommand = _editProductCommand ?? new RelayCommand<Product>((product) =>
                {
                    Messenger.Default.Send(new EditProductMessage(this, product));
                });

                return _editProductCommand;
            }
        }

    }
}
