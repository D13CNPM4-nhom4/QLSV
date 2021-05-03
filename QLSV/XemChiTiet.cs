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
using System.IO;

namespace QLSV
{
    public partial class XemChiTiet : Form
    {
        public XemChiTiet()
        {
            InitializeComponent();
        }
        
        private void XemChiTiet_Load(object sender, EventArgs e)
        {
            Hienthi();
        }
        void Hienthi()
        {

            String conn = @"Data Source=ADMIN-2N12AHLMA\SQLEXPRESS;Initial Catalog=QLSV4;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from SinhViennn", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
          
            con.Close();
        }

        Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String conn = @"Data Source=ADMIN-2N12AHLMA\SQLEXPRESS;Initial Catalog=QLSV1;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            int numrow;
            numrow = e.RowIndex;
            int r = dataGridView1.CurrentCell.RowIndex;
            byte[] b = (byte[])dataGridView1.Rows[r].Cells["Anhhoso"].Value;
            pictureBox1.Image = ByteArrayToImage(b);
            lbmsv.Text = dataGridView1.Rows[numrow].Cells["MaSV"].Value.ToString();
            lbtensv.Text = dataGridView1.Rows[numrow].Cells["Hoten"].Value.ToString();
            lbngaysinh.Text = dataGridView1.Rows[numrow].Cells["Ngaysinh"].Value.ToString();
               lbgioitinh.Text = dataGridView1.Rows[numrow].Cells["Gioitinh"].Value.ToString();
               lbdantoc.Text = dataGridView1.Rows[numrow].Cells["Dantoc"].Value.ToString();
               lbsdt.Text = dataGridView1.Rows[numrow].Cells["SDT"].Value.ToString();
               lbkhoa.Text = dataGridView1.Rows[numrow].Cells["Makhoa"].Value.ToString();
               lblop.Text = dataGridView1.Rows[numrow].Cells["Malop"].Value.ToString();
               lbcmnd.Text = dataGridView1.Rows[numrow].Cells["CMND"].Value.ToString();
               lbhedaotao.Text = dataGridView1.Rows[numrow].Cells["Hedaotao"].Value.ToString();
               lbtenbo.Text = dataGridView1.Rows[numrow].Cells["Hotenbo"].Value.ToString();
               lbtenme.Text = dataGridView1.Rows[numrow].Cells["Hotenme"].Value.ToString();
               lbtentinh.Text = dataGridView1.Rows[numrow].Cells["Tentinh"].Value.ToString();
               lbtinhtrang.Text = dataGridView1.Rows[numrow].Cells["Tinhtrang"].Value.ToString();
               lbnamnhaphoc.Text = dataGridView1.Rows[numrow].Cells["NamNhapHoc"].Value.ToString();
            lbemail.Text = dataGridView1.Rows[numrow].Cells["Email"].Value.ToString();
           // SqlDataAdapter dt = new SqlDataAdapter("select Anhhoso from SinhVien where Anhhoso = '" + dataGridView1.Rows[numrow].Cells[2].Value.ToString() + "'", conn);
            //DataSet ds = new DataSet("image"); //tạo một "image" có 2 trường 
           // byte[] mydata = new byte[0];   //khai báo một mảng mydata có kiểu byte
            //dt.Fill(ds, "image");  // đổ dữ liệu vào table image
            //dataRow row;
            //row = ds.Tables["image"].Rows[numrow];
          //  mydata = (byte[])row["Ảnh hồ sơ"]; //mydata lưu từng byte ảnh trong image
         //   MemoryStream memo = new MemoryStream(mydata);
           // pictureBox1.Image = Image.FromStream(memo); // gán các byte của 1anh cho picturebox*/
          
           /* byte[] imgdata = (byte[])dataGridView1.Rows[numrow].Cells[2].Value;
             MemoryStream ms = new MemoryStream(imgdata);
             pictureBox1.Image = Image.FromStream(ms);*/
            
     
        }
        public void loadimage()
        {/*
            String conn = @"Data Source=ADMIN-2N12AHLMA\SQLEXPRESS;Initial Catalog=QLSV1;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            DataTable source = (DataTable)dataGridView1.DataSource;
            DataRow row = source.Rows[dataGridView1.CurrentRow.Index];

            DataSet ds = new DataSet("hinh");
            byte[] MyData = new byte[0];
            // dp.Fill(ds, "hinh");
           
         
            MemoryStream stream = new MemoryStream(MyData);
            pictureBox1.Image = Image.FromStream(stream);
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMain form1 = new FrmMain();
            form1.Show();
            this.Hide();
        }
    }
}
