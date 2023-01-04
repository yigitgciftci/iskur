using System.ComponentModel.DataAnnotations;

namespace SchoolApp.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(12)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(12)]
        public string LastName { get; set; }
        public string Department { get; set; }
        public List<Hobby> Hobbys { get; set; }
        public int MainTeacherId { get; set; }
        public int GuideTeacherId { get; set; }
        public MainTeacher MainTeacher { get; set; }
        public GuideTeacher GuideTeacher { get; set; }
    }
}
