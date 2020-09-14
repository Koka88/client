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
    public partial class rucovodF : Form
    {
        public rucovodF()
        {
            InitializeComponent();
        }

        private void rucovodF_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Руководители". При необходимости она может быть перемещена или удалена.
          //  this.руководителиTableAdapter.Fill(this.dataDataSet.Руководители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Руководители". При необходимости она может быть перемещена или удалена.
        //    this.руководителиTableAdapter.Fill(this.dataDataSet.Руководители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Руководители". При необходимости она может быть перемещена или удалена.
            this.руководителиTableAdapter.Fill(this.dataDataSet.Руководители);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            руководителиBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            руководителиBindingSource.MoveNext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            руководителиBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.руководителиBindingSource.EndEdit();
            руководителиBindingSource.MoveLast();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            руководителиBindingSource.RemoveCurrent();
            this.Validate();
            this.руководителиBindingSource.EndEdit();
        }

        private void rucovodF_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            this.руководителиBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.dataDataSet);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.руководителиBindingSource.EndEdit();
        }
    }
}
