namespace SoftWare_Engineering.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Asset
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoomID { get; set; }

        public int? Fan { get; set; }

        public int? Lights { get; set; }

        public int? Cabinets { get; set; }

        public int? Bed { get; set; }
    }
}
