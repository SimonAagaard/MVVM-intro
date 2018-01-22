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
using System.Windows.Shapes;
using MVVM_intro.ViewModels;
using System.ComponentModel;
using MVVM_intro.Models;

namespace MVVM_intro.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel mainViewModel = new MainViewModel();
       
        
       
        public MainWindow()
        {
            InitializeComponent();
            FirstName.Text = mainViewModel.ImportantPerson.FirstName;
            LastName.Text = mainViewModel.ImportantPerson.LastName;
            FullName.Text = mainViewModel.ImportantPerson.FullName;
        }

        public void Save_Click(object sender, RoutedEventArgs e)
        {
            Person person = new Person();
            mainViewModel.ImportantPerson.FirstName = FirstName.Text;
            mainViewModel.ImportantPerson.LastName = LastName.Text;
            FullName.Text = mainViewModel.ImportantPerson.FirstName + mainViewModel.ImportantPerson.LastName;

        }
       

      
    }
}
