using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4_Aznabaev_Nadir_BPI_23_01
{
    public class Role : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string NameRole { get; internal set; }
    }
}
