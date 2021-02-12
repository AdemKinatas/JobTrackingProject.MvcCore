using JobTrackingProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobTrackingProject.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class DutyMap : IEntityTypeConfiguration<Duty>
    {
        public void Configure(EntityTypeBuilder<Duty> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.Property(I => I.DutyName).HasMaxLength(200);
            builder.Property(I => I.Description).HasColumnType("ntext");

            builder.HasOne(x => x.Urgency).WithMany(x => x.Duties).HasForeignKey(x => x.UrgencyId);
        }
    }
}