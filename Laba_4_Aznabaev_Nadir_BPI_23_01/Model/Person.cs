using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4_Aznabaev_Nadir_BPI_23_01.Model
{
    public class Person
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public Person() { }

        public Person(int id, int roleId, string firstName, string lastName, DateTime birthday)
        {
            Id = id;
            RoleId = roleId;
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
        }
    }

}
