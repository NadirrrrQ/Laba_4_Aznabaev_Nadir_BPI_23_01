using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4_Aznabaev_Nadir_BPI_23_01.Model
{
    public class Role
    {
        public int Id { get; set; }
        public string NameRole { get; set; }
        public Role() { }
        public Role(int id, string nameRole)
        {
            Id = id;
            NameRole = nameRole;
        }
    }

}
