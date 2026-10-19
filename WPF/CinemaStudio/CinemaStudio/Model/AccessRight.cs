using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaStudio.Model
{
    [Table("Access_right")]
    public class AccessRight
    {
        [Key]
        [Column("login")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] 
        public string Login { get; set; } = string.Empty;

        [Column("password")]
        public string Password { get; set; } = string.Empty;

        public ICollection<Staff> Staff { get; set; } = new List<Staff>();
    }
}
