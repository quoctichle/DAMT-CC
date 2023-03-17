namespace WebSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Books
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Books()
        {
            Chapter = new HashSet<Chapter>();
        }

        [Key]
        public int Book_Id { get; set; }

        [StringLength(250)]
        public string Title { get; set; }

        [StringLength(250)]
        public string Category { get; set; }

        [Required]
        [StringLength(50)]
        public string Author { get; set; }

        public string Description { get; set; }

        public DateTime? Create_at { get; set; }

        public DateTime? Update_at { get; set; }

        [StringLength(50)]
        public string Avatar { get; set; }

        public int? View { get; set; }

        public string Content { get; set; }

        [StringLength(10)]
        public string User_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chapter> Chapter { get; set; }
    }
}
