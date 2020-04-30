namespace VisProg9
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.publish")]
    public partial class publish
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public publish()
        {
            purch_book = new HashSet<purch_book>();
        }

        [Key]
        public int publ_id { get; set; }

        [Required]
        public string publ_name { get; set; }

        public string publ_city { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<purch_book> purch_book { get; set; }
    }
}
