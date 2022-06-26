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

namespace QLCH
{
    public partial class Login : Form
    {
        int id = 0;
        SqlConnection conn = null;
        string stringConnect = @"Data Source=LAPTOP-OF4VVCUP;Initial Catalog=QLCHQA;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
            cbPostion.Items.Add("Manager");
            cbPostion.Items.Add("Saler");
        }

        public void Check()
        {
            if(tbPasss.Text != "" && tbEmail.Text != "" && cbPostion.Text != "")
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
                        command.CommandText = "Loginn";
                        command.Connection = conn;

                        command.Parameters.Add("@email", SqlDbType.Text).Value = tbEmail.Text;
                        command.Parameters.Add("@passs", SqlDbType.Text).Value = tbPasss.Text;
                        command.Parameters.Add("@position", SqlDbType.Text).Value = cbPostion.Text;


                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            id = reader.GetInt32(0);
                            reader.Close();
                            command.Dispose();
                            conn.Close();
                            MessageBox.Show("Login Successfully");
                            if(cbPostion.Text == "Manager")
                            {
                                Form2 manager = new Form2();
                                this.Hide();
                                manager.ShowDialog();

                            }
                            if (cbPostion.Text == "Saler")
                            {
                                Saler saler = new Saler(id);
                                this.Hide();
                                saler.ShowDialog();

                            }
                        }
                        else
                        {
                            MessageBox.Show("Email hoặc mật khẩu không đúng. Vui lòng kiểm tra lại.");
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
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
            }
            


                   
        }

        private void pHide1_Click(object sender, EventArgs e)
        {
            
        }

        private void pShow1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbEmail.Text = "";
            tbPasss.Text = "";
            cbPostion.Text = "";
        }

        private void pShow1_Click_1(object sender, EventArgs e)
        {
            if (tbPasss.PasswordChar == '\0')
            {
                pHide1.BringToFront();
                tbPasss.PasswordChar = '*';
            }
        }

        private void pHide1_Click_1(object sender, EventArgs e)
        {
            if (tbPasss.PasswordChar == '*')
            {
                pShow1.BringToFront();
                tbPasss.PasswordChar = '\0';
            }
        }
    }
}
