using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorlWithAPI.Models.Interfaces;

namespace WorlWithAPI.Models.Editers
{
    internal class InsertCountry : ICountrySaver
    {
        public string Insert(Country country) =>
            $"INSERT INTO [dbo].[{AppSettings.TableCountry}] ([Name], [Capital], [Area], [Towspeople], [Region], [Code]) " +
            $"VALUES ('{country.Name}', {country.CapitalCity.ID}, {country.Area}, {country.Townspeople}, {country.Region.ID}, '{country.Code}')";
    }
}
