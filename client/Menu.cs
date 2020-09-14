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
    public partial class Menu1 : Form
    {
        int role;
        public Menu1(int _r)
        {
            InitializeComponent();
            role = _r;
            switch (role)
            {
                case 1:
                    {
                      
                    }
                    break;
                case 2:
                    {
                       
                        tren.Enabled = false;
                        spec.Enabled = false;
                        nagruzka.Enabled = false;
                        groupe.Enabled = false;
                        rucovod.Enabled = false;
                        authc.Enabled = false;
                        sorev.Enabled = false;
                        Sekc.Enabled = false;
                        pohod.Enabled = false;
                        slojnost.Enabled = false;
                        marshrut.Enabled = false;
                        tur.Enabled = false;
                    }
                    break;
                default:
                    break;

            }
        }

        private void Menu1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tren_Click(object sender, EventArgs e)
        {
            trener s = new trener();
            s.Show();
        }

        private void spec_Click(object sender, EventArgs e)
        {
            specF s = new specF();
            s.Show();
        }

        private void nagruzka_Click(object sender, EventArgs e)
        {
            nagruzkaF s = new nagruzkaF();
            s.Show();
        }

        private void tur_Click(object sender, EventArgs e)
        {
            turF s = new turF();
            s.Show();
        }

        private void nazgroupe_Click(object sender, EventArgs e)
        {
            nazgroupeF s = new nazgroupeF();
            s.Show();
        }

        private void groupe_Click(object sender, EventArgs e)
        {
            groupeF s = new groupeF();
            s.Show();
        }

        private void rucovod_Click(object sender, EventArgs e)
        {
            rucovodF s = new rucovodF();
            s.Show();
        }

        private void authc_Click(object sender, EventArgs e)
        {
            authcF s = new authcF();
            s.Show();
        }

        private void provsorev_Click(object sender, EventArgs e)
        {
            provsorevF s = new provsorevF();
            s.Show();
        }

        private void sorev_Click(object sender, EventArgs e)
        {
            sorevF s = new sorevF();
            s.Show();
        }

        private void provtren_Click(object sender, EventArgs e)
        {
            provtrenF s = new provtrenF();
            s.Show();
        }

        private void Sekc_Click(object sender, EventArgs e)
        {
            seckF s = new seckF();
            s.Show();
        }

        private void provpohod_Click(object sender, EventArgs e)
        {
            provpohodF s = new provpohodF();
            s.Show();
        }

        private void pohod_Click(object sender, EventArgs e)
        {
            pohodF s = new pohodF();
            s.Show();
        }

        private void slojnost_Click(object sender, EventArgs e)
        {
            slojnostF s = new slojnostF();
            s.Show();
        }

        private void marshrut_Click(object sender, EventArgs e)
        {
            marshrutF s = new marshrutF();
            s.Show();
        }
    }
}
