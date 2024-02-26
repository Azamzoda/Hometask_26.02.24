using Domain.Models;

namespace Infrustructure.Services;

public class StudentService
{
   List<Student> students = new List<Student>();
   public List<Student> GetStudents()
    {
        return students;
    }
    public void AddStudent(Student student)
    {
        students.Add(student);
    }
    public void UpdateStudent(Student student)
    {
       foreach (var item in students)
       {
            if (item.Id == student.Id)
            {
                item.FirstName = student.FirstName;
                item.LastName = student.LastName;
                item.BirthDate = student.BirthDate;
                item.Adress = student.Adress;
            }        
       }
    }
    public void DeleteStudent(int Id)
    {
        foreach (var st in students)
        {
            if (st.Id == Id)
            {
                students.Remove(st);
                break;
            }
        }
    }
    
}
