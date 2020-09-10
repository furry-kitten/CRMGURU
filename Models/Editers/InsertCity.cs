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
        public string Insert(City city)
        {
            return $"INSERT INTO [dbo].[{AppSettings.TableCity}] ([Name]) VALUES ('{city.Name}')";
        }
    }
}
