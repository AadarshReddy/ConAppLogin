using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppLogin
{
    public class Authentication
    {
        public  string Login(string username, string password)
        {
            string loginMsg;
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                loginMsg = "please provide credentials";

            }
            else
            {
                if(((username == "admin") && (password == "admin@123")) || ((username == "sam")&&  (password == "sam@123")))
                {
                    loginMsg = "login Success";
                }
                else
                {
                    loginMsg = "login failed";
                }
                
            }
            return loginMsg;
        }
    }
}
