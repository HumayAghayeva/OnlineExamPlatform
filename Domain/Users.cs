using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
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
