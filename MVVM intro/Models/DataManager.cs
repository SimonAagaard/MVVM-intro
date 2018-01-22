using MVVM_intro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_intro.ViewModels;



namespace MVVM_intro
{
    public class DataManager
    {
        
        public Person ImportantPerson { get; set; }
        public DataManager()
        {
            ImportantPerson = new Person { FirstName = "Fissan", LastName = "Poulsen", FullName =" k" };
        }
        public void NotifyChange()
        {
         
        }
    }
 
}
