namespace VisProg9
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.purchase")]
    public partial class purchase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public purchase()
        {
            purch_book = new HashSet<purch_book>();
        }

        [Key]
        public int purch_id { get; set; }

        public int? buyer_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime purch_date { get; set; }

        public virtual buyer buyer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<purch_book> purch_book { get; set; }
    }
}
