using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_home_controller
{
    public class user
    {
        //private fields
        private int userId;
        private string username;
        private string password;
        private string contactInfo;
        private bool isLoggedIn;

        //public properties

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
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

        public string ContactInfo
        {
            get { return contactInfo; }
            set { contactInfo = value; }
        }
        public bool isLoggedIn
        {
            get { return isLoggedIn; }
            private set { isLoggedIn = value; }
        }

        public bool Login(string username, string password)
        {
            // Simulate login process
            if (username == this.username && password == this.password)
            {
                isLoggedIn = true;
                Console
                }
            else
            {
                isLoggedIn = false;
                Console.WriteLine("Login failed. Invalid username or password.");
            }
            return isLoggedIn;
        }
        public void Logout()
        {
            if (isLoggedIn)
            {
                IsLoggedIn = false;
                Console.WriteLine("User logged out successfully.");
            }
            else
            {
                Console.WriteLine("User is not logged in.");
            }

        }

    }
    public void ControlDevice(int deviceId, string deviceName, string deviceAction)
    {
        if (isLoggedIn)
            {
                Console.WriteLine($"User {username} is performing action '{deviceAction}' on device '{deviceName}' (ID: {deviceId}).");
            }
        else
            {
                Console.WriteLine("Action failed. User is not logged in.");
            }
        }
    }

    public User(int userId, string username, string password, string contactInfo)
    {
        this.userId = userId;
        this.username = username;
        this.password = password;
        this.contactInfo = contactInfo;
        this.isLoggedIn = false;
}

































