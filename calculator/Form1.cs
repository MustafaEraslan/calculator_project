using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        int sum = 0;
        int counterInc = 0;
        int counterDec = 0;
        int counterMul = 0;
        bool opr = false;
        public Form1()
        {
            InitializeComponent();
        }
        
       
         

        private void btnInc_Click(object sender, EventArgs e)
        {
            counterInc++;
            if (counterInc == 1)
            {
                sum = int.Parse(txtSum.Text);
            }
            else
            {
                sum = int.Parse(label1.Text) + int.Parse(txtSum.Text);
                txtSum.Text = sum.ToString();
            }
            label1.Text = sum.ToString();

            txtSum.Focus();
            opr = true;
        }
       

        private void btnDec_Click(object sender, EventArgs e)
        {
            counterDec++;
            if (counterDec == 1)
            {
                sum = int.Parse(txtSum.Text);
            }
            else
            {
                sum = int.Parse(label1.Text) - int.Parse(txtSum.Text);
                txtSum.Text = sum.ToString();

            }
            label1.Text = sum.ToString();
            txtSum.Focus();
            opr = true;
            
        }

        
        private void btnMul_Click(object sender, EventArgs e)
        {
            counterMul++;
            if (counterMul == 1)
            {
                sum = int.Parse(txtSum.Text);
            }
            else
            {
                sum = int.Parse(label1.Text) * int.Parse(txtSum.Text);
                txtSum.Text = sum.ToString();
                txtSum.Focus();

            }
            label1.Text = sum.ToString();
            opr = true;
            
        }
        
        private void txtSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (opr==true)
            { 
                txtSum.Text = "";
                opr = false;
            }
            string gg = e.KeyChar.ToString();
            //if (gg=="+")
            //{
            //    sumissue();
            //}

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            counterDec++;
            if (counterDec == 1)
            {
                sum = int.Parse(txtSum.Text);
            }
            else
            {
                sum = int.Parse(label1.Text) / int.Parse(txtSum.Text);
                txtSum.Text = sum.ToString();

            }
            label1.Text = sum.ToString();
            txtSum.Focus();
            opr = true; 
            

        }
    }
}
