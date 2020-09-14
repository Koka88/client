using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class authcF : Form
    {
        public authcF()
        {
            InitializeComponent();
        }

        private void authcF_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Auth". При необходимости она может быть перемещена или удалена.
         //   this.authTableAdapter.Fill(this.dataDataSet.Auth);
         //   // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Auth". При необходимости она может быть перемещена или удалена.
         //   this.authTableAdapter.Fill(this.dataDataSet.Auth);
         //   // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Auth". При необходимости она может быть перемещена или удалена.
         // //  this.authTableAdapter.Fill(this.dataDataSet.Auth);
         //   // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Auth". При необходимости она может быть перемещена или удалена.
         ////   this.authTableAdapter.Fill(this.dataDataSet.Auth);
         //   // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Auth". При необходимости она может быть перемещена или удалена.
         //   this.authTableAdapter.Fill(this.dataDataSet.Auth);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Auth". При необходимости она может быть перемещена или удалена.
            this.authTableAdapter.Fill(this.dataDataSet.Auth);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.authBindingSource.EndEdit();
            authBindingSource.MoveLast();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            authBindingSource.RemoveCurrent();
            this.Validate();
            this.authBindingSource.EndEdit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            authBindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            authBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            authBindingSource.MoveNext();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.authBindingSource.EndEdit();
        }

        private void authcF_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            this.authBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.dataDataSet);
        }
    }
}
