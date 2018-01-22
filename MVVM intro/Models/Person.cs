using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_intro.ViewModels;
using System.ComponentModel;

namespace MVVM_intro.Models
{
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyChangedPerson(string propertyname)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (_firstName != value)
                    _firstName = value;
                NotifyChangedPerson("FirstName");
                NotifyChangedPerson("FullName");
            }
        }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (_lastName != value)
                    _lastName = value;
                NotifyChangedPerson("LastName");
                NotifyChangedPerson("FullName");
            }
        }

        private string _fullName;
        public string FullName
        {
            get
            {
                return _fullName = _firstName + " " + _lastName;
            }
            set
            {
                if (_fullName != value)
                    _fullName = value;
                NotifyChangedPerson("FullName");
            
            }
        }
    }
}
