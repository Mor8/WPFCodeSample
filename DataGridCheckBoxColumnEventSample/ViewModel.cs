using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridCheckBoxColumnEventSample
{
    class ViewModel
    {
        public ObservableCollection<Person> Persons { get; set; }

        public ViewModel()
        {
            Persons = new ObservableCollection<Person>();
            Persons.Add(new Person { Name = "Aoki", IsValid = true });
            Persons.Add(new Person { Name = "Aikawa", IsValid = false });
        }

    }
}
