namespace WebSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int User_Id { get; set; }

        [StringLength(50)]
        public string User_Name { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public DateTime? Create_at { get; set; }

        public DateTime? Last_Login { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public bool? Permission_Id { get; set; }
    }
}
