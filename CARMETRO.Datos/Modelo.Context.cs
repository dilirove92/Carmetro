﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CARMETRO.Datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ParqueoEntity : DbContext
    {
        public ParqueoEntity()
            : base("name=ParqueoEntity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<area_estacionamiento> area_estacionamiento { get; set; }
        public DbSet<area_estacionamiento_pagos> area_estacionamiento_pagos { get; set; }
        public DbSet<piso> pisoes { get; set; }
        public DbSet<propietario> propietarios { get; set; }
        public DbSet<vehiculo> vehiculoes { get; set; }
    }
}
