namespace SoftWare_Engineering.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Calendar")]
    public partial class Calendar
    {
        [Key]
        [Column(Order = 0, TypeName = "date")]
        public DateTime Day { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Staff { get; set; }

        public TimeSpan? Time { get; set; }
    }
}
