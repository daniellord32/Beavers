using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Beavers
{
    public partial class frmUpdateDoctor : Form
    {
        SqlDataAdapter daBeaverData, daDoctorData;
        SqlConnection conn;
        DataSet dsBeaversAdmin = new DataSet();
        SqlCommandBuilder cmdBeaverData, cmdDoctorData;
        DataRow drBeaverData, drDoctorData;
        String connStr, sqlBeaverData, sqDoctorData;

        Doctors myDoctor;

        private void btnAddB_Click(object sender, EventArgs e)
        {
            myDoctor = new Doctors();
            bool ok = true;

            try
            {
                myDoctor.DoctorID = Convert.ToInt32(txtDoctorID.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtDoctorID, MyEx.toString());
            }
            try
            {
                myDoctor.Forename = txtForenameD.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtForenameD, MyEx.toString());
            }
            try
            {
                myDoctor.Surname = txtSurnameD.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtSurnameD, MyEx.toString());
            }
            try
            {
                myDoctor.Street = txtStreetD.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtStreetD, MyEx.toString());
            }
            try
            {
                myDoctor.Town = txtTownD.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtTownD, MyEx.toString());
            }
            try
            {
                myDoctor.County = txtCountyD.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtCountyD, MyEx.toString());
            }
            try
            {
                myDoctor.Postcode = txtPostcodeD.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtPostcodeD, MyEx.toString());
            }
            try
            {
                myDoctor.TelNo = txtTelNoD.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtTelNoD, MyEx.toString());
            }
            try
            {
                if (ok)
                {
                    drDoctorData = dsBeaversAdmin.Tables["Doctor"].NewRow();


                    drDoctorData["Forename"] = myDoctor.Forename;
                    drDoctorData["Surname"] = myDoctor.Surname;
                    drDoctorData["Street"] = myDoctor.Street;
                    drDoctorData["Town"] = myDoctor.Town;
                    drDoctorData["County"] = myDoctor.County;
                    drDoctorData["Postcode"] = myDoctor.Postcode;
                    drDoctorData["TelNo"] = myDoctor.TelNo;


                    dsBeaversAdmin.Tables["Doctor"].Rows.Add(drDoctorData);
                    daDoctorData.Update(dsBeaversAdmin, "Doctor");
                }

            }
            catch (Exception ex)
            {
                ok = false;
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void frmUpdateDoctor_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = BeaversAdmin; Integrated Security = true";
            conn = new SqlConnection(connStr);

            selectDoctor();
        }

        private void selectDoctor()
        {
            foreach (DataRow dr in dsBeaversAdmin.Tables["Parents"].Rows)
            {
                if (dr["DoctorID"].ToString() == cmbExistingD.Text)
                {
                    txtDoctorID.Text = dr["ParentID"].ToString();
                    txtForenameD.Text = dr["forname"].ToString();
                    txtSurnameD.Text = dr["surname"].ToString();
                    txtStreetD.Text = dr["Street"].ToString();
                    txtTownD.Text = dr["Town"].ToString();
                    txtCountyD.Text = dr["County"].ToString();
                    txtPostcodeD.Text = dr["Postcode"].ToString();
                    txtTelNoD.Text = dr["telNo"].ToString();
                }

            }
        }

        public frmUpdateDoctor()
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

        void clearForm()
        {
            cmbExistingD.SelectedIndex = -1;
            txtForenameD.Clear();
            txtSurnameD.Clear();
            txtStreetD.Clear();
            txtTownD.Clear();
            txtCountyD.Clear();
            txtPostcodeD.Clear();
            txtTelNoD.Clear();
        }

        void setControls(bool option)
        {
            txtForenameD.Enabled = option;
            txtSurnameD.Enabled = option;
            txtStreetD.Enabled = option;
            txtTownD.Enabled = option;
            txtPostcodeD.Enabled = option;
            txtCountyD.Enabled = option;
            txtTelNoD.Enabled = option;
        }


    }


}
