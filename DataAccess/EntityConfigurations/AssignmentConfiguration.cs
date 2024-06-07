using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            builder.ToTable("Assignments").HasKey(op => op.Id);

            builder.Property(op => op.Id).HasColumnName("Id").IsRequired();
            builder.Property(op => op.UserId).HasColumnName("UserId").IsRequired();
            builder.Property(op => op.Title).HasColumnName("Title").IsRequired();
            builder.Property(op => op.Description).HasColumnName("Description").IsRequired();
            builder.Property(op => op.CreationDate).HasColumnName("CreationDate").IsRequired();

            builder.HasQueryFilter(op => !op.DeletedDate.HasValue);

            builder.HasMany(op => op.Comments).WithOne(uc => uc.Assignment).HasForeignKey(uc => uc.AssignmentId);

        }
    }
}
