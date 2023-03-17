namespace WebSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Access_Times
    {
        [Key]
        public int AccessTimes { get; set; }

        public DateTime? Update_at { get; set; }
    }
}
