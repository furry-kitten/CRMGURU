using DevExpress.Mvvm;
using Egor92.MvvmNavigation.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using WorlWithAPI.Models;
using WorlWithAPI.Models.Navigation;
using WorlWithAPI.Models.Readers;

namespace WorlWithAPI.ViewModels
{
    internal class ViewCountriesVM : BaseVM
    {
        private readonly INavigationManager navigationManager;
#if DEBUG
        private ObservableCollection<Country> countries = new ObservableCollection<Country>()
        {
            new Country()
            {
                Area = 25.5,
                CapitalCity = new City("Санкт-Петербург"),
                Code = "1",
                Name = "125",
                Region = new Region("1234"),
                Townspeople = 5000000
            },
            new Country()
            {
                Area = 25.5,
                CapitalCity = new City("123"),
                Code = "1",
                Name = "12",
                Region = new Region("1234"),
                Townspeople = 12000000
            },
            new Country()
            {
                Area = 25.5,
                CapitalCity = new City("123"),
                Code = "1",
                Name = "12",
                Region = new Region("1234"),
                Townspeople = 12000000
            },
            new Country()
            {
                Area = 25.5,
                CapitalCity = new City("123"),
                Code = "1",
                Name = "12",
                Region = new Region("1234"),
                Townspeople = 12000000
            },
            new Country()
            {
                Area = 25.5,
                CapitalCity = new City("123"),
                Code = "1",
                Name = "12",
                Region = new Region("1234"),
                Townspeople = 12000000
            },
            new Country()
            {
                Area = 25.5,
                CapitalCity = new City("123"),
                Code = "1",
                Name = "12",
                Region = new Region("1234"),
                Townspeople = 12000000
            },
            new Country()
            {
                Area = 25.5,
                CapitalCity = new City("123"),
                Code = "1",
                Name = "12",
                Region = new Region("1234"),
                Townspeople = 12000000
            },
            new Country()
            {
                Area = 25.5,
                CapitalCity = new City("123"),
                Code = "1",
                Name = "12",
                Region = new Region("1234"),
                Townspeople = 12000000
            },
            new Country()
            {
                Area = 25.5,
                CapitalCity = new City("123"),
                Code = "1",
                Name = "12",
                Region = new Region("1234"),
                Townspeople = 12000000
            },
            new Country()
            {
                Area = 25.5,
                CapitalCity = new City("123"),
                Code = "1",
                Name = "12",
                Region = new Region("1234"),
                Townspeople = 12000000
            },
            new Country()
            {
                Area = 25.5,
                CapitalCity = new City("123"),
                Code = "1",
                Name = "12",
                Region = new Region("1234"),
                Townspeople = 12000000
            },
            new Country()
            {
                Area = 25.5,
                CapitalCity = new City("123"),
                Code = "1",
                Name = "12",
                Region = new Region("1234"),
                Townspeople = 12000000
            }
        };
#else
        private ObservableCollection<Country> countries = new ObservableCollection<Country>();
#endif

        private string searchByName = string.Empty;

        public ViewCountriesVM()
        {

        }

        public ViewCountriesVM(INavigationManager navigationManager)
        {
            this.navigationManager = navigationManager;
        }

        public ICommand Search => new DelegateCommand(SearchCountries);

        public string SearchByName
        {
            get => searchByName;
            set
            {
                searchByName = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Country> Countries
        {
            get => countries;
            set
            {
                countries = value;
                OnPropertyChanged();
            }
        }

        public void AllCountries()
        {
            countries = new ObservableCollection<Country>(new DBReader().GetAllCountriesFromDB());

            OnPropertyChanged("Countries");
        }
        public async void SearchCountries()
        {
            var result = await new APIReader().GetCoutries(searchByName);
            countries = new ObservableCollection<Country>(result);

            if(countries.Count == 0 || countries == null)
            {
                if (MessageBox.Show("Такая страна не найдена! Хотите добавить?", "Ошибка поиска", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    navigationManager.Navigate(NavigationKeys.Add);
                }
            }

            OnPropertyChanged("Countries");
        }
    }
}
