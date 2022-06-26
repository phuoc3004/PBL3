using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLCH
{
    public partial class KhachHangg : DbContext
    {
        public KhachHangg()
            : base("name=KhachHangg1")
        {
        }

        public virtual DbSet<KhachHang> KhachHangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KhachHang>()
                .Property(e => e.HoVaTenKH)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.GioiTinhKH)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SĐTKH)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.DiaChi)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.EmailKH)
                .IsUnicode(false);
        }
    }
}
