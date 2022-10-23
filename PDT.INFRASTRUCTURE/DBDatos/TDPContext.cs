using Microsoft.EntityFrameworkCore;
using PDT.CORE.Entities;

namespace PDT.INFRASTRUCTURE.DBDatos
{
    public partial class TDPContext : DbContext
    {
        public TDPContext()
        {
        }

        public TDPContext(DbContextOptions<TDPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DetailsFlight> DetailsFlights { get; set; } = null!;
        public virtual DbSet<Flight> Flights { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetailsFlight>(entity =>
            {
                entity.HasKey(e => e.IdxDetailsFlights);

                entity.ToTable("DETAILS_FLIGHTS");

                entity.Property(e => e.IdxDetailsFlights)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDX_DETAILS_FLIGHTS");

                entity.Property(e => e.DateBirth)
                    .HasColumnType("date")
                    .HasColumnName("DATE_BIRTH");

                entity.Property(e => e.DocumentPerson)
                    .HasMaxLength(50)
                    .HasColumnName("DOCUMENT_PERSON");

                entity.Property(e => e.IdxFlights)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDX_FLIGHTS");

                entity.Property(e => e.IsChild).HasColumnName("IS_CHILD");

                entity.Property(e => e.NamePerson)
                    .HasMaxLength(150)
                    .HasColumnName("NAME_PERSON");

                entity.HasOne(d => d.IdxFlightsNavigation)
                    .WithMany(p => p.DetailsFlights)
                    .HasForeignKey(d => d.IdxFlights)
                    .HasConstraintName("FK_DETAILS_FLIGHTS_FLIGHTS");
            });

            modelBuilder.Entity<Flight>(entity =>
            {
                entity.HasKey(e => e.IdxFlights);

                entity.ToTable("FLIGHTS");

                entity.Property(e => e.IdxFlights)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDX_FLIGHTS");

                entity.Property(e => e.Adult)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ADULT");

                entity.Property(e => e.ArrivalCity)
                    .HasMaxLength(50)
                    .HasColumnName("ARRIVAL_CITY");

                entity.Property(e => e.Child)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CHILD");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.DepartureCity)
                    .HasMaxLength(50)
                    .HasColumnName("DEPARTURE_CITY");

                entity.Property(e => e.Hour)
                    .HasColumnType("datetime")
                    .HasColumnName("HOUR");

                entity.Property(e => e.Money)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("MONEY");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
