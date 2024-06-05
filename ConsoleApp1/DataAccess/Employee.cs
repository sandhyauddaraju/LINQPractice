using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        [ForeignKey("Department")]
        public int DeptId { get; set; }

        public DateTime DateCreated { get; set; }


    }

    public class EmployeeStore
    {
        public static List<Employee> employees = new List<Employee>() { 
        
            new Employee(){Id=101, Name="Sal",Salary= 7000, DeptId =1, DateCreated=DateTime.Now },
            new Employee(){Id=102, Name="Will",Salary= 8000,DeptId =1, DateCreated=DateTime.Now},
            new Employee(){ Id=103, Name="John",Salary= 10000,DeptId =2, DateCreated=DateTime.Now},
            new Employee(){Id=104, Name="Julie",Salary= 20000, DeptId =2,DateCreated=DateTime.Now },
            new Employee(){Id=105, Name="Sam",Salary= 8000,DeptId =2,DateCreated=DateTime.Now},
            new Employee(){Id=106, Name="Jude",Salary= 20000,DeptId =3, DateCreated=DateTime.Now },
            new Employee(){Id=107, Name="Jen",Salary= 15000,DeptId =3, DateCreated=DateTime.Now },
            new Employee(){Id=108, Name="Ram",Salary= 11000,DeptId =4, DateCreated=DateTime.Now},
            new Employee(){Id=109, Name="Violet",Salary= 12000,DeptId =4, DateCreated=DateTime.Now },
            new Employee(){ Id=110, Name="Andy",Salary= 30000,DeptId= 2, DateCreated=DateTime.Now},
            new Employee(){Id=111, Name="Molly",Salary= 16000,DeptId =1, DateCreated=DateTime.Now},
            new Employee(){ Id=112, Name="Vincent",Salary= 6000, DeptId =2,DateCreated=DateTime.Now}


        };
    }
}
