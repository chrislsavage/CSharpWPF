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
    
    public class EditProductViewModel : ViewModelBase
    {
        private ICommand _saveProductCommand;
        private ICommand _deleteProductCommand;
        private readonly ICommerceService _commerceService;
        public Product Product { get; private set; }

        public EditProductViewModel(ICommerceService commerceService, Product product = null)
        {
           _commerceService = _commerceService;
           Product = product ;
        }

        public ICommand SaveProductCommand
        {
            get
            {
                _saveProductCommand = _saveProductCommand ?? new RelayCommand<Product>((product) =>
                {
                    _commerceService.Add(product);
                    Messenger.Default.Send(new SaveProductMessage(this, product));
                });

                return _saveProductCommand;
            }
        }

        public ICommand DeleteProductCommand
        {
            get
            {
                _deleteProductCommand = _deleteProductCommand ?? new RelayCommand<Product>((product) =>
                {
                    _commerceService.Remove(product);
                    Messenger.Default.Send(new DeleteProductMessage(this, product));
                });

                return _deleteProductCommand;
            }
        }
    }
}
