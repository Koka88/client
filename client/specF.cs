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
    public partial class specF : Form
    {
        public specF()
        {
            InitializeComponent();
        }

        private void specF_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Специализация". При необходимости она может быть перемещена или удалена.
            this.специализацияTableAdapter.Fill(this.dataDataSet.Специализация);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Специализация". При необходимости она может быть перемещена или удалена.
            this.специализацияTableAdapter.Fill(this.dataDataSet.Специализация);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            специализацияBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            специализацияBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            специализацияBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.специализацияBindingSource.EndEdit();
            специализацияBindingSource.MoveLast();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            специализацияBindingSource.RemoveCurrent();
            this.Validate();
            this.специализацияBindingSource.EndEdit();
        }

        private void specF_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            this.специализацияBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.dataDataSet);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.специализацияBindingSource.EndEdit();
        }
    }
}
