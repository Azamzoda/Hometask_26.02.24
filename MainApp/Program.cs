using System.Runtime.InteropServices;
using Domain.Models;
using Infrustructure.Services;

var stService = new StudentService();
var st = new Student()
{
    FirstName = "Mansur",
    LastName = "Azamzoda",
    Id = 1,
    Adress = "Dusti",
    BirthDate = DateTime.Now
};


var st2 = new Student();
st2.Id =2;
st2.FirstName = "Sunatullo";
st2.LastName = "Chillaevv";
st2.Adress = "Joyi Azimshon";
st2.BirthDate = DateTime.Now;

var st3 = new Student();
st3.Id =3;
st3.FirstName = "Alijon";
st3.LastName = "Sattorov";
st3.Adress = "Joyi zist";
st3.BirthDate = DateTime.Now;

stService.AddStudent(st);
stService.AddStudent(st2);
stService.AddStudent(st3);

foreach (var item in stService.GetStudents())
{
    
    System.Console.WriteLine($"----------------------");
    System.Console.WriteLine();
    System.Console.WriteLine($"Id = {item.Id}");
    System.Console.WriteLine($"FirstName: {item.FirstName}");
    System.Console.WriteLine($"LastName: {item.LastName}");
    System.Console.WriteLine($"BirthDate: {item.BirthDate}");
    System.Console.WriteLine($"Adress: {item.Adress}");
    System.Console.WriteLine();
    System.Console.WriteLine($"-----------------------");
}


var stup = new Student();
stup.Id = 2;
stup.FirstName = "Mumtoz";
stup.LastName = "Sharipovv";
stup.Adress = "46";
stup.BirthDate = DateTime.Now;

stService.UpdateStudent(stup);





foreach (var item in stService.GetStudents())
{
    
    System.Console.WriteLine($"----------------------");
    System.Console.WriteLine();
    System.Console.WriteLine($"Id = {item.Id}");
    System.Console.WriteLine($"FirstName: {item.FirstName}");
    System.Console.WriteLine($"LastName: {item.LastName}");
    System.Console.WriteLine($"BirthDate: {item.BirthDate}");
    System.Console.WriteLine($"Adress: {item.Adress}");
    System.Console.WriteLine();
    System.Console.WriteLine($"-----------------------");
}
var postService = new PostService();
var post = new Post()
{
    Id = 1,
    Title = "Dushanbe, Tajikistan",
    Description = "So beautiful",
    VoteAmount = 10,
    CreatedAt = DateTime.Now,    
};postService.AddPosts(post);

var post2 = new Post()
{
    Id = 2,
    Title = "Dushanbe",
    Description = "Prfect",
    VoteAmount = 14,
    CreatedAt = DateTime.Now,    
};
postService.AddPosts(post2);

var post3 = new Post()
{
    Id = 2,
    Title = " Tajikistan",
    Description = "Great",
    VoteAmount = 10,
    CreatedAt = DateTime.Now,    
};
postService.AddPosts(post3);
foreach (var item in postService.GetPosts())
{

    System.Console.WriteLine();
    System.Console.WriteLine($"Id = {item.Id}");
    System.Console.WriteLine($"Title: {item.Title}");
    System.Console.WriteLine($"Description: : {item.Description}");
    System.Console.WriteLine($" {item.VoteAmount}");
    System.Console.WriteLine($" {item.CreatedAt}");
    System.Console.WriteLine();
    System.Console.WriteLine($"****************************");
}
postService.UpdatePosts(post3);
foreach (var item in postService.GetPosts())
{
    
    System.Console.WriteLine();
    System.Console.WriteLine($"Id = {item.Id}");
    System.Console.WriteLine($"Title: {item.Title}");
    System.Console.WriteLine($"Description: : {item.Description}");
    System.Console.WriteLine($" {item.VoteAmount}");
    System.Console.WriteLine($" {item.CreatedAt}");
    System.Console.WriteLine();
    System.Console.WriteLine($"****************************");
}



var crService = new CourseService();
var cr = new Course()
{
    Id = 1,
    Title = "C#",
    Description = "Kursi zuray",
};
crService.AddCourses(cr);
var cr2 = new Course()
{
    Id = 2,
    Title = "C++",
    Description = "Kursi zuray",
};
crService.AddCourses(cr2);
var cr3 = new Course()
{
    Id = 1,
    Title = "C",
    Description = "Kursi zuray",
};
crService.AddCourses(cr3);
foreach (var item in crService.GetCourses())
{
    
    System.Console.WriteLine();
    System.Console.WriteLine($"Id = {item.Id}");
    System.Console.WriteLine($"Title: {item.Title}");
    System.Console.WriteLine($"Description: : {item.Description}");
    System.Console.WriteLine();
    System.Console.WriteLine($"_______________________________");
}




var teachService = new TecherService();
var teach = new Teacher();
teach.FirstName = "Alijon";
teach.LastName = "Zabiri";
teach.Position = "C#-teacher";
teach.ExperienceAmount = 5;
teachService.AddTeacher(teach);

var teach2 = new Teacher();

teach2.Id =1;
teach2.FirstName = "Muhammadjon";
teach2.LastName = "Mirzoyev";
teach2.Position = "C++-teacher";
teach2.ExperienceAmount = 5;

teachService.AddTeacher(teach2);
foreach (var item in teachService.GetTeachers())
{
       System.Console.WriteLine();
    System.Console.WriteLine($"Id = {item.Id}");
    System.Console.WriteLine($"FirstName: {item.FirstName}");
    System.Console.WriteLine($"LastName: {item.LastName}");
    System.Console.WriteLine($"Position: {item.Position}");
    System.Console.WriteLine($"Experience: {item.ExperienceAmount}");
    System.Console.WriteLine();
    System.Console.WriteLine($"_______________________________")
    
}
