namespace WebSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Chapter")]
    public partial class Chapter
    {
        [Key]
        public int Chapter_Id { get; set; }

        [StringLength(250)]
        public string Chapter_Name { get; set; }

        public string Content { get; set; }

        public int? Book_Id { get; set; }

        public virtual Books Books { get; set; }
    }
}
