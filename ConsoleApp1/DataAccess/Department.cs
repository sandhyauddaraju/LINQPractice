using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string DeptName { get; set; }

       

    }

    public class DeptStore
    {
        public static List<Department> departments = new List<Department>() { 
            new Department { DeptId = 1, DeptName = "Operations"},
            new Department { DeptId = 2, DeptName = "Development"},
            new Department { DeptId = 3, DeptName = "Sales"},
            new Department { DeptId = 4, DeptName = "HR"},

        };
    }
}
