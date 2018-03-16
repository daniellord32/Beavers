namespace Beavers
{
    partial class frmUpdateBeaver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateBeaver));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.PictureBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblresetB = new System.Windows.Forms.Label();
            this.lblFnd = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.PictureBox();
            this.btnMainMenu = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckCap = new System.Windows.Forms.CheckBox();
            this.cmbBeaverID = new System.Windows.Forms.ComboBox();
            this.lblIDB = new System.Windows.Forms.Label();
            this.txtPostcodeB = new System.Windows.Forms.TextBox();
            this.txtCountyB = new System.Windows.Forms.TextBox();
            this.txtTownB = new System.Windows.Forms.TextBox();
            this.txtStreetB = new System.Windows.Forms.TextBox();
            this.txtSurnameB = new System.Windows.Forms.TextBox();
            this.txtForenameB = new System.Windows.Forms.TextBox();
            this.dpDob = new System.Windows.Forms.DateTimePicker();
            this.lblPostCodeB = new System.Windows.Forms.Label();
            this.lblCountyB = new System.Windows.Forms.Label();
            this.lblTownB = new System.Windows.Forms.Label();
            this.lblStreetB = new System.Windows.Forms.Label();
            this.lblDOBb = new System.Windows.Forms.Label();
            this.lblSurnameB = new System.Windows.Forms.Label();
            this.lblForenameB = new System.Windows.Forms.Label();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtAllergens = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Beaver";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(852, 234);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(59, 53);
            this.btnUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Click += new System.EventHandler(this.Book_Click);
            this.btnUpdate.MouseHover += new System.EventHandler(this.mouseOver);
            // 
            // btnReset
            // 
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(852, 333);
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
            this.lblAdd.Location = new System.Drawing.Point(848, 290);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(68, 24);
            this.lblAdd.TabIndex = 20;
            this.lblAdd.Text = "Update";
            // 
            // lblresetB
            // 
            this.lblresetB.AutoSize = true;
            this.lblresetB.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresetB.Location = new System.Drawing.Point(858, 398);
            this.lblresetB.Name = "lblresetB";
            this.lblresetB.Size = new System.Drawing.Size(53, 24);
            this.lblresetB.TabIndex = 21;
            this.lblresetB.Text = "Reset";
            // 
            // lblFnd
            // 
            this.lblFnd.AutoSize = true;
            this.lblFnd.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFnd.Location = new System.Drawing.Point(858, 207);
            this.lblFnd.Name = "lblFnd";
            this.lblFnd.Size = new System.Drawing.Size(46, 24);
            this.lblFnd.TabIndex = 23;
            this.lblFnd.Text = "Find";
            // 
            // btnFind
            // 
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(852, 151);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(59, 53);
            this.btnFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFind.TabIndex = 22;
            this.btnFind.TabStop = false;
            this.btnFind.Click += new System.EventHandler(this.Find_Beaver);
            this.btnFind.MouseHover += new System.EventHandler(this.mouseOver);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMainMenu.Image")));
            this.btnMainMenu.Location = new System.Drawing.Point(852, 447);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(59, 53);
            this.btnMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMainMenu.TabIndex = 24;
            this.btnMainMenu.TabStop = false;
            this.btnMainMenu.Click += new System.EventHandler(this.buttonClick);
            this.btnMainMenu.MouseHover += new System.EventHandler(this.mouseOver);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(839, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Main Menu";
            // 
            // ckCap
            // 
            this.ckCap.AutoSize = true;
            this.ckCap.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckCap.Location = new System.Drawing.Point(249, 529);
            this.ckCap.Name = "ckCap";
            this.ckCap.Size = new System.Drawing.Size(113, 28);
            this.ckCap.TabIndex = 42;
            this.ckCap.Text = "Capitation";
            this.ckCap.UseVisualStyleBackColor = true;
            // 
            // cmbBeaverID
            // 
            this.cmbBeaverID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBeaverID.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBeaverID.FormattingEnabled = true;
            this.cmbBeaverID.Items.AddRange(new object[] {
            "--Select--"});
            this.cmbBeaverID.Location = new System.Drawing.Point(217, 151);
            this.cmbBeaverID.Name = "cmbBeaverID";
            this.cmbBeaverID.Size = new System.Drawing.Size(200, 32);
            this.cmbBeaverID.TabIndex = 41;
            // 
            // lblIDB
            // 
            this.lblIDB.AutoSize = true;
            this.lblIDB.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDB.Location = new System.Drawing.Point(128, 159);
            this.lblIDB.Name = "lblIDB";
            this.lblIDB.Size = new System.Drawing.Size(80, 24);
            this.lblIDB.TabIndex = 40;
            this.lblIDB.Text = "BeaverID";
            // 
            // txtPostcodeB
            // 
            this.txtPostcodeB.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostcodeB.Location = new System.Drawing.Point(217, 473);
            this.txtPostcodeB.Name = "txtPostcodeB";
            this.txtPostcodeB.Size = new System.Drawing.Size(200, 32);
            this.txtPostcodeB.TabIndex = 39;
            // 
            // txtCountyB
            // 
            this.txtCountyB.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountyB.Location = new System.Drawing.Point(217, 435);
            this.txtCountyB.Name = "txtCountyB";
            this.txtCountyB.Size = new System.Drawing.Size(200, 32);
            this.txtCountyB.TabIndex = 38;
            // 
            // txtTownB
            // 
            this.txtTownB.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTownB.Location = new System.Drawing.Point(217, 397);
            this.txtTownB.Name = "txtTownB";
            this.txtTownB.Size = new System.Drawing.Size(200, 32);
            this.txtTownB.TabIndex = 37;
            // 
            // txtStreetB
            // 
            this.txtStreetB.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreetB.Location = new System.Drawing.Point(217, 359);
            this.txtStreetB.Name = "txtStreetB";
            this.txtStreetB.Size = new System.Drawing.Size(200, 32);
            this.txtStreetB.TabIndex = 36;
            // 
            // txtSurnameB
            // 
            this.txtSurnameB.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurnameB.Location = new System.Drawing.Point(217, 282);
            this.txtSurnameB.Name = "txtSurnameB";
            this.txtSurnameB.Size = new System.Drawing.Size(200, 32);
            this.txtSurnameB.TabIndex = 34;
            // 
            // txtForenameB
            // 
            this.txtForenameB.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForenameB.Location = new System.Drawing.Point(217, 244);
            this.txtForenameB.Name = "txtForenameB";
            this.txtForenameB.Size = new System.Drawing.Size(200, 32);
            this.txtForenameB.TabIndex = 33;
            // 
            // dpDob
            // 
            this.dpDob.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDob.Location = new System.Drawing.Point(217, 321);
            this.dpDob.Name = "dpDob";
            this.dpDob.Size = new System.Drawing.Size(200, 32);
            this.dpDob.TabIndex = 35;
            // 
            // lblPostCodeB
            // 
            this.lblPostCodeB.AutoSize = true;
            this.lblPostCodeB.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostCodeB.Location = new System.Drawing.Point(118, 481);
            this.lblPostCodeB.Name = "lblPostCodeB";
            this.lblPostCodeB.Size = new System.Drawing.Size(82, 24);
            this.lblPostCodeB.TabIndex = 32;
            this.lblPostCodeB.Text = "Postcode";
            // 
            // lblCountyB
            // 
            this.lblCountyB.AutoSize = true;
            this.lblCountyB.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountyB.Location = new System.Drawing.Point(128, 443);
            this.lblCountyB.Name = "lblCountyB";
            this.lblCountyB.Size = new System.Drawing.Size(72, 24);
            this.lblCountyB.TabIndex = 31;
            this.lblCountyB.Text = "County";
            // 
            // lblTownB
            // 
            this.lblTownB.AutoSize = true;
            this.lblTownB.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTownB.Location = new System.Drawing.Point(145, 405);
            this.lblTownB.Name = "lblTownB";
            this.lblTownB.Size = new System.Drawing.Size(55, 24);
            this.lblTownB.TabIndex = 30;
            this.lblTownB.Text = "Town";
            // 
            // lblStreetB
            // 
            this.lblStreetB.AutoSize = true;
            this.lblStreetB.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetB.Location = new System.Drawing.Point(145, 367);
            this.lblStreetB.Name = "lblStreetB";
            this.lblStreetB.Size = new System.Drawing.Size(57, 24);
            this.lblStreetB.TabIndex = 29;
            this.lblStreetB.Text = "Street";
            // 
            // lblDOBb
            // 
            this.lblDOBb.AutoSize = true;
            this.lblDOBb.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOBb.Location = new System.Drawing.Point(145, 329);
            this.lblDOBb.Name = "lblDOBb";
            this.lblDOBb.Size = new System.Drawing.Size(57, 24);
            this.lblDOBb.TabIndex = 28;
            this.lblDOBb.Text = "D.O.B";
            // 
            // lblSurnameB
            // 
            this.lblSurnameB.AutoSize = true;
            this.lblSurnameB.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurnameB.Location = new System.Drawing.Point(128, 290);
            this.lblSurnameB.Name = "lblSurnameB";
            this.lblSurnameB.Size = new System.Drawing.Size(80, 24);
            this.lblSurnameB.TabIndex = 27;
            this.lblSurnameB.Text = "Surname";
            // 
            // lblForenameB
            // 
            this.lblForenameB.AutoSize = true;
            this.lblForenameB.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForenameB.Location = new System.Drawing.Point(109, 252);
            this.lblForenameB.Name = "lblForenameB";
            this.lblForenameB.Size = new System.Drawing.Size(91, 24);
            this.lblForenameB.TabIndex = 26;
            this.lblForenameB.Text = "Forename";
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(505, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 43;
            this.label3.Text = "Allergens";
            // 
            // txtAllergens
            // 
            this.txtAllergens.Location = new System.Drawing.Point(509, 290);
            this.txtAllergens.Multiline = true;
            this.txtAllergens.Name = "txtAllergens";
            this.txtAllergens.Size = new System.Drawing.Size(288, 215);
            this.txtAllergens.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(524, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 45;
            this.label4.Text = "Class";
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(577, 172);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(206, 32);
            this.cmbClass.TabIndex = 46;
            // 
            // frmUpdateBeaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(967, 588);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAllergens);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ckCap);
            this.Controls.Add(this.cmbBeaverID);
            this.Controls.Add(this.lblIDB);
            this.Controls.Add(this.txtPostcodeB);
            this.Controls.Add(this.txtCountyB);
            this.Controls.Add(this.txtTownB);
            this.Controls.Add(this.txtStreetB);
            this.Controls.Add(this.txtSurnameB);
            this.Controls.Add(this.txtForenameB);
            this.Controls.Add(this.dpDob);
            this.Controls.Add(this.lblPostCodeB);
            this.Controls.Add(this.lblCountyB);
            this.Controls.Add(this.lblTownB);
            this.Controls.Add(this.lblStreetB);
            this.Controls.Add(this.lblDOBb);
            this.Controls.Add(this.lblSurnameB);
            this.Controls.Add(this.lblForenameB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.lblFnd);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblresetB);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateBeaver";
            this.Text = "Update Beaver";
            this.Load += new System.EventHandler(this.frmUpdateBeaver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnReset;
        private System.Windows.Forms.PictureBox btnUpdate;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblresetB;
        private System.Windows.Forms.Label lblFnd;
        private System.Windows.Forms.PictureBox btnFind;
        private System.Windows.Forms.PictureBox btnMainMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckCap;
        private System.Windows.Forms.ComboBox cmbBeaverID;
        private System.Windows.Forms.Label lblIDB;
        private System.Windows.Forms.TextBox txtPostcodeB;
        private System.Windows.Forms.TextBox txtCountyB;
        private System.Windows.Forms.TextBox txtTownB;
        private System.Windows.Forms.TextBox txtStreetB;
        private System.Windows.Forms.TextBox txtSurnameB;
        private System.Windows.Forms.TextBox txtForenameB;
        private System.Windows.Forms.DateTimePicker dpDob;
        private System.Windows.Forms.Label lblPostCodeB;
        private System.Windows.Forms.Label lblCountyB;
        private System.Windows.Forms.Label lblTownB;
        private System.Windows.Forms.Label lblStreetB;
        private System.Windows.Forms.Label lblDOBb;
        private System.Windows.Forms.Label lblSurnameB;
        private System.Windows.Forms.Label lblForenameB;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAllergens;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label4;
    }
}

