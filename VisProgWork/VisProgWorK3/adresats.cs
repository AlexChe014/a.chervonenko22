//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VisProgWorK3
{
    using System;
    using System.Collections.Generic;
    
    public partial class adresats
    {
        public int id_a { get; set; }
        public string snp { get; set; }
        public string email { get; set; }
        public int adr { get; set; }
        public string message_t { get; set; }
    
        public virtual clients clients { get; set; }
    }
}
