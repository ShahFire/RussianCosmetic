//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RussianCosmetic.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class pasport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pasport()
        {
            this.fiz_lizo = new HashSet<fiz_lizo>();
        }
    
        public int id { get; set; }
        public int seria { get; set; }
        public int nomer { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fiz_lizo> fiz_lizo { get; set; }
    }
}