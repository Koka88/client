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
    public partial class nagruzkaF : Form
    {
        public nagruzkaF()
        {
            InitializeComponent();
        }

        private void nagruzkaF_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Руководители". При необходимости она может быть перемещена или удалена.
            this.руководителиTableAdapter.Fill(this.dataDataSet.Руководители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Тренера". При необходимости она может быть перемещена или удалена.
            this.тренераTableAdapter.Fill(this.dataDataSet.Тренера);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Нагрузка_тренеров". При необходимости она может быть перемещена или удалена.
            //  this.нагрузка_тренеровTableAdapter.Fill(this.dataDataSet.Нагрузка_тренеров);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Нагрузка_тренеров". При необходимости она может быть перемещена или удалена.
            this.нагрузка_тренеровTableAdapter.Fill(this.dataDataSet.Нагрузка_тренеров);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            нагрузкаТренеровBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            нагрузкаТренеровBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           нагрузкаТренеровBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.нагрузкаТренеровBindingSource.EndEdit();
            нагрузкаТренеровBindingSource.MoveLast();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            нагрузкаТренеровBindingSource.RemoveCurrent();
            this.Validate();
            this.нагрузкаТренеровBindingSource.EndEdit();
        }

        private void nagruzkaF_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            this.нагрузкаТренеровBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.dataDataSet);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
              this.Validate();
            this.нагрузкаТренеровBindingSource.EndEdit();
        }
    }
}
