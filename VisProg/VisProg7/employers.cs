namespace VisProg7
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.employers")]
    public partial class employers
    {
        [Key]
        public int emp_id { get; set; }

        [Required]
        public string surname { get; set; }

        [Required]
        public string name { get; set; }

        public string patronymic { get; set; }

        [Column(TypeName = "date")]
        public DateTime? birthday { get; set; }

        [Column(TypeName = "date")]
        public DateTime? employ_d { get; set; }
    }
}
