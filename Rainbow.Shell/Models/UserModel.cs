using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow.Shell.Models
{
    public class UserModel
    {
        private string _Name;
        public string Name
        {
            get { return this._Name; }
            set
            {
                if (this._Name != value)
                {
                    this._Name = value;
                    //this.RaisePropertyChanged("Name");
                }
            }
        }
        private string _Password;
        public string Password
        {
            get { return this._Password; }
            set
            {
                if (this._Password != value)
                {
                    this._Password = value;
                    //this.RaisePropertyChanged("Password");
                }
            }
        }
        private string _IP;
        public string IP
        {
            get { return this._IP; }
            set
            {
                if (this._IP != value)
                {
                    this._IP = value;
                    //this.RaisePropertyChanged("IP");
                }
            }
        }
    }
}
