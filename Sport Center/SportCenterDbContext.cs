using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Center
{
    internal class SportCenterDbContext : DbContext
    {
        public SportCenterDbContext() : base("name=SportCenterDbContext")
        {
        }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Membership> Memberships { get; set; }
    }
}
