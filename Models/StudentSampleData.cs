namespace Demo.Models
{
    public class StudentSampleData
    {
        public List<Student> students;  

        public StudentSampleData() { 
         students = new List<Student>();
         students.Add(new Student { ID = 1, Name = "Ahmed", Address = "Cairo", Image = "istockphoto-1438969575-612x612.jpg" });
         students.Add(new Student { ID = 2, Name = "Ali", Address = "Giza", Image = "istockphoto-1351018006-612x612.jpg" });
         students.Add(new Student { ID = 3, Name = "Sara", Address = "Alexandria", Image = "360_F_35308534_WGRVXlymcjQqoRXzeWEfVCOfBHBq9YdW.jpg" });
         students.Add(new Student { ID = 4, Name = "Mona", Address = "Aswan", Image = "pexels-george-dolgikh-551816-1326947.jpg" });
        }
        public List<Student> GetAllStudents()
        {
            return students;
        }
        public Student GetStudentByID(int id) { 
            return students.FirstOrDefault(s => s.ID == id);
        }
    }
}
