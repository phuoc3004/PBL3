using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLCH
{
    public partial class NhanVienn : DbContext
    {
        public NhanVienn()
            : base("name=NhanVienn")
        {
        }

        public virtual DbSet<NhanVien> NhanViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NhanVien>()
                .Property(e => e.HoVaTenNV)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.GioiTinhNV)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.ChucVuNV)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SĐTNV)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.EmailNV)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.QueQuanNV)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Pass)
                .IsUnicode(false);
        }
    }
}
