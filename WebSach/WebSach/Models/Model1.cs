using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebSach.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Chapter> Chapter { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<Reaction> Reaction { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Access_Times> Access_Times { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
