using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sport_Center
{
    [Table("Table_Package")]
    internal class Package
    {
        [Key]
        public int Package_Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Package_Name { get; set; }

        [Required]
        public decimal Package_Price { get; set; }

        [Required]
        public int Package_Duration { get; set; }

        public virtual ICollection<Membership> Memberships { get; set; }
    }
}
