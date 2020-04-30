namespace VisProg9
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.buyer")]
    public partial class buyer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public buyer()
        {
            purchase = new HashSet<purchase>();
        }

        [Key]
        public int buyer_id { get; set; }

        [Required]
        public string buyer_name { get; set; }

        public string buyer_city { get; set; }

        public string type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<purchase> purchase { get; set; }
    }
}
