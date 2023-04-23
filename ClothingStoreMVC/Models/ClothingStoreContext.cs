using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ClothingStoreMVC.Models
{
    public partial class ClothingStoreContext : DbContext
    {
        public ClothingStoreContext()
        {
        }

        public ClothingStoreContext(DbContextOptions<ClothingStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Checkout> Checkout { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Preview> Preview { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Wishlist> Wishlist { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=localhost;Database=ClothingStore;uid=sa;pwd=1234$;MultipleActiveResultSets=True;");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ImgBrand)
                    .HasColumnName("imgBrand")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdPro).HasColumnName("idPro");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.HasOne(d => d.IdProNavigation)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.IdPro)
                    .HasConstraintName("FK__Cart__idPro__20C1E124");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Checkout>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(100);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(100);

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.Idcart).HasColumnName("idcart");

                entity.Property(e => e.Payment)
                    .HasColumnName("payment")
                    .HasMaxLength(100);

                entity.Property(e => e.Shipcode)
                    .HasColumnName("shipcode")
                    .HasMaxLength(100);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(100);

                entity.Property(e => e.ZipCode)
                    .HasColumnName("zipCode")
                    .HasMaxLength(20);

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Checkout)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__Checkout__idUser__22AA2996");

                entity.HasOne(d => d.IdcartNavigation)
                    .WithMany(p => p.Checkout)
                    .HasForeignKey(d => d.Idcart)
                    .HasConstraintName("FK__Checkout__idcart__239E4DCF");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Message).HasColumnName("message");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Preview>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.Preview1).HasColumnName("preview");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Preview)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__Preview__idUser__24927208");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(50);

                entity.Property(e => e.IdCate).HasColumnName("idCate");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasMaxLength(50);

                entity.Property(e => e.Star).HasColumnName("star");

                entity.HasOne(d => d.IdCateNavigation)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.IdCate)
                    .HasConstraintName("FK__Product__idCate__1FCDBCEB");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(255);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.FirstName)
                    .HasColumnName("firstName")
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .HasColumnName("lastName")
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(255);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Wishlist>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdPro).HasColumnName("idPro");

                entity.HasOne(d => d.IdProNavigation)
                    .WithMany(p => p.Wishlist)
                    .HasForeignKey(d => d.IdPro)
                    .HasConstraintName("FK__Wishlist__idPro__21B6055D");
            });
        }
    }
}
