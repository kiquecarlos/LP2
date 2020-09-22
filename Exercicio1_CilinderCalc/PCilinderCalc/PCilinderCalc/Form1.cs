using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PCilinderCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtRaio.Text = "";
            txtAltura.Text = "";
            txtVolume.Text = "";
            txtRaio.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            double altura, raio;

            if(double.TryParse(txtRaio.Text,out raio) && double.TryParse(txtAltura.Text, out altura))
            {
                double volume;

                volume = Math.PI * Math.Pow(raio, 2) * altura;

                txtVolume.Text = volume.ToString("N2");

            }
            else
            {
                MessageBox.Show("Digite Valores Válidos");
            }
        }
    }
}
