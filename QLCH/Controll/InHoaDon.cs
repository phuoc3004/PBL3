using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace QLCH.Controller
{
    public partial class InHoaDon : Form
    {
        SqlConnection conn = null;
        string stringConnect = @"Data Source=LAPTOP-OF4VVCUP;Initial Catalog=QLCHQA;Integrated Security=True";
        int maHD;
        public InHoaDon()
        {
            
        }

        public InHoaDon(int ma)
        {
            InitializeComponent();
            maHD = ma;
        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {
            if(conn == null)
            {
                conn = new SqlConnection(stringConnect);
            }
            string sql = @"select hd.MaHDX,ct.MaCTHD,nv.HoVaTenNV,kh.HoVaTenKH,hd.NgayLap,sp.TenSP,ct.DonGia,ct.SoLuongMua,ct.ThanhTien from HoaDonXuat hd inner join ChiTietHoaDon ct on hd.MaHDX = ct.MaHDX inner join SanPham sp on ct.MaSP = sp.MaSP inner join NhanVien nv on hd.MaNV = nv.MaNV inner join KhachHang kh on hd.MaKH = kh.MaKH where hd.MaHDX = " + maHD + ";";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds,"HoaDon");

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLCH.ReportHoaDon.rdlc";

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables["HoaDon"];

            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
