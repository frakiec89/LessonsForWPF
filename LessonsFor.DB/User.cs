// track
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace LessonsFor.DB
{

    [Index("Login", IsUnique = true)]
    public class User
    {

        [Key]
        public int  Id { get; set; }
       
        public string Login { get; set; }


        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Password { get; set; }
    }
}
