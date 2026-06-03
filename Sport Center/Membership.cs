using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sport_Center
{
    [Table("Table_Membership")]
    internal class Membership
    {
        [Key]
        public int Membership_Id { get; set; }

        [ForeignKey("Member")]
        public int Member_Id { get; set; }

        [ForeignKey("Package")]
        public int Package_Id { get; set; }

        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }

        public virtual Member Member { get; set; }
        public virtual Package Package { get; set; }
    }
}
