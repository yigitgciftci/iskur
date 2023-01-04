using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolApp.Entities;
using System.ComponentModel.DataAnnotations;

namespace SchoolApp.Models
{
    public class StudentEditViewModel
    {
        [Required]
        [StringLength(12)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(12)]
        public string LastName { get; set; }
        public string Department { get; set; }
        public List<Hobby> Hobbys { get; set; }
        public MainTeacher MainTeacher { get; set; }
        public GuideTeacher GuideTeacher { get; set; }
        public SelectList Departments { get; set; }
        public SelectList Hobbies { get; set; }
        public SelectList MainTeachers { get; set; }
        public SelectList GuideTeachers { get; set; }
    }
}
