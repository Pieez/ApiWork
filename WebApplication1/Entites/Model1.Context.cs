﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Entites
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RegistrEntities : DbContext
    {
        public RegistrEntities()
            : base("name=RegistrEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C_1> C_1 { get; set; }
        public virtual DbSet<C_2> C_2 { get; set; }
        public virtual DbSet<Emission> Emission { get; set; }
        public virtual DbSet<Source> Source { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Imaage> Imaage { get; set; }
        public virtual DbSet<order2> order2 { get; set; }
        public virtual DbSet<Pictures> Pictures { get; set; }
        public virtual DbSet<Stud> Stud { get; set; }
    }
}
