using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Admin
    {
        private string username;
        private string password;
        private int status;


        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        public Admin(){

        }

        public Admin(string username, string password, int status)
        {
            this.username = username;
            this.password = password;
            this.status = status;
            
        }

        

    }



}
