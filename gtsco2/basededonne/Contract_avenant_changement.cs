namespace gtsco2.basededonne
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contract_avenant_changement
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_emp { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(12)]
        public string num_stg { get; set; }

        public int? NUM_AV_CHANG { get; set; }

        public int? NUM_AV_VALID_CHANG { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATE_AV_VALID_CHANG { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATE_DBT_FORMA_CHANG { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATE_FIN_FORMA_CHANG { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATE_FIN_FORMA_ANCIEN_EMP { get; set; }

        public virtual Employeur Employeur { get; set; }

        public virtual Stagiair Stagiair { get; set; }
    }
}
