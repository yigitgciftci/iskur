using System.ComponentModel.DataAnnotations;

namespace SchoolApp.Entities
{
    public class MainTeacher
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(12)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(12)]
        public string LastName { get; set; }
        public List<Student> Students { get; set; }

    }
}
