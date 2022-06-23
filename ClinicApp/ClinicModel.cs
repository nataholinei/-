using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ClinicApp
{
    public partial class ClinicModel : DbContext
    {
        public ClinicModel()
            : base("name=ClinicModelConection")
        {
        }

        public virtual DbSet<BadDrugs> BadDrugs { get; set; }
        public virtual DbSet<Diagnoses> Diagnoses { get; set; }
        public virtual DbSet<Doctors> Doctors { get; set; }
        public virtual DbSet<Drugs> Drugs { get; set; }
        public virtual DbSet<DrugsComponents> DrugsComponents { get; set; }
        public virtual DbSet<DrugsList> DrugsList { get; set; }
        public virtual DbSet<History> History { get; set; }
        public virtual DbSet<Ingredients> Ingredients { get; set; }
        public virtual DbSet<Patients> Patients { get; set; }
        public virtual DbSet<Persons> Persons { get; set; }
        public virtual DbSet<SpecialAccount> SpecialAccount { get; set; }
        public virtual DbSet<Specialization> Specialization { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctors>()
                .HasMany(e => e.History)
                .WithRequired(e => e.Doctors)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patients>()
                .HasMany(e => e.History)
                .WithRequired(e => e.Patients)
                .WillCascadeOnDelete(false);
        }
    }
}
