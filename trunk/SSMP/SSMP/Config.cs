using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace SSMP
{
    [Serializable]
    public class Config 
    {
        private string server;
        private string database;
        private string username;
        private string password;

        public string Server
        {
            get { return server; }
            set { server = value; }
        }

        public string Database
        {
            get { return database; }
            set { database = value; }
        }        

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
    }
}
