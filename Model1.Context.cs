//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _13._12._21
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class arama23Entities : DbContext
    {
        public arama23Entities()
            : base("name=arama23Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<author> author { get; set; }
        public virtual DbSet<book> book { get; set; }
        public virtual DbSet<reader> reader { get; set; }
        public virtual DbSet<reader_ticket> reader_ticket { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
