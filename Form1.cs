using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        //-------------------------------Sicilian	Marine	Napoliten	Mixed	GreenPepper Tomato  Pickle Mushroom  Olive
        double[] calorie = new double[9] { 100, 125, 125, 140, 15, 10, 25, 40, 10 };
        double[] price = new double[9] { 27.50, 28.50, 30.00, 27.50, 2.25, 1.25, 2.35, 2.75, 0.70 };

        List<double> prevTotal = new List<double>();
        List<int> indexArr = new List<int>();
        double total, caltotal;
        double GrandTotal = 0.0;
       
        private void RB1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
            numOfUnits.Enabled = true;
            txtPrice.Text = price[0].ToString();
            txtAmount.Text = calorie[0].ToString();
            pictureBox1.Visible = true;
            grPrice.Enabled = true;
            txtTotal.Text = price[0].ToString();
            total = price[0];
            caltotal = calorie[0];
            grAddition.Enabled = true;
            btnInsert.Enabled = true;
        }

        private void RB2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[1];
            numOfUnits.Enabled = true;
            txtPrice.Text = price[1].ToString();
            txtAmount.Text = calorie[1].ToString();
            pictureBox1.Visible = true;
            grPrice.Enabled = true;
            txtTotal.Text = price[1].ToString();
            total = price[1];
            caltotal = calorie[1];
            grAddition.Enabled = true;
            btnInsert.Enabled = true;
        }

        private void RB3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[2];
            numOfUnits.Enabled = true;
            txtPrice.Text = price[2].ToString();
            txtAmount.Text = calorie[2].ToString();
            pictureBox1.Visible = true;
            grPrice.Enabled = true;
            txtTotal.Text = price[2].ToString();
            total = price[2];
            caltotal = calorie[2];
            grAddition.Enabled = true;
            btnInsert.Enabled = true;
        }

        private void RB4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[3];
            numOfUnits.Enabled = true;
            txtPrice.Text = price[3].ToString();
            txtAmount.Text = calorie[3].ToString();
            pictureBox1.Visible = true;
            grPrice.Enabled = true;
            txtTotal.Text = price[3].ToString();
            total = price[3];
            caltotal = calorie[3];
            grAddition.Enabled = true;
            btnInsert.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double tempValue = total * Decimal.ToDouble(numOfUnits.Value);
            txtTotal.Text = tempValue.ToString();
        }

       
        private void btnInsert_Click(object sender, EventArgs e)
        {
            txtTotal.Enabled = true;
            lblCurOrder.Enabled = true;
            string fullOrder = "";
            //----------grand total and prevtotal computation -------
            GrandTotal = GrandTotal + Convert.ToDouble(txtTotal.Text);
            prevTotal.Add(Convert.ToDouble(txtTotal.Text));
            txtGTotal.Text = GrandTotal.ToString();
            //-------------------------------------------------------
            foreach (Control rd in grPizza.Controls.OfType<RadioButton>())
            {
                if (((RadioButton)rd).Checked == true)
                {
                    fullOrder = fullOrder + ((RadioButton)rd).Text + " \t";
                }
            }
            foreach (Control cb in grAddition.Controls.OfType<CheckBox>())
            {
                if (((CheckBox)cb).Checked == true)
                {
                    fullOrder = fullOrder + ((CheckBox)cb).Text[0] + "";
                }
            }
            //tabs [\t] are just for formatting purposes
            fullOrder = fullOrder + "\t\t";

            fullOrder = fullOrder + numOfUnits.Text + "\t\t";
            fullOrder = fullOrder + txtPrice.Text + "\t\t";
            fullOrder = fullOrder + txtTotal.Text;

            lblCurOrder.Items.Add(fullOrder.ToString());

            //-----------to clear entries of previous order---------
            foreach (Control rd in grPizza.Controls.OfType<RadioButton>())
            {
                ((RadioButton)rd).Checked = false;
            }
            foreach (Control cb in grAddition.Controls.OfType<CheckBox>())
            {
                ((CheckBox)cb).Checked = false;
            }
            foreach (Control tb in grPrice.Controls.OfType<TextBox>())
            {
                ((TextBox)tb).Text = string.Empty;
            }
            //-------------------------------------------------------
            total = 0;
            caltotal = 0;
            grPizza.Enabled = false;
            grAddition.Enabled = false;
            grPrice.Enabled = false;
            numOfUnits.Enabled = false;
            numOfUnits.Value = 1;
            btnInsert.Enabled = false;
            btnNew.Enabled = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblCurOrder.SelectedItems.Count >= 0)
            {

                foreach (object o in lblCurOrder.SelectedItems)
                {
                    GrandTotal -= prevTotal[lblCurOrder.Items.IndexOf(o)];

                }
                txtGTotal.Text = GrandTotal.ToString();
            }
            int index = lblCurOrder.SelectedIndex;
            while (lblCurOrder.SelectedItems.Count != 0)
            {

                lblCurOrder.Items.Remove(lblCurOrder.SelectedItems[0]);
            }
            btnDelete.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            grCusInfo.Enabled = false;
            grPizza.Enabled = true;
        }

        private void btnNewCust_Click(object sender, EventArgs e)
        {
            grCusInfo.Enabled = true ;
            txtName.Text = "";
            textAddress.Text = "";
            txtGTotal.Text = string.Empty;
            lblCurOrder.Items.Clear();  //clears listbox

            //-----------to clear entries of previous order---------
            foreach (Control rd in grPizza.Controls.OfType<RadioButton>())
            {
                ((RadioButton)rd).Checked = false;
            }
            foreach (Control cb in grAddition.Controls.OfType<CheckBox>())
            {
                ((CheckBox)cb).Checked = false;
            }
            foreach (Control tb in grPrice.Controls.OfType<TextBox>())
            {
                ((TextBox)tb).Text = string.Empty;
            }
            //-------------------------------------------------------
            total = 0;
            caltotal = 0;
            grPizza.Enabled = false;
            grAddition.Enabled = false;
            grPrice.Enabled = false;
            numOfUnits.Enabled = false;
            btnInsert.Enabled = false;
            btnDelete.Enabled = false;
            txtName.Focus();
        }

        private void grCusInfo_Enter(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged_1(object sender, EventArgs e)
        {
                // Save the selection's start and length.
                int sel_start = txtName.SelectionStart;
                int sel_length = txtName.SelectionLength;
                CultureInfo culture_info = Thread.CurrentThread.CurrentCulture;
                TextInfo text_info = culture_info.TextInfo;
                txtName.Text = text_info.ToTitleCase(txtName.Text);
                // Restore the selection's start and length.
                txtName.Select(sel_start, sel_length);

        }

        private void textAddress_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter a name first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }
            grPizza.Enabled=true;

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBox1_CheckedChanged(object sender, EventArgs e)
        {
            numOfUnits.Enabled = true;
            if (CBox1.Checked == true)
            {
                txtPrice.Text = (total + price[4]).ToString();
                txtAmount.Text = (caltotal + calorie[4]).ToString();
                txtTotal.Text = ((total + price[4]) * Decimal.ToDouble(numOfUnits.Value)).ToString();
                total += price[4];
                caltotal += calorie[4];
            }
            if (CBox1.Checked == false)
            {
                txtPrice.Text = (total - price[4]).ToString();
                txtAmount.Text = (caltotal - calorie[4]).ToString();
                txtTotal.Text = ((total - price[4]) * Decimal.ToDouble(numOfUnits.Value)).ToString();
                total -= price[4];
                caltotal -= calorie[4];
            }
        }

        private void CBox2_CheckedChanged(object sender, EventArgs e)
        {
            numOfUnits.Enabled = true;
            if (CBox2.Checked == true)
            {
                txtPrice.Text = (total + price[5]).ToString();
                txtAmount.Text = (caltotal + calorie[5]).ToString();
                txtTotal.Text = ((total + price[5]) * Decimal.ToDouble(numOfUnits.Value)).ToString();
                total += price[5];
                caltotal += calorie[5];
            }
            if (CBox2.Checked == false)
            {
                txtPrice.Text = (total - price[5]).ToString();
                txtAmount.Text = (caltotal - calorie[5]).ToString();
                txtTotal.Text = ((total - price[5]) * Decimal.ToDouble(numOfUnits.Value)).ToString();
                total -= price[5];
                caltotal -= calorie[5];
            }
        }

        private void CBox3_CheckedChanged(object sender, EventArgs e)
        {
            numOfUnits.Enabled = true;
            if (CBox3.Checked == true)
            {
                txtPrice.Text = (total + price[6]).ToString();
                txtAmount.Text = (caltotal + calorie[6]).ToString();
                txtTotal.Text = ((total + price[6]) * Decimal.ToDouble(numOfUnits.Value)).ToString();
                total += price[6];
                caltotal += calorie[6];
            }
            if (CBox3.Checked == false)
            {
                txtPrice.Text = (total - price[6]).ToString();
                txtAmount.Text = (caltotal - calorie[6]).ToString();
                txtTotal.Text = ((total - price[6]) * Decimal.ToDouble(numOfUnits.Value)).ToString();
                total -= price[6];
                caltotal -= calorie[6];
            }
        }

        private void CBox4_CheckedChanged(object sender, EventArgs e)
        {
            numOfUnits.Enabled = true;
            if (CBox4.Checked == true)
            {
                txtPrice.Text = (total + price[7]).ToString();
                txtAmount.Text = (caltotal + calorie[7]).ToString();
                txtTotal.Text = ((total + price[7]) * Decimal.ToDouble(numOfUnits.Value)).ToString();
                total += price[7];
                caltotal += calorie[7];
            }
            if (CBox4.Checked == false)
            {
                txtPrice.Text = (total - price[7]).ToString();
                txtAmount.Text = (caltotal - calorie[7]).ToString();
                txtTotal.Text = ((total - price[7]) * Decimal.ToDouble(numOfUnits.Value)).ToString();
                total -= price[7];
                caltotal -= calorie[7];
            }
        }

        private void CBox5_CheckedChanged(object sender, EventArgs e)
        {
            numOfUnits.Enabled = true;
            if (CBox5.Checked == true)
            {
                txtPrice.Text = (total + price[8]).ToString();
                txtAmount.Text = (caltotal + calorie[8]).ToString();
                txtTotal.Text = ((total + price[8]) * Decimal.ToDouble(numOfUnits.Value)).ToString();
                total += price[8];
                caltotal += calorie[8];
            }
            if (CBox5.Checked == false)
            {
                txtPrice.Text = (total - price[8]).ToString();
                txtAmount.Text = (caltotal - calorie[8]).ToString();
                txtTotal.Text = ((total - price[8]) * Decimal.ToDouble(numOfUnits.Value)).ToString();
                total -= price[8];
                caltotal -= calorie[8];
            }
        }

        private void lblGTotal_Click(object sender, EventArgs e)
        {

        }

        private void txtGTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void lblCurOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            indexArr.Add(lblCurOrder.SelectedIndex);
        }
    }
}
