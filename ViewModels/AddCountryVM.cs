using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WorlWithAPI.Models;
using WorlWithAPI.Models.Editers;
using WorlWithAPI.Models.Readers;

namespace WorlWithAPI.ViewModels
{
    internal class AddCountryVM : BaseVM
    {
        private ObservableCollection<Country> countries = new ObservableCollection<Country>();

        public AddCountryVM()
        {
            countries.Add(new Country() { IsReadOnly = false });
        }

        public ICommand AddList => new DelegateCommand(Add);

        public ObservableCollection<Country> Countries
        {
            get => countries;
            set
            {
                countries = value;
                OnPropertyChanged();
            }
        }

        private void Add()
        {
            var editer = new DBEditer();
            var reader = new DBReader();

            foreach (var country in countries)
            {
                var countryID = reader.GetID(new SelectCountry().GetIDCountry(country));
                var cityID = reader.GetID(new SelectCity().GetIDCity(country.CapitalCity));
                var regionID = reader.GetID(new SelectRegion().GetIDRegion(country.Region));

                if (cityID == -1)
                {
                    editer.EditDB(new InsertCity().Insert(country.CapitalCity));
                    cityID = reader.GetID(new SelectCity().GetIDCity(country.CapitalCity));
                }

                if (regionID == -1)
                {
                    editer.EditDB(new InsertRegion().Insert(country.Region));
                    regionID = reader.GetID(new SelectRegion().GetIDRegion(country.Region));
                }

                country.CapitalCity = new City(cityID, country.CapitalCity.Name);
                country.Region = new Region(regionID, country.Region.Name);

                OnPropertyChanged("Countries");

                if (countryID == -1)
                {
                    editer.EditDB(new InsertCountry().Insert(country));
                }
                else
                {
                    MessageBox.Show($"{country.Name}");
                }
            }
        }
    }
}
