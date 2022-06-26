using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH.Controller
{
    public partial class KhachHangPageManager : UserControl
    {
        int check = 0;
        //check = 1 them khach hang moi
        // check = 2 = sua thogn tin khach hang
        public KhachHangPageManager()
        {
            InitializeComponent();
            show();
        }

        public void show()
        {
            dataGridView1.DataSource = KhachHangController.Instance.GetDSKH();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            noti.Text = "Vui lòng nhập đủ thông tin và bấm lưu để thêm khách hàng mới";
            check = 1;
            btnDel.Enabled = false;
            btnEdit.Enabled = false;

            tbMaKH.Text = "";
            tbTenKH.Text = "";
            cbGT.Text = "";
            tbSDT.Text = "";
            tbEmail.Text = "";
            tbDiaChi.Text = "";
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            noti.Text = "Nhập thông tin cần sửa và bấm lưu để lưu thông tin khách hàng";
            check = 2;
            btnDel.Enabled = false;
            btnAdd.Enabled = false;
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            



        }

        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (row != null)
            {
                tbMaKH.Text = row.Cells["MaKH"].Value.ToString();
                tbTenKH.Text = row.Cells["HoVaTenKH"].Value.ToString();
                cbGT.Text = row.Cells["GioiTinhKH"].Value.ToString();
                tbEmail.Text = row.Cells["EmailKH"].Value.ToString();
                tbSDT.Text = row.Cells["SĐTKH"].Value.ToString();
                tbDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                dtNS.Value = DateTime.Parse(row.Cells["NgaySinhKH"].Value.ToString()).Date;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                {
                    
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        int MaKH = int.Parse(row.Cells["MaKH"].Value.ToString());
                        KhachHangController.Instance.Del_KhachHang(MaKH);
                    }
                    show();
                    MessageBox.Show("Xoa Thanh Cong");
                }
                catch (Exception)
                {
                    MessageBox.Show("Khong Thanh Cong");
                }
                }
                    
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(check == 1)
            {
                try
                {
                    string tenKH = tbTenKH.Text;
                    string gioitinh = cbGT.Text;
                    DateTime ngaysinh = dtNS.Value.Date;
                    string SDT = tbSDT.Text;
                    string email = tbEmail.Text;
                    string diachi = tbDiaChi.Text;
                    KhachHang kh = new KhachHang
                    {
                        HoVaTenKH = tenKH,
                        GioiTinhKH = gioitinh,
                        NgaySinhKH = ngaysinh,
                        SĐTKH = SDT,
                        EmailKH = email,
                        DiaChi = diachi,
                    };
                    KhachHangController.Instance.Add_KhachHang(kh);
                    show();
                    MessageBox.Show("Thêm khách hàng thành công");
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm khách hàng không thành công");
                }
                btnDel.Enabled = true;
                btnEdit.Enabled = true;
                noti.Text = "";
            }
            else if(check == 2)
            {
                int maKH = int.Parse(tbMaKH.Text);
                string tenKH = tbTenKH.Text;
                string gioitinh = cbGT.Text;
                DateTime ngaysinh = dtNS.Value.Date;
                string SDT = tbSDT.Text;
                string email = tbEmail.Text;
                string diachi = tbDiaChi.Text;
                try
                {
                    if (dataGridView1.SelectedRows.Count == 1)
                    {
                        KhachHang kh = new KhachHang
                        {
                            MaKH = maKH,
                            HoVaTenKH = tenKH,
                            GioiTinhKH = gioitinh,
                            NgaySinhKH = ngaysinh,
                            SĐTKH = SDT,
                            EmailKH = email,
                            DiaChi = diachi,
                        };
                        KhachHangController.Instance.Update_KhachHang(kh);
                        show();
                        MessageBox.Show("Thanh Cong");

                    }
                }
                catch (Exception res)
                {
                    MessageBox.Show(res.Message);
                }
                btnDel.Enabled = true;
                btnAdd.Enabled = true;
                noti.Text = "";
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnDel.Enabled = true;
            btnEdit.Enabled = true;
            btnAdd.Enabled=true;
            noti.Text = "";
        }
    }
}
