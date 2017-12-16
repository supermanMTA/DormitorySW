namespace SoftWare_Engineering.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bill")]
    public partial class Bill
    {
        public int ID { get; set; }

        public int BillOfMonth { get; set; }

        public int BillOfYear { get; set; }

        public double? Rent { get; set; }

        public double? ElectricCharge { get; set; }

        public double? WaterCharge { get; set; }

        public double? Surcharge { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateFounded { get; set; }

        public int? ID_Student { get; set; }

        public int? ID_Room { get; set; }

        public int? ID_Staff { get; set; }
    }
}
