namespace Beavers
{
    partial class frmOrderUniform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderUniform));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddB = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.PictureBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblresetB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdSmall = new System.Windows.Forms.RadioButton();
            this.rdMedium = new System.Windows.Forms.RadioButton();
            this.rdLarge = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Uniform";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddB
            // 
            this.btnAddB.Image = ((System.Drawing.Image)(resources.GetObject("btnAddB.Image")));
            this.btnAddB.Location = new System.Drawing.Point(563, 81);
            this.btnAddB.Name = "btnAddB";
            this.btnAddB.Size = new System.Drawing.Size(59, 53);
            this.btnAddB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddB.TabIndex = 18;
            this.btnAddB.TabStop = false;
            this.btnAddB.Click += new System.EventHandler(this.buttonClick);
            this.btnAddB.MouseHover += new System.EventHandler(this.mouseOver);
            // 
            // btnReset
            // 
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(88, 182);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(59, 53);
            this.btnReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReset.TabIndex = 19;
            this.btnReset.TabStop = false;
            this.btnReset.Click += new System.EventHandler(this.buttonClick);
            this.btnReset.MouseHover += new System.EventHandler(this.mouseOver);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.Location = new System.Drawing.Point(569, 137);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(44, 24);
            this.lblAdd.TabIndex = 20;
            this.lblAdd.Text = "Add";
            // 
            // lblresetB
            // 
            this.lblresetB.AutoSize = true;
            this.lblresetB.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresetB.Location = new System.Drawing.Point(84, 238);
            this.lblresetB.Name = "lblresetB";
            this.lblresetB.Size = new System.Drawing.Size(78, 24);
            this.lblresetB.TabIndex = 21;
            this.lblresetB.Text = "Confrim";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdLarge);
            this.panel1.Controls.Add(this.rdMedium);
            this.panel1.Controls.Add(this.rdSmall);
            this.panel1.Location = new System.Drawing.Point(203, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 94);
            this.panel1.TabIndex = 23;
            // 
            // rdSmall
            // 
            this.rdSmall.AutoSize = true;
            this.rdSmall.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSmall.Location = new System.Drawing.Point(17, 4);
            this.rdSmall.Name = "rdSmall";
            this.rdSmall.Size = new System.Drawing.Size(70, 28);
            this.rdSmall.TabIndex = 0;
            this.rdSmall.TabStop = true;
            this.rdSmall.Text = "Small";
            this.rdSmall.UseVisualStyleBackColor = true;
            // 
            // rdMedium
            // 
            this.rdMedium.AutoSize = true;
            this.rdMedium.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMedium.Location = new System.Drawing.Point(17, 34);
            this.rdMedium.Name = "rdMedium";
            this.rdMedium.Size = new System.Drawing.Size(96, 28);
            this.rdMedium.TabIndex = 1;
            this.rdMedium.TabStop = true;
            this.rdMedium.Text = "Medium";
            this.rdMedium.UseVisualStyleBackColor = true;
            // 
            // rdLarge
            // 
            this.rdLarge.AutoSize = true;
            this.rdLarge.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLarge.Location = new System.Drawing.Point(17, 61);
            this.rdLarge.Name = "rdLarge";
            this.rdLarge.Size = new System.Drawing.Size(71, 28);
            this.rdLarge.TabIndex = 2;
            this.rdLarge.TabStop = true;
            this.rdLarge.Text = "Large";
            this.rdLarge.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "-- SELECT--",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(425, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 32);
            this.comboBox1.TabIndex = 24;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Jumper",
            "Scarf",
            "Woggle"});
            this.comboBox2.Location = new System.Drawing.Point(10, 83);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(174, 32);
            this.comboBox2.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Uniform type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(438, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Quantity";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lbItem,
            this.lbSize,
            this.lbQuantity});
            this.listView1.Location = new System.Drawing.Point(17, 173);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(505, 183);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // lbItem
            // 
            this.lbItem.Text = "Item";
            this.lbItem.Width = 170;
            // 
            // lbSize
            // 
            this.lbSize.Text = "Size";
            this.lbSize.Width = 59;
            // 
            // lbQuantity
            // 
            this.lbQuantity.Text = "Quantity";
            this.lbQuantity.Width = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(569, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Remove";
            // 
            // btnRemove
            // 
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.Location = new System.Drawing.Point(563, 206);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(59, 53);
            this.btnRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRemove.TabIndex = 30;
            this.btnRemove.TabStop = false;
            this.btnRemove.Click += new System.EventHandler(this.buttonClick);
            this.btnRemove.MouseHover += new System.EventHandler(this.mouseOver);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnAddB);
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblAdd);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 375);
            this.panel2.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.lblresetB);
            this.panel3.Location = new System.Drawing.Point(687, 228);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 296);
            this.panel3.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Total cost";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(69, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 32);
            this.textBox1.TabIndex = 23;
            // 
            // frmOrderUniform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(947, 588);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrderUniform";
            this.Text = "Order Uniform";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnReset;
        private System.Windows.Forms.PictureBox btnAddB;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblresetB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdLarge;
        private System.Windows.Forms.RadioButton rdMedium;
        private System.Windows.Forms.RadioButton rdSmall;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader lbItem;
        private System.Windows.Forms.ColumnHeader lbSize;
        private System.Windows.Forms.ColumnHeader lbQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btnRemove;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}

