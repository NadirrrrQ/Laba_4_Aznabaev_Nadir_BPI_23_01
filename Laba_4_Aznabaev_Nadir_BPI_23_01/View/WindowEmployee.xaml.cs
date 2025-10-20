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

            DataContext = new PersonViewModel();

            List<Role> roles = new List<Role>();
            ObservableCollection<PersonDpo> persons = new ObservableCollection<PersonDpo>();

            foreach (Role r in Role.ListRole)
            {
                roles.Add(r);
            }
            FindRole finder;
            foreach (var p in Person.ListPerson)
            {
                finder = new FindRole(p.RoleId);
                Role rol = roles.Find(new Predicate<Role>(finder.RolePredicate));
                persons.Add(new PersonDpo
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


    }
}
