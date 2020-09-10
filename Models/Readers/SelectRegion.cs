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
        public string GetAllRegions() => $"SELECT * FROM {AppSettings.TableRegion}";

        public string GetIDRegion(Region region) =>
            $"SELECT ID FROM {AppSettings.TableRegion} " +
            $"WHERE Name = '{region.Name}'";
    }
}
