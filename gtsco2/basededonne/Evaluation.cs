namespace gtsco2.basededonne
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Evaluation")]
    public partial class Evaluation
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string Num_STG { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Semestre { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Année_SCO { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Module { get; set; }

        public int? Enseignant { get; set; }

        public double? Control_1 { get; set; }

        public double? Control_2 { get; set; }

        public double? Exam { get; set; }

        public double? Rattrapage { get; set; }

        public double? Moyenne_Module_AvRt { get; set; }

        public double? Moyenne_Module_ApRt { get; set; }

        public virtual annee_scolaire annee_scolaire { get; set; }

        public virtual Enseignant Enseignant1 { get; set; }

        public virtual Module Module { get; set; }

        public virtual Semestre Semestre { get; set; }

        public virtual Stagiair Stagiair { get; set; }
    }
}
