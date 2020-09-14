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
    public partial class groupeF : Form
    {
        public groupeF()
        {
            InitializeComponent();
        }

        private void groupeF_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Группы". При необходимости она может быть перемещена или удалена.
         //   this.группыTableAdapter.Fill(this.dataDataSet.Группы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Группы". При необходимости она может быть перемещена или удалена.
            this.группыTableAdapter.Fill(this.dataDataSet.Группы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           группыBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            группыBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            группыBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.группыBindingSource.EndEdit();
            группыBindingSource.MoveLast();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            группыBindingSource.RemoveCurrent();
            this.Validate();
            this.группыBindingSource.EndEdit();
        }

        private void groupeF_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            this.группыBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.dataDataSet);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.группыBindingSource.EndEdit();
        }
    }
}
