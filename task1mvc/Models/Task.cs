namespace task1mvc.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Description { get; set; }
        public string ImportanceLevel { get; set; }
        public int EmployeeId { get; set; }

        public Task(int taskId, string title, DateTime startDate, DateTime dueDate, string description, string importanceLevel, int employeeId)
        {
            TaskId = taskId;
            Title = title;
            StartDate = startDate;
            DueDate = dueDate;
            Description = description;
            ImportanceLevel = importanceLevel;
            EmployeeId = employeeId;
        }

        public void AssignTask(string title, DateTime startDate, DateTime dueDate, string description, string importanceLevel, int employeeId)
        {
            // Code to assign a new task to an employee
        }

        public List<Task> GetTasksByEmployee(int employeeId)
        {
            // Code to retrieve tasks for a specific employee
            return new List<Task>();
        }
    }
}
