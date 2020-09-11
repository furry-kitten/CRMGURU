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
        /// <summary>
        /// Создаёт строку SQL запроса для получения всех записей из таблицы городов
        /// </summary>
        /// <returns></returns>
        public string GetAllCities() => $"SELECT * FROM {AppSettings.TableCity}";

        /// <summary>
        /// Создаёт строку SQL запроса для получения id найденого города
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        public string GetIDCity(City city) =>
            $"SELECT ID FROM {AppSettings.TableCity} " +
            $"WHERE Name = '{city.Name}'";
    }
}
