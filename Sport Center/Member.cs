using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sport_Center
{
    [Table("Table_Member")]
    internal class Member
    {
        [Key]
        public int Member_Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Member_Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Member_Surname { get; set; }

        [Required]
        [MaxLength(50)]
        public string Member_Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string Member_Phone { get; set; }

        public virtual ICollection<Membership> Memberships { get; set; }
    }
}
