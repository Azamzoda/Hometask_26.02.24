using Domain.Models;

namespace Infrustructure.Services;

public class TecherService
{
    List<Teacher> teachers = new List<Teacher>();
    public List<Teacher> GetTeachers()
    {
        return teachers;
    }
    public void AddTeacher(Teacher teacher)
    {
        teachers.Add(teacher);
    }
    public void UpdateTeacher(Teacher teacher)
    {
        foreach (var teach in teachers)
        {
            teach.FirstName = teacher.FirstName;
            teach.LastName = teacher.LastName;
            teach.Position = teacher.Position;
            teach.ExperienceAmount = teacher.ExperienceAmount;
            break; 
        }
        
    }
    public void Delete(int Id)
    {
        foreach (var item in teachers)
        {
            if (item.Id == Id)
            {
                teachers.Remove(item);
                break;
            }
        }
    }
}
