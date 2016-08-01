using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow.Shell.Models
{
    public class ShellWindowModel : BindableBase
    {
        private UserModel _CurrentUser;
        public UserModel CurrentUser
        {
            get { return this._CurrentUser; }
            set { SetProperty<UserModel>(ref this._CurrentUser, value); }
        }
    }
}
