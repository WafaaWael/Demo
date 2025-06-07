using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Phone { get; set; }

        //? Nullable properties for optional data
        public string? Address { get; set; }
        public string Image { get; set; } // Assuming you want to store an image path or URL

        //department is named after the variable pf depatment not after the class name
        [ForeignKey("Department")]
        public int DepartmentID { get; set; }

        //we use virtual keyword to enable lazy loading
        // This means that the Department property will be loaded from the database only when it is accessed
        // This is useful for performance optimization in Entity Framework
        //this don't creat5 new department onlt access it
        public virtual Department ?Department { get; set; } // Navigation property
    }
}
