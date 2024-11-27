using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_1
{
    class Account
    {
        public string link, user, pass;

        public Account(string _link,string _user,string _pass)
        {
            link = _link;
            user = _user;
            pass = _pass;
        }

        public string Data()
        {
            return "連結: " + link + "\r\n"
                 + "使用者: " + user + "\r\n"
                 + "密碼: " + pass + "\r\n"
                 + "======================================================" + "\r\n";
        }
    }
}
