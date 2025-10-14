using Laba_4_Aznabaev_Nadir_BPI_23_01.Helper;
using Laba_4_Aznabaev_Nadir_BPI_23_01.Model;
using Laba_4_Aznabaev_Nadir_BPI_23_01.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


            RoleViewModel Role = new RoleViewModel();

            List<Role> roles = new List<Role>();
            ObservableCollection<PersonDPO> persons = new ObservableCollection<PersonDPO>();

            foreach (Role r in Role.ListRole)
            {
                roles.Add(r);
            }
            FindRole finder;
            foreach (var p in Person.ListPerson)
            {
                finder = new FindRole(p.RoleId);
                Role rol = roles.Find(new Predicate<Role>(finder.RolePredicate));
                persons.Add(new PersonDPO
                {
                    Id = p.Id,
                    Role = rol.NameRole,
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    Birthday = p.Birthday
                });

            }
            Employee.ItemsSource = persons;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delet_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
