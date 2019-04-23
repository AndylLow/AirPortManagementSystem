using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Admin:Employee
    {
        public Admin(Employee s)
        {
            this.Email = s.Email;
            this.FullName = s.FullName;
            this.ID1 = s.ID1;
            this.Password = s.Password;
            this.Privilige = s.Privilige;
            this.Type = 0;
        }
        public Admin()
        {

        }
    }
}
