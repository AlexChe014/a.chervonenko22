namespace VisProg7
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.report")]
    public partial class report
    {
        [Key]
        public int rep_id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int emp_id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int prov_id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int exp_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime rep_date { get; set; }
    }
}
