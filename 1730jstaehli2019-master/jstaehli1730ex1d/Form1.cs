using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jstaehli1730ex1d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtAmountDenmark.Text = "0.00";
            txtRateDenmark.Text = "0.148352";
            txtAmountNorway.Text = "0.00";
            txtRateNorway.Text = "0.111326";
            txtAmountChile.Text = "0.00";
            txtRateChile.Text = "0.00142144";
            txtAmountSwiss.Text = "0.00";
            txtRateSwiss.Text = "1.00979";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DenmarkTextChanged(object sender, EventArgs e)
        {
            txtUsdDenmark.Text = (
               Convert.ToDecimal(txtAmountDenmark.Text) * Convert.ToDecimal(txtRateDenmark.Text)
               ).ToString("0.00");
        }

        private void NorwayTextChanged(object sender, EventArgs e)
        {
            txtUsdNorway.Text = (
                Convert.ToDecimal(txtAmountNorway.Text) * Convert.ToDecimal(txtRateDenmark.Text)
                ).ToString("0.00");

        }

        private void ChileTextChanged(object sender, EventArgs e)
        {
            txtUsdChile.Text = (
                Convert.ToDecimal(txtAmountChile.Text) * Convert.ToDecimal(txtRateChile.Text)
                ).ToString("0.00");
        }

        private void SwissTextChanged(object sender, EventArgs e)
        {
            txtUsdSwiss.Text = (
                Convert.ToDecimal(txtAmountSwiss.Text) * Convert.ToDecimal(txtRateSwiss.Text)
                ).ToString("0.00");
        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtUsd.Text = (
               Convert.ToDecimal(txtUsdDenmark.Text) +
               Convert.ToDecimal(txtUsdNorway.Text) +
               Convert.ToDecimal(txtUsdChile.Text) +
               Convert.ToDecimal(txtUsdSwiss.Text)
               ).ToString("0.00");
               
             

        }
           

    }
    }

