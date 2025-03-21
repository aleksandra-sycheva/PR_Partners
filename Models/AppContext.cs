using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PR4_Patners.Models;

public partial class AppContext : DbContext
{
    public AppContext()
    {
    }

    public AppContext(DbContextOptions<AppContext> options)
        : base(options)
    {
    }

    public virtual DbSet<HistoriOfSupplier> HistoriOfSuppliers { get; set; }

    public virtual DbSet<HistoryOfProduct> HistoryOfProducts { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<Partner> Partners { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<TypesOfMaterial> TypesOfMaterials { get; set; }

    public virtual DbSet<TypesOfPartner> TypesOfPartners { get; set; }

    public virtual DbSet<TypesOfProduct> TypesOfProducts { get; set; }

    public virtual DbSet<TypesOfSupplier> TypesOfSuppliers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Db_exam;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HistoriOfSupplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_histori_of_suppliers");

            entity.ToTable("histori_of_suppliers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CostPerPackage).HasColumnName("cost_per_package");
            entity.Property(e => e.CountInPackage).HasColumnName("count_in_package");
            entity.Property(e => e.CountPackage).HasColumnName("count_package");
            entity.Property(e => e.DateDelivery).HasColumnName("date_delivery");
            entity.Property(e => e.IdMaterials).HasColumnName("id_materials");
            entity.Property(e => e.IdSuppliers).HasColumnName("id_suppliers");
            entity.Property(e => e.QualityDelivery).HasColumnName("quality_ delivery");

            entity.HasOne(d => d.IdMaterialsNavigation).WithMany(p => p.HistoriOfSuppliers)
                .HasForeignKey(d => d.IdMaterials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_histori_of_suppliers_materials");

            entity.HasOne(d => d.IdSuppliersNavigation).WithMany(p => p.HistoriOfSuppliers)
                .HasForeignKey(d => d.IdSuppliers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_histori_of_suppliers_suppliers");
        });

        modelBuilder.Entity<HistoryOfProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Partners_Products_pkey");

            entity.ToTable("history_of_products");

            entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"Partners_Products_Id_seq\"'::regclass)");

            entity.HasOne(d => d.Partner).WithMany(p => p.HistoryOfProducts)
                .HasForeignKey(d => d.IdPartner)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Partners_Products_IdPartner_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.HistoryOfProducts)
                .HasForeignKey(d => d.IdProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Partners_Products_IdProduct_fkey");
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_materials");

            entity.ToTable("materials");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('\"Materials_id_seq\"'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IdTypeOfMaterials).HasColumnName("id_type_of_materials");
            entity.Property(e => e.Image).HasColumnName("image");
            entity.Property(e => e.Name).HasColumnName("name");

            entity.HasOne(d => d.IdTypeOfMaterialsNavigation).WithMany(p => p.Materials)
                .HasForeignKey(d => d.IdTypeOfMaterials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_materials_type_of_materials");
        });

        modelBuilder.Entity<Partner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Pertners_pkey");

            entity.ToTable("partners");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('\"Pertners_id_seq\"'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Email).HasMaxLength(30);
            entity.Property(e => e.FiooftheDirector)
                .HasMaxLength(100)
                .HasColumnName("FIOOftheDirector");
            entity.Property(e => e.IdTypeOfPerther).HasColumnName("idTypeOfPerther");
            entity.Property(e => e.Inn)
                .HasMaxLength(12)
                .HasColumnName("INN");
            entity.Property(e => e.LegalAdress).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(30);
            entity.Property(e => e.Phone).HasMaxLength(15);

            entity.HasOne(d => d.IdTypeOfPertherNavigation).WithMany(p => p.Partners)
                .HasForeignKey(d => d.IdTypeOfPerther)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Pertners_idTypeOfPerther_fkey");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Products_pkey");

            entity.ToTable("products");

            entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"Products_Id_seq\"'::regclass)");
            entity.Property(e => e.Article).HasMaxLength(10);
            entity.Property(e => e.MinimumCost).HasColumnType("money");
            entity.Property(e => e.Name).HasMaxLength(70);

            entity.HasOne(d => d.IdTypeOfProductNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdTypeOfProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Products_IdTypeOfProduct_fkey");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_Suppliers");

            entity.ToTable(" suppliers");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('\" Suppliers_id_seq\"'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.AvgQualityOfSuppliers)
                .HasDefaultValue((short)0)
                .HasColumnName("avg_quality_of_suppliers");
            entity.Property(e => e.IdTypeOfSuppliers).HasColumnName("id_typeOfSuppliers");
            entity.Property(e => e.Inn).HasColumnName("inn");
            entity.Property(e => e.Name).HasColumnName("name");

            entity.HasOne(d => d.IdTypeOfSuppliersNavigation).WithMany(p => p.Suppliers)
                .HasForeignKey(d => d.IdTypeOfSuppliers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Suppliers_TypesOfSuppliers");
        });

        modelBuilder.Entity<TypesOfMaterial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TypesOfMaterial_pkey");

            entity.ToTable("types_of_materials");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('\"TypesOfMaterial_id_seq\"'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.TypeOfMaterial).HasColumnName("TypeOfMAterial");
        });

        modelBuilder.Entity<TypesOfPartner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TypeOfPartners_pkey");

            entity.ToTable("types_of_partners");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('\"TypeOfPartners_id_seq\"'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.TypeOfPartner).HasMaxLength(15);
        });

        modelBuilder.Entity<TypesOfProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TypeOfProducts_pkey");

            entity.ToTable("types_of_products");

            entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"TypeOfProducts_Id_seq\"'::regclass)");
            entity.Property(e => e.TypeOfProduct).HasMaxLength(20);
        });

        modelBuilder.Entity<TypesOfSupplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TypesOf Suppliers_pkey");

            entity.ToTable("types_of_suppliers");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('\"TypesOf Suppliers_id_seq\"'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.TypeOfSupplier).HasColumnName("TypeOf Supplier");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
