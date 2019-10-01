using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jstaehli17301f
{
    public partial class FrmCurrency : Form
    {
        public FrmCurrency()
        {
            InitializeComponent();
        }

        private void FrmCurrency_Load(object sender, EventArgs e)
        {
            btnChile.BackgroundImage = picChileDim.Image;
            btnDenmark.BackgroundImage = picDenmarkDim.Image;
            btnNorway.BackgroundImage = picNorwayDim.Image;
            btnSwiss.BackgroundImage = picSwissDim.Image; 
            txtRate.Text = "0.00142144";
            lblCurrency.Text = btnChile.Text;
            lblEquation.Text = "";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtCurrency.Focus(); 
        }

        private void BtnChile_Click(object sender, EventArgs e)
        {
            btnChile.BackgroundImage = picChile.Image;
            btnDenmark.BackgroundImage = picDenmarkDim.Image;
            btnNorway.BackgroundImage = picNorwayDim.Image;
            btnSwiss.BackgroundImage = picSwissDim.Image;
            txtRate.Text = "0.00142144";
            lblCurrency.Text = btnChile.Text;
        }

        private void BtnDenmark_Click(object sender, EventArgs e)
        {
            btnDenmark.BackgroundImage = picDenmark.Image;
            btnChile.BackgroundImage = picChileDim.Image;
            btnNorway.BackgroundImage = picNorwayDim.Image;
            btnSwiss.BackgroundImage = picSwissDim.Image;
            txtRate.Text = "0.148352";
            lblCurrency.Text = btnDenmark.Text;
        }

        private void BtnNorway_Click(object sender, EventArgs e)
        {
            btnNorway.BackgroundImage = picNorway.Image;
            btnChile.BackgroundImage = picChileDim.Image;
            btnDenmark.BackgroundImage = picDenmarkDim.Image;
            btnSwiss.BackgroundImage = picSwissDim.Image;
            txtRate.Text = "0.111326";
            lblCurrency.Text = btnNorway.Text;
        }

        private void BtnSwiss_Click(object sender, EventArgs e)
        {
            btnSwiss.BackgroundImage = picSwiss.Image;
            btnChile.BackgroundImage = picChileDim.Image;
            btnDenmark.BackgroundImage = picDenmarkDim.Image;
            btnNorway.BackgroundImage = picNorwayDim.Image;
            txtRate.Text = "1.00979";
            lblCurrency.Text = btnSwiss.Text; 
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSDollars.Text = (
                Convert.ToDecimal(txtCurrency.Text) * Convert.ToDecimal(txtRate.Text)
               ).ToString("0.00");
        }

        private void TxtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            lblEquation.Text = lblEquation.Text + " + " + txtUSDollars.Text;
            txtTotalUSD.Text = lblEquation.Text + txtUSDollars.Text;



        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtCurrency.Text = "0.00";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            lblEquation.Text = "";
                
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
