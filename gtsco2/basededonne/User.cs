namespace gtsco2.basededonne
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [Key]
        public int ID_user { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string Nomeutlisature { get; set; }

        public string MotedePasse { get; set; }

        [StringLength(50)]
        public string Role { get; set; }

        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }
    }
}
