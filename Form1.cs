using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CSHdigitalniSat
{
    public partial class Form1 : Form
    {
        private string kultura = "hr-HR";
        private bool cb_sat_dugi = false;
        private bool cb_datum_dugi = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(kultura);
            if (cb_sat_dugi)
                labela_vrijeme.Text = DateTime.Now.ToLongTimeString();
            else
                labela_vrijeme.Text = DateTime.Now.ToShortTimeString();
            if (cb_datum_dugi)
            {
                labela_datum.Text = DateTime.Now.ToLongDateString();
                double standardna_vel_fonta = labela_datum.Font.Size;
                //ako dugacka verzija prikaza datuma neke kulture duza od gui-a, while smanjuje font postepeno
                while (labela_datum.Width > 400) 
                {
                    labela_datum.Font = new Font(labela_datum.Font.FontFamily, labela_datum.Font.Size - 0.5f, labela_datum.Font.Style);
                }
                resetirajVelFontaDatum(standardna_vel_fonta);
                
            }
            else
                labela_datum.Text = DateTime.Now.ToShortDateString();

        }

        private void resetirajVelFontaDatum(double vel_fonta)
        {
            //
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kult_dugi = comboBox1.SelectedItem.ToString();
            kultura = kult_dugi.Substring(0, kult_dugi.IndexOf(" "));
        }

        private void checkBoxSat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSat.Checked)
                cb_sat_dugi = true;
            else
                cb_sat_dugi = false;
        }

        private void checkBoxDatum_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDatum.Checked)
                cb_datum_dugi = true;
            else
                cb_datum_dugi = false;
        }
    }
}
