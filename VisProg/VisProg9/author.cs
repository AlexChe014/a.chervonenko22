namespace VisProg9
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.author")]
    public partial class author
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public author()
        {
            book = new HashSet<book>();
        }

        [Key]
        public int aut_id { get; set; }

        [Required]
        public string aut_surname { get; set; }

        [Required]
        public string aut_name { get; set; }

        public string aut_lastname { get; set; }

        [Column(TypeName = "date")]
        public DateTime? aut_bd { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<book> book { get; set; }
    }
}
