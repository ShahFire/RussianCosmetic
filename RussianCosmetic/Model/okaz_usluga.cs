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
    
    public partial class okaz_usluga
    {
        public int id { get; set; }
        public System.DateTime data { get; set; }
        public int usluga_id { get; set; }
        public int controller_id { get; set; }
    
        public virtual controller controller { get; set; }
        public virtual usluga usluga { get; set; }
    }
}