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
        public string Insert(Region region) => $"INSERT INTO [dbo].[{AppSettings.TableRegion}] ([Name]) " +
            $"VALUES ('{region.Name}')";
    }
}
