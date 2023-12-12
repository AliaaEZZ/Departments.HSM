using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace HSM
{
    public partial class Model1: DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<APPOINTMENT> APPOINTMENTs { get; set; }
        public virtual DbSet<DEPARTMENT> DEPARTMENTs { get; set; }
        public virtual DbSet<DOCTOR> DOCTORs { get; set; }
        public virtual DbSet<PATIENT> PATIENTs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DEPARTMENT>()
                .Property(e => e.NAME_DEP)
                .IsUnicode(false);

            modelBuilder.Entity<DOCTOR>()
                .Property(e => e.DOC_Name)
                .IsUnicode(false);

            modelBuilder.Entity<DOCTOR>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<DOCTOR>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<PATIENT>()
                .Property(e => e.name_patient)
                .IsUnicode(false);

            modelBuilder.Entity<PATIENT>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<PATIENT>()
                .Property(e => e.Town)
                .IsUnicode(false);

            modelBuilder.Entity<PATIENT>()
                .Property(e => e.AddressS)
                .IsUnicode(false);

            modelBuilder.Entity<PATIENT>()
                .Property(e => e.PHONE)
                .IsUnicode(false);
        }
    }
}
