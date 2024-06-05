using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LinqMethods
    {
        public static Employee? GetSingleEmp(string name)
        {
            try
            {
                using (ApplicationDBContext db = new ApplicationDBContext())
                {
                    return db.Employees.Single(n => n.Name.Contains(name));
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public static Employee? GetSingleOrDefaultEmp(string name)
        {
            
            using (ApplicationDBContext db = new ApplicationDBContext())
            {
                return db.Employees.SingleOrDefault(n => n.Name.Contains(name));
            }
            
        }
    }
}
