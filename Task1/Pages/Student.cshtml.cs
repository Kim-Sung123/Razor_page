using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homeworl2.Pages
{
    public class StudentModel : PageModel
    {
        public List<student> list_student {  get; set; }
        public void OnGet()
        {
            this.GenerateStudentList();
        }

        public void GenerateStudentList()
        {
            this.list_student = new List<student>();
            student student = new student();
            student.Id = 1;
            student.Name = "Dara";
            student.Gender = "Male";
            student.Grade = 80;
            student.Address = "Phnom Penh";
            this.list_student.Add(student);
            student = new student();
            student.Id = 2;
            student.Name = "Hong";
            student.Gender = "Female";
            student.Grade = 90;
            student.Address = "Battambang";
            this.list_student.Add(student);
            student = new student();
            student.Id = 3;
            student.Name = "Raksmey";
            student.Gender = "Female";
            student.Grade = 70;
            student.Address = "Takeo";
            this.list_student.Add(student);
        }
    }
}
