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
    public partial class NhanVienPageManager : UserControl
    {
        int check = 0;
        //check = 1 them moi nhan vien 
        //check = 2 sua nhan vien
        public NhanVienPageManager()
        {
            InitializeComponent();
            ShowDTG();
            cbChucVu.Items.Add("Manager");
            cbChucVu.Items.Add("Saler");
            cbChucVu.Items.Add("");
            cbGT.Items.Add("Nam");
            cbGT.Items.Add("Nu");
            cbGT.Items.Add("");
            tbMaNV.Enabled = false;

        }



        private void ShowDTG()
        {
            dataGridView1.DataSource = NhanVienController.Instance.GetDSNV();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (row != null)
            {
                tbMaNV.Text = row.Cells["MaNV"].Value.ToString();
                tbTenNV.Text = row.Cells["HoVaTenNV"].Value.ToString();
                cbGT.Text = row.Cells["GioiTinhNV"].Value.ToString();
                cbChucVu.Text = row.Cells["ChucVuNV"].Value.ToString();
                tbLuong.Text = row.Cells["LuongNV"].Value.ToString();
                tbEmail.Text = row.Cells["EmailNV"].Value.ToString();
                tbSDT.Text = row.Cells["SĐTNV"].Value.ToString();
                tbQueQuan.Text = row.Cells["QueQuanNV"].Value.ToString();
                dtNS.Value = DateTime.Parse(row.Cells["NgaySinhNV"].Value.ToString()).Date;
                dtBD.Value = DateTime.Parse(row.Cells["NgayBatDauLamNV"].Value.ToString()).Date;
            }
        }

        private void CheckData()
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbMaNV.Text = "";
            tbTenNV.Text = "";
            tbSDT.Text = "";
            tbQueQuan.Text = "";
            tbLuong.Text = "";
            tbEmail.Text = "";
            cbChucVu.Text = "";
            cbGT.Text = "";
            lbNotifi.Text = "Nhập thông tin nhân viên bấm lưu để thêm mới nhân viên.";
            check = 1;

            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(check == 1)
            {
                if (tbTenNV.Text != "" && tbEmail.Text != "" && tbLuong.Text != "" && tbQueQuan.Text != "" && tbSDT.Text != "" && cbChucVu.Text != "" && cbGT.Text != "")
                {
                    try
                    {
                        string tenNV = tbTenNV.Text;
                        string gioitinh = cbGT.Text;
                        DateTime ngaysinh = dtNS.Value.Date;
                        string chucVu = cbChucVu.Text;
                        DateTime NgayBD = dtBD.Value.Date;
                        float luong = float.Parse(tbLuong.Text);
                        string SDT = tbSDT.Text;
                        string email = tbEmail.Text;
                        string quequan = tbQueQuan.Text;
                        NhanVien nv = new NhanVien
                        {
                            HoVaTenNV = tenNV,
                            GioiTinhNV = gioitinh,
                            NgaySinhNV = ngaysinh,
                            ChucVuNV = chucVu,
                            NgayBatDauLamNV = NgayBD,
                            LuongNV = luong,
                            SĐTNV = SDT,
                            EmailNV = email,
                            QueQuanNV = quequan,
                        };
                        NhanVienController.Instance.Add_NhanVien(nv);
                        ShowDTG();
                        MessageBox.Show("Thanh Cong");


                    }
                    catch (Exception res)
                    {
                        MessageBox.Show(res.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                }
                
                check = 0;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnAdd.Enabled = true;
                lbNotifi.Text = "";
            }
            else if(check == 2)
            {
                int maNV = int.Parse(tbMaNV.Text);
                string tenNV = tbTenNV.Text;
                string gioitinh = cbGT.Text;
                DateTime ngaysinh = dtNS.Value.Date;
                string chucVu = cbChucVu.Text;
                DateTime NgayBD = dtBD.Value.Date;
                float luong = float.Parse(tbLuong.Text);
                string SDT = tbSDT.Text;
                string email = tbEmail.Text;
                string quequan = tbQueQuan.Text;
                try
                {
                    if (dataGridView1.SelectedRows.Count == 1)
                    {
                        NhanVien nv = new NhanVien
                        {
                            MaNV = maNV,
                            HoVaTenNV = tenNV,
                            GioiTinhNV = gioitinh,
                            NgaySinhNV = ngaysinh,
                            ChucVuNV = chucVu,
                            NgayBatDauLamNV = NgayBD,
                            LuongNV = luong,
                            SĐTNV = SDT,
                            EmailNV = email,
                            QueQuanNV = quequan,
                        };
                        NhanVienController.Instance.Update_NV(nv);
                        ShowDTG();
                        MessageBox.Show("Thanh Cong");
                    }
                }
                catch (Exception res)
                {
                    MessageBox.Show(res.Message);
                }
                check = 0;
                btnDelete.Enabled = true;
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                lbNotifi.Text = "";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        {
                            int MaNV = int.Parse(row.Cells["MaNV"].Value.ToString());
                            NhanVienController.Instance.Del_NV(MaNV);
                        }
                        ShowDTG();
                        MessageBox.Show("Xoa Thanh Cong");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Khong Thanh Cong");
                    }
                }
                   
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn xoá");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            check = 2;
            lbNotifi.Text = "Nhập thông tin nhân viên cần sửa rồi bấm lưu để lưu thông tin.";
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
            btnAdd.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            lbNotifi.Text = "";
        }
    }
}
