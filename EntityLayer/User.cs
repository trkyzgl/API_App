using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class User
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Fullname { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? mail { get; set; }
        public bool? email_verified { get; set; }
        public DateTime? Create_date { get; set; }
        public bool? Enabled { get; set; }







    }
}
