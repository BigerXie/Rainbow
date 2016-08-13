using Rainbow.Shell.Constant;
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
    }
}
