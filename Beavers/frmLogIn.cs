﻿using System;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
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

        /*private void fromLoginClass_Load(object sender, EventArgs e)
        {
            
        }*/

        private void tlPassword_Popup(object sender, PopupEventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnLogin, "Login");
        }
    }
}
