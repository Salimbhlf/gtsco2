namespace gtsco2.basededonne
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Enseignant")]
    public partial class Enseignant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Enseignant()
        {
            Evaluations = new HashSet<Evaluation>();
            PARTICIPEs = new HashSet<PARTICIPE>();
            Suiver_stagiaire = new HashSet<Suiver_stagiaire>();
        }

        [Key]
        public int id_Enseignant { get; set; }

        [StringLength(50)]
        public string Nom { get; set; }

        [StringLength(50)]
        public string Nom_ar { get; set; }

        [StringLength(50)]
        public string prenom { get; set; }

        [StringLength(50)]
        public string Prenom_ar { get; set; }

        [StringLength(50)]
        public string Niveau { get; set; }

        [StringLength(50)]
        public string Poste { get; set; }

        [StringLength(50)]
        public string Poste_ar { get; set; }

        [StringLength(50)]
        public string Specialite { get; set; }

        public int? Mode_Formation { get; set; }

        public virtual Mode_formation Mode_formation1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evaluation> Evaluations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PARTICIPE> PARTICIPEs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Suiver_stagiaire> Suiver_stagiaire { get; set; }
    }
}
