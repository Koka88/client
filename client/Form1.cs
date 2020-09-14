using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace client
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection
          ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Data.mdb");
            OleDbDataAdapter da = new OleDbDataAdapter
                ("Select rol From Auth Where login='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                int role = Convert.ToInt32(dt.Rows[0][0]);
                Menu1 f = new Menu1(role);
               f.Show();
            }
        }

        private void Auth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1.PerformClick();
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = false;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;
        }
    }
}
