namespace VisProg9
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.book")]
    public partial class book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public book()
        {
            purch_book = new HashSet<purch_book>();
        }

        [Key]
        public int book_id { get; set; }

        public int? aut_id { get; set; }

        [Required]
        public string book_name { get; set; }

        public int? book_year { get; set; }

        public string genre { get; set; }

        public virtual author author { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<purch_book> purch_book { get; set; }
    }
}
