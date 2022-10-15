using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Databinding
{
    internal class Person:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private string fname = string.Empty;
        public string Fname
        {
            get
            {
                return this.fname;
            }

            set
            {
                if (value != this.fname)
                {
                    this.fname = value;
                    NotifyPropertyChanged();
                }
            }
        }

    }
}
