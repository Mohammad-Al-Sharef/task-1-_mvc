namespace task1mvc.Models
{
    public class Manager
    {
        public int ManagerId { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string PhoneNumber { get; set; }
        public string NationalId { get; set; }
        public string Nationality { get; set; }
        public string MaritalStatus { get; set; }
        public byte[] PersonalPhoto { get; set; }
        public DateTime EntryDate { get; set; }
        public string Password { get; set; }

        public Manager(int managerId, string name, DateTime birthdate, string phoneNumber, string nationalId,
                       string nationality, string maritalStatus, byte[] personalPhoto, DateTime entryDate, string password)
        {
            ManagerId = managerId;
            Name = name;
            Birthdate = birthdate;
            PhoneNumber = phoneNumber;
            NationalId = nationalId;
            Nationality = nationality;
            MaritalStatus = maritalStatus;
            PersonalPhoto = personalPhoto;
            EntryDate = entryDate;
            Password = password;
        }

        public void AddManager(string name, DateTime birthdate, string phoneNumber, string nationalId,
                               string nationality, string maritalStatus, byte[] personalPhoto, DateTime entryDate, string password)
        {
            // Code to add a new manager
        }

        public List<Employee> ViewAllEmployees()
        {
            // Code to view all employees
            return new List<Employee>();
        }

        public List<Employee> FilterEmployeesByName(string name)
        {
            // Code to filter employees by name
            return new List<Employee>();
        }
    }
}
