using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient
namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "数据库名称:";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入要连接的数据库名称");
            }
            else
            {
                try
                {
                string ConStr="server=.;datebase="+textBox1.Text.Trim()+";uid=sa;pwd=";
                SqlConnection conn =new SqlConnection(ConStr);
                conn.Open();
                if(conn.State==ConnectionState.Open)
                {
                    label2.Text="数据库【"+textBox1.Text.Trim()+"】已经连接并打开";
                }
                }
            catch{
                MessageBox.Show("数据库连接失败");
            }

            }

        }
    }
}
