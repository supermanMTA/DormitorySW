namespace SoftWare_Engineering.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoomAssessment")]
    public partial class RoomAssessment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? ID_Staff { get; set; }

        public int? ID_Room { get; set; }

        [StringLength(50)]
        public string Purport { get; set; }

        public int? ID_Year { get; set; }
    }
}
