namespace gtsco2.basededonne
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contrat_changement_employeur
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string Num_stg { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_emp { get; set; }

        public int? Num_validation_cont_proro { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_validation_cont_proro { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_dbt_proro { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_fin_proro { get; set; }

        public virtual Employeur Employeur { get; set; }

        public virtual Stagiair Stagiair { get; set; }
    }
}
