using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Rainbow.Shell
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            //pack://application:,,,/Rainbow.Shell;component/Views/Login/LoginWindow.xaml
            this.StartupUri = new Uri("pack://application:,,,/Rainbow.Shell;component/ShellWindow.xaml");
        }
    }
}
