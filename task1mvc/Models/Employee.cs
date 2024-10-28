namespace task1mvc.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string PhoneNumber { get; set; }
        public string NationalId { get; set; }
        public string Nationality { get; set; }
        public string MaritalStatus { get; set; }
        public byte[] PersonalPhoto { get; set; }
        public DateTime EntryDate { get; set; }
        public string Password { get; set; }
        public int DepartmentId { get; set; }

        public Employee(int employeeId, string name, DateTime birthdate, string phoneNumber, string nationalId,
                        string nationality, string maritalStatus, byte[] personalPhoto, DateTime entryDate, string password, int departmentId)
        {
            EmployeeId = employeeId;
            Name = name;
            Birthdate = birthdate;
            PhoneNumber = phoneNumber;
            NationalId = nationalId;
            Nationality = nationality;
            MaritalStatus = maritalStatus;
            PersonalPhoto = personalPhoto;
            EntryDate = entryDate;
            Password = password;
            DepartmentId = departmentId;
        }

        public void AddEmployee(string name, DateTime birthdate, string phoneNumber, string nationalId,
                                string nationality, string maritalStatus, byte[] personalPhoto, DateTime entryDate, string password, int departmentId)
        {
            // Code to add a new employee
        }

        public List<Task> ViewTasks()
        {
            // Code to view tasks assigned to the employee
            return new List<Task>();
        }

    }
}
