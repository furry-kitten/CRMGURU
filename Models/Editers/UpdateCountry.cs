using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorlWithAPI.Models.Interfaces;

namespace WorlWithAPI.Models.Editers
{
    internal class UpdateCountry : IUpdateCountry
    {
        /// <summary>
        /// Создаёт строку SQL запроса для обновления таблица стран
        /// </summary>
        /// <param name="country"></param>
        /// <param name="id">Индетификатор соответствующий этой стране, не должен быть равен -1</param>
        /// <returns></returns>
        public string UpdateCountryString(Country country, int id) => $"UPDATE [dbo].[Country] " +
            $"SET " +
            $"[Name] = '{country.Name}', " +
            $"[Capital] = {country.CapitalCity.ID}, " +
            $"[Area] = {country.Area}, " +
            $"[Towspeople] = {country.Townspeople}, " +
            $"[Region] = {country.Region.ID}, " +
            $"[Code] = '{country.Code}' " +
            $"WHERE [id] = {id}";
    }
}
