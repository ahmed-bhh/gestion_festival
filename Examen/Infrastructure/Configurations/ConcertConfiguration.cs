using ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    public class ConcertConfiguration : IEntityTypeConfiguration<Concert>
    {
        public void Configure(EntityTypeBuilder<Concert> builder)
        {
            builder.Property(c => c.ArtisteId).HasColumnName("ArtisteFK");
            builder.Property(c => c.FestivalId).HasColumnName("FestivalFK");
           

            //
            builder.HasKey(c => new {c.ArtisteId,c.FestivalId,c.DateConcert});


        }
    }
}
