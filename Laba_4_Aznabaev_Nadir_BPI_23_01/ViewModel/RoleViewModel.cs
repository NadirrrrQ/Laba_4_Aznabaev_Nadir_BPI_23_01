using Laba_4_Aznabaev_Nadir_BPI_23_01.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4_Aznabaev_Nadir_BPI_23_01.ViewModel
{
    public class RoleViewModel
    {
        public ObservableCollection<Role> ListRole { get; set; } = new ObservableCollection<Role>();
        public RoleViewModel()
        {
            ListRole.Add(
            new Role
            {
                Id = 1,
                NameRole = "Директор"
            }
            );
            ListRole.Add(
            new Role
            {
                Id = 2,
                NameRole = "Бухгалтер"
            }
            );
            ListRole.Add(new Role
            {
                Id = 3,
                NameRole = "Менеджер"

            });
        }
    }
}
