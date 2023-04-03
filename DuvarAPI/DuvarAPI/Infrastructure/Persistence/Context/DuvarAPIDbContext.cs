using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class DuvarAPIDbContext:DbContext
    {
        public DuvarAPIDbContext(DbContextOptions options) : base(options)
        { }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.HasDefaultSchema("dbo");
        //    modelBuilder.Entity<User>(entity =>
        //    {
        //        entity.ToTable("users");
        //        entity.Property(prop => prop.ID).HasColumnName("ID").HasColumnType("int").UseIdentityColumn().IsRequired();
        //        entity.Property(prop => prop.Name).HasColumnName("Name").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
        //        entity.Property(prop => prop.Email).HasColumnName("Email").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
        //        entity.Property(prop => prop.Password).HasColumnName("Password").HasColumnType("nvarchar").IsRequired();
        //        entity.Property(prop => prop.CreatedDate).HasColumnName("CreatedDate");
        //        entity.HasMany(prop => prop.Entries).WithOne(i => i.User).HasForeignKey(i => i.User_Id).HasConstraintName("user_entry_id_fk");
        //    });
        //    modelBuilder.Entity<Entry>(entity =>
        //    {
        //        entity.ToTable("entries");
        //        entity.Property(prop => prop.ID).HasColumnName("ID").HasColumnType("int").UseIdentityColumn().IsRequired();
        //        entity.Property(prop => prop.Title).HasColumnName("Title").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
        //        entity.Property(prop => prop.Description).HasColumnName("Description").HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
        //        entity.Property(prop => prop.Vote).HasColumnName("Vote").HasColumnType("bigint").HasDefaultValue(0);
        //        entity.Property(prop => prop.CreatedDate).HasColumnName("CreatedDate");
        //        entity.HasMany(prop => prop.).WithOne(i => i.User).HasForeignKey(i => i.User_Id).HasConstraintName("user_entry_id_fk");
        //    });

        //}

        public DbSet<User> Users { get; set; }
        public DbSet<Entry> Entries { get; set; }
    }
}
