namespace SoftWare_Engineering.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TypeRoom")]
    public partial class TypeRoom
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string Name { get; set; }
    }
}
