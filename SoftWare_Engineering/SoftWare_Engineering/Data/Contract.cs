namespace SoftWare_Engineering.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contract")]
    public partial class Contract
    {
        public int ID { get; set; }

        public int? ID_Student { get; set; }

        public int? ID_Staff { get; set; }

        public int ID_Room { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateStart { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateEnd { get; set; }

        public bool? Expired { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateFound { get; set; }
    }
}
