namespace VisProg7
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.expences")]
    public partial class expences
    {
        [Key]
        public int exp_id { get; set; }

        [Required]
        public string exp_name { get; set; }

        public string description { get; set; }
    }
}
