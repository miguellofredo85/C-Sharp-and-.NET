using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSys
{
    internal class UserRegister
    {
        private static User[] users =
        {
            new User(){ name = "lionelmessi", password= "123456!@#" },
            new User(){ name = "cutiromero", password = "098765321" },
            new User(){ name = "fideodimaria", password = "fideosmarolio"  }
        } ; 
        private static User _userLogin = null;
        public static User UserLogin
        { 
            get { return _userLogin; }
            private set { _userLogin = value; }
        }
        public static bool Login(string name, string pass)
        {
            foreach (User user in users)
            {
                if (user.name == name && user.password == pass)
                {
                    UserLogin = user;
                    return true;

                }
            }
            return false;
        }
    }
}
