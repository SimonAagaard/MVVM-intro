using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_intro.Models;
using MVVM_intro.Views;

namespace MVVM_intro.ViewModels
{
    public class MainViewModel
    {
        DataManager data = new DataManager();
        //MainWindow main = new MainWindow();

        public Person ImportantPerson { get; set; }
        

        public MainViewModel()
        {
            ImportantPerson = data.ImportantPerson;
         
        }
        public void NotifyChange()
        {
            
        }
    }
}
