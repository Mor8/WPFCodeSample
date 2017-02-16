using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DataGridCheckBoxColumnEventSample
{
    class Person : INotifyPropertyChanged
    {
        string name;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name {
            get { return name; }
            set
            {
                name = value;
                var pc = PropertyChanged;
                if(pc != null)
                {
                    pc(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }
        public bool IsValid { get; set; }
    }
}
