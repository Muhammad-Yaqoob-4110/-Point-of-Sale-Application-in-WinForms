using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bilingSystemGUI.BL;
using bilingSystemGUI.DL;
using System.IO;
namespace bilingSystemGUI.DL
{
    class Staff_DL
    {
        private static string path = "staff_File.txt";
        public static void addStaffToFile(Staff_BL member)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(member.Name + "," + member.IdCard + "," + member.Salary);
            f.Flush();
            f.Close();
        }
        public static List<Staff_BL> getStaffList()
        {
            List<Staff_BL> lst = new List<Staff_BL>();
            StreamReader f = new StreamReader(path);
            string line;
            string[] staffInfo;
            while ((line = f.ReadLine()) != null)
            {
                staffInfo = line.Split(',');
                Staff_BL s = new Staff_BL();
                s.Name = staffInfo[0];
                s.IdCard = staffInfo[1];
                s.Salary = float.Parse(staffInfo[2]);
                lst.Add(s);
            }
            f.Close();
            return lst;
        }
        public static List<Staff_BL> deleteStaffFromList(Staff_BL member)
        {
            List<Staff_BL> lst = getStaffList();
            for (int i = 0; i < lst.Count; i++)
            {
                Staff_BL temp = lst[i];

                if (temp.Name == member.Name && temp.IdCard == member.IdCard && temp.Salary == member.Salary)
                {
                    lst.RemoveAt(i);
                }
            }
            return lst;
        }
        public static void storeDataInFile(List<Staff_BL> lst)
        {
            StreamWriter f = new StreamWriter(path);
            foreach (Staff_BL staff in lst)
            {
                f.WriteLine(staff.Name + "," + staff.IdCard + "," + staff.Salary);
            }
            f.Flush();
            f.Close();
        }
        public static List<Staff_BL> editStaffInList(Staff_BL previous, Staff_BL update)
        {
            List<Staff_BL> lst = getStaffList();
            for (int i = 0; i < lst.Count; i++)
            {
                Staff_BL temp = new Staff_BL();
                temp = lst[i];
                if (temp.Name == previous.Name && temp.IdCard == previous.IdCard && temp.Salary == previous.Salary)
                {
                    lst.RemoveAt(i);
                    lst.Insert(i, update);
                }
            }
            return lst;
        }
    }
}
