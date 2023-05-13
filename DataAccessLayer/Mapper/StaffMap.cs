using EntityLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapper
{
    public class StaffMap : IEntityTypeConfiguration<Staff>
    {  
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.ToTable("Staffs");
            builder.HasKey(s => s.Id);
            builder.HasIndex(s => s.Email).IsUnique();
            builder.Property(s => s.Email).HasMaxLength(50);
            builder.Property(s => s.FirstName).HasMaxLength(50);
            builder.Property(s => s.LastName).HasMaxLength(50);
            builder.Property(s => s.Phone).HasMaxLength(11);
            builder.Property(s => s.AddressLine1).HasMaxLength(1000);
            builder.Property(s => s.City).HasMaxLength(100);
            builder.Property(s => s.Country).HasMaxLength(100);
            builder.Property(s => s.Province).HasMaxLength(100);
            builder.Property(s => s.CreatedBy).HasMaxLength(50);
        }
    }
}