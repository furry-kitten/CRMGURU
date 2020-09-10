using DevExpress.Mvvm;
using Egor92.MvvmNavigation;
using Egor92.MvvmNavigation.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using WorlWithAPI.Models;
using WorlWithAPI.Models.Navigation;
using WorlWithAPI.Models.Readers;

namespace WorlWithAPI.ViewModels
{
    internal class MainVM : BaseVM
    {
        private readonly INavigationManager navigationManager;

        public MainVM()
        {

        }
        public MainVM(INavigationManager navigationManager)
        {
            this.navigationManager = navigationManager;
        }

        public ICommand Search => new DelegateCommand(SearchCountries);
        public ICommand ShowAllCountries => new DelegateCommand(AllCountries);
        public ICommand ShowSettings => new DelegateCommand(SettingsPage);

        private void SearchCountries()
        {
            navigationManager.Navigate(NavigationKeys.Countries);
        }
        private void AllCountries()
        {
            navigationManager.Navigate(NavigationKeys.DBC);
        }
        private void SettingsPage()
        {
            navigationManager.Navigate(NavigationKeys.Settings);
        }
    }
}
