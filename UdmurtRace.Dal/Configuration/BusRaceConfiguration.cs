using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdmurtRace.Domain;

namespace UdmurtRace.Dal.Configuration
{
    public class BusRaceConfiguration : IEntityTypeConfiguration<BusRace>
    {
        public void Configure(EntityTypeBuilder<BusRace> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.DepartureDateTime)
                    .HasColumnType("datetime")
                    .IsRequired();

            builder.Property(x => x.Destination)
                    .HasColumnType("varchar(100)")
                    .IsRequired();

            builder.Property(x => x.TicketCost)
                    .HasColumnType("decimal(9,2)")
                    .IsRequired();

            builder.Property(x => x.NumberOfSeats)
                    .HasColumnType("int")
                    .IsRequired();

            builder.Property(x => x.Description)
                    .HasColumnType("varchar(255)");

            builder.HasMany(x => x.Tickets)
                    .WithOne(x => x.BusRaceModel)
                    .HasForeignKey(x => x.IdBusRace);
        }
    }
}
