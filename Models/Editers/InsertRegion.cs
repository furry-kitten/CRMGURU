using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorlWithAPI.Models.Interfaces;

namespace WorlWithAPI.Models.Editers
{
    internal class InsertRegion : IRegionSaver
    {
        /// <summary>
        /// Создаёт строку SQL запроса на заполнение таблицы регионов
        /// </summary>
        /// <param name="region"></param>
        /// <returns></returns>
        public string Insert(Region region) => $"INSERT INTO [dbo].[{AppSettings.TableRegion}] ([Name]) " +
            $"VALUES ('{region.Name}')";
    }
}
