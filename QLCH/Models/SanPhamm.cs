using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLCH
{
    public partial class SanPhamm : DbContext
    {
        public SanPhamm()
            : base("name=SanPhamm2")
        {
        }
        private static SanPhamm _Instance;
        public static SanPhamm Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new SanPhamm();
                }
                return _Instance;

            }
            private set { }
        }
        public virtual DbSet<HangSanXuat> HangSanXuats { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HangSanXuat>()
                .Property(e => e.TenHSX)
                .IsUnicode(false);

            modelBuilder.Entity<HangSanXuat>()
                .Property(e => e.DiaChi)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.TenSP)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MoTa)
                .IsUnicode(false);
        }
    }
}
