﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GamesImHereData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GamesImHeredb : DbContext
    {
        public GamesImHeredb()
            : base("name=GamesImHeredb")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Console> Console { get; set; }
        public virtual DbSet<Games> Games { get; set; }
        public virtual DbSet<Images> Images { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
