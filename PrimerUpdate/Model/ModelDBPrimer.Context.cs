﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrimerUpdate.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PrimerEntities : DbContext
    {
        public PrimerEntities()
            : base("name=PrimerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tovar> Tovars { get; set; }
        public virtual DbSet<TypeTovar> TypeTovars { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<ViewTovar> ViewTovars { get; set; }
    
        public virtual int KolichestvoTovarov(Nullable<decimal> price, ObjectParameter kolvo)
        {
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("KolichestvoTovarov", priceParameter, kolvo);
        }
    }
}