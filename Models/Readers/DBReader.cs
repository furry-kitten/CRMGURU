using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows;

namespace WorlWithAPI.Models.Readers
{
    internal class DBReader
    {
        public int GetID(string commandString)
        {
            int id = -1;

            using (var connection = new SqlConnection(AppSettings.ConnectionString))
            {
                connection.Open();

                var reader = new SqlCommand(commandString, connection).ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    id = (int)reader[0];

                    reader.Close();
                }
            }

            return id;
        }

        public List<Country> GetAllCountriesFromDB()
        {
            var cities = new List<City>();
            var regions = new List<Region>();
            var countries = new List<Country>();

            string str = string.Empty;

            using (var connection = new SqlConnection(AppSettings.ConnectionString))
            {
                connection.Open();

                var cityReader = new SqlCommand(new SelectCity().GetAllCities(), connection).ExecuteReader();

                if (cityReader.HasRows)
                    while (cityReader.Read())
                        cities.Add(new City((int)cityReader["id"], (string)cityReader["Name"]));

                cityReader.Close();

                var regionReader = new SqlCommand(new SelectRegion().GetAllRegions(), connection).ExecuteReader();

                if (regionReader.HasRows)
                    while (regionReader.Read())
                        regions.Add(new Region((int)regionReader["id"], (string)regionReader["Name"]));

                regionReader.Close();

                var countryReader = new SqlCommand(new SelectCountry().GetAllCountries(), connection).ExecuteReader();
                if (countryReader.HasRows)
                    while (countryReader.Read())
                    {
                        countries.Add(new Country(
                            (int)countryReader["id"],
                            (int)countryReader["Towspeople"],
                            (string)countryReader["Name"],
                            (string)countryReader["Code"],
                            regions.Find((r) => r.ID == (int)countryReader["Region"]),
                            cities.Find((c) => c.ID == (int)countryReader["Capital"])));
                    }
                countryReader.Close();
            }

            return countries;
        }
    }
}
