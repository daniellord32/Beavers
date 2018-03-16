namespace Beavers
{
    partial class frmManageClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageClass));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstStaff = new System.Windows.Forms.ListBox();
            this.lstBeavers = new System.Windows.Forms.ListView();
            this.DogNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DogName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KennelNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstBeaver = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // lstStaff
            // 
            this.lstStaff.FormattingEnabled = true;
            this.lstStaff.Location = new System.Drawing.Point(685, 144);
            this.lstStaff.Name = "lstStaff";
            this.lstStaff.Size = new System.Drawing.Size(167, 225);
            this.lstStaff.TabIndex = 4;
            // 
            // lstBeavers
            // 
            this.lstBeavers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DogNo,
            this.DogName,
            this.KennelNo});
            this.lstBeavers.Location = new System.Drawing.Point(427, 385);
            this.lstBeavers.Name = "lstBeavers";
            this.lstBeavers.Size = new System.Drawing.Size(257, 211);
            this.lstBeavers.TabIndex = 8;
            this.lstBeavers.UseCompatibleStateImageBehavior = false;
            // 
            // DogNo
            // 
            this.DogNo.Text = "DogNo";
            // 
            // DogName
            // 
            this.DogName.Text = "Dog Name";
            // 
            // KennelNo
            // 
            this.KennelNo.Text = "Kennel No";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(737, 412);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 56);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Staff";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(737, 504);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 56);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove Staff";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(115, 193);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(197, 21);
            this.cmbClass.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select Class";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 269);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Day";
            // 
            // lstBeaver
            // 
            this.lstBeaver.FormattingEnabled = true;
            this.lstBeaver.Location = new System.Drawing.Point(427, 144);
            this.lstBeaver.Name = "lstBeaver";
            this.lstBeaver.Size = new System.Drawing.Size(167, 225);
            this.lstBeaver.TabIndex = 25;
            // 
            // frmManageClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1137, 733);
            this.Controls.Add(this.lstBeaver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.lstBeavers);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstStaff);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmManageClass";
            this.Text = "Add Beaver";
            this.Load += new System.EventHandler(this.frmManageClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstStaff;
        private System.Windows.Forms.ListView lstBeavers;
        private System.Windows.Forms.ColumnHeader DogNo;
        private System.Windows.Forms.ColumnHeader DogName;
        private System.Windows.Forms.ColumnHeader KennelNo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstBeaver;
    }
}

