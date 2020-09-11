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
        /// <summary>
        /// Создаёт строку SQL запроса для вывода всех строк из таблицы стран
        /// </summary>
        /// <returns></returns>
        public string GetAllCountries() => $"SELECT * FROM {AppSettings.TableCountry}";

        /// <summary>
        /// Создаёт строку SQL запроса для получения ID страны, поиск выполнет по коду страны
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public string GetIDCountry(Country country) =>
            $"SELECT ID FROM {AppSettings.TableCountry} " +
            $"WHERE Code = '{country.Code}'";
    }
}
