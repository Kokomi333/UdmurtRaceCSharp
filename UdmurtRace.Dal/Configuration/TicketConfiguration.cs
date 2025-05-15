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
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Status)
                    .HasColumnType("varchar(40)")
                    .IsRequired();

            builder.Property(x => x.Notes)
                    .HasColumnType("varchar(255)");

            builder.HasOne(x => x.ClientModel)
                    .WithMany(x => x.Tickets)
                    .HasForeignKey(x => x.IdClient);

            builder.HasOne(x => x.BusRaceModel)
                    .WithMany(x => x.Tickets)
                    .HasForeignKey(x => x.IdBusRace);

        }
    }
}
