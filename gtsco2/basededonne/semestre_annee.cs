namespace gtsco2.basededonne
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class semestre_annee
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Semestre { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_annee_sco { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_dube_semester { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_fin_semester { get; set; }

        public virtual annee_scolaire annee_scolaire { get; set; }

        public virtual Semestre Semestre { get; set; }
    }
}
