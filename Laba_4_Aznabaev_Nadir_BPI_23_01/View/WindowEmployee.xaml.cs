using Laba_4_Aznabaev_Nadir_BPI_23_01.ViewModel;
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

namespace Laba_4_Aznabaev_Nadir_BPI_23_01.View
{
    /// <summary>
    /// Логика взаимодействия для WindowEmployee.xaml
    /// </summary>
    public partial class WindowEmployee : Window
    {
        public WindowEmployee()
        {
            InitializeComponent();
            PersonViewModel Person = new PersonViewModel();
            Employee.ItemsSource = Person.ListPerson;
        }
    }
}
