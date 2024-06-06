using ConsoleApp1;
using DataAccess;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aggregations");
            Console.WriteLine($"Sum - Employee salaries in Department with Id=1  {Aggregations.DeptTotalEmpSal(1)}");
            Console.WriteLine($"Max - Employee salary in Department with Id=1  {Aggregations.DeptMaxSal(1)}");
            Console.WriteLine($"Min - Employee salary in Department with Id=1  {Aggregations.DeptMinSal(1)}");
            Console.WriteLine($"Avg - Employee salary in Department with Id=1  {Aggregations.DeptAvgSal(1)}");
            Console.WriteLine($"Count - of employees in all departments  {Aggregations.TotalEmps()}");
            Console.WriteLine($"Aggregate - Employee salaries in Department with Id=1  {Aggregations.AggregateTot(1)}");

            Console.WriteLine("=====================================");

            Console.WriteLine("Single-SingleOrDefault/Contains");

            Console.WriteLine("Check if employee name exists in DB - Enter a name");
            string? name = Console.ReadLine();
            Employee? emp = name != null ? LinqMethods.GetSingleEmp(name) : LinqMethods.GetSingleOrDefaultEmp(name);

            if (emp != null)
                Console.WriteLine("Emp name: {0} , DeptId: {1}, Sal : {2} ", emp.Name, emp.DeptId, emp.Salary);
            else
                Console.WriteLine($"Employee with name- {name} not found");

            Console.WriteLine("=====================================");

            
            Console.WriteLine("=====================================");

            Console.WriteLine("Sorting");



            Console.WriteLine("=====================================");

            Console.WriteLine("Pagination Methods");

            int RecordsPerPage = 3;
            int PageNumber = 0;
            do
            {
                Console.WriteLine("Enter Page no. between 1 and 4");
                if(Int32.TryParse(Console.ReadLine(), out PageNumber))
                {
                    if(PageNumber > 0 && PageNumber < 5)
                    {
                        using (ApplicationDBContext db = new ApplicationDBContext())
                        {
                           var emplst = db.Employees.Skip((PageNumber - 1) * RecordsPerPage).Take(RecordsPerPage);
                            foreach (var item in emplst)
                            {
                                Console.WriteLine($"EmpId -  {item.Id} , EmpName - { item.Name} , EmpSal - { item.Salary}");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid page number 1 to 4");
                }


            } while(true);


        }
    }
}
