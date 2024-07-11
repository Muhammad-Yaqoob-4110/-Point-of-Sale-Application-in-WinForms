using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using bilingSystemGUI.BL;
namespace bilingSystemGUI.DL
{
    class MUserDL
    {
        private static string path = "dataSource.txt";
        public static void addIntoFile(MUserBL newUser)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(newUser.Name + "," + newUser.Password + "," + newUser.Role);
            f.Flush();
            f.Close();
        }
        public static List<MUserBL> getUsersList()
        {
            List<MUserBL> lst = new List<MUserBL>();
            StreamReader f = new StreamReader(path);
            string line;
            string[] splittedLine;
            while ((line = f.ReadLine()) != null)
            {
                MUserBL user = new MUserBL();
                splittedLine = line.Split(',');
                user.Name = splittedLine[0];
                user.Password = splittedLine[1];
                user.Role = splittedLine[2];
                lst.Add(user);
            }
            f.Close();
            return lst;
        }
        public static MUserBL checkFromFile(MUserBL temp)
        {
            List<MUserBL> lst = getUsersList();
            foreach (MUserBL user in lst)
            {
                if (user.Name == temp.Name && user.Password == temp.Password)
                {
                    return user;
                }
            }
            return null;
        }
        
    }
}
