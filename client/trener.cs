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
    public partial class trener : Form
    {
        public trener()
        {
            InitializeComponent();
        }

        private void trener_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Специализация". При необходимости она может быть перемещена или удалена.
            this.специализацияTableAdapter.Fill(this.dataDataSet.Специализация);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Тренера". При необходимости она может быть перемещена или удалена.
            this.тренераTableAdapter.Fill(this.dataDataSet.Тренера);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Специализация". При необходимости она может быть перемещена или удалена.
            this.специализацияTableAdapter.Fill(this.dataDataSet.Специализация);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Тренера". При необходимости она может быть перемещена или удалена.
            this.тренераTableAdapter.Fill(this.dataDataSet.Тренера);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Руководители". При необходимости она может быть перемещена или удалена.
           // this.руководителиTableAdapter.Fill(this.dataDataSet.Руководители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Нагрузка_тренеров". При необходимости она может быть перемещена или удалена.
           // this.нагрузка_тренеровTableAdapter.Fill(this.dataDataSet.Нагрузка_тренеров);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Специализация". При необходимости она может быть перемещена или удалена.
          //  this.специализацияTableAdapter.Fill(this.dataDataSet.Специализация);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Тренера". При необходимости она может быть перемещена или удалена.
           // this.тренераTableAdapter.Fill(this.dataDataSet.Тренера);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            тренераBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            тренераBindingSource.MoveNext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            тренераBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //studentDataGridView.Visible = false;
            this.Validate();
            this.тренераBindingSource.EndEdit();
            // this.tableAdapterManager.UpdateAll(this.studDataSet);
            тренераBindingSource.MoveLast();
            //studentDataGridView.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            тренераBindingSource.RemoveCurrent();
            this.Validate();
            this.тренераBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.studDataSet);
        }

        private void trener_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            this.тренераBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.dataDataSet);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тренераBindingSource.EndEdit();
        }
    }
}
