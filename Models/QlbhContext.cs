using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Models;

public partial class QlbhContext : DbContext
{
    public QlbhContext()
    {
    }

    public QlbhContext(DbContextOptions<QlbhContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblCtdondh> TblCtdondhs { get; set; }

    public virtual DbSet<TblCtpnhap> TblCtpnhaps { get; set; }

    public virtual DbSet<TblCtpxuat> TblCtpxuats { get; set; }

    public virtual DbSet<TblDondh> TblDondhs { get; set; }

    public virtual DbSet<TblNhacc> TblNhaccs { get; set; }

    public virtual DbSet<TblPnhap> TblPnhaps { get; set; }

    public virtual DbSet<TblPxuat> TblPxuats { get; set; }

    public virtual DbSet<TblTonkho> TblTonkhos { get; set; }

    public virtual DbSet<TblVattu> TblVattus { get; set; }



    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        // => optionsBuilder.UseSqlServer("Server=DESKTOP-DQ8VDI6\\SQLEXPRESS;Database=QLBH;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblCtdondh>(entity =>
        {
            entity.HasKey(e => new { e.SoDh, e.MaVtu }).HasName("PK__tblCTDON__0F2181992198D099");

            entity.ToTable("tblCTDONDH");

            entity.Property(e => e.SoDh).HasColumnName("SoDH");
            entity.Property(e => e.MaVtu)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaVTu");
            entity.Property(e => e.Sldat).HasColumnName("SLDat");

            entity.HasOne(d => d.MaVtuNavigation).WithMany(p => p.TblCtdondhs)
                .HasForeignKey(d => d.MaVtu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblCTDOND__MaVTu__182C9B23");

            entity.HasOne(d => d.SoDhNavigation).WithMany(p => p.TblCtdondhs)
                .HasForeignKey(d => d.SoDh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblCTDONDH__SoDH__173876EA");
        });

        modelBuilder.Entity<TblCtpnhap>(entity =>
        {
            entity.HasKey(e => new { e.SoPn, e.MaVtu }).HasName("PK__tblCTPNH__0F20EF36BCC15E43");

            entity.ToTable("tblCTPNHAP");

            entity.Property(e => e.SoPn)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SoPN");
            entity.Property(e => e.MaVtu)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaVTu");

            entity.HasOne(d => d.MaVtuNavigation).WithMany(p => p.TblCtpnhaps)
                .HasForeignKey(d => d.MaVtu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblCTPNHA__MaVTu__1ED998B2");

            entity.HasOne(d => d.SoPnNavigation).WithMany(p => p.TblCtpnhaps)
                .HasForeignKey(d => d.SoPn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblCTPNHAP__SoPN__1DE57479");
        });

        modelBuilder.Entity<TblCtpxuat>(entity =>
        {
            entity.HasKey(e => new { e.SoPx, e.MaVtu }).HasName("PK__tblCTPXU__0F20EF008A7A530F");

            entity.ToTable("tblCTPXUAT");

            entity.Property(e => e.SoPx)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SoPX");
            entity.Property(e => e.MaVtu)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaVTu");
            entity.Property(e => e.Slxuat).HasColumnName("SLXuat");

            entity.HasOne(d => d.MaVtuNavigation).WithMany(p => p.TblCtpxuats)
                .HasForeignKey(d => d.MaVtu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblCTPXUA__SLXua__239E4DCF");

            entity.HasOne(d => d.SoPxNavigation).WithMany(p => p.TblCtpxuats)
                .HasForeignKey(d => d.SoPx)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblCTPXUAT__SoPX__24927208");
        });

        modelBuilder.Entity<TblDondh>(entity =>
        {
            entity.HasKey(e => e.SoDh).HasName("PK__tblDONDH__BC3D04DC679F189A");

            entity.ToTable("tblDONDH");

            entity.Property(e => e.SoDh)
                .ValueGeneratedNever()
                .HasColumnName("SoDH");
            entity.Property(e => e.Manhacc)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NgayDh)
                .HasColumnType("datetime")
                .HasColumnName("NgayDH");

            entity.HasOne(d => d.ManhaccNavigation).WithMany(p => p.TblDondhs)
                .HasForeignKey(d => d.Manhacc)
                .HasConstraintName("FK__tblDONDH__Manhac__145C0A3F");
        });

        modelBuilder.Entity<TblNhacc>(entity =>
        {
            entity.HasKey(e => e.Manhacc).HasName("PK__tblNHACC__4C23FBF059BE947A");

            entity.ToTable("tblNHACC");

            entity.Property(e => e.Manhacc)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Diachi).HasMaxLength(30);
            entity.Property(e => e.Dienthoai)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Tennhacc).HasMaxLength(30);
        });

        modelBuilder.Entity<TblPnhap>(entity =>
        {
            entity.HasKey(e => e.SoPn).HasName("PK__tblPNHAP__BC3C6A73E3FE43B9");

            entity.ToTable("tblPNHAP");

            entity.Property(e => e.SoPn)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SoPN");
            entity.Property(e => e.Ngaynhap).HasColumnType("datetime");
            entity.Property(e => e.SoDh).HasColumnName("SoDH");

            entity.HasOne(d => d.SoDhNavigation).WithMany(p => p.TblPnhaps)
                .HasForeignKey(d => d.SoDh)
                .HasConstraintName("FK__tblPNHAP__SoDH__1B0907CE");
        });

        modelBuilder.Entity<TblPxuat>(entity =>
        {
            entity.HasKey(e => e.SoPx).HasName("PK__tblPXUAT__BC3C6A454DB8917F");

            entity.ToTable("tblPXUAT");

            entity.Property(e => e.SoPx)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SoPX");
            entity.Property(e => e.Ngayxuat).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblTonkho>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblTONKHO");

            entity.Property(e => e.MaVtu)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaVTu");
            entity.Property(e => e.Namthang)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NAMTHANG");
            entity.Property(e => e.Sltonkho).HasColumnName("SLTonkho");
            entity.Property(e => e.Tongnhap).HasColumnName("TONGNHAP");
            entity.Property(e => e.Tongxuat).HasColumnName("TONGXUAT");

            entity.HasOne(d => d.MaVtuNavigation).WithMany()
                .HasForeignKey(d => d.MaVtu)
                .HasConstraintName("FK__tblTONKHO__MaVTu__267ABA7A");
        });

        modelBuilder.Entity<TblVattu>(entity =>
        {
            entity.HasKey(e => e.MaVtu).HasName("PK__tblVATTU__31C8545AC03BD941");

            entity.ToTable("tblVATTU");

            entity.Property(e => e.MaVtu)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaVTu");
            entity.Property(e => e.Dvtinh)
                .HasMaxLength(10)
                .HasColumnName("DVTinh");
            entity.Property(e => e.TenVtu).HasMaxLength(30);
        });

        OnModelCreatingPartial(modelBuilder);
        
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
