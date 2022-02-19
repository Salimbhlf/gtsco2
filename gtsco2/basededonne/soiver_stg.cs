namespace gtsco2.basededonne
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class soiver_stg
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string num_stg { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int prof { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int semestre { get; set; }

        [Column("NBR_ VISITE_FORMATEUR")]
        public int? NBR__VISITE_FORMATEUR { get; set; }

        [StringLength(50)]
        public string OBSERV_FORMAT { get; set; }

        public virtual prof prof1 { get; set; }

        public virtual Semestre Semestre1 { get; set; }

        public virtual Stagiair Stagiair { get; set; }
    }
}
