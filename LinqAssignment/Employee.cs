using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    internal class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }


        public static List<Employee> EmpList = new List<Employee>
    {

    new Employee() {EmployeeID = 1001,FirstName = "Malcolm",LastName = "Daruwalla",Title = "Manager",DOB = DateTime.Parse("1984-01-02"),DOJ = DateTime.Parse("2011-08-09"),City = "Mumbai"},
    new Employee() {EmployeeID = 1002,FirstName = "Asdin",LastName = "Dhalla",Title = "AsstManager",DOB = DateTime.Parse("1984-08-20"),DOJ = DateTime.Parse("2012-7-7"),City = "Mumbai"},
    new Employee() {EmployeeID = 1003,FirstName = "Madhavi",LastName = "Oza",Title = "Consultant",DOB = DateTime.Parse("1987-11-14"),DOJ = DateTime.Parse("2015-4-12"),City = "Pune"},
    new Employee() {EmployeeID = 1004,FirstName = "Saba",LastName = "Shaikh",Title = "SE",DOB = DateTime.Parse("6/3/1990"),DOJ = DateTime.Parse("2/2/2016"),City = "Pune"},
    new Employee() {EmployeeID = 1005,FirstName = "Nazia",LastName = "Shaikh",Title = "SE",DOB = DateTime.Parse("3/8/1991"),DOJ = DateTime.Parse("2/2/2016"),City = "Mumbai"},
    new Employee() {EmployeeID = 1006,FirstName = "Suresh",LastName = "Pathak",Title = "Consultant",DOB = DateTime.Parse("11/7/1989"),DOJ = DateTime.Parse("8/8/2014"),City = "Chennai"},
    new Employee() {EmployeeID = 1007,FirstName = "Vijay",LastName = "Natrajan",Title = "Consultant",DOB = DateTime.Parse("12/2/1989"),DOJ = DateTime.Parse("6/1/2015"),City = "Mumbai"},
    new Employee() {EmployeeID = 1008,FirstName = "Rahul",LastName = "Dubey",Title = "Associate",DOB = DateTime.Parse("11/11/1993"),DOJ = DateTime.Parse("11/6/2014"),City = "Chennai"},
    new Employee() {EmployeeID = 1009,FirstName = "Amit",LastName = "Mistry",Title = "Associate",DOB = DateTime.Parse("8/12/1992"),DOJ = DateTime.Parse("12/3/2014"),City = "Chennai"},
    new Employee() {EmployeeID = 1010,FirstName = "Sumit",LastName = "Shah",Title = "Manager",DOB = DateTime.Parse("4/12/1991"),DOJ = DateTime.Parse("1/2/2016"),City = "Pune"},

    };
        public static void DisplayAll()
        {
            Console.WriteLine("All employee details are :\n");
            var DisplayAllEmployees = (from e in EmpList select e);
            foreach (var emp in DisplayAllEmployees)
            {                
                Console.WriteLine(emp.EmployeeID +", " + emp.FirstName+", "+emp.LastName+", "+emp.Title+", "+emp.DOB+", "+emp.DOJ+", "+emp.City);
            }
        }

        public static void NotMumbai()
        {
            Console.WriteLine("\nAll employee details except Mumbai are :\n");
            var NotMumbaiEmployees = (from e in EmpList where e.City!="Mumbai" select e);
            foreach(var emp in NotMumbaiEmployees)
            {                
                Console.WriteLine(emp.EmployeeID + ", " + emp.FirstName + ", " + emp.LastName + ", " + emp.Title + ", " + emp.DOB + ", " + emp.DOJ + ", " + emp.City);
            }
        }

        public static void AssiatantManager()
        {
            Console.WriteLine("\nAll the details of Assistant Manager are :\n");
            var AssistantManagerEmployees = (from e in EmpList where e.Title == "AsstManager" select e);
            foreach(var emp in AssistantManagerEmployees)
            {
                Console.WriteLine(emp.EmployeeID + ", " + emp.FirstName + ", " + emp.LastName + ", " + emp.Title + ", " + emp.DOB + ", " + emp.DOJ + ", " + emp.City);
            }
        }

        public static void LastNameStarts()
        {
            Console.WriteLine("\nAll the deatils of employees where lastname starts with letter 'S' :\n");
            var LastNameStartsEmployees = (from e in EmpList where e.LastName[0]== 'S' select e);
            foreach (var emp in LastNameStartsEmployees)
            {
                Console.WriteLine(emp.EmployeeID + ", " + emp.FirstName + ", " + emp.LastName + ", " + emp.Title + ", " + emp.DOB + ", " + emp.DOJ + ", " + emp.City);
            }
        }

        public static void DateOfJoinBefore()
        {
            Console.WriteLine("\nAll the details of employees who joined before 1/1/2015 are :\n");
            var DateOfJoinBeforeEmployees = (from e in EmpList where e.DOJ < DateTime.Parse ("1/1/2015") select e);
            foreach (var emp in DateOfJoinBeforeEmployees)
            {
                Console.WriteLine(emp.EmployeeID + ", " + emp.FirstName + ", " + emp.LastName + ", " + emp.Title + ", " + emp.DOB + ", " + emp.DOJ + ", " + emp.City);
            }
        }

        public static void DateOfBirthAfter()
        {
            Console.WriteLine("\nAll the details of employees whose DOB is after 1/1/1990 are :\n");
            var DateOfBirthAfterEmployees = (from e in EmpList where e.DOB > DateTime.Parse("1/1/1990") select e);
            foreach(var emp in DateOfBirthAfterEmployees)
            {
                Console.WriteLine(emp.EmployeeID + ", " + emp.FirstName + ", " + emp.LastName + ", " + emp.Title + ", " + emp.DOB + ", " + emp.DOJ + ", " + emp.City);
            }
        }

        public static void Designation()
        {
            Console.WriteLine("\nAll the details of employees whose designation is Consultant & Associate are :\n");
            var DesignationEmployees = (from e in EmpList where e.Title == "Consultant" || e.Title == "Associate" select e);
            foreach(var emp in DesignationEmployees)
            {
                Console.WriteLine(emp.EmployeeID + ", " + emp.FirstName + ", " + emp.LastName + ", " + emp.Title + ", " + emp.DOB + ", " + emp.DOJ + ", " + emp.City);
            }
        }

        

        public static void TotalNumber()
        {
            Console.Write("\nThe total number of employees are : ");
            var TotalNumberEmployees = (from e in EmpList select e).Count();
            Console.WriteLine(TotalNumberEmployees);
        }

        public static void TotalChennai()
        {
            Console.Write("\nThe total number of employees in Chennai are :\n");
            var TotalChennaiEmployees = (from e in EmpList where e.City == "Chennai" select e);
            foreach(var emp in TotalChennaiEmployees)
            {
                Console.WriteLine(emp.EmployeeID + ", " + emp.FirstName + ", " + emp.LastName + ", " + emp.Title + ", " + emp.DOB + ", " + emp.DOJ + ", " + emp.City);
            }
        }

        public static void MaxId()
        {
            Console.Write("\nThe largest employee ID from the list is : ");
            var MaxIdEmployee = (from e in EmpList select e.EmployeeID).Max();
            Console.WriteLine(MaxIdEmployee);
        }

        public static void JoinedAfter()
        {
            Console.WriteLine("\nDetails of employees joined after 1/1/2015 are :\n");
            var JoinedAfterEmployees = (from e in EmpList where e.DOJ > DateTime.Parse("1/1/2015") select e);
            foreach(var emp in JoinedAfterEmployees)
            {
                Console.WriteLine(emp.EmployeeID + ", " + emp.FirstName + ", " + emp.LastName + ", " + emp.Title + ", " + emp.DOB + ", " + emp.DOJ + ", " + emp.City);
            }
        }

        public static void NotAssociate()
        {
            Console.WriteLine("\nDetails of employees whose designation is not Associate are :\n");
            var NotAssociateEmployees = (from e in EmpList where e.Title != "Associate" select e);
            foreach (var emp in NotAssociateEmployees)
            {
                Console.WriteLine(emp.EmployeeID + ", " + emp.FirstName + ", " + emp.LastName + ", " + emp.Title + ", " + emp.DOB + ", " + emp.DOJ + ", " + emp.City);
            }
        }


        static void Main(string[] args)
        {
            DisplayAll();
            NotMumbai();
            AssiatantManager();
            LastNameStarts();
            DateOfJoinBefore();
            Designation();
            TotalNumber();
            TotalChennai();
            MaxId();
            JoinedAfter();
            NotAssociate();
            Console.ReadKey();
        }
    }
}