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
    
    public partial class Schedule
    {
        public int ID { get; set; }
        public int ID_DayOfTheWeek { get; set; }
        public int ID_ClassTime { get; set; }
        public int ID_Group { get; set; }
        public int ID_Location { get; set; }
        public int ID_Trainer { get; set; }
    
        public virtual ClassTime ClassTime { get; set; }
        public virtual DayOfTheWeek DayOfTheWeek { get; set; }
        public virtual Group Group { get; set; }
        public virtual Location Location { get; set; }
        public virtual Trainers Trainers { get; set; }
    }
}
