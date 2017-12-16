namespace SoftWare_Engineering.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dormitory")]
    public partial class Dormitory
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? NumberRoom { get; set; }
    }
}
