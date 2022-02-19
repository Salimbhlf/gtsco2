namespace gtsco2.basededonne
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Module")]
    public partial class Module
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Module()
        {
            Evaluations = new HashSet<Evaluation>();
        }

        [Key]
        public int ID_Module { get; set; }

        [StringLength(30)]
        public string Designation_Module { get; set; }

        public double? Note_Elim_Module { get; set; }

        public int? coefficient_Module { get; set; }

        public int? ID_Option { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evaluation> Evaluations { get; set; }

        public virtual Opation Opation { get; set; }
    }
}
