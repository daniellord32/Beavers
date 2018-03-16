namespace Beavers
{
    partial class frmAttendBeaver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAttendBeaver));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddB = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.PictureBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.lblresetB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbClassID = new System.Windows.Forms.ComboBox();
            this.dtpClass = new System.Windows.Forms.DateTimePicker();
            this.dgvBeaversAttendance = new System.Windows.Forms.DataGridView();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeaversAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attendance";
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
            // btnAddB
            // 
            this.btnAddB.Image = ((System.Drawing.Image)(resources.GetObject("btnAddB.Image")));
            this.btnAddB.Location = new System.Drawing.Point(386, 620);
            this.btnAddB.Name = "btnAddB";
            this.btnAddB.Size = new System.Drawing.Size(59, 53);
            this.btnAddB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddB.TabIndex = 18;
            this.btnAddB.TabStop = false;
            this.btnAddB.Click += new System.EventHandler(this.btnConfirm);
            this.btnAddB.MouseHover += new System.EventHandler(this.mouseOver);
            // 
            // btnReset
            // 
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(526, 620);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(59, 53);
            this.btnReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReset.TabIndex = 19;
            this.btnReset.TabStop = false;
            this.btnReset.Click += new System.EventHandler(this.buttonClick);
            this.btnReset.MouseHover += new System.EventHandler(this.mouseOver);
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.Location = new System.Drawing.Point(380, 676);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(78, 24);
            this.lblConfirm.TabIndex = 20;
            this.lblConfirm.Text = "Confirm";
            // 
            // lblresetB
            // 
            this.lblresetB.AutoSize = true;
            this.lblresetB.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresetB.Location = new System.Drawing.Point(532, 676);
            this.lblresetB.Name = "lblresetB";
            this.lblresetB.Size = new System.Drawing.Size(53, 24);
            this.lblresetB.TabIndex = 21;
            this.lblresetB.Text = "Reset";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Staff name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(629, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Date";
            // 
            // cmbClassID
            // 
            this.cmbClassID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClassID.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClassID.FormattingEnabled = true;
            this.cmbClassID.Items.AddRange(new object[] {
            "---select----"});
            this.cmbClassID.Location = new System.Drawing.Point(151, 156);
            this.cmbClassID.Name = "cmbClassID";
            this.cmbClassID.Size = new System.Drawing.Size(200, 32);
            this.cmbClassID.TabIndex = 25;
            this.cmbClassID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtpClass
            // 
            this.dtpClass.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpClass.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpClass.Location = new System.Drawing.Point(681, 153);
            this.dtpClass.Name = "dtpClass";
            this.dtpClass.Size = new System.Drawing.Size(200, 32);
            this.dtpClass.TabIndex = 26;
            // 
            // dgvBeaversAttendance
            // 
            this.dgvBeaversAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeaversAttendance.Location = new System.Drawing.Point(324, 201);
            this.dgvBeaversAttendance.Name = "dgvBeaversAttendance";
            this.dgvBeaversAttendance.Size = new System.Drawing.Size(390, 403);
            this.dgvBeaversAttendance.TabIndex = 27;
            this.dgvBeaversAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBeaversAttendance_CellContentClick);
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(486, 153);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(121, 32);
            this.cmbClass.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Class";
            // 
            // frmAttendBeaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1156, 709);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.dgvBeaversAttendance);
            this.Controls.Add(this.dtpClass);
            this.Controls.Add(this.cmbClassID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblresetB);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAttendBeaver";
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.frmAttendBeaver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeaversAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnReset;
        private System.Windows.Forms.PictureBox btnAddB;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label lblresetB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbClassID;
        private System.Windows.Forms.DateTimePicker dtpClass;
        private System.Windows.Forms.DataGridView dgvBeaversAttendance;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label4;
    }
}

