using QLCH.Controll;
using QLCH.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            btnTrangChu.Checked = true;
            HomePageManager home = new HomePageManager();
            panelContainerAD.Controls.Add(home);
            btnTrangChu.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
      

        private void sidebar_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            this.Close();
            login.ShowDialog();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            panelContainerAD.Controls.Clear();
            HomePageManager home = new HomePageManager();
            panelContainerAD.Controls.Add(home);
            btnNhanVien.Checked = false;
            btnDoanhThu.Checked = false;
            btnHoTro.Checked = false;
            btnSanPham.Checked = false;
            btnThoat.Checked = false;
            btnTrangChu.Checked = true;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            panelContainerAD.Controls.Clear();
            NhanVienPageManager profile = new NhanVienPageManager();
            panelContainerAD.Controls.Add(profile);
            btnNhanVien.Checked = true;
            btnDoanhThu.Checked = false;
            btnHoTro.Checked = false;
            btnSanPham.Checked = false;
            btnThoat.Checked = false;
            btnTrangChu.Checked = false;
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            panelContainerAD.Controls.Clear();
            SanPhamPageManager sanPham = new SanPhamPageManager();
            panelContainerAD.Controls.Add(sanPham);
            btnNhanVien.Checked = false;
            btnDoanhThu.Checked = false;
            btnHoTro.Checked = false;
            btnSanPham.Checked = true;
            btnThoat.Checked = false;
            btnTrangChu.Checked = false;
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            panelContainerAD.Controls.Clear();
            DoanhThuControll doanhThu = new DoanhThuControll();
            panelContainerAD.Controls.Add(doanhThu);
            btnNhanVien.Checked = false;
            btnDoanhThu.Checked = true;
            btnHoTro.Checked = false;
            btnSanPham.Checked = false;
            btnThoat.Checked = false;
            btnTrangChu.Checked = false;
        }

        private void btnHoTro_Click(object sender, EventArgs e)
        {
            panelContainerAD.Controls.Clear();
            HoTroControll sp = new HoTroControll();
            panelContainerAD.Controls.Add(sp);
            btnNhanVien.Checked = false;
            btnDoanhThu.Checked = false;
            btnHoTro.Checked = true;
            btnSanPham.Checked = false;
            btnThoat.Checked = false;
            btnTrangChu.Checked = false;
        }
    }
}
