using ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    public class ChansonConfiguration : IEntityTypeConfiguration<Chanson>
    {
        public void Configure(EntityTypeBuilder<Chanson> builder)
        {
            builder.HasOne(c=> c.artiste).WithMany(a=>a.Chansons).HasForeignKey(c=>c.ArtisteFK).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
