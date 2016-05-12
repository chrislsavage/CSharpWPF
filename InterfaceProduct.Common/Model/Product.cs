using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProduct.Common.Model
{
    public class Product : INotifyPropertyChanged
    {
        string _Name;

        public string Name
        {
            get { return _Name;  }
            set
            {
                if (_Name != value)
                {
                    _Name = value;
                    PropertyChanged(this, 
                        new PropertyChangedEventArgs("Name"));
                }
            }
        }


        public double _Price;
        public double Price
        {
            get { return _Price; }
            set
            {
                if (_Price != value)
                {
                    _Price = value;
                    PropertyChanged(this,
                        new PropertyChangedEventArgs("Price"));
                }
            }
        }

        //public object EditCommand
        //{
        //    get { throw new NotImplementedException(); }
        //}

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
