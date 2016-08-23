using Rainbow.Shell.Constant;
using Rainbow.Shell.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rainbow.Shell
{
    /// <summary>
    /// Interaction logic for ShellWindow.xaml
    /// </summary>
    public partial class ShellWindow : Window
    {
        public ShellWindowViewModel ViewModel { get; set; }
        public ShellWindow()
        {
            InitializeComponent();
            this.ViewModel = new ShellWindowViewModel();
            this.ViewModel.MenuItems = new System.Collections.ObjectModel.ObservableCollection<Models.MenuItem>();
            this.ViewModel.MenuItems.Add(new Models.MenuItem() { Title = "功能目录", Icon = "/Images/Catalog.png" });
            this.ViewModel.MenuItems.Add(new Models.MenuItem() { Title = "彩虹桥", Icon = "/Images/Catalog.png" });
            this.ViewModel.MenuItems.Add(new Models.MenuItem() { Title = "功能目录", Icon = "/Images/Catalog.png" });
            this.rbPageBar.ItemsSource = this.ViewModel.MenuItems;
            
        }
        private FunctionCatalogPage _CatalogPage = new FunctionCatalogPage();
        private PersonPage _PersonPage = new PersonPage();
        private MessagePage _MessagePage = new MessagePage();
        private SettingPage _SettingPage = new SettingPage();
        private void CatalogButton_Click(object sender, RoutedEventArgs e)
        {
            this.MainPlaceHolder.Child = _CatalogPage;
        }

        private void UserButton_Click(object sender, RoutedEventArgs e)
        {
            this.MainPlaceHolder.Child = _PersonPage;
        }

        private void MessageButton_Click(object sender, RoutedEventArgs e)
        {
            this.MainPlaceHolder.Child = _MessagePage;
        }

        private void SetupButton_Click(object sender, RoutedEventArgs e)
        {
            this.MainPlaceHolder.Child = _SettingPage;
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            this.MainPlaceHolder.Child =null;
        }
    }
}
