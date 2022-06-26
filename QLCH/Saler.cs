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
using System.Data.SqlClient;
using QLCH.Controll;

namespace QLCH
{
    public partial class Saler : Form
    {
        int nvien;
        public Saler(int id)
        {
            nvien = id;
            InitializeComponent();
            HomePageSaler home = new HomePageSaler();
            panelContainerSL.Controls.Add(home);
        }

        

       

        private void btnBill_Click(object sender, EventArgs e)
        {
            
            panelContainerSL.Controls.Clear();
            BillController billController = new BillController();

            panelContainerSL.Controls.Add(billController);
            btnTrangChu.Checked = false;
            btnBill.Checked = true;
            btnHoTro.Checked = false;
            btnSanPham.Checked = false;
            btnThoat.Checked = false;
            btnKhachHang.Checked = false;
            btnEditProfile.Checked = false;

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            panelContainerSL.Controls.Clear();
            HomePageSaler homePage = new HomePageSaler();
            panelContainerSL.Controls.Add(homePage);
            btnTrangChu.Checked = true;
            btnBill.Checked = false;
            btnHoTro.Checked = false;
            btnSanPham.Checked = false;
            btnThoat.Checked = false;
            btnEditProfile.Checked = false;
            btnKhachHang.Checked = false;
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            panelContainerSL.Controls.Clear();
            SanPhamPageManager productPage = new SanPhamPageManager();
            panelContainerSL.Controls.Add(productPage);
            btnTrangChu.Checked = false;
            btnBill.Checked = false;
            btnHoTro.Checked = false;
            btnSanPham.Checked = true;
            btnThoat.Checked = false;
            btnKhachHang.Checked = false;
            btnEditProfile.Checked = false;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            panelContainerSL.Controls.Clear();
            KhachHangPageManager khPage = new KhachHangPageManager();
            panelContainerSL.Controls.Add(khPage);
            btnTrangChu.Checked = false;
            btnBill.Checked = false;
            btnHoTro.Checked = false;
            btnKhachHang.Checked = true;
            btnSanPham.Checked = false;
            btnThoat.Checked = false;
            btnEditProfile.Checked = false;
        }

        private void btnHoTro_Click(object sender, EventArgs e)
        {
            panelContainerSL.Controls.Clear();
            HoTroControll hoTroPage = new HoTroControll();
            panelContainerSL.Controls.Add(hoTroPage);
            btnTrangChu.Checked = false;
            btnBill.Checked = false;
            btnHoTro.Checked = true;
            btnKhachHang.Checked = false;
            btnSanPham.Checked = false;
            btnThoat.Checked = false;
            btnEditProfile.Checked = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            this.Close();
            login.ShowDialog();

        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            panelContainerSL.Controls.Clear();
            ProfilePageControll profile = new ProfilePageControll(nvien);
            panelContainerSL.Controls.Add(profile);
            btnTrangChu.Checked = false;
            btnBill.Checked = false;
            btnHoTro.Checked = false;
            btnKhachHang.Checked = false;
            btnSanPham.Checked = false;
            btnThoat.Checked = false;
            btnEditProfile.Checked = true;
        }
    }
}
