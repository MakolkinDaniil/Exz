using System;
using LombardWPF;

namespace ClassLibrary1
{
    public class Test
    {
        LombardDBEntities db = new LombardDBEntities();
        public static class Unit
        {
            public static bool LoginPasswordCheck(string login, string password)
            {
                if (login != "" || password != "")
                {
                    var loginDB = db.Staff.Where(u => u.Login == login).SingleOrDefault();
                    var passwordDB = db.Staff.Where(u => u.Password == password).SingleOrDefault();
                    if (loginDB == null || passwordDB == null)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
                
            }
        }
    }
}
