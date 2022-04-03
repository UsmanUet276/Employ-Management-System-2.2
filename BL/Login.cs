using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.BL
{
    internal class Login
    {
        public Login(string usernameA , string passwordA , string rolesA)
        {
            this.usernameA = usernameA;
            this.passwordA = passwordA;
            this.rolesA = rolesA;
        }
        public Login(string usernameA, string passwordA, string rolesA , string initialPassA)
        {
            this.usernameA = usernameA;
            this.passwordA = passwordA;
            this.rolesA = rolesA;
            this.initialPassA = initialPassA;
        }
        public string usernameA;
        public string passwordA;
        public string initialPassA;
        public string rolesA;
    }
}
