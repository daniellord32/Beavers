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
    public partial class frmAddBeavers : Form
    {

        SqlDataAdapter daBeaverData, daParentData, daDoctorData, daClassData;
        SqlConnection conn;
        DataSet dsBeaversAdmin = new DataSet();
        SqlCommandBuilder cmdBeaverData, cmdParentData, cmdDoctorData, cmdClassData;
        SqlCommand cmdParent;
        DataRow drBeaverData, drParentData, drDoctorData, drClassData;
        string connStr, sqlBeaverData, sqlParentData, sqlDoctorData, sqlClassData;

        Beavers myBeaver;

        public frmAddBeavers()
        {
            InitializeComponent();

            pnlExParent.Enabled = false;
            pnlNewParent.Enabled = false;

        }

        private void mouseOver(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BorderStyle = BorderStyle.FixedSingle;
        }

        private void buttonAdd(object sender, EventArgs e)
        {
            
        }

        private void frmAddBeaver_Load(object sender, EventArgs e)
        {

            
            
            //////Connection for Beavers///////

            connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = BeaversAdmin; Integrated Security = true";
            conn = new SqlConnection(connStr);
            sqlBeaverData = @"select * from Beavers";
            daBeaverData = new SqlDataAdapter(sqlBeaverData, conn);
            cmdBeaverData = new SqlCommandBuilder(daBeaverData);
            daBeaverData.FillSchema(dsBeaversAdmin, SchemaType.Source, "Beavers");
            daBeaverData.Fill(dsBeaversAdmin, "Beavers");

            ////Connection for Parents//////

            
            sqlParentData = @"select * from Parents";
            daParentData = new SqlDataAdapter(sqlParentData, conn);
            cmdParentData = new SqlCommandBuilder(daParentData);
            daParentData.FillSchema(dsBeaversAdmin, SchemaType.Source, "Parents");
            daParentData.Fill(dsBeaversAdmin, "Parents");

            /////Connecton for doctor///////

            
            sqlDoctorData = @"select * from Doctor";
            daDoctorData = new SqlDataAdapter(sqlDoctorData, conn);
            cmdDoctorData = new SqlCommandBuilder(daDoctorData);
            daDoctorData.FillSchema(dsBeaversAdmin, SchemaType.Source, "Doctor");
            daDoctorData.Fill(dsBeaversAdmin, "Doctor");

            ////// Connection for Class////////

            
            sqlClassData = @"select s.Staffid, (s.forename + ' ' + s.surname) as Name, c.ClassID from staff s inner join StaffClass c ON s.staffID = c.staffID";
            daClassData = new SqlDataAdapter(sqlClassData, conn);
            cmdClassData = new SqlCommandBuilder(daClassData);
            daClassData.FillSchema(dsBeaversAdmin, SchemaType.Source, "Class");
            daClassData.Fill(dsBeaversAdmin, "Class");

            

            selectClass();

            int noRows = dsBeaversAdmin.Tables["Beavers"].Rows.Count;
            if (noRows == 0)
            {
                txtBeaverID.Text = "1";
                
            }
            else
            {
                getNumber(noRows);
            }
            
            int noRows2 = dsBeaversAdmin.Tables["Doctor"].Rows.Count;
            if (noRows2 == 0)
            {
                txtDoctorID.Text = "100";
            }
            else
            {
                getNumber(noRows2);
            }
        }

        public void buttonClick(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BorderStyle = BorderStyle.Fixed3D;
            bool ok = true;
            errP.Clear();


            Classes myClass = new Classes();
            errP.Clear();

            try
            {
                myClass.ClassID = int.Parse(cmbClass.SelectedValue.ToString());
            }
            catch(MyException myEx)
            {
                ok = false;
                errP.SetError(txtForenameP, myEx.toString());
            }

            //******************************************Adding parents tab **************************************************

            Parents myParent = new Parents();
            errP.Clear();
            //if (!Validation.validLength(txtSurname, errP, 2, 60))
            //    ok = false;
            //else if (!Validation.validNumber(txtStreet.Text))
            //    ok = false;

            
            try
            {
                myParent.Forename = txtForenameP.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtForenameP, MyEx.toString());
            }
            try
            {
                myParent.Surname = txtSurnameP.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtSurnameP, MyEx.toString());
            }
            try
            {
                myParent.TelNo = txtTelNoP.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtTelNoP, MyEx.toString());
            }
            if (rBNewP.Checked)
            {
                try
                {

                    drParentData = dsBeaversAdmin.Tables["Parents"].NewRow();

                    drParentData["ParentID"] = myParent.ParentID;
                    drParentData["Forname"] = myParent.Forename;
                    drParentData["Surname"] = myParent.Surname;
                    drParentData["TelNo"] = myParent.TelNo;
                    drParentData["Email"] = myParent.Email;
                    drParentData["Volunteer"] = myParent.Volunteer;

                    dsBeaversAdmin.Tables["Parents"].Rows.Add(drParentData);
                    daParentData.Update(dsBeaversAdmin, "Parents");
                }
                catch (Exception ex)
                {
                    ok = false;
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }
            }


                //*********************************************** Add Doctor Tab ***********************************************

                Doctors myDoctor = new Doctors();
                errP.Clear();
            //if (!Validation.validLength(txtSurname, errP, 2, 60))
            //    ok = false;
            //else if (!Validation.validNumber(txtStreet.Text))
            //    ok = false;

                try
                {
                    myDoctor.DoctorID = Convert.ToInt32(txtDoctorID.Text.Trim());
                }
                catch(MyException MyEx)
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
                    myDoctor.TelNo = txtTelNoP.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtTelNoP, MyEx.toString());
                }
                if (rbNewD.Checked && ok == true)
                {
                    try
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
                    catch (Exception ex)
                    {
                        ok = false;
                        MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                    }
                }


                    //*************************Adding Beavers tab******************************************

                    myBeaver = new Beavers();
                    paidCapitation();
            
                    try
                    {
                        myBeaver.Forename = txtForenameB.Text.Trim();
                    }
                    catch (MyException MyEx)
                    {
                        ok = false;
                        errP.SetError(txtForenameB, MyEx.toString());
                    }
                    try
                    {
                        myBeaver.Surname = txtSurnameB.Text.Trim();
                    }
                    catch (MyException MyEx)
                    {
                        ok = false;
                        errP.SetError(txtSurnameB, MyEx.toString());
                    }
                    try
                    {
                        myBeaver.Street = txtStreetB.Text.Trim();
                    }
                    catch (MyException MyEx)
                    {
                        ok = false;
                        errP.SetError(txtStreetB, MyEx.toString());
                    }
                    try
                    {
                        myBeaver.Town = txtTownB.Text.Trim();
                    }
                    catch (MyException MyEx)
                    {
                        ok = false;
                        errP.SetError(txtTownB, MyEx.toString());
                    }
                    try
                    {
                        myBeaver.County = txtCountyB.Text.Trim();
                    }
                    catch (MyException MyEx)
                    {
                        ok = false;
                        errP.SetError(txtCountyB, MyEx.toString());
                    }
                    try
                    {
                        myBeaver.Postcode = txtPostcodeB.Text.Trim();
                    }
                    catch (MyException MyEx)
                    {
                        ok = false;
                        errP.SetError(txtPostcodeB, MyEx.toString());
                    }
                    try
                    {

                        DateTime DOB = DateTime.ParseExact(dpDob.Text.Trim(), "dd/MM/yyyy", null);
                        myBeaver.Dob = DOB;
                    }
                    catch (MyException MyEx)
                    {
                        ok = false;
                        errP.SetError(dpDob, MyEx.toString());
                    }

                    try
                    {
                        if ( dpStartDate.Capture.Equals ("Tuesday") || dpStartDate.Capture.Equals("Wednesday"))
                        {
                            MessageBox.Show("Start date ok");
                        }
                    }
                    catch (MyException MyEx)
                    {
                        ok = false;
                        errP.SetError(dpStartDate, MyEx.toString());
                    }
                    try
                    {
                        if (ok)
                        {
                                drBeaverData = dsBeaversAdmin.Tables["Beavers"].NewRow();

                            drBeaverData["DoctorID"] = myDoctor.DoctorID;
                            drBeaverData["BeaverID"] = myBeaver.BeaverID;
                            drBeaverData["ParentID"] = cmbExistingP.SelectedIndex;
                            drBeaverData["Forename"] = myBeaver.Forename;
                            drBeaverData["Surname"] = myBeaver.Surname;
                            drBeaverData["DOB"] = myBeaver.Dob;
                            drBeaverData["DateStart"] = myBeaver.startDate;
                            drBeaverData["Street"] = myBeaver.Street;
                            drBeaverData["Town"] = myBeaver.Town;
                            drBeaverData["County"] = myBeaver.County;
                            drBeaverData["Postcode"] = myBeaver.Postcode;
                            drBeaverData["Allergens"] = myBeaver.Allergens;
                            drBeaverData["Capitation"] = myBeaver.captiation;
                            drBeaverData["ClassID"] = int.Parse(cmbClass.SelectedValue.ToString());
                            

                            dsBeaversAdmin.Tables["Beavers"].Rows.Add(drBeaverData);
                            daBeaverData.Update(dsBeaversAdmin, "Beavers");

                            MessageBox.Show("Beaver Added" + myBeaver.Forename);

                            if (MessageBox.Show("Do you wish to add another Beaver?", "Add Beaver", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                            {
                                clearForm();
                                getNumber(dsBeaversAdmin.Tables["Beavers"].Rows.Count);
                            }
                            else
                                this.Close();
                        }

                    }
                    catch (Exception ex)
                    {
                        ok = false;
                        MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);

                    }

                }
            
        

        


        private void existingParent(object sender, EventArgs e)
        {
            if (RBExistingP.Checked)
            {
                cmbExistingP.SelectedIndex = -1;
                pnlExParent.Enabled = true;
                pnlNewParent.Enabled = false;
                selectParent();
                
            }
            else if (rBNewP.Checked)
            {
                pnlExParent.Enabled = false;
                pnlNewParent.Enabled = true;
                newParent();
            }
        }
        private void existingDoctor(object sender, EventArgs e)
        {
            if (rBExistingD.Checked)
            {
                pnlExDoc.Enabled = true;
                pnlNewDoc.Enabled = false;
                selectDocotr();
            }
            else if (rbNewD.Checked)
            {
                pnlNewDoc.Enabled = true;
                pnlExDoc.Enabled = false;
                newDoctor();
            }
        }

        private void paidCapitation()
        {
            if(cbCap.Checked)
            {
                myBeaver.captiation = 1;
            }
            else
            {
                myBeaver.captiation = 0;
            }
        }

        private void getNumber(int noRows)
        {
            drBeaverData = dsBeaversAdmin.Tables["Beavers"].Rows[noRows - 1];
            txtBeaverID.Text = (int.Parse(drBeaverData["BeaverID"].ToString()) + 1).ToString();
        }
        private void getNumberParents(int noRows)
        {
            drBeaverData = dsBeaversAdmin.Tables["Parents"].Rows[noRows - 1];
            txtParentID.Text = (int.Parse(drBeaverData["ParentID"].ToString()) + 1).ToString();
        }
        private void getNumberDoctor(int noRows)
        {
            drBeaverData = dsBeaversAdmin.Tables["Doctor"].Rows[noRows - 1];
            txtDoctorID.Text = (int.Parse(drBeaverData["DoctorID"].ToString()) + 1).ToString();
        }

        private void clearForm()
        {

            txtForenameB.Clear();
            txtForenameB.Clear();
            txtSurnameB.Clear();
            txtStreetB.Clear();
            txtTownB.Clear();
            txtCountyB.Clear();
        }

        private void selectClass()
        {
            try
            {
                cmbClass.DataSource = dsBeaversAdmin.Tables["Class"];
                cmbClass.ValueMember = "ClassID";
                cmbClass.DisplayMember = "Name";
            }
            catch(NullReferenceException nRE)
            {
                MessageBox.Show("No Classes in Database");
            }

         }
            
       
        private void selectParent()
        {
            try
            {
                drParentData = dsBeaversAdmin.Tables["Parents"].Rows.Find(cmbExistingP.SelectedIndex);

                foreach (DataRow dr in dsBeaversAdmin.Tables["Parents"].Rows)
                {
                    Parents parent = new Parents();
                    parent.ParentID = int.Parse(dr["ParentID"].ToString());
                    cmbExistingP.Items.Add(parent.ParentID);
                }
            }
            catch(NullReferenceException nRE)
            {
                MessageBox.Show("No Parents in Database");
            }
            
        }

        private void populateParents(object sender, EventArgs e)
        {
            if (cmbExistingP.SelectedIndex == -1)
            {
                txtForenameP.Text = "";
                txtSurnameP.Text = "";
                txtEmailP.Text = "";
                txtTelNoP.Text = "";
            }
            else
            {
                
                foreach (DataRow dr in dsBeaversAdmin.Tables["Parents"].Rows)
                {
                    if(dr["ParentID"].ToString() == cmbExistingP.Text)
                    {
                        txtParentID.Text = dr["ParentID"].ToString();
                        txtForenameP.Text = dr["forname"].ToString();
                        txtSurnameP.Text = dr["surname"].ToString();
                        txtEmailP.Text = dr["email"].ToString();
                        txtTelNoP.Text = dr["telNo"].ToString();
                    }
                    
                }

                
            }

            
        }
        private void newParent()
        {
            int noRows1 = dsBeaversAdmin.Tables["Parents"].Rows.Count;
            if (noRows1 == 0)
            {
                txtParentID.Text = "200";
            }
            else
            {
                getNumberParents(noRows1);
            }
        }
        private void selectDocotr()
        {
            try
            {
                foreach (DataRow dr in dsBeaversAdmin.Tables["Doctor"].Rows)
                {
                    Doctors doctor = new Doctors();
                    doctor.DoctorID = int.Parse(dr["DoctorID"].ToString());
                    cmbExistingD.Items.Add(doctor.DoctorID);
                    
                }
            }
            catch (NullReferenceException nRE)
            {
                MessageBox.Show("No Doctors in Database");
            }
        }

        private void populateDoctor(object sender, EventArgs e)
        {
            if (cmbExistingD.SelectedIndex < 0)
            {
                MessageBox.Show("No information to display");
            }
            else
            {
                DataSet ds = new DataSet();
                foreach (DataRow dr in dsBeaversAdmin.Tables["Doctor"].Rows)
                {
                    if (dr["DoctorID"].ToString() == cmbExistingD.Text)
                    {
                        txtDoctorID.Text = dr["DoctorID"].ToString();
                        txtForenameD.Text = dr["forename"].ToString();
                        txtSurnameD.Text = dr["surname"].ToString();
                        txtStreetD.Text = dr["Street"].ToString();
                        txtTownD.Text = dr["Town"].ToString();
                        txtCountyD.Text = dr["County"].ToString();
                        txtPostcodeD.Text = dr["Postcode"].ToString();
                        txtTelNoD.Text = dr["telNo"].ToString();
                    }

                }

            }
        }

        private void newDoctor()
        {
            int noRows2 = dsBeaversAdmin.Tables["Doctor"].Rows.Count;
            if (noRows2 == 0)
            {
                txtParentID.Text = "300";
            }
            else
            {
                getNumberDoctor(noRows2);
            }
        }
        private void checkedBox(object sender, EventArgs e)
        {
            Parents myparents = new Parents();

            if (cbVolunteer.Checked)
            {
                myparents.Volunteer = 'Y';
            }
            else
                myparents.Volunteer = 'N';
        }

    }
}
