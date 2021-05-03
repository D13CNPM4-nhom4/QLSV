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

namespace QLSV
{
    public partial class KetQuaDangKy : Form
    {
        public KetQuaDangKy()
        {
            InitializeComponent();
        }

        private void KetQuaDangKy_Load(object sender, EventArgs e)
        {
            Hienthi();
            txtmadk.Text = Masinh();
            getlop();
            txtmadk.Enabled = false;
            getlophp();
        }
        private void getlop()
        {
            String conn = @"Data Source=ADMIN-2N12AHLMA\SQLEXPRESS;Initial Catalog=QLSV4;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Lopp", con);
            SqlDataAdapter add = new SqlDataAdapter(cmd);
            DataSet lop = new DataSet();
            add.Fill(lop, "khoa");
            cbblop.DataSource = lop.Tables["khoa"];
            cbblop.DisplayMember = "Tenlop";
            cbblop.ValueMember = "Malop";
            con.Close();
        }
        private void getlophp()
        {
            String conn = @"Data Source=ADMIN-2N12AHLMA\SQLEXPRESS;Initial Catalog=QLSV4;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand("select MonHoc.TenMH,LopHocPhan.* from LopHocPhan,MonHoc where MonHoc.MaMH=LopHocPhan.MaMH", con);
            SqlDataAdapter add = new SqlDataAdapter(cmd);
            DataSet lop = new DataSet();
            add.Fill(lop, "khoa");
            cbbmonhoc.DataSource = lop.Tables["khoa"];
            cbbmonhoc.DisplayMember = "TenMH";
            cbbmonhoc.ValueMember = "MaMH";
            con.Close();
        }
        void Hienthi()
        {

            String conn = @"Data Source=ADMIN-2N12AHLMA\SQLEXPRESS;Initial Catalog=QLSV4;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from KetQuaDangKy", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        public string Masinh()
        {
            String conn = @"Data Source=ADMIN-2N12AHLMA\SQLEXPRESS;Initial Catalog=QLSV4;Integrated Security=True";
            string sql = @"select * from KetQuaDangKy";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conn;
            SqlDataAdapter ds = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ds.Fill(dt);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "KQ001";
            }
            else
            {
                int k;
                ma = "KQ";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(3));
                k = k + 1;
                if (k < 10)
                {
                    ma = ma + "00";
                }
                else if (k < 100)
                {
                    ma = ma + "0";
                }
                ma = ma + k.ToString();
            }
            return ma;

        }

        private void cbblop_SelectedIndexChanged(object sender, EventArgs e)
        {

            String conn = @"Data Source=ADMIN-2N12AHLMA\SQLEXPRESS;Initial Catalog=QLSV4;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand("select Lopp.*,SinhViennn.* from Lopp, SinhViennn where SinhViennn.Malop=Lopp.Malop and Lopp.Malop='" + cbblop.SelectedValue + "'", con);
            SqlDataAdapter add = new SqlDataAdapter(cmd);
            DataSet lop = new DataSet();
            add.Fill(lop, "lop");
            cbbmasv.DataSource = lop.Tables["lop"];
            cbbmasv.DisplayMember = "MaSV";
            cbbmasv.ValueMember = "MaSV";
            con.Close();
        }

        private void cbbmasv_SelectedIndexChanged(object sender, EventArgs e)
        {
            String conn = @"Data Source=ADMIN-2N12AHLMA\SQLEXPRESS;Initial Catalog=QLSV4;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand("select SinhViennn.* from SinhViennn where MaSV='" + cbbmasv.SelectedValue + "'", con);
            SqlDataAdapter add = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            add.Fill(dt);
            txthoten.Text = dt.Rows[0]["Hoten"].ToString();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String conn = @"Data Source=ADMIN-2N12AHLMA\SQLEXPRESS;Initial Catalog=QLSV4;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO KetQuaDangKy VALUES (@Madangky,@MaSV,@MalopHP,@MaMH)", con);
            cmd.Parameters.AddWithValue("Madangky", txtmadk.Text);
            cmd.Parameters.AddWithValue("MaSV", cbbmasv.SelectedValue);
            cmd.Parameters.AddWithValue("MalopHP", cbblophp.SelectedValue);
            cmd.Parameters.AddWithValue("MaMH", cbbmonhoc.SelectedValue);
            MessageBox.Show("Thêm thành công");
            cmd.ExecuteNonQuery();
            con.Close();
            Hienthi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KetQuaDangKy_Load(sender, e);
            txthoten.ResetText();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            String conn = @"Data Source=ADMIN-2N12AHLMA\SQLEXPRESS;Initial Catalog=QLSV4;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand("select LopHocPhan.* from LopHocPhan where LopHocPhan.MaMH='" + cbbmonhoc.SelectedValue + "'", con);
            SqlDataAdapter add = new SqlDataAdapter(cmd);
            DataSet lop = new DataSet();
            add.Fill(lop, "lop");
            cbblophp.DataSource = lop.Tables["lop"];
            cbblophp.DisplayMember = "TenlopHP";
            cbblophp.ValueMember = "MalopHP";
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMain form2 = new FrmMain();
            form2.Show();
            this.Hide();
        }
    }
}
