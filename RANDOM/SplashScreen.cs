using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RANDOM
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //.PerformStep();
           // label1.Text = "Carregando Aplicação ... " + progressBar1.Value + " % ";
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            //timer1.Start();
        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            label1.Text = "Carregando Aplicação ... " + progressBar1.Value + " % ";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

