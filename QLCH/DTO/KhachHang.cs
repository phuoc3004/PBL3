namespace QLCH
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [Key]
        public int MaKH { get; set; }

        [Required]
        [StringLength(50)]
        public string HoVaTenKH { get; set; }

        [Required]
        [StringLength(5)]
        public string GioiTinhKH { get; set; }

        public DateTime NgaySinhKH { get; set; }

        [Required]
        [StringLength(10)]
        public string SĐTKH { get; set; }

        [Required]
        [StringLength(100)]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(50)]
        public string EmailKH { get; set; }
    }
}
