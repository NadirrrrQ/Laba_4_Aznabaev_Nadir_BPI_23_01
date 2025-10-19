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

namespace Laba_4_Aznabaev_Nadir_BPI_23_01
{
    /// <summary>
    /// Логика взаимодействия для WindowNewEmployee.xaml
    /// </summary>
    public partial class WindowNewEmployee : Window
    {
        public Role SelectedRole => CbRole.SelectedItem as Role;

        public WindowNewEmployee()
        {
            InitializeComponent();
            var vmRole = new RoleViewModel();
            CbRole.ItemsSource = vmRole.ListRole;
            CbRole.SelectedIndex = 0;
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
