namespace gtsco2.basededonne
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transferer")]
    public partial class Transferer
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_etb { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(12)]
        public string num_stg { get; set; }

        [StringLength(50)]
        public string nom_directeur { get; set; }

        [StringLength(50)]
        public string prinom_directeur { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_transfert { get; set; }

        public virtual Etablissement Etablissement { get; set; }

        public virtual Stagiair Stagiair { get; set; }
    }
}
