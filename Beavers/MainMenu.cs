using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beavers
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void mouseOver(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BorderStyle = BorderStyle.FixedSingle;
        }

        private void buttonClick(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BorderStyle = BorderStyle.Fixed3D;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddBeavers addBeaver = new frmAddBeavers();
            addBeaver.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateBeaver upDateBeaver = new frmUpdateBeaver();
            upDateBeaver.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteBeaver deleteBeaver = new frmDeleteBeaver();
            deleteBeaver.Show();
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAttendBeaver attendanceB = new frmAttendBeaver();
            attendanceB.Show();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUpdateDoctor updateDoc = new frmUpdateDoctor();
            updateDoc.Show();
        }

        private void displayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDisplay dispBeaver = new frmDisplay();
            dispBeaver.ChangeTab(0);
            dispBeaver.Show();
            
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDisplay disDoctor = new frmDisplay();
            disDoctor.ChangeTab(2);
            disDoctor.Show();
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Updating parent Feature is not implemented yet");
        }

        private void displayToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmDisplay disParent = new frmDisplay();
            disParent.ChangeTab(1);
            disParent.Show();
        }

        private void newAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAttendBeaver AttBeaver = new frmAttendBeaver();
            AttBeaver.Show();
        }

        private void displayToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmDisplay dispAttend = new frmDisplay();
            dispAttend.ChangeTab(4);
            dispAttend.Show();
        }
    }
}
