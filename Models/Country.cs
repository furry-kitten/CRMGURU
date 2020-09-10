using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WorlWithAPI.Models
{
    [DataContract]
    internal class Country : BaseVM
    {
        private bool isReadOnly = true;
        private int
            id,
            townspeople;
        private string
            name,
            code;

        private Region region;
        private City capitalCity;

        private double area;

        public Country()
        {
            id = -1;
            isReadOnly = true;
            townspeople = 0;
            name = string.Empty;
            code = string.Empty;
            region = new Region();
            capitalCity = new City();
        }
        public Country(int newTownspeople, string newName, string newCode, Region newRegion, City newCapitalCity)
        {
            id = -1;
            townspeople = newTownspeople;
            name = newName;
            code = newCode;
            region = newRegion;
            capitalCity = newCapitalCity;
        }
        public Country(int dbID, int dbTownspeople, string dbName, string dbCode, Region dbRegion, City dbCapitalCity)
        {
            id = dbID;
            townspeople = dbTownspeople;
            name = dbName;
            code = dbCode;
            region = dbRegion;
            capitalCity = dbCapitalCity;
        }

        public bool IsReadOnly
        {
            get => isReadOnly;
            set { isReadOnly = value; OnPropertyChanged(); }
        }
        public int ID => id;
        [JsonPropertyName("population")]
        public int Townspeople
        {
            get => townspeople;
            set { townspeople = value; OnPropertyChanged(); }
        }
        [JsonPropertyName("area")]
        public double Area
        {
            get => area;
            set { area = value; OnPropertyChanged(); }
        }
        [JsonPropertyName("name")]
        public string Name
        {
            get => name;
            set { name = value; OnPropertyChanged(); }
        }
        [JsonPropertyName("alpha2Code")]
        public string Code
        {
            get => code;
            set { code = value; OnPropertyChanged(); }
        }
        [JsonPropertyName("region")]
        public string RegionName
        {
            get => region.Name;
            set { region = new Region(value); OnPropertyChanged("Region"); }
        }
        [JsonPropertyName("capital")]
        public string CapitalName
        {
            get => capitalCity.Name;
            set { capitalCity = new City(value); OnPropertyChanged("CapitalCity"); }
        }
        public Region Region
        {
            get => region;
            set { region = value; OnPropertyChanged(); }
        }
        public City CapitalCity
        {
            get => capitalCity;
            set { capitalCity = value; OnPropertyChanged(); }
        }
    }
}
