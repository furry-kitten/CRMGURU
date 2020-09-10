using Egor92.MvvmNavigation;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WorlWithAPI.Models.Navigation;
using WorlWithAPI.ViewModels;
using WorlWithAPI.Views;

namespace WorlWithAPI
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var window = new MainWindow();
            var navigationManager = new NavigationManager(window.FrameContent);

            var viewModel = new MainVM(navigationManager);
            window.DataContext = viewModel;

            navigationManager.Register<MainWindow>(NavigationKeys.Main, () => new MainVM(navigationManager));
            navigationManager.Register<ViewCountries>(NavigationKeys.Countries, () => new ViewCountriesVM(navigationManager));
            navigationManager.Register<AddCountry>(NavigationKeys.Add, () => new AddCountryVM());
            navigationManager.Register<ViewDBCountries>(NavigationKeys.DBC, () => new ViewDBCountriesVM());
            navigationManager.Register<AppSettingsView>(NavigationKeys.Settings, () => new AppSettingsVM());

            window.Show();
        }
    }
}
