// track

using System.ComponentModel.DataAnnotations;

namespace LessonsFor.DB.DBContent
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string FirstName { get; set; }

        public string GroupName { get; set; }
    }
}
