﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracProject.Model.Context
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MN_ProjectEntities : DbContext
    {
        public MN_ProjectEntities()
            : base("name=MN_ProjectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<state> state { get; set; }
    }
}
