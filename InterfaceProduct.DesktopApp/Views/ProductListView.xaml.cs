using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GalaSoft.MvvmLight.Messaging;
using InterfaceProduct.Common.Model;
using InterfaceProduct.Common.Services;
using InterfaceProduct.DesktopApp.Messages;
using InterfaceProduct.DesktopApp.ViewModel;

namespace InterfaceProduct.DesktopApp.Views
{
    /// <summary>
    /// Interaction logic for ProductListView.xaml
    /// </summary>
    public partial class ProductListView : UserControl
    {
        public ProductListView()
        {
            InitializeComponent();

            Messenger.Default.Register<EditProductMessage>(this, EditProductMessageReceived);

          //  Messenger.Default.Register<SaveProductMessage>(this, SaveProductMessageReceived);

        }

        private void EditProductMessageReceived(EditProductMessage msg)
        {
            //if (msg.Notification == "ShowEditProductView")
           // {
            var editProductView = new EditProductView {DataContext = msg.Product};
            editProductView.Show();
       

            // }
        }

        //private void SaveProductMessageReceived(SaveProductMessage msg)
        //{
        //    if (msg.Notification == "ShowEditProductView")
        //    {
        //        msg.obj.Close();
        //    }
        //}

    }
}
