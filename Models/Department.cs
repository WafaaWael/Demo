namespace Demo.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string  ? MangerName { get; set; }
        public string Name { get; set; }
        public virtual List<Employee> ? Employees { get; set; } = new List<Employee>(); // Navigation property for related employees
    }
}
