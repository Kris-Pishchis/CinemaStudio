using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaStudio.Model
{
    [Table("Staff")]
    public class Staff
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("family_name")]
        public string FamilyName { get; set; } = string.Empty;

        [Column("name")]
        public string Name { get; set; } = string.Empty;

        [Column("father_name")]
        public string FatherName {  get; set; } = string.Empty;

        [Column("rule_id")]
        public int RuleId { get; set; }

        [ForeignKey(nameof(RuleId))]
        public Rule? Rule { get; set; }

        [Column("bet")]
        public decimal Bet { get; set; }

        [Column("telephone")]
        public string? Telephone { get; set; } = string.Empty;

        [Column("mail")]
        public string? Mail {  get; set; } = string.Empty;

        [Column("login_id")]
        public string LoginId { get; set; } = string.Empty;

        [ForeignKey(nameof(LoginId))]
        public AccessRight? AccessRight { get; set; }
    }
}
