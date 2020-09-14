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
    public partial class nazgroupeF : Form
    {
        public nazgroupeF()
        {
            InitializeComponent();
        }

        private void nazgroupeF_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Группы". При необходимости она может быть перемещена или удалена.
            this.группыTableAdapter.Fill(this.dataDataSet.Группы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Туристы". При необходимости она может быть перемещена или удалена.
            this.туристыTableAdapter.Fill(this.dataDataSet.Туристы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Назначение_в_группы". При необходимости она может быть перемещена или удалена.
            //  this.назначение_в_группыTableAdapter.Fill(this.dataDataSet.Назначение_в_группы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Группы". При необходимости она может быть перемещена или удалена.
            // this.группыTableAdapter.Fill(this.dataDataSet.Группы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Туристы". При необходимости она может быть перемещена или удалена.
            // this.туристыTableAdapter.Fill(this.dataDataSet.Туристы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Назначение_в_группы". При необходимости она может быть перемещена или удалена.
            this.назначение_в_группыTableAdapter.Fill(this.dataDataSet.Назначение_в_группы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            назначениеВГруппыBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            назначениеВГруппыBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            назначениеВГруппыBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.назначениеВГруппыBindingSource.EndEdit();
            назначениеВГруппыBindingSource.MoveLast();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            назначениеВГруппыBindingSource.RemoveCurrent();
            this.Validate();
            this.назначениеВГруппыBindingSource.EndEdit();
        }

        private void nazgroupeF_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            this.назначениеВГруппыBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.dataDataSet);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.назначениеВГруппыBindingSource.EndEdit();
        }
    }
}
