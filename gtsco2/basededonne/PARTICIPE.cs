namespace gtsco2.basededonne
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PARTICIPE")]
    public partial class PARTICIPE
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_Enseignant { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_PV_Délibiration { get; set; }

        [StringLength(50)]
        public string Qualite { get; set; }

        [StringLength(50)]
        public string Qualite_ar { get; set; }

        public virtual Enseignant Enseignant { get; set; }

        public virtual Proce_verbal_delibation Proce_verbal_delibation { get; set; }
    }
}
