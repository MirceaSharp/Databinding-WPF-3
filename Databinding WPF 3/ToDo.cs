using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databinding_WPF_3
{
    class ToDo:INotifyPropertyChanged,IDataErrorInfo
    {

        private string _when;
        private string _what;
        private string _who;

        private void RaisePropertyChanged(string text)
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        

        public string When
        {
            get
            {
                return _when;
            }
            set
            {
                _when = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("When"));
                }
            }
        }
        public string What
        {
            get
            {
                return _what;
            }
            set
            {
                _what = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("What"));
                }
            }
        }

        public string Who
        {
            get
            {
                return _who;
            }
            set
            {
                _who = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Who"));
                }
            }
        }
           

        public string Error { get; }

        public ToDo(string when, string what, string who)
        {
            this.When = when;
            this.What = what;
            this.Who = who;
        }
        public override string ToString()
        {
            return When + "   " + Who + "   " + What;
        }

        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    default: return null;
                }
            }
        }

    }
}
