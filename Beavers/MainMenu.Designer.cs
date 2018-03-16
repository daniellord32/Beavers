namespace Beavers
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.PictureBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.beaverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.parentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(264, 342);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(59, 53);
            this.btnReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReset.TabIndex = 19;
            this.btnReset.TabStop = false;
            this.btnReset.Click += new System.EventHandler(this.buttonClick);
            this.btnReset.MouseHover += new System.EventHandler(this.mouseOver);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(329, 357);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(41, 24);
            this.lblExit.TabIndex = 21;
            this.lblExit.Text = "Exit";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beaverToolStripMenuItem,
            this.doctorToolStripMenuItem,
            this.parentToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.attendanceToolStripMenuItem,
            this.suppliersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // beaverToolStripMenuItem
            // 
            this.beaverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.displayToolStripMenuItem1});
            this.beaverToolStripMenuItem.Name = "beaverToolStripMenuItem";
            this.beaverToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.beaverToolStripMenuItem.Text = "Beaver";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem1,
            this.displayToolStripMenuItem});
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.doctorToolStripMenuItem.Text = "Doctor";
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.updateToolStripMenuItem1.Text = "Update";
            this.updateToolStripMenuItem1.Click += new System.EventHandler(this.updateToolStripMenuItem1_Click);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.displayToolStripMenuItem.Text = "Display";
            this.displayToolStripMenuItem.Click += new System.EventHandler(this.displayToolStripMenuItem_Click);
            // 
            // displayToolStripMenuItem1
            // 
            this.displayToolStripMenuItem1.Name = "displayToolStripMenuItem1";
            this.displayToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.displayToolStripMenuItem1.Text = "Display";
            this.displayToolStripMenuItem1.Click += new System.EventHandler(this.displayToolStripMenuItem1_Click);
            // 
            // parentToolStripMenuItem
            // 
            this.parentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem2,
            this.displayToolStripMenuItem2});
            this.parentToolStripMenuItem.Name = "parentToolStripMenuItem";
            this.parentToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.parentToolStripMenuItem.Text = "Parent";
            // 
            // updateToolStripMenuItem2
            // 
            this.updateToolStripMenuItem2.Name = "updateToolStripMenuItem2";
            this.updateToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.updateToolStripMenuItem2.Text = "Update";
            this.updateToolStripMenuItem2.Click += new System.EventHandler(this.updateToolStripMenuItem2_Click);
            // 
            // displayToolStripMenuItem2
            // 
            this.displayToolStripMenuItem2.Name = "displayToolStripMenuItem2";
            this.displayToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.displayToolStripMenuItem2.Text = "Display";
            this.displayToolStripMenuItem2.Click += new System.EventHandler(this.displayToolStripMenuItem2_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.updateToolStripMenuItem3,
            this.deleteToolStripMenuItem1,
            this.displayToolStripMenuItem3});
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.staffToolStripMenuItem.Text = "Staff";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem1.Text = "Add";
            // 
            // updateToolStripMenuItem3
            // 
            this.updateToolStripMenuItem3.Name = "updateToolStripMenuItem3";
            this.updateToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.updateToolStripMenuItem3.Text = "Update";
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            // 
            // displayToolStripMenuItem3
            // 
            this.displayToolStripMenuItem3.Name = "displayToolStripMenuItem3";
            this.displayToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.displayToolStripMenuItem3.Text = "Display";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAttendanceToolStripMenuItem,
            this.displayToolStripMenuItem4});
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.suppliersToolStripMenuItem.Text = "Suppliers";
            // 
            // newAttendanceToolStripMenuItem
            // 
            this.newAttendanceToolStripMenuItem.Name = "newAttendanceToolStripMenuItem";
            this.newAttendanceToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.newAttendanceToolStripMenuItem.Text = "New Attendance";
            this.newAttendanceToolStripMenuItem.Click += new System.EventHandler(this.newAttendanceToolStripMenuItem_Click);
            // 
            // displayToolStripMenuItem4
            // 
            this.displayToolStripMenuItem4.Name = "displayToolStripMenuItem4";
            this.displayToolStripMenuItem4.Size = new System.Drawing.Size(162, 22);
            this.displayToolStripMenuItem4.Text = "Display";
            this.displayToolStripMenuItem4.Click += new System.EventHandler(this.displayToolStripMenuItem4_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(616, 508);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnReset;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem beaverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
    }
}

