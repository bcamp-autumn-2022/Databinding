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

namespace Databinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person objectPerson=new Person();

        public MainWindow()
        {
            InitializeComponent();
            objectPerson = new Person();
            objectPerson.Fname = "Simon";
            this.DataContext= objectPerson;

        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            
            tbCheck.Text=objectPerson.Fname;
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            objectPerson.Fname = "Lisa";
        }

 
    }
}
