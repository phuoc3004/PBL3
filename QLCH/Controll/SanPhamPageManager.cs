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
    public partial class SanPhamPageManager : UserControl
    {
        int check = 0;
        //check =1  them moi san pham
        //check = 2 sua thong tin san pham 
        public SanPhamPageManager()
        {
            InitializeComponent();
            ShowDTG();
            SetCBB();
            tbMaSP.Enabled = false;
        }
        public void SetCBB()
        {
            foreach (ComboboxItem i in Controller.QLSanPhamController.Instance.GetCBB())
            {
                cbHang.Items.Add(i);
            }
           
            
        }
        public void ShowDTG()
        {
            try
            {
                dataGridView1.DataSource = Controller.QLSanPhamController.Instance.GetAllSP();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        // btn add click
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = false;

            tbMaSP.Text = "";
            tbTenSP.Text = "";
            tbSoLuong.Text = "";
            tbMoTa.Text = "";
            tbGiaBan.Text = "";            
            cbHang.Text = "";
           // cbSize.Text = "";
            check = 1;
            noti.Text = "Điền thông tin sản phẩm mới và nhấn lưu để thêm mới sản phẩm";

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = false;
            check = 2;
            noti.Text = "Điền thông tin sản phẩm và nhấn lưu để thay đổi thông tin sản phầm";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbMaSP.Text == "")
            {
                // thêm mới sản phẩm
                SanPham sp = new SanPham();
                sp.TenSP = tbTenSP.Text;
                sp.MaHSX = (int)((ComboboxItem)cbHang.SelectedItem).Value;
                sp.DonGia = Convert.ToDouble(tbGiaBan.Text);
                sp.MoTa = tbMoTa.Text;
               // sp.KichCo = cbSize.Text;               
                sp.SoLuong = Convert.ToInt32(tbSoLuong.Text);
                Controller.QLSanPhamController.Instance.AddSP(sp);
                ShowDTG();
                noti.Text = "";
            }
            else if (check == 2)
            {
                // sửa sản phẩm
                try
                {
                    if (dataGridView1.SelectedRows.Count == 1)
                    {
                        SanPham sp = new SanPham();
                        sp.MaSP = Convert.ToInt32(tbMaSP.Text);
                        sp.TenSP = tbTenSP.Text;
                        sp.MaHSX = (int)((ComboboxItem)cbHang.SelectedItem).Value;
                        sp.DonGia = Convert.ToDouble(tbGiaBan.Text);
                        sp.MoTa = tbMoTa.Text;
                      //  sp.KichCo = cbSize.Text;
                        sp.SoLuong = Convert.ToInt32(tbSoLuong.Text);
                        Controller.QLSanPhamController.Instance.UpdateSP(sp);
                        MessageBox.Show("Cập nhật thành công!");
                        ShowDTG();
                        btnDelete.Enabled = true;
                        btnEdit.Enabled = true;
                        btnAdd.Enabled = true;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnAdd.Enabled = true;
            noti.Text = "";
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (row != null)
            {
                tbMaSP.Text = row.Cells["MaSP"].Value.ToString();
                tbTenSP.Text = row.Cells["TenSP"].Value.ToString();
                cbHang.Text = row.Cells["HangSanXuat"].Value.ToString();
                tbGiaBan.Text = row.Cells["DonGia"].Value.ToString();
                tbSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
              //  cbSize.Text = row.Cells["KichCo"].Value.ToString();
                tbMoTa.Text = row.Cells["MoTa"].Value.ToString();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {

                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {

                        string Ten = row.Cells["TenSP"].Value.ToString();
                        if (MessageBox.Show("Bạn có muốn xóa sản phẩm " + Ten + " không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            string mssv = row.Cells["MaSP"].Value.ToString();
                            Controller.QLSanPhamController.Instance.Del_SP(mssv);
                            ShowDTG();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm muốn xoá.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text != "")
            {


                try
                {
                    string text = tbSearch.Text;
                    dataGridView1.DataSource = Controller.QLSanPhamController.Instance.Search_SP(text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

