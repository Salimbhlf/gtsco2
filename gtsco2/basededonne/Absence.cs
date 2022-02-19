namespace gtsco2.basededonne
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Absence")]
    public partial class Absence
    {
        [Key]
        public int ID_Absence { get; set; }

        public bool? Seance_1_ABS { get; set; }

        public bool? Seance_2_ABS { get; set; }

        public bool? Seance_3_ABS { get; set; }

        public bool? Seance_4_ABS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_ABS { get; set; }

        public bool? Absence_Justifer { get; set; }

        [StringLength(50)]
        public string Justif_ABS { get; set; }

        [StringLength(12)]
        public string Num_STG { get; set; }

        public int? ID_Semestre { get; set; }

        public int? ID_Année_SCO { get; set; }

        public virtual annee_scolaire annee_scolaire { get; set; }

        public virtual Semestre Semestre { get; set; }

        public virtual Stagiair Stagiair { get; set; }
    }
}
