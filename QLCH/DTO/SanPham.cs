namespace QLCH
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]
        public int MaSP { get; set; }

        [Required]
        [StringLength(50)]
        public string TenSP { get; set; }

        public int? MaHSX { get; set; }

        public double? DonGia { get; set; }

        [StringLength(200)]
        public string MoTa { get; set; }

        public int? SoLuong { get; set; }

        public virtual HangSanXuat HangSanXuat { get; set; }
    }
}
