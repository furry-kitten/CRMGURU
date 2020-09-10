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
