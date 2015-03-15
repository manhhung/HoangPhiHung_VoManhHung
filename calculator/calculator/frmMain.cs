using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class frmMain : Form
    {
        double save1,save2, MS;
        string savepheptinh;
        bool isTypingNumber = false;
        bool isphay = true;
        public frmMain()
        {
            
            InitializeComponent();
            
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (isTypingNumber)
            {
                lblDisplay.Text = lblDisplay.Text + btn9.Text;

            }
            else
            {
                lblDisplay.Text = btn9.Text;
                isTypingNumber = true;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (isTypingNumber)
            {
                lblDisplay.Text = lblDisplay.Text + btn8.Text;

            }
            else
            {
                lblDisplay.Text = btn8.Text;
                isTypingNumber = true;
            }
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (isTypingNumber)
            {
                lblDisplay.Text = lblDisplay.Text + btn7.Text;
                
            }
            else
            {
                lblDisplay.Text = btn7.Text;
                isTypingNumber = true;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (isTypingNumber)
            {
                lblDisplay.Text = lblDisplay.Text + btn6.Text;

            }
            else
            {
                lblDisplay.Text = btn6.Text;
                isTypingNumber = true;
            }

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (isTypingNumber)
            {
                lblDisplay.Text = lblDisplay.Text + btn5.Text;

            }
            else
            {
                lblDisplay.Text = btn5.Text;
                isTypingNumber = true;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (isTypingNumber)
            {
                lblDisplay.Text = lblDisplay.Text + btn4.Text;

            }
            else
            {
                lblDisplay.Text = btn4.Text;
                isTypingNumber = true;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (isTypingNumber)
            {
                lblDisplay.Text = lblDisplay.Text + btn3.Text;

            }
            else
            {
                lblDisplay.Text = btn3.Text;
                isTypingNumber = true;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (isTypingNumber)
            {
                lblDisplay.Text = lblDisplay.Text + btn2.Text;

            }
            else
            {
                lblDisplay.Text = btn2.Text;
                isTypingNumber = true;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (isTypingNumber)
            {
                lblDisplay.Text = lblDisplay.Text + btn1.Text;

            }
            else
            {
                lblDisplay.Text = btn1.Text;
                isTypingNumber = true;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != "0")
            {
                if (isTypingNumber)
                {
                    lblDisplay.Text = lblDisplay.Text + btn0.Text;

                }
                else
                {
                    lblDisplay.Text = btn0.Text;
                    isTypingNumber = true;
                }
            }
        }
        // Dấu phẩy
        private void btnphay_Click(object sender, EventArgs e)
        {
            if (isphay)
            {
                lblDisplay.Text = lblDisplay.Text + btnPhay.Text;
                isphay = false;
                isTypingNumber = true;
            }
            
        }
        // phép tính
        private void btncong_Click(object sender, EventArgs e)
        {
            save1 = double.Parse(lblDisplay.Text);
            savepheptinh = "+";
            lblDisplay.Text = "0";
            isTypingNumber = false;

        }

        private void btntru_Click(object sender, EventArgs e)
        {
            save1 = double.Parse(lblDisplay.Text);
            savepheptinh = "-";
            lblDisplay.Text = "0";
            isTypingNumber = false;
        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            save1 = double.Parse(lblDisplay.Text);
            savepheptinh = "*";
            lblDisplay.Text = "0"; 
            isTypingNumber = false;
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            save1 = double.Parse(lblDisplay.Text);
            savepheptinh = "/";
            lblDisplay.Text = "0";
            isTypingNumber = false;
        }
        //dấu bằng
        private void btnbang_Click(object sender, EventArgs e)
        {
            switch (savepheptinh)
            {
                case "+": lblDisplay.Text = (double.Parse(lblDisplay.Text) + save1).ToString(); break;
                case "-": lblDisplay.Text = (save1-double.Parse(lblDisplay.Text)).ToString(); break;
                case "*": lblDisplay.Text = (save1*double.Parse(lblDisplay.Text)).ToString(); break;
                case "/": lblDisplay.Text = (save1 /double.Parse(lblDisplay.Text)).ToString(); break;
                default: break;
            }
           
            isTypingNumber=false;
            isphay = true;
        }
        // các phép toán khác
        private void btnsoam_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = (-1* double.Parse(lblDisplay.Text)).ToString();
        }
        // C
        private void btndefault_Click(object sender, EventArgs e)
        {
            save1 = 0;
            save2 = 0;
            lblDisplay.Text = "0";
            isTypingNumber = false;
            MS = 0;
        }
        //CE
        private void btnCE_Click(object sender, EventArgs e)
        {
            save1 = 0;
            save2 = 0;
            lblDisplay.Text = "0";
            isTypingNumber = false;
        }
        //<-
        private void btnxoa_Click(object sender, EventArgs e)
        {
            lblDisplay.Text =(double.Parse(lblDisplay.Text)/10).ToString();
            if (lblDisplay.Text == "0") { isTypingNumber = false; }
        }

        private void btnmotphanx_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = (1 / double.Parse(lblDisplay.Text)).ToString();
            isTypingNumber = false;
        }

        private void btnMdelete_Click(object sender, EventArgs e)
        {
            MS = MS + double.Parse(lblDisplay.Text);
            lblM.Text = "M";
        }

        private void btnMcong_Click(object sender, EventArgs e)
        {
            MS = MS + double.Parse(lblDisplay.Text);
            lblM.Text = "M";
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            MS = double.Parse(lblDisplay.Text);
            lblM.Text = "M";
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            lblDisplay.Text= MS.ToString();
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MS = 0;
            lblM.Text = "";
        }

        private void btncan_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = (Math.Sqrt(double.Parse(lblDisplay.Text))).ToString();
        }

        private void btnphantram_Click(object sender, EventArgs e)
        {
          
            switch (savepheptinh)
            {
                case "+": lblDisplay.Text = ((double.Parse(lblDisplay.Text)*100) + save1).ToString(); break;
                case "-": lblDisplay.Text = (save1 - (double.Parse(lblDisplay.Text)*100)).ToString(); break;
                case "*": lblDisplay.Text = (save1 * (double.Parse(lblDisplay.Text)*100)).ToString(); break;
                case "/": lblDisplay.Text = (save1 / (double.Parse(lblDisplay.Text)*100)).ToString(); break;
                default: break;
            }
            
            isTypingNumber = false;
        }

        
    }
}

