using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorlWithAPI.Models.Interfaces;

namespace WorlWithAPI.Models.Readers
{
    internal class SelectCity : ICityReader
    {
        public string GetAllCities() => $"SELECT * FROM {AppSettings.TableCity}";

        public string GetIDCity(City city) =>
            $"SELECT ID FROM {AppSettings.TableCity} " +
            $"WHERE Name = '{city.Name}'";
    }
}
