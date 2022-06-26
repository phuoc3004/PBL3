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

namespace QLCH.Controller
{
    public partial class BillController : UserControl
    {

        SqlConnection conn = null;
        string stringConnect = @"Data Source=LAPTOP-OF4VVCUP;Initial Catalog=QLCHQA;Integrated Security=True";
        int MaCTHDXSelected = 0;
        int MaHDSelected = 0;
        public BillController()
        {
            InitializeComponent();
            HienThiToanBoHoaDon();
            HienThiToanBoTenNhanVien();
            HienThiToanBoTenKhachHang();
            HienThiToanBoTenSanPham();
            btnThemSP.Enabled = false;
            btnXoaSP.Enabled = false;
        }

        //Hiển thị toàn bộ mã hoá đơn xuất
        private void HienThiToanBoHoaDon()
        {
            if (conn == null)
                conn = new SqlConnection(stringConnect);
            if(conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "LayToanBoHoaDonXuat";
                    command.Connection = conn;


                    SqlDataReader reader = command.ExecuteReader();
                    cbMaHoaDon.Items.Clear();
                    while (reader.Read())
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = reader.GetInt32(0).ToString();
                        item.Value = reader.GetInt32(0);

                        cbMaHoaDon.Items.Add(item);
                    }
                    reader.Close();
                    command.Dispose();
                }
                    
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }


        }

        //Hiển thị toàn bộ tên sản phẩm ra combobox tên sản phẩm
        private void HienThiToanBoTenSanPham()
        {
            if (conn == null)
                conn = new SqlConnection(stringConnect);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "LayToanBoTenSanPham";
                    command.Connection = conn;


                    SqlDataReader reader = command.ExecuteReader();
                    cbTenSanPham.Items.Clear();
                    while (reader.Read())
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = reader.GetString(1);
                        item.Value = reader.GetInt32(0);

                        cbTenSanPham.Items.Add(item);
                    }
                    reader.Close();
                    command.Dispose();
                }
                    
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }


        }

        //Hiển thị toàn bộ tên nhân viên
        private void HienThiToanBoTenNhanVien()
        {
            if (conn == null)
                conn = new SqlConnection(stringConnect);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "HienThiToanBoTenNhanVien";
                    command.Connection = conn;


                    SqlDataReader reader = command.ExecuteReader();
                    cbTenNhanVien.Items.Clear();
                    
                    while (reader.Read())
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = reader.GetString(1);
                        item.Value = reader.GetInt32(0);

                        cbTenNhanVien.Items.Add(item);
                    }
                    reader.Close();
                    command.Dispose();
                    
                }
                    
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }


        }

        //Hiển thị toàn bộ tên khách hàng
        private void HienThiToanBoTenKhachHang()
        {
            if (conn == null)
                conn = new SqlConnection(stringConnect);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "HienThiToanBoTenKhachHang";
                    command.Connection = conn;


                    SqlDataReader reader = command.ExecuteReader();
                    cbTenKhachHang.Items.Clear();
                    while (reader.Read())
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = reader.GetString(1);
                        item.Value = reader.GetInt32(0);

                        cbTenKhachHang.Items.Add(item);
                    }
                    reader.Close();
                    command.Dispose();
                }
                    
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }


        }

        //Hiển thị chi tiết hoá đơn xuất đã selected
        private void HienThiChiTietHoaDonDaChon(int ma)
        {
            if (conn == null)
                conn = new SqlConnection(stringConnect);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "HienThiChiTietHoaDonDaChon";
                    command.Connection = conn;

                    SqlParameter parMaHDX = new SqlParameter("@maHDX", SqlDbType.Int);
                    parMaHDX.Value = ma;
                    command.Parameters.Add(parMaHDX);



                    SqlDataReader reader = command.ExecuteReader();
                    lvHoaDon.Items.Clear();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ListViewItem lvi = new ListViewItem(reader.GetInt32(0) + "");
                            lvi.SubItems.Add(reader.GetInt32(1) + "");
                            lvi.SubItems.Add(reader.GetInt32(2) + "");
                            lvi.SubItems.Add(reader.GetString(3));
                            lvi.SubItems.Add(reader.GetDouble(4) + "");
                            lvi.SubItems.Add(reader.GetInt32(5) + "");
                            lvi.SubItems.Add(reader.GetDouble(6) + "");
                            lvHoaDon.Items.Add(lvi);

                        }
                        
                    }
                    reader.Close();
                    command.Dispose();
                    

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }


        }

        //tính tổng tiền của hoá đơn
        private void TongTienHoaDon(int ma)
        {
            if (conn == null)
                conn = new SqlConnection(stringConnect);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "TongTienHoaDon";
                    command.Connection = conn;

                    SqlParameter parMaHDX = new SqlParameter("@maHD", SqlDbType.Int);
                    parMaHDX.Value = ma;
                    command.Parameters.Add(parMaHDX);



                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        tbTongTien.Text = reader.GetDouble(0) + "";
                    }
                    reader.Close();
                    command.Dispose();
                }
                    
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                conn.Close();
            }


        }

        //Clear data 
        private void ClearData()
        {
            tbMaSanPham.Text = "";
            tbSoLuongCon.Text = "";
            cbTenSanPham.Text = "";
            tbDonGia.Text = "";
            tbHangSanXuat.Text = "";
            tbSoLuongMua.Text = "";
            tbThanhTien.Text = "";
        }

        //Hiển thị chi tiết sản phẩm
        private void HienThiChiTietSanPham(int ma)
        {
            if (conn == null)
                conn = new SqlConnection(stringConnect);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "HienThiChiTietSanPham";
                    command.Connection = conn;

                    SqlParameter parMaHDX = new SqlParameter("@maSP", SqlDbType.Int);
                    parMaHDX.Value = ma;
                    command.Parameters.Add(parMaHDX);



                    SqlDataReader reader = command.ExecuteReader();
                    ClearData();

                    if (reader.Read())
                    {
                        tbMaSanPham.Text = reader.GetInt32(0) + "";
                        cbTenSanPham.Text = reader.GetString(1);
                        tbHangSanXuat.Text = reader.GetString(2);
                        tbSoLuongCon.Text = reader.GetInt32(3) + "";
                        tbDonGia.Text = reader.GetDouble(4) + "";

                    }
                    reader.Close();
                    command.Dispose();
                }
                
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }


        }

        //Hiển thị chi tiết khách hàng
        private void HienThiChiTietKhachHang(int ma)
        {
            if (conn == null)
                conn = new SqlConnection(stringConnect);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "HienThiChiTietKhachHang";
                    command.Connection = conn;

                    SqlParameter parMaHDX = new SqlParameter("@maKH", SqlDbType.Int);
                    parMaHDX.Value = ma;
                    command.Parameters.Add(parMaHDX);



                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        tbMaKhachHang.Text = reader.GetInt32(0) + "";
                        cbTenKhachHang.Text = reader.GetString(1);
                        tbDiaChi.Text = reader.GetString(2);
                        tbSoDienThoai.Text = reader.GetString(3);

                    }
                    reader.Close();
                    command.Dispose();
                }
                    
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }


        }

        //Hiển thị chi tiết Nhân viên
        private void HienThiChiTietNhanVien(int ma)
        {
            if (conn == null)
                conn = new SqlConnection(stringConnect);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "HienThiChiTietNhanVien";
                    command.Connection = conn;

                    SqlParameter parMaHDX = new SqlParameter("@maNV", SqlDbType.Int);
                    parMaHDX.Value = ma;
                    command.Parameters.Add(parMaHDX);



                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        tbMaNhanVien.Text = reader.GetInt32(0) + "";
                        cbTenNhanVien.Text = reader.GetString(1);

                    }
                    reader.Close();
                    command.Dispose();
                }
                   
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }


        }

        //Hiển thị thông tin cơ bản hoá đơn lên top
        private void HienThiChiThongTinCoBanHoaDon(int ma)
        {
            if (conn == null)
                conn = new SqlConnection(stringConnect);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "HienThiChiThongTinCoBanHoaDon";
                    command.Connection = conn;

                    SqlParameter parMaHDX = new SqlParameter("@maHD", SqlDbType.Int);
                    parMaHDX.Value = ma;
                    command.Parameters.Add(parMaHDX);



                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        tbMaHoaDon.Text = reader.GetInt32(0) + "";
                        dtNgayLap.Value = reader.GetDateTime(1);
                        tbMaNhanVien.Text = reader.GetInt32(2) + "";
                        cbTenNhanVien.Text = reader.GetString(3);
                        tbMaKhachHang.Text = reader.GetInt32(4) + "";
                        cbTenKhachHang.Text = reader.GetString(5);
                        tbDiaChi.Text = reader.GetString(6);
                        tbSoDienThoai.Text = reader.GetString(7);

                    }
                    reader.Close();
                    command.Dispose();
                    
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //btn Tìm kiếm click
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(cbMaHoaDon.Text != "")
            {
                int temp = int.Parse((cbMaHoaDon.SelectedItem as ComboboxItem).Value.ToString());
                MaHDSelected = temp;
                HienThiChiTietHoaDonDaChon(temp);
                HienThiChiThongTinCoBanHoaDon(temp);
                btnThemSP.Enabled = true;
                btnXoaSP.Enabled = true;
                TongTienHoaDon(temp);
                cbMaHoaDon.Text = "";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hoá đơn muốn tìm!!!");
            }
            
        }

        //update chi tiết hoá đơn
        private void UpdateChiTietHoaDon(int ma,int maHD)
        {
            if (conn == null)
                conn = new SqlConnection(stringConnect);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                int quantity = int.Parse(tbSoLuongMua.Text);
                float price = float.Parse(tbDonGia.Text);
                int origi = int.Parse(tbSoLuongCon.Text);
                if(tbMaSanPham.Text != "")
                {
                    if (origi >= quantity)
                    {
                        float sum = quantity * price;
                        try
                        {
                            using (SqlCommand command = new SqlCommand())
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.CommandText = "UpdateChiTietHoaDon";
                                command.Connection = conn;

                                command.Parameters.Add("@maCT", SqlDbType.Int).Value = ma;
                                command.Parameters.Add("@maSP", SqlDbType.Int).Value = tbMaSanPham.Text;

                                command.Parameters.Add("@donGia", SqlDbType.Float).Value = tbDonGia.Text;
                                command.Parameters.Add("@soLuong", SqlDbType.Int).Value = tbSoLuongMua.Text;
                                command.Parameters.Add("@thanhTien", SqlDbType.Float).Value = sum;



                                SqlDataReader reader = command.ExecuteReader();
                                ClearData();
                                if (reader.Read())
                                {
                                    tbMaSanPham.Text = reader.GetInt32(0) + "";
                                    cbTenSanPham.Text = reader.GetString(1);
                                    tbHangSanXuat.Text = reader.GetString(2);
                                    tbSoLuongCon.Text = reader.GetInt32(3) + "";
                                    tbDonGia.Text = reader.GetDouble(4) + "";

                                }
                                reader.Close();
                                ClearData();
                                MaCTHDXSelected = 0;
                                HienThiChiTietHoaDonDaChon(maHD);
                                MessageBox.Show("Update chi tiết hoá đơn thành công.");
                                command.Dispose();
                                
                            }

                        }
                        catch(Exception ex)
                        {

                        }
                        finally
                        {
                            conn.Close();
                        }
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("Số lượng sản phẩm không đủ. Vui lòng kiểm tra lại!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra dữ liệu nhập vào!!!");
                }
                
                
            }
            catch (Exception ex)
            {
            }
        }

        //tạo mới hoá đơn
        private void TaoMoiHoaDon()
        {
            if (conn == null)
                conn = new SqlConnection(stringConnect);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                
                if (tbMaNhanVien.Text != "" && tbMaKhachHang.Text != "")
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "TaoMoiHoaDon";
                        command.Connection = conn;

                        command.Parameters.Add("@maNV", SqlDbType.Int).Value = tbMaNhanVien.Text;
                        command.Parameters.Add("@maKH", SqlDbType.Int).Value = tbMaKhachHang.Text;
                        command.Parameters.Add("@ngayLap", SqlDbType.Date).Value = dtNgayLap.Value.ToString("yyyy-MM-dd");


                        int ret = command.ExecuteNonQuery();
                        if (ret > 0)
                        {
                            CleanDataTop();
                            ClearData();
                            HienThiToanBoHoaDon();
                            MessageBox.Show("Đã tạo mới hoá đơn thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Tạo mới hoá đơn thất bại");
                        }
                        MaCTHDXSelected = 0;
                        command.Dispose();
                    }
                       
                    

                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra dữ liệu nhập vào!!!");
                }


            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
        }

        private void lvHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHoaDon.SelectedItems.Count == 0) return;
            ListViewItem lvi = lvHoaDon.SelectedItems[0];
            int maSP = int.Parse(lvi.SubItems[2].Text);
            HienThiChiTietSanPham(maSP);
            tbSoLuongMua.Text = lvi.SubItems[5].Text;
            tbThanhTien.Text = lvi.SubItems[6].Text;
            MaCTHDXSelected = int.Parse(lvi.SubItems[0].Text);
            MaHDSelected = int.Parse(lvi.SubItems[1].Text);
            btnXoaSP.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(Check == 1)
            {
                TaoMoiHoaDon();
                Check = 0;
            }
            else if(Check == 0)
            {
                if (MaCTHDXSelected != 0)
                {
                    if (MaHDSelected != 0)
                    {
                        UpdateChiTietHoaDon(MaCTHDXSelected, MaHDSelected);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn hoá đơn muốn sửa");
                }
            }
            
        }

        private void XoaSanPhamKhoiCTHD(int maCT)
        {
            if (conn == null)
                conn = new SqlConnection(stringConnect);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "XoaSanPhamKhoiCTHD";
                        command.Connection = conn;

                        command.Parameters.Add("@maCTHD", SqlDbType.Int).Value = maCT;


                        int ret = command.ExecuteNonQuery();
                        if (ret > 0)
                        {
                            HienThiToanBoHoaDon();
                            MessageBox.Show("Đã xoá sản phẩm thành công.");
                            for (int i = 0; i < lvHoaDon.Items.Count; i++)
                            {
                                if (lvHoaDon.Items[i].Selected)
                                {
                                    lvHoaDon.Items[i].Remove();
                                    i--;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Xoá sản phẩm thất bại");
                        }
                        MaCTHDXSelected = 0;
                        command.Dispose();
                    }
                        


                }
                catch (Exception ex)
                {
                }
                finally
                {
                    conn.Close();
                }
            }
            
        }

        private void ThemSanPhamVaoCTHD(int maHD)
        {
            if (conn == null)
                conn = new SqlConnection(stringConnect);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            if (MessageBox.Show("Bạn có muốn thêm sản phẩm vào hoá đơn không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if(tbMaSanPham.Text != "")
                {
                    try
                    {

                        int quantity = int.Parse(tbSoLuongMua.Text);
                        int origi = int.Parse(tbSoLuongCon.Text);
                        float price = float.Parse(tbDonGia.Text);
                        float sum = quantity * price;
                        if (origi >= quantity)
                        {
                            using (SqlCommand command = new SqlCommand())
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.CommandText = "ThemSanPhamVaoCTHD";
                                command.Connection = conn;

                                command.Parameters.Add("@maHD", SqlDbType.Int).Value = maHD;
                                command.Parameters.Add("@maSP", SqlDbType.Int).Value = tbMaSanPham.Text;
                                command.Parameters.Add("@donGia", SqlDbType.Float).Value = tbDonGia.Text;
                                command.Parameters.Add("@soLuong", SqlDbType.Int).Value = tbSoLuongMua.Text;
                                command.Parameters.Add("@thanhTien", SqlDbType.Float).Value = sum;


                                int ret = command.ExecuteNonQuery();
                                if (ret > 0)
                                {
                                    HienThiToanBoHoaDon();
                                    HienThiChiTietHoaDonDaChon(MaHDSelected);
                                    MessageBox.Show("Đã thêm sản phẩm thành công.");
                                }
                                else
                                {
                                    MessageBox.Show("Thêm sản phẩm thất bại");
                                }
                                MaCTHDXSelected = 0;
                                command.Dispose();
                            }
                                
                            
                        }
                        else
                        {
                            MessageBox.Show("Số lượng không đủ vui lòng kiểm tra lại số lượng.");
                        }




                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                
            }

        }

        //xoá hoá đơn
        private void XoaHoaDon(int maCT)
        {
            if (conn == null)
                conn = new SqlConnection(stringConnect);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            if (MessageBox.Show("Bạn có muốn xóa hoá đơn không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "XoaHoaDon";
                        command.Connection = conn;

                        command.Parameters.Add("@maHD", SqlDbType.Int).Value = maCT;


                        int ret = command.ExecuteNonQuery();
                        if (ret > 0)
                        {
                            HienThiToanBoHoaDon();
                            MessageBox.Show("Đã xoá hoá đơn thành công.");

                        }
                        else
                        {
                            MessageBox.Show("Xoá hoá đơn thất bại");
                        }
                        MaCTHDXSelected = 0;
                        MaHDSelected = 0;
                        command.Dispose();
                    }
                        


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui lòng xoá sản phẩm ra khỏi hoá đơn trước khi xoá hoá đơn!!!");
                }
                finally
                {
                    conn.Close();
                }
            }

        }

        private void cbTenSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maSPSelected = int.Parse((cbTenSanPham.SelectedItem as ComboboxItem).Value.ToString());
            HienThiChiTietSanPham(maSPSelected);
            
        }

        private void cbTenKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tenKHSelected = int.Parse((cbTenKhachHang.SelectedItem as ComboboxItem).Value.ToString());
            HienThiChiTietKhachHang(tenKHSelected);
        }

        private void cbTenNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tenNVSelected = int.Parse((cbTenNhanVien.SelectedItem as ComboboxItem).Value.ToString());
            HienThiChiTietNhanVien(tenNVSelected);
        }
        int Check = 0;

        private void CleanDataTop()
        {
            tbMaHoaDon.Text = "";
            tbMaNhanVien.Text = "";
            cbTenNhanVien.Text = "";
            tbMaKhachHang.Text = "";
            cbTenNhanVien.Text = "";
            tbDiaChi.Text = "";
            tbSoDienThoai.Text = "";
        }
        private void btnTao_Click(object sender, EventArgs e)
        {
            CleanDataTop();
            ClearData();
            Check = 1;
            btnIn.Enabled = false;
            btnXoa.Enabled = false;
            btnTao.Enabled = false;
            btnThemSP.Enabled = false;
            btnXoaSP.Enabled = false;
        }


        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if(tbMaSanPham.Text != "")
            {
                if(MaCTHDXSelected != 0)
                {
                    XoaSanPhamKhoiCTHD(MaCTHDXSelected);
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn hoá đơn!!!");
                }

            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm cần xoá!!!");
            }
            
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (tbMaSanPham.Text != "")
            {
                if (MaHDSelected != 0)
                {
                    ThemSanPhamVaoCTHD(MaHDSelected);
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn hoá đơn!!!");
                }

            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm cần thêm!!!");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MaHDSelected == 0)
            {
                MessageBox.Show("Vui lòng chọn hoá đơn muốn xoá!!!");
            }
            else{
                XoaHoaDon(MaHDSelected);
                cbMaHoaDon.Text = "";
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if(MaHDSelected != 0)
            {
                MessageBox.Show("Tiến hành in hóa đơn!");
                try
                {
                    
                    InHoaDon inHD =  new InHoaDon(MaHDSelected);
                    inHD.ShowDialog();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hoá đơn cần in!!!");
            }
            
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            CleanDataTop();
            ClearData();
            tbTongTien.Text = "";
            btnTao.Enabled = true;
            btnXoa.Enabled = true;
            btnIn.Enabled = true;
            btnThemSP.Enabled = false;
            btnXoaSP.Enabled = false;
        }
    }
}
