using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorlWithAPI.Models.Interfaces;

namespace WorlWithAPI.Models.Readers
{
    internal class SelectCountry : ICountryReader
    {
        public string GetAllCountries() => $"SELECT * FROM {AppSettings.TableCountry}";

        public string GetIDCountry(Country country) =>
            $"SELECT ID FROM {AppSettings.TableCountry} " +
            $"WHERE Code = '{country.Code}'";
    }
}
