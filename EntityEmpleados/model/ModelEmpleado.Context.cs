﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityEmpleados.model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EmpleadosEntities : DbContext
    {
        public EmpleadosEntities()
            : base("name=EmpleadosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Puesto> Puesto { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<EmpleadoProyecto> EmpleadoProyecto { get; set; }
        public virtual DbSet<Proyecto> Proyecto { get; set; }
    }
}