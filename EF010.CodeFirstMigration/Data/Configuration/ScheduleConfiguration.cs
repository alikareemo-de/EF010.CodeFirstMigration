using EF010.CodeFirstMigration.Entities;
using EF010.CodeFirstMigration.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF010.CodeFirstMigration.Data.Configuration
{
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            // builder.Property(x => x.CourseName).HasMaxLength(255); // nvarchar(255)



            builder.Property(x => x.Title).
                HasConversion(x => x.ToString(), x => (ScheduleEnum)Enum.Parse(typeof(ScheduleEnum), x));


            builder.ToTable("Schedules");


        }


    }
}
