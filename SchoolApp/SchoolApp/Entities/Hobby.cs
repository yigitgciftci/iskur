using System.ComponentModel.DataAnnotations;

namespace SchoolApp.Entities
{
    public class Hobby
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(12)]
        public string Name { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }

    }
}
