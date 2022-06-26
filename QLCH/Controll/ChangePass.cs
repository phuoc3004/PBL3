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


namespace QLCH.Controll
{
    public partial class ChangePass : Form
    {
        int nvien;
        SqlConnection conn = null;
        string stringConnect = @"Data Source=LAPTOP-OF4VVCUP;Initial Catalog=QLCHQA;Integrated Security=True";
        private string oldPass = "";

        public ChangePass(int id)
        {
            InitializeComponent();
            nvien = id;
            GetOldPass(nvien);
        }


        private void GetOldPass(int idNvien)
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
                        command.CommandText = "GetOldPass";
                        command.Connection = conn;
                        SqlParameter ma = new SqlParameter("@id", SqlDbType.Int);
                        ma.Value = idNvien;
                        command.Parameters.Add(ma);



                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {

                            oldPass = reader.GetString(0);

                        }
                        reader.Close();
                        command.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Chua co id 2");
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
        

        private void pHide1_Click(object sender, EventArgs e)
        {
            if(tbOld.PasswordChar == '*')
            {
                pShow1.BringToFront();
                tbOld.PasswordChar = '\0';
            }
        }

        private void pShow1_Click(object sender, EventArgs e)
        {
            if (tbOld.PasswordChar == '\0')
            {
                pHide1.BringToFront();
                tbOld.PasswordChar = '*';
            }
        }

        private void pShow2_Click(object sender, EventArgs e)
        {
            if (tbNew.PasswordChar == '\0')
            {
                pHide2.BringToFront();
                tbNew.PasswordChar = '*';
            }
        }

        private void pHide2_Click(object sender, EventArgs e)
        {
            if (tbNew.PasswordChar == '*')
            {
                pShow2.BringToFront();
                tbNew.PasswordChar = '\0';
            }
        }

        private void pShow3_Click(object sender, EventArgs e)
        {
            if (tbConfirm.PasswordChar == '\0')
            {
                pHide3.BringToFront();
                tbConfirm.PasswordChar = '*';
            }
        }

        private void pHide3_Click(object sender, EventArgs e)
        {
            if (tbConfirm.PasswordChar == '*')
            {
                pShow3.BringToFront();
                tbConfirm.PasswordChar = '\0';
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(tbOld.Text == oldPass)
            {
                if(tbNew.Text == tbConfirm.Text)
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
                                command.CommandText = "ChangePassword";
                                command.Connection = conn;
                                MessageBox.Show(nvien+"",tbNew.Text);
                                command.Parameters.Add("@id", SqlDbType.Int).Value = nvien;
                                command.Parameters.Add("@moi", SqlDbType.VarChar).Value = tbNew.Text;

                                int res = command.ExecuteNonQuery();
                                if(res > 1)
                                {
                                    MessageBox.Show("Doi mat khau thanh cong");
                                    conn.Close();
                                    command.Dispose();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Doi mat khau khong thanh cong");
                                    conn.Close();
                                    command.Dispose();
                                }
                                
                                

                            }
                            else
                            {
                                MessageBox.Show("Chua co id");
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
                    MessageBox.Show("Mat khau khong trung nhau");
                }
                
            }
            else{
                MessageBox.Show("Sai mai khau cu");
            }
            
        }
    }
}
