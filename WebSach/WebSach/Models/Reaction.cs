namespace WebSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reaction")]
    public partial class Reaction
    {
        [Key]
        public int Comment_Id { get; set; }

        public string Comment_content { get; set; }

        public DateTime Update_at { get; set; }

        [StringLength(50)]
        public string User_Name { get; set; }

        public int? Book_Id { get; set; }

        public virtual Books Books { get; set; }

        public virtual User User { get; set; }
    }
}
