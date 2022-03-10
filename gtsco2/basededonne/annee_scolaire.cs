namespace gtsco2.basededonne
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class annee_scolaire
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public annee_scolaire()
        {
            Absences = new HashSet<Absence>();
            Evaluations = new HashSet<Evaluation>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Année_SCO { get; set; }

        [StringLength(50)]
        public string Designation { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATE_D_Année_SCO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_F_Année_SCO { get; set; }

        [StringLength(15)]
        public string Session_Année_SCO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Absence> Absences { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evaluation> Evaluations { get; set; }
    }
}
