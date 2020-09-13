using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CatalogService.Models
{
    public partial class catalogContext : DbContext
    {
        public catalogContext()
        {
        }

        public catalogContext(DbContextOptions<catalogContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CatalogBrands> CatalogBrands { get; set; }
        public virtual DbSet<CatalogItems> CatalogItems { get; set; }
        public virtual DbSet<CatalogTypes> CatalogTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatalogBrands>(entity =>
            {
                entity.ToTable("catalog_brands");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasColumnName("brand")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CatalogItems>(entity =>
            {
                entity.ToTable("catalog_items");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BrandId).HasColumnName("brand_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PictureFilename)
                    .HasColumnName("picture_filename")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.CatalogItems)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_catalog_items_catalog_brands");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.CatalogItems)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_catalog_items_catalog_types");
            });

            modelBuilder.Entity<CatalogTypes>(entity =>
            {
                entity.ToTable("catalog_types");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
