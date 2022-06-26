namespace QLCH
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [Key]
        public int MaNV { get; set; }

        [Required]
        [StringLength(50)]
        public string HoVaTenNV { get; set; }

        [Required]
        [StringLength(5)]
        public string GioiTinhNV { get; set; }

        public DateTime NgaySinhNV { get; set; }

        [Required]
        [StringLength(20)]
        public string ChucVuNV { get; set; }

        public DateTime NgayBatDauLamNV { get; set; }

        public double LuongNV { get; set; }

        [Required]
        [StringLength(10)]
        public string SĐTNV { get; set; }

        [Required]
        [StringLength(50)]
        public string EmailNV { get; set; }

        [Required]
        [StringLength(100)]
        public string QueQuanNV { get; set; }

        [StringLength(10)]
        public string Pass { get; set; }
    }
}
