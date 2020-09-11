using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorlWithAPI.Models
{
    [Serializable]
    internal class Region : BaseVM
    {
        private int id;
        private string name;

        public Region()
        {
            id = -1;
            name = string.Empty;
        }
        public Region(string newCity)
        {
            id = -1;
            name = newCity;
        }
        public Region(int dbID, string dbName)
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
