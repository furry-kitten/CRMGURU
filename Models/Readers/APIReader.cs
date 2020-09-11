using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;

namespace WorlWithAPI.Models.Readers
{
    /// <summary>
    /// Класс для общения с API
    /// </summary>
    internal class APIReader
    {
        private HttpClient client = new HttpClient();

        /// <summary>
        /// Запрашивает у API список стран
        /// </summary>
        /// <param name="name">Полное название или часть названия страны</param>
        /// <returns></returns>
        public async Task<List<Country>> GetCoutries(string name)
        {
            List<Country> countries = new List<Country>();
            try
            {
                var streamTask = client.GetStreamAsync($"https://restcountries.eu" +
                    $"/rest/v2/name/" +
                    $"{name}" +
                    $"?fields=name;capital;alpha2Code;region;population;area");

                var countries1 = await streamTask;
                countries = await System.Text.Json.JsonSerializer.DeserializeAsync<List<Country>>(countries1);
            }
            catch
            {
            }

            return countries;
        }
    }
}
