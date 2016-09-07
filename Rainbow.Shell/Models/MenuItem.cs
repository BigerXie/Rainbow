using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow.Shell.Models
{
    public class MenuItem : BindableBase
    {
        private string _FunctionId;
        public string FunctionId
        {
            get { return this._FunctionId; }
            set { SetProperty<string>(ref this._FunctionId, value, "FunctionId"); }
        }

        private string _Title;
        public string Title
        {
            get { return this._Title; }
            set { SetProperty<string>(ref this._Title, value, "Title"); }
        }

        private string _Icon;
        public string Icon
        {
            get { return this._Icon; }
            set { SetProperty<string>(ref this._Icon, value, "Icon"); }
        }
    }
}
