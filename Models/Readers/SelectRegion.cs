using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorlWithAPI.Models.Interfaces;

namespace WorlWithAPI.Models.Readers
{
    internal class SelectRegion : IRegionReader
    {
        /// <summary>
        /// Создаёт строку SQL запроса для получения всех записей из таблицы регионов
        /// </summary>
        /// <returns></returns>
        public string GetAllRegions() => $"SELECT * FROM {AppSettings.TableRegion}";

        /// <summary>
        /// Создаёт строку SQL запроса для получения id найденого региона
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        public string GetIDRegion(Region region) =>
            $"SELECT ID FROM {AppSettings.TableRegion} " +
            $"WHERE Name = '{region.Name}'";
    }
}
