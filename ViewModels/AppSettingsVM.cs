using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using WorlWithAPI.Models;

namespace WorlWithAPI.ViewModels
{
    internal class AppSettingsVM : BaseVM
    {
        private string
            id = string.Empty,
            pas = string.Empty,
            datasource = string.Empty,
            catalog = string.Empty;

        public ICommand SaveChanges => new DelegateCommand(Saving);
        public ICommand CombineCS => new DelegateCommand(Combine);

        public string ConnectionString
        {
            get => AppSettings.ConnectionString;
            set
            {
                AppSettings.ConnectionString = value;

                OnPropertyChanged();
            }
        }
        public string City
        {
            get => AppSettings.TableCity;
            set
            {
                AppSettings.TableCity = value;

                OnPropertyChanged();
            }
        }
        public string Region
        {
            get => AppSettings.TableRegion;
            set
            {
                AppSettings.TableRegion = value;

                OnPropertyChanged();
            }
        }
        public string Country
        {
            get => AppSettings.TableCountry;
            set
            {
                AppSettings.TableCountry = value;

                OnPropertyChanged();
            }
        }
        public string DataSource
        {
            get => datasource;
            set
            { 
                datasource = value;
                OnPropertyChanged();
            }
        }
        public string Catalog
        {
            get => catalog;
            set
            {
                catalog = value;
                OnPropertyChanged();
            }
        }
        public string ID
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }
        public string Password
        {
            get => pas;
            set
            {
                pas = value;
                OnPropertyChanged();
            }
        }

        private void Saving()
        {
            AppSettings.SaveChanges();
        }
        private void Combine()
        {
            MessageBox.Show("combine");
            //AppSettings.ConnectionString = $"Data Source={datasource};Initial Catalog={catalog};User ID={id};Password={pas};Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //Saving();
        }
    }
}
