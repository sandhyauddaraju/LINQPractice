using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Aggregations
    {
        //sum
        public static int DeptTotalEmpSal(int deptId)
        {
            using (ApplicationDBContext db = new ApplicationDBContext())
            {
              return  db.Employees.Where(id=>id.DeptId == deptId).Select(i => i.Salary).Sum();
            }
        }

        //max
        public static int DeptMaxSal(int deptId)
        {
            using (ApplicationDBContext db = new ApplicationDBContext())
            {
                return db.Employees.Where(id => id.DeptId == deptId).Select(i => i.Salary).Max();
            }
        }

        //min
        public static int DeptMinSal(int deptId)
        {
            using (ApplicationDBContext db = new ApplicationDBContext())
            {
                return db.Employees.Where(id => id.DeptId == deptId).Select(i => i.Salary).Min();
            }
        }

        //average
        public static double DeptAvgSal(int deptId)
        {
            using (ApplicationDBContext db = new ApplicationDBContext())
            {
                return db.Employees.Where(id => id.DeptId == deptId).Select(i => i.Salary).Average();
            }
        }

        //count

        public static double TotalEmps()
        {
            using (ApplicationDBContext db = new ApplicationDBContext())
            {
                return db.Employees.Count();
            }
        }

        //aggregate

        public static int AggregateTot(int deptId)
        {
            using (ApplicationDBContext db = new ApplicationDBContext())
            {
                return db.Employees.Where(id => id.DeptId == deptId).Select(i => i.Salary)
                        .AsEnumerable().Aggregate((accumulator, sal) => accumulator + sal);
            }
        }

    }
}
