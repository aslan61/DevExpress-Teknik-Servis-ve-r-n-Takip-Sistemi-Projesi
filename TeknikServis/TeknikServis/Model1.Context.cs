﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeknikServis
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DBTeknikServisEntities : DbContext
    {
        public DBTeknikServisEntities()
            : base("name=DBTeknikServisEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TBLADMIN> TBLADMIN { get; set; }
        public virtual DbSet<TBLCARI> TBLCARI { get; set; }
        public virtual DbSet<TBLDEPARTMAN> TBLDEPARTMAN { get; set; }
        public virtual DbSet<TBLFATURABILGI> TBLFATURABILGI { get; set; }
        public virtual DbSet<TBLFATURADETAY> TBLFATURADETAY { get; set; }
        public virtual DbSet<TBLKATEGORİ> TBLKATEGORİ { get; set; }
        public virtual DbSet<TBLNOTLARIM> TBLNOTLARIM { get; set; }
        public virtual DbSet<TBLPERSONEL> TBLPERSONEL { get; set; }
        public virtual DbSet<TBLURUN> TBLURUN { get; set; }
        public virtual DbSet<TBLURUNHAREKET> TBLURUNHAREKET { get; set; }
        public virtual DbSet<TBLURUNKABUL> TBLURUNKABUL { get; set; }
        public virtual DbSet<TBLURUNTAKIP> TBLURUNTAKIP { get; set; }
        public virtual DbSet<TBLARACLAR> TBLARACLAR { get; set; }
        public virtual DbSet<TBLHAKKIMIZDA> TBLHAKKIMIZDA { get; set; }
        public virtual DbSet<TBLİLETİŞİM> TBLİLETİŞİM { get; set; }
        public virtual DbSet<TBLILÇELER> TBLILÇELER { get; set; }
        public virtual DbSet<TBLILLER> TBLILLER { get; set; }
    
        public virtual ObjectResult<urunkategori_Result> urunkategori()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<urunkategori_Result>("urunkategori");
        }
    
        public virtual ObjectResult<string> MAXKATEGORİURUN()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("MAXKATEGORİURUN");
        }
    
        public virtual ObjectResult<string> maksürünmarka()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("maksürünmarka");
        }
    
        public virtual ObjectResult<string> makscariil()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("makscariil");
        }
    }
}