using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BussinessObject;

public partial class HacoloCinemaContext : DbContext
{
    public HacoloCinemaContext()
    {
    }

    public HacoloCinemaContext(DbContextOptions<HacoloCinemaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Wallet> Wallets { get; set; }

    public virtual DbSet<WalletTransaction> WalletTransactions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server =(local); database =HacoloCinema;uid=sa;pwd=sa123456;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64D8AD81A857");

            entity.Property(e => e.CustomerId).ValueGeneratedNever();
            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Wallet>(entity =>
        {
            entity.HasKey(e => e.WalletId).HasName("PK__Wallet__84D4F90EB2DE6A1A");

            entity.ToTable("Wallet");

            entity.HasIndex(e => e.CustomerId, "UQ__Wallet__A4AE64D937DEE310").IsUnique();

            entity.Property(e => e.WalletId).ValueGeneratedNever();
            entity.Property(e => e.WalletBalance).HasColumnType("decimal(10, 0)");

            entity.HasOne(d => d.Customer).WithOne(p => p.Wallet)
                .HasForeignKey<Wallet>(d => d.CustomerId)
                .HasConstraintName("FK__Wallet__Customer__3A81B327");
        });

        modelBuilder.Entity<WalletTransaction>(entity =>
        {
            entity.HasKey(e => e.WalletTransactionId).HasName("PK__WalletTr__7184AEEFC856E55B");

            entity.Property(e => e.WalletTransactionId).ValueGeneratedNever();
            entity.Property(e => e.TransactionAmount).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");

            entity.HasOne(d => d.Wallet).WithMany(p => p.WalletTransactions)
                .HasForeignKey(d => d.WalletId)
                .HasConstraintName("FK__WalletTra__Walle__3D5E1FD2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
