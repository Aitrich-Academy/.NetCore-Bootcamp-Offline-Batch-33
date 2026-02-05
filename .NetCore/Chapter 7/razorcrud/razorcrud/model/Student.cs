using System.ComponentModel.DataAnnotations;

namespace razorcrud.model
{
    public class Student
    {
        [Key]
        public int NID { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(1, 150)]
        public int Age { get; set; }

        public string Course { get; set; }
    }
}
