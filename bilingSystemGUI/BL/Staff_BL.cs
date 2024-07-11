using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilingSystemGUI.BL
{
    public class Staff_BL
    {
        private string name;
        private string idCard;
        private float salary;

        public string Name { get => name; set => name = value; }
        public string IdCard { get => idCard; set => idCard = value; }
        public float Salary { get => salary; set => salary = value; }

    }
}
