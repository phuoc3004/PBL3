using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH.Controll
{
    public partial class ProfilePageControll : UserControl
    {
        int nvien;
        SqlConnection conn = null;
        string stringConnect = @"Data Source=LAPTOP-OF4VVCUP;Initial Catalog = QLCHQA; Integrated Security = True";

        //save old data
        string username = "";
        DateTime birthday, dayStart;
        string homeTown = "";
        string sex = "";
        string phone = "";
        string email = "";


        public ProfilePageControll(int id)
        {
            InitializeComponent();
            nvien = id;
            cbGT.Items.Add("Nam");
            cbGT.Items.Add("Nữ");
            cbChucVu.Items.Add("Manager");
            cbChucVu.Items.Add("Saler");
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(nvien != 0)
            {
                ChangePass change = new ChangePass(nvien);
                change.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chua co id 1");
            }
            
        }

        private void tbMaNV_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void ProfilePageControll_Load(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(stringConnect);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    if(nvien != 0)
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "Profile";
                        command.Connection = conn;
                        SqlParameter ma = new SqlParameter("@id", SqlDbType.Int);
                        ma.Value = nvien;
                        command.Parameters.Add(ma);



                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            tbMaNV.Text = reader.GetInt32(0).ToString();
                            tbTenNV.Text = reader.GetString(1);
                            cbGT.Text = reader.GetString(2);
                            dtNS.Value = DateTime.Parse(reader.GetDateTime(3).ToString()).Date;
                            cbChucVu.Text = reader.GetString(4);
                            dtNBD.Value = DateTime.Parse(reader.GetDateTime(5).ToString()).Date;
                            tbLuong.Text = reader.GetDouble(6).ToString();
                            tbSDT.Text = reader.GetString(7);
                            tbEmail.Text = reader.GetString(8);
                            tbQueQuan.Text = reader.GetString(9);

                            username = reader.GetString(1);
                            homeTown = reader.GetString(9);
                            sex = reader.GetString(2);
                            phone = reader.GetString(7);
                            email = reader.GetString(8);



                        }
                        reader.Close();
                        command.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Chua co id");
                    }
                    
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
        private bool checkChanged()
        {
            if (tbTenNV.Text != username)
            {
                return true;
            }
            else if(tbQueQuan.Text != homeTown)
            {
                return true;
            }
            else if(cbGT.Text != sex)
            {
                return true;
            }
            else if(tbSDT.Text != phone)
            {
                return true;
            }
            else if(tbEmail.Text != email)
            {
                return true;
            }


            return false;
        }
        private void tbQuaQuan_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkChanged())
            {
                if (conn == null)
                    conn = new SqlConnection(stringConnect);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        if (nvien != 0)
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.CommandText = "UpdateProfile";
                            command.Connection = conn;
                            command.Parameters.Add("@id", SqlDbType.Int).Value = nvien;
                            command.Parameters.Add("@name", SqlDbType.VarChar).Value = tbTenNV.Text;
                            command.Parameters.Add("@sex", SqlDbType.VarChar).Value = cbGT.Text;
                            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = tbSDT.Text;
                            command.Parameters.Add("@email", SqlDbType.VarChar).Value = tbEmail.Text;
                            command.Parameters.Add("@homeTown", SqlDbType.VarChar).Value = tbQueQuan.Text;
                            int res = command.ExecuteNonQuery();
                            if (res > 0)
                            {
                                MessageBox.Show("Thay doi thong tin thanh cong");
                            }
                            else
                            {
                                MessageBox.Show("Thay doi thong tin khong thanh cong");
                            }

                            conn.Close();
                            command.Dispose();
                            
                        }

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
            else
            {
                MessageBox.Show("Chua thay doi");
            }
        }
    }
}
