using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using Rainbow.Controls;
using Rainbow.Shell.Models;
using Rainbow.Shell.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace Rainbow.Shell
{
    public class ShellWindowViewModel : BindableBase
    {
        #region Property

        private Dictionary<MenuItem, RbPage> Pages = new Dictionary<MenuItem, RbPage>();

        private HomePage HomePage = new HomePage();

        private ListCollectionView _MenuItems = new ListCollectionView(new ObservableCollection<MenuItem>());
        public ListCollectionView MenuItems
        {
            get { return this._MenuItems; }
            set { SetProperty<ListCollectionView>(ref this._MenuItems, value, "MenuItems"); }
        }

        private RbPage _CurrentPage;
        public RbPage CurrentPage
        {
            get { return this._CurrentPage; }
            set { SetProperty<RbPage>(ref this._CurrentPage, value, "CurrentPage"); }
        }

        private MenuItem _SelectedMenuItem;
        public MenuItem SelectedMenuItem
        {
            get { return this._SelectedMenuItem; }
            set { SetProperty<MenuItem>(ref this._SelectedMenuItem, value, "SelectedMenuItem"); }
        }

        #endregion

        #region Command

        public ICommand OpenCatalogPageCmd { get; set; }
        public ICommand OpenPersonalPageCmd { get; set; }
        public ICommand OpenMessagePageCmd { get; set; }
        public ICommand OpenSettingPageCmd { get; set; }
        public ICommand OpenHomePageCmd { get; set; }

        #endregion

        #region Ctor
        public ShellWindowViewModel()
        {
            InitPages();
            this.OpenCatalogPageCmd = new DelegateCommand(this.OpenCatalogPage);
            this.OpenPersonalPageCmd = new DelegateCommand(this.OpenPersonalPage);
            this.OpenMessagePageCmd = new DelegateCommand(this.OpenMessagePage);
            this.OpenSettingPageCmd = new DelegateCommand(this.OpenSettingPage);
            this.OpenHomePageCmd = new DelegateCommand(this.OpenHomePage);
        }
        #endregion

        #region Method
        private void InitPages()
        {
            MenuItem menuItem = new MenuItem()
            {
                FunctionId = "101",
                Icon = "/Images/Catalog.png",
                Title = "功能目录"
            };
            Pages.Add(menuItem, new FunctionCatalogPage());
            menuItem = new MenuItem()
            {
                FunctionId = "102",
                Icon = "/Images/Catalog.png",
                Title = "我的主页"
            };
            Pages.Add(menuItem, new PersonPage());
            menuItem = new MenuItem()
            {
                FunctionId = "103",
                Icon = "/Images/Catalog.png",
                Title = "消息中心"
            };
            Pages.Add(menuItem, new MessagePage());
            menuItem = new MenuItem()
            {
                FunctionId = "104",
                Icon = "/Images/Catalog.png",
                Title = "系统设置"
            };
            Pages.Add(menuItem, new SettingPage());
        }

        private void OpenHomePage()
        {
            //throw new NotImplementedException();
        }

        private void OpenSettingPage()
        {
            throw new NotImplementedException();
        }

        private void OpenMessagePage()
        {
            throw new NotImplementedException();
        }

        private void OpenPersonalPage()
        {
            throw new NotImplementedException();
        }

        private void OpenCatalogPage()
        {
            var menuItem = this.Pages.Keys.First(c => c.FunctionId == "101");
            var page = this.Pages[menuItem];

        }

        #endregion
    }
}
