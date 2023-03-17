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
        public string Comment_content { get; set; }

        [Key]
        public DateTime Update_at { get; set; }
    }
}
