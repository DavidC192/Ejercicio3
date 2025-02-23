using System.ComponentModel.DataAnnotations;

namespace AztroWebApplication.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }
        
        public User()
        {
        }

    }
}
