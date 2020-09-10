using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorlWithAPI.Models;
using WorlWithAPI.Models.Readers;

namespace WorlWithAPI.ViewModels
{
    internal class ViewDBCountriesVM :BaseVM
    {
        private ObservableCollection<Country> countries = new ObservableCollection<Country>(new DBReader().GetAllCountriesFromDB());

        public ObservableCollection<Country> Countries
        {
            get => countries;
        }
    }
}
