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
    
    public partial class Note
    {
        public int Id { get; set; }
        public string DateOfIssue { get; set; }
        public string Status { get; set; }
        public int NumberOfCopy { get; set; }
    
        public virtual Document Document { get; set; }
        public virtual Reader Reader { get; set; }
    }
}
