using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilingSystemGUI.BL
{
    class MUserBL
    {
        private string name;
        private string password;
        private string role;

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }

        public MUserBL(string name, string password, string role)
        {
            this.name = name;
            this.password = password;
            this.Role = role;
        }
        public MUserBL(string name, string password)
        {
            this.name = name;
            this.password = password;
            Role = null;
        }
        public MUserBL() { }
    }
}
