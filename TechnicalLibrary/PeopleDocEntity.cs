//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechnicalLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class PeopleDocEntity
    {
        public int Id { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Document Document { get; set; }
        public virtual Student Student { get; set; }
    }
}
