namespace SoftWare_Engineering.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RegistrationForm")]
    public partial class RegistrationForm
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [StringLength(50)]
        public string Object { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [StringLength(10)]
        public string Nation { get; set; }

        [StringLength(10)]
        public string Religion { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(20)]
        public string IdentityCard { get; set; }

        [StringLength(50)]
        public string NameFather { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthDayOfFather { get; set; }

        [StringLength(50)]
        public string JobOfFather { get; set; }

        [StringLength(50)]
        public string NameMother { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthDayOfMother { get; set; }

        [StringLength(50)]
        public string JobOfMother { get; set; }

        public int? ID_Class { get; set; }
    }
}
