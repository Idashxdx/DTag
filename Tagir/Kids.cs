//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tagir
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kids
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public int ID_Gerder { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public int ID_Group { get; set; }
        public string Parents { get; set; }
    
        public virtual GenderKids GenderKids { get; set; }
        public virtual Group Group { get; set; }
    }
}
