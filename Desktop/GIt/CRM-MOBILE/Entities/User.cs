using System;
namespace CRMMOBILE.Entities
{
    public class User
    {
        public string userName
        {
            get;
            set;
        }
        public string password
        {
            get;
            set;
        }
        public User(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }
    }
}
