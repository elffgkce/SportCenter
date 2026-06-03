using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sport_Center
{
    [Table("Table_Staff")]
    internal class Staff
    {
        [Key]
        public int Staff_Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Staff_Name { get; set; } 

        [Required]
        [MaxLength(50)]
        public string Staff_Username { get; set; } 

        [Required]
        [MaxLength(50)]
        public string Staff_Password { get; set; }
    }
}
