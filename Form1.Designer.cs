namespace Pizza_Order
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grCusInfo = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.grPizza = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RB4 = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.RB3 = new System.Windows.Forms.RadioButton();
            this.RB2 = new System.Windows.Forms.RadioButton();
            this.RB1 = new System.Windows.Forms.RadioButton();
            this.grAddition = new System.Windows.Forms.GroupBox();
            this.CBox5 = new System.Windows.Forms.CheckBox();
            this.CBox4 = new System.Windows.Forms.CheckBox();
            this.CBox3 = new System.Windows.Forms.CheckBox();
            this.CBox2 = new System.Windows.Forms.CheckBox();
            this.CBox1 = new System.Windows.Forms.CheckBox();
            this.grPrice = new System.Windows.Forms.GroupBox();
            this.numOfUnits = new System.Windows.Forms.NumericUpDown();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCurOrder = new System.Windows.Forms.ListBox();
            this.txtGTotal = new System.Windows.Forms.TextBox();
            this.lblGTotal = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnNewCust = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grCusInfo.SuspendLayout();
            this.grPizza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grAddition.SuspendLayout();
            this.grPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfUnits)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // grCusInfo
            // 
            this.grCusInfo.Controls.Add(this.txtName);
            this.grCusInfo.Controls.Add(this.lblName);
            this.grCusInfo.Controls.Add(this.textAddress);
            this.grCusInfo.Controls.Add(this.lblAddress);
            this.grCusInfo.Location = new System.Drawing.Point(12, 12);
            this.grCusInfo.Name = "grCusInfo";
            this.grCusInfo.Size = new System.Drawing.Size(776, 100);
            this.grCusInfo.TabIndex = 4;
            this.grCusInfo.TabStop = false;
            this.grCusInfo.Text = "Customer Information";
            this.grCusInfo.Enter += new System.EventHandler(this.grCusInfo_Enter);
            // 
            // txtName
            // 
            this.txtName.AcceptsTab = true;
            this.txtName.Location = new System.Drawing.Point(82, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(656, 20);
            this.txtName.TabIndex = 7;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged_1);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // textAddress
            // 
            this.textAddress.AcceptsTab = true;
            this.textAddress.Location = new System.Drawing.Point(82, 58);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(656, 20);
            this.textAddress.TabIndex = 5;
            this.textAddress.TextChanged += new System.EventHandler(this.textAddress_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(6, 58);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // grPizza
            // 
            this.grPizza.Controls.Add(this.pictureBox1);
            this.grPizza.Controls.Add(this.RB4);
            this.grPizza.Controls.Add(this.RB3);
            this.grPizza.Controls.Add(this.RB2);
            this.grPizza.Controls.Add(this.RB1);
            this.grPizza.Enabled = false;
            this.grPizza.Location = new System.Drawing.Point(12, 118);
            this.grPizza.Name = "grPizza";
            this.grPizza.Size = new System.Drawing.Size(200, 111);
            this.grPizza.TabIndex = 5;
            this.grPizza.TabStop = false;
            this.grPizza.Text = "Pizza Types";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(82, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 92);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RB4
            // 
            this.RB4.AutoSize = true;
            this.RB4.ImageList = this.imageList1;
            this.RB4.Location = new System.Drawing.Point(6, 88);
            this.RB4.Name = "RB4";
            this.RB4.Size = new System.Drawing.Size(53, 17);
            this.RB4.TabIndex = 3;
            this.RB4.TabStop = true;
            this.RB4.Text = "Mixed";
            this.RB4.UseVisualStyleBackColor = true;
            this.RB4.CheckedChanged += new System.EventHandler(this.RB4_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Sicilian.jpg");
            this.imageList1.Images.SetKeyName(1, "Marine.jpg");
            this.imageList1.Images.SetKeyName(2, "Napoliten.jpg");
            this.imageList1.Images.SetKeyName(3, "Mixed.jpg");
            // 
            // RB3
            // 
            this.RB3.AutoSize = true;
            this.RB3.ImageList = this.imageList1;
            this.RB3.Location = new System.Drawing.Point(6, 67);
            this.RB3.Name = "RB3";
            this.RB3.Size = new System.Drawing.Size(70, 17);
            this.RB3.TabIndex = 2;
            this.RB3.TabStop = true;
            this.RB3.Text = "Napoliten";
            this.RB3.UseVisualStyleBackColor = true;
            this.RB3.CheckedChanged += new System.EventHandler(this.RB3_CheckedChanged);
            // 
            // RB2
            // 
            this.RB2.AutoSize = true;
            this.RB2.ImageList = this.imageList1;
            this.RB2.Location = new System.Drawing.Point(7, 44);
            this.RB2.Name = "RB2";
            this.RB2.Size = new System.Drawing.Size(57, 17);
            this.RB2.TabIndex = 1;
            this.RB2.TabStop = true;
            this.RB2.Text = "Marine";
            this.RB2.UseVisualStyleBackColor = true;
            this.RB2.CheckedChanged += new System.EventHandler(this.RB2_CheckedChanged);
            // 
            // RB1
            // 
            this.RB1.AutoSize = true;
            this.RB1.ImageList = this.imageList1;
            this.RB1.Location = new System.Drawing.Point(6, 21);
            this.RB1.Name = "RB1";
            this.RB1.Size = new System.Drawing.Size(58, 17);
            this.RB1.TabIndex = 0;
            this.RB1.TabStop = true;
            this.RB1.Text = "Sicilian";
            this.RB1.UseVisualStyleBackColor = true;
            this.RB1.CheckedChanged += new System.EventHandler(this.RB1_CheckedChanged);
            // 
            // grAddition
            // 
            this.grAddition.Controls.Add(this.CBox5);
            this.grAddition.Controls.Add(this.CBox4);
            this.grAddition.Controls.Add(this.CBox3);
            this.grAddition.Controls.Add(this.CBox2);
            this.grAddition.Controls.Add(this.CBox1);
            this.grAddition.Enabled = false;
            this.grAddition.Location = new System.Drawing.Point(12, 235);
            this.grAddition.Name = "grAddition";
            this.grAddition.Size = new System.Drawing.Size(200, 94);
            this.grAddition.TabIndex = 6;
            this.grAddition.TabStop = false;
            this.grAddition.Text = "Additions";
            // 
            // CBox5
            // 
            this.CBox5.AutoSize = true;
            this.CBox5.Location = new System.Drawing.Point(104, 71);
            this.CBox5.Name = "CBox5";
            this.CBox5.Size = new System.Drawing.Size(50, 17);
            this.CBox5.TabIndex = 4;
            this.CBox5.Text = "Olive";
            this.CBox5.UseVisualStyleBackColor = true;
            this.CBox5.CheckedChanged += new System.EventHandler(this.CBox5_CheckedChanged);
            // 
            // CBox4
            // 
            this.CBox4.AutoSize = true;
            this.CBox4.Location = new System.Drawing.Point(104, 20);
            this.CBox4.Name = "CBox4";
            this.CBox4.Size = new System.Drawing.Size(75, 17);
            this.CBox4.TabIndex = 3;
            this.CBox4.Text = "Mushroom";
            this.CBox4.UseVisualStyleBackColor = true;
            this.CBox4.CheckedChanged += new System.EventHandler(this.CBox4_CheckedChanged);
            // 
            // CBox3
            // 
            this.CBox3.AutoSize = true;
            this.CBox3.Location = new System.Drawing.Point(7, 68);
            this.CBox3.Name = "CBox3";
            this.CBox3.Size = new System.Drawing.Size(55, 17);
            this.CBox3.TabIndex = 2;
            this.CBox3.Text = "Pickle";
            this.CBox3.UseVisualStyleBackColor = true;
            this.CBox3.CheckedChanged += new System.EventHandler(this.CBox3_CheckedChanged);
            // 
            // CBox2
            // 
            this.CBox2.AutoSize = true;
            this.CBox2.Location = new System.Drawing.Point(6, 44);
            this.CBox2.Name = "CBox2";
            this.CBox2.Size = new System.Drawing.Size(62, 17);
            this.CBox2.TabIndex = 1;
            this.CBox2.Text = "Tomato";
            this.CBox2.UseVisualStyleBackColor = true;
            this.CBox2.CheckedChanged += new System.EventHandler(this.CBox2_CheckedChanged);
            // 
            // CBox1
            // 
            this.CBox1.AutoSize = true;
            this.CBox1.Location = new System.Drawing.Point(6, 20);
            this.CBox1.Name = "CBox1";
            this.CBox1.Size = new System.Drawing.Size(92, 17);
            this.CBox1.TabIndex = 0;
            this.CBox1.Text = "Green Pepper";
            this.CBox1.UseVisualStyleBackColor = true;
            this.CBox1.CheckedChanged += new System.EventHandler(this.CBox1_CheckedChanged);
            // 
            // grPrice
            // 
            this.grPrice.Controls.Add(this.numOfUnits);
            this.grPrice.Controls.Add(this.txtAmount);
            this.grPrice.Controls.Add(this.txtTotal);
            this.grPrice.Controls.Add(this.txtPrice);
            this.grPrice.Controls.Add(this.label4);
            this.grPrice.Controls.Add(this.lblTotal);
            this.grPrice.Controls.Add(this.label2);
            this.grPrice.Controls.Add(this.label1);
            this.grPrice.Enabled = false;
            this.grPrice.Location = new System.Drawing.Point(12, 335);
            this.grPrice.Name = "grPrice";
            this.grPrice.Size = new System.Drawing.Size(200, 112);
            this.grPrice.TabIndex = 7;
            this.grPrice.TabStop = false;
            // 
            // numOfUnits
            // 
            this.numOfUnits.Location = new System.Drawing.Point(94, 37);
            this.numOfUnits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOfUnits.Name = "numOfUnits";
            this.numOfUnits.Size = new System.Drawing.Size(48, 20);
            this.numOfUnits.TabIndex = 8;
            this.numOfUnits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOfUnits.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(94, 86);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 7;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(94, 63);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(94, 10);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount of Calorie";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(6, 63);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "# of unit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unit Price";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.lblCurOrder);
            this.groupBox5.Controls.Add(this.txtGTotal);
            this.groupBox5.Controls.Add(this.lblGTotal);
            this.groupBox5.Location = new System.Drawing.Point(218, 118);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(570, 238);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Current Order";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(347, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Unit Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "# of units";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Additions";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pizza";
            // 
            // lblCurOrder
            // 
            this.lblCurOrder.Enabled = false;
            this.lblCurOrder.FormattingEnabled = true;
            this.lblCurOrder.Location = new System.Drawing.Point(6, 39);
            this.lblCurOrder.Name = "lblCurOrder";
            this.lblCurOrder.Size = new System.Drawing.Size(535, 147);
            this.lblCurOrder.TabIndex = 3;
            this.lblCurOrder.SelectedIndexChanged += new System.EventHandler(this.lblCurOrder_SelectedIndexChanged);
            // 
            // txtGTotal
            // 
            this.txtGTotal.Enabled = false;
            this.txtGTotal.Location = new System.Drawing.Point(279, 212);
            this.txtGTotal.Name = "txtGTotal";
            this.txtGTotal.Size = new System.Drawing.Size(285, 20);
            this.txtGTotal.TabIndex = 2;
            this.txtGTotal.TextChanged += new System.EventHandler(this.txtGTotal_TextChanged);
            // 
            // lblGTotal
            // 
            this.lblGTotal.AutoSize = true;
            this.lblGTotal.Location = new System.Drawing.Point(179, 212);
            this.lblGTotal.Name = "lblGTotal";
            this.lblGTotal.Size = new System.Drawing.Size(63, 13);
            this.lblGTotal.TabIndex = 1;
            this.lblGTotal.Text = "Grand Total";
            this.lblGTotal.Click += new System.EventHandler(this.lblGTotal_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Enabled = false;
            this.btnInsert.Location = new System.Drawing.Point(236, 362);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(130, 32);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Insert Order";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(372, 362);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 32);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "    ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Enabled = false;
            this.btnNew.Location = new System.Drawing.Point(514, 362);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(120, 32);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "New Order";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnNewCust
            // 
            this.btnNewCust.Location = new System.Drawing.Point(640, 362);
            this.btnNewCust.Name = "btnNewCust";
            this.btnNewCust.Size = new System.Drawing.Size(142, 32);
            this.btnNewCust.TabIndex = 12;
            this.btnNewCust.Text = "New Customer";
            this.btnNewCust.UseVisualStyleBackColor = true;
            this.btnNewCust.Click += new System.EventHandler(this.btnNewCust_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(236, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(546, 41);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewCust);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.grPrice);
            this.Controls.Add(this.grAddition);
            this.Controls.Add(this.grPizza);
            this.Controls.Add(this.grCusInfo);
            this.Name = "Form1";
            this.Text = "Pizza Ordering System";
            this.grCusInfo.ResumeLayout(false);
            this.grCusInfo.PerformLayout();
            this.grPizza.ResumeLayout(false);
            this.grPizza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grAddition.ResumeLayout(false);
            this.grAddition.PerformLayout();
            this.grPrice.ResumeLayout(false);
            this.grPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfUnits)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grCusInfo;
        private System.Windows.Forms.GroupBox grPizza;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton RB4;
        private System.Windows.Forms.RadioButton RB3;
        private System.Windows.Forms.RadioButton RB2;
        private System.Windows.Forms.RadioButton RB1;
        private System.Windows.Forms.GroupBox grAddition;
        private System.Windows.Forms.CheckBox CBox5;
        private System.Windows.Forms.CheckBox CBox4;
        private System.Windows.Forms.CheckBox CBox3;
        private System.Windows.Forms.CheckBox CBox2;
        private System.Windows.Forms.CheckBox CBox1;
        private System.Windows.Forms.GroupBox grPrice;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtGTotal;
        private System.Windows.Forms.Label lblGTotal;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnNewCust;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.NumericUpDown numOfUnits;
        private System.Windows.Forms.ListBox lblCurOrder;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

