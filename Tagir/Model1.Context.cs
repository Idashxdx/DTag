﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class tagirEntities1 : DbContext
    {
        public tagirEntities1()
            : base("name=tagirEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<ClassTime> ClassTime { get; set; }
        public virtual DbSet<DayOfTheWeek> DayOfTheWeek { get; set; }
        public virtual DbSet<GenderKids> GenderKids { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<Kids> Kids { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Trainers> Trainers { get; set; }
        public virtual DbSet<Type> Type { get; set; }
    }
}
