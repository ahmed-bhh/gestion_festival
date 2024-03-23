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
    public class FestivalConfiguration : IEntityTypeConfiguration<Festival>
    {
        public void Configure(EntityTypeBuilder<Festival> builder)
        {
            //houni aamlt manyTomany w khtart eli Concert heya join entity



            //aamlitli mochkla ama khedmet ki aaamktha fil ExamenContext
                  builder.HasMany(a => a.Artists).WithMany(f => f.Festivals).UsingEntity<Concert>();
        }
    }
}
