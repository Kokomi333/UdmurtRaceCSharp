
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
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(x => x.Id); 
            builder.Property(x => x.PhoneNumber)
                   .HasColumnType("varchar(13)")
                   .IsRequired();
            builder.HasIndex(x => x.PhoneNumber)
                    .IsUnique();

            builder.Property(x => x.Name)
                   .HasColumnType("varchar(100)")
                   .IsRequired();

            builder.Property(x => x.Surname)
                   .HasColumnType("varchar(100)")
                   .IsRequired();
            
            builder.Property(x => x.Email)
                    .HasColumnType("varchar(100)")
                    .IsRequired();
            builder.HasIndex(x => x.Email)
                    .IsUnique();

            builder.Property(x => x.Patronymic)
                   .HasColumnType("varchar(100)");

            builder.Property(x => x.Address)
                   .HasColumnType("varchar(100)")
                   .IsRequired();

            builder.HasMany(x => x.Tickets)
                    .WithOne(x => x.ClientModel)
                    .HasForeignKey(x => x.IdClient);
        }
    }
}
