namespace SoftWare_Engineering.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Discipline")]
    public partial class Discipline
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string Reason { get; set; }

        [StringLength(30)]
        public string Degree { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        [StringLength(100)]
        public string Level_Dis { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        public int? ID_Student { get; set; }
    }
}
