using Domain.Models;

namespace Infrustructure.Services;

public class CourseService
{
    List<Course> courses = new List<Course>();
    public List<Course> GetCourses()
    {
        return courses;
    }
    public void AddCourses(Course course)
    {
        courses.Add(course);
    }
    public void UpdateCourses(Course course)
    {
        foreach (var item in courses)
        {
            item.Title = course.Title;
            item.Description = course.Description;
            item.Fee = course.Fee;
            item.HasDiscount = course.HasDiscount;
            break;
        }    
        
    }
    public void Delete(int Id)
    {
        foreach (var item in courses)
        {
            if (item.Id == Id)
            {
                courses.Remove(item);
                break;
            }
        }
    }
}

