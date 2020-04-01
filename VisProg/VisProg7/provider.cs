namespace VisProg7
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.provider")]
    public partial class provider
    {
        [Key]
        public int prov_id { get; set; }

        [Required]
        public string prov_name { get; set; }

        public string address { get; set; }
    }
}
