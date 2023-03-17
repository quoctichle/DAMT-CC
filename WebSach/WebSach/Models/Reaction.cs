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
        public int Reaction_Id { get; set; }

        public string Comment_content { get; set; }

        public DateTime Update_at { get; set; }
    }
}
