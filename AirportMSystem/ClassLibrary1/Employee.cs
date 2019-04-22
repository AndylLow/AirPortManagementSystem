using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Employee
    {
        string fullName;
        string email;
        string password;
        int ID;
        int type;
        int privilige;

        public string FullName { get => fullName; set => fullName = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public int ID1 { get => ID; set => ID = value; }
        public int Type { get => type; set => type = value; }
        public int Privilige { get => privilige; set => privilige = value; }

        public Employee(string fullName, string email, string password, int type, int privilige)
        {
            this.fullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
            this.email = email ?? throw new ArgumentNullException(nameof(email));
            this.password = password ?? throw new ArgumentNullException(nameof(password));
            this.type = type;
            this.privilige = privilige;
            //TO BE IMPLEMENTED:: ADD THIS TO DATABASE!!
        }

        public Employee()
        {

        }
    }
}
