﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UP
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<access_network> access_network { get; set; }
        public virtual DbSet<applicaitons> applicaitons { get; set; }
        public virtual DbSet<backbone_equipment> backbone_equipment { get; set; }
        public virtual DbSet<base_stations> base_stations { get; set; }
        public virtual DbSet<employee_roles> employee_roles { get; set; }
        public virtual DbSet<info_for_employeers> info_for_employeers { get; set; }
        public virtual DbSet<payments> payments { get; set; }
        public virtual DbSet<st_petersburg_districts> st_petersburg_districts { get; set; }
        public virtual DbSet<stations> stations { get; set; }
        public virtual DbSet<subscriber_tariffs> subscriber_tariffs { get; set; }
        public virtual DbSet<subscribers> subscribers { get; set; }
        public virtual DbSet<subscribers_addresses> subscribers_addresses { get; set; }
        public virtual DbSet<subscribers_equipment> subscribers_equipment { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tariffs> tariffs { get; set; }
        public virtual DbSet<TNS_employeers> TNS_employeers { get; set; }
        public virtual DbSet<treates> treates { get; set; }
    }
}
