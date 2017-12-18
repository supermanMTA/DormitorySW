namespace SoftWare_Engineering.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Room")]
    public partial class Room
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string Name { get; set; }

        public int? ID_Dormitori { get; set; }

        public int? Number { get; set; }

        public int? MaxNumber { get; set; }

        public int? ID_TypeR { get; set; }
    }
}
