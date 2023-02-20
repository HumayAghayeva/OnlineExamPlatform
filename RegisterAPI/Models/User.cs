using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineExamAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string Fullname { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string Email { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string Password { get; set; }
    }
}
