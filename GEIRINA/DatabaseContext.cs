using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using CIME.Core;
using CIME.LoadModel;
using CIME.Wires;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace CIME.GEIRINA
{
    public class DatabaseContext : DbContext
    {
//        public DbSet<IdentifiedObject> IdentifiedObjects { get; set; }
        public DbSet<ControlArea.ControlArea> ControlAreas { get; set; }
        public DbSet<BaseVoltage> BaseVoltages { get; set; }
        public DbSet<Substation> Substations { get; set; }
        public DbSet<VoltageLevel> VoltageLevels { get; set; }
        public DbSet<Bay> Bays { get; set; }
        public DbSet<Breaker> Breakers { get; set; }
        public DbSet<Disconnector> Disconnectors { get; set; }
        public DbSet<GroundDisconnector> GroundDisconnectors { get; set; }
        public DbSet<BusbarSection> BusbarSections { get; set; }
        public DbSet<SynchronousMachine> SynchronousMachines { get; set; }
        public DbSet<ACLineSegment> ACLineSegments { get; set; }
        public DbSet<ACLineDot> ACLineDots { get; set; }
        public DbSet<Load> Loads { get; set; }
        public DbSet<PowerTransformer> PowerTransformers { get; set; }
        public DbSet<TransformerWinding> TransformerWindings { get; set; }
        public DbSet<TapChangerType> TapChangerTypes { get; set; }
        public DbSet<ShuntCompensator> ShuntCompensators { get; set; }
        public DbSet<SeriesCompensator> SeriesCompensators { get; set; }

        public DatabaseContext()
        {
            base.Database.EnsureCreated();
        }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //            var baseType = typeof(IdentifiedObject);
            //            var types = AppDomain.CurrentDomain.GetAssemblies()
            //                                 .SelectMany(s => s.GetTypes())
            //                                 .Where(p => baseType.IsAssignableFrom(p));
#if TPT
            modelBuilder.Entity<IdentifiedObject>();
//            modelBuilder.Entity<PowerSystemResource>();
//            modelBuilder.Entity<PowerSystemResourceWithPathname>();
//            modelBuilder.Entity<ConnectivityNodeContainer>();
//            modelBuilder.Entity<EquipmentContainer>();
//            modelBuilder.Entity<Equipment>();
//            modelBuilder.Entity<ConductingEquipment>();
//            modelBuilder.Entity<EnergyConsumer>();
//            modelBuilder.Entity<ConformLoad>();
//            modelBuilder.Entity<Connector>();
//            modelBuilder.Entity<RegulatingCondEq>();
//            modelBuilder.Entity<Conductor>();
//            modelBuilder.Entity<Switch>();
//            modelBuilder.Entity<ProtectedSwitch>();
#endif
//            modelBuilder.Entity<ControlArea.ControlArea>().ToTable("ControlArea");
//            modelBuilder.Entity<BaseVoltage>().ToTable("BaseVoltage");
//            modelBuilder.Entity<Substation>().ToTable("Substation");
//            modelBuilder.Entity<VoltageLevel>().ToTable("VoltageLevel");
//            modelBuilder.Entity<Bay>().ToTable("Bay");
//            modelBuilder.Entity<Breaker>().ToTable("Breaker");
//            modelBuilder.Entity<Disconnector>().ToTable("Disconnector");
//            modelBuilder.Entity<GroundDisconnector>().ToTable("GroundDisconnector");
//            modelBuilder.Entity<BusbarSection>().ToTable("BusbarSection");
//            modelBuilder.Entity<SynchronousMachine>().ToTable("SynchronousMachine");
//            modelBuilder.Entity<ACLineSegment>().ToTable("ACLineSegment");
//            modelBuilder.Entity<ACLineDot>().ToTable("ACLineDot");
//            modelBuilder.Entity<Load>().ToTable("Load");
//            modelBuilder.Entity<PowerTransformer>().ToTable("PowerTransformer");
//            modelBuilder.Entity<TransformerWinding>().ToTable("TransformerWinding");
//            modelBuilder.Entity<TapChangerType>().ToTable("TapChangerType");
//            modelBuilder.Entity<ShuntCompensator>().ToTable("ShuntCompensator");
//            modelBuilder.Entity<SeriesCompensator>().ToTable("SeriesCompensator");

            modelBuilder.Entity<Substation>().Property(b => b.x).HasColumnName("x");
            modelBuilder.Entity<ACLineSegment>().Property(b => b.X).HasColumnName("x");
            modelBuilder.Entity<SeriesCompensator>().Property(b => b.x).HasColumnName("x");
            modelBuilder.Entity<SynchronousMachine>().Property(b => b.X).HasColumnName("x");
            modelBuilder.Entity<TransformerWinding>().Property(b => b.x).HasColumnName("x");

            modelBuilder.Entity<Bay>().Property(b => b.Type).HasColumnName("Type");
            modelBuilder.Entity<Breaker>().Property(b => b.type).HasColumnName("Type");
            modelBuilder.Entity<GroundDisconnector>().Property(b => b.type).HasColumnName("Type");
            modelBuilder.Entity<PowerTransformer>().Property(b => b.type).HasColumnName("Type");
            modelBuilder.Entity<Substation>().Property(b => b.Type).HasColumnName("Type");
            modelBuilder.Entity<SynchronousMachine>().Property(b => b.Type).HasColumnName("Type");
            modelBuilder.Entity<VoltageLevel>().Property(b => b.Type).HasColumnName("Type");

            modelBuilder.Entity<ACLineSegment>().Property(b => b.R).HasColumnName("R");
            modelBuilder.Entity<SeriesCompensator>().Property(b => b.r).HasColumnName("R");
            modelBuilder.Entity<SynchronousMachine>().Property(b => b.R).HasColumnName("R");
            modelBuilder.Entity<TransformerWinding>().Property(b => b.r).HasColumnName("R");

            modelBuilder.Entity<ACLineSegment>().Property(b => b.ratedMW).HasColumnName("RatedMW");
            modelBuilder.Entity<SynchronousMachine>().Property(b => b.RatedMW).HasColumnName("RatedMW");
        }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = E:\cim.db;");
        }
    }
}
