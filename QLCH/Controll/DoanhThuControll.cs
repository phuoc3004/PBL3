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
    public partial class DoanhThuControll : UserControl
    {
        SqlConnection conn = null;
        string stringConnect = @"Data Source=LAPTOP-OF4VVCUP;Initial Catalog=QLCHQA;Integrated Security=True";
        public DoanhThuControll()
        {
            InitializeComponent();
            HienThiBieuDo();

        }
        public void HienThiBieuDo()
        {
            try
            {
                if (conn == null)
                    conn = new SqlConnection(stringConnect);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                DataTable dt = new DataTable();
                string query = "";
                query = "select MaHDX,TongTien from HoaDonXuat; " ;
                
                

                MessageBox.Show(query);
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);

                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Tổng doanh thu";
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Thời gian";

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    chart1.Series["DoanhThu"].Points.AddXY(dt.Rows[i]["MaHDX"], dt.Rows[i]["TongTien"]);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
