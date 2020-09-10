using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorlWithAPI.Models
{
    internal static class AppSettings
    {
        public static string ConnectionString
        {
            get => Properties.Settings.Default.ConnectionString;
            set { Properties.Settings.Default.ConnectionString = value; }
        }
        public static string TableCity
        {
            get => Properties.Settings.Default.TableCity;
            set { Properties.Settings.Default.TableCity = value; }
        }
        public static string TableRegion
        {
            get => Properties.Settings.Default.TableRegion;
            set { Properties.Settings.Default.ConnectionString = value; }
        }
        public static string TableCountry
        {
            get => Properties.Settings.Default.TableCountry;
            set { Properties.Settings.Default.TableCountry = value; }
        }

        public static void SaveChanges()
        {
            Properties.Settings.Default.Save();
        }
    }
}
