using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCH.DTO
{
   public class SanPhamView
    {
        public int MaSP { get; set; }

        public string TenSP { get; set; }

        public int? MaHSX { get; set; }

        public double? DonGia { get; set; }

        public string MoTa { get; set; }

      //  public string KichCo { get; set; }

        public int SoLuong { get; set; }

        public string HangSanXuat { get; set; }
    }
}
