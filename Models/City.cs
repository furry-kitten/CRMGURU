using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WorlWithAPI.Models
{
    [DataContract]
    internal class City : BaseVM
    {
        private int id;
        private string name;

        public City()
        {
            id = -1;
            name = string.Empty;
        }
        public City(string newCity)
        {
            id = -1;
            name = newCity;
        }
        public City(int dbID, string dbName)
        {
            id = dbID;
            name = dbName;
        }

        public int ID => id;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }
    }
}
