﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LombardWPF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LombardDBEntities : DbContext
    {
        public LombardDBEntities()
            : base("name=LombardDBEntities")
        {
        }

        private static LombardDBEntities _context;
        public static LombardDBEntities GetContext()
        {
            if (_context == null)
                _context = new LombardDBEntities();
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<PaymentSchedule> PaymentSchedule { get; set; }
        public virtual DbSet<PaymentStatus> PaymentStatus { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}