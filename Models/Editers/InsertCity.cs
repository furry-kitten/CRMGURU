using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorlWithAPI.Models.Interfaces;

namespace WorlWithAPI.Models.Editers
{
    internal class InsertCity : ICitySaver
    {
        /// <summary>
        /// Создаёт строку SQL запроса на заполнение таблицы городов
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        public string Insert(City city)
        {
            return $"INSERT INTO [dbo].[{AppSettings.TableCity}] ([Name]) VALUES ('{city.Name}')";
        }
    }
}
