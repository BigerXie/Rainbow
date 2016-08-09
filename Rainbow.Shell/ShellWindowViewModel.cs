using Microsoft.Practices.Prism.Mvvm;
using Rainbow.Shell.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow.Shell
{
    public class ShellWindowViewModel : BindableBase
    {
        private ObservableCollection<MenuItem> _MenuItems;
        public ObservableCollection<MenuItem> MenuItems
        {
            get { return this._MenuItems; }
            set { SetProperty<ObservableCollection<MenuItem>>(ref this._MenuItems, value); }
        }
    }
}
