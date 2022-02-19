namespace gtsco2.basededonne
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Decision")]
    public partial class Decision
    {
        [Key]
        public int ID_Decision { get; set; }

        [StringLength(30)]
        public string Type_Decision { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_Decision { get; set; }

        public int? ID_PV_Délibiration { get; set; }

        public int? ID_Promo { get; set; }

        public int? ID_Semestre { get; set; }

        [StringLength(12)]
        public string Num_STG { get; set; }

        public virtual Proce_verbal_delibation Proce_verbal_delibation { get; set; }

        public virtual Promo Promo { get; set; }

        public virtual Semestre Semestre { get; set; }

        public virtual Stagiair Stagiair { get; set; }
    }
}
