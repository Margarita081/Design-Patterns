using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba04_task1
{
    public class Solid
    {
    }

    // not correct of Single responsibility principle
    public class User
    {
        public string Name { get; set; }
        public int SecondName { get; set; }
        public string Password { get; set; }
        public void CreatUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException("username");
            }
            SendMail(username);
        }

        public void SendMail(string username)
        {
            Console.WriteLine($"Hello {username}");
        }
    }
}
