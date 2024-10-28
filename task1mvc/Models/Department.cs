namespace task1mvc.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public Department(int departmentId, string departmentName)
        {
            DepartmentId = departmentId;
            DepartmentName = departmentName;
        }

        public void AddDepartment(string name)
        {
            // Code to add a new department
        }

        public List<Department> GetAllDepartments()
        {
            // Code to retrieve all departments
            return new List<Department>();
        }
    }
}
