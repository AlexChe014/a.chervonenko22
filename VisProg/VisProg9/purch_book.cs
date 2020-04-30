namespace VisProg9
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.purch_book")]
    public partial class purch_book
    {
        [Key]
        [Column(Order = 0)]
        public int purch_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public int book_id { get; set; }

        [Key]
        [Column(Order = 2)]
        public int publ_id { get; set; }

        public int? count { get; set; }

        public virtual book book { get; set; }

        public virtual publish publish { get; set; }

        public virtual purchase purchase { get; set; }
    }
}
