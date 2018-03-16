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
    public partial class frmUpdateBeaver : Form
    {

        SqlDataAdapter daBeaverData, daClassData;
        SqlConnection conn;
        DataSet dsBeaversAdmin = new DataSet();
        SqlCommandBuilder cmdBeaverData, cmdClassData;
        DataRow drBeaverData, drClassData;
        String connStr, sqlBeaverData, sqlClassData;

        Beavers myBeaver;
        Classes myClass;

        public frmUpdateBeaver()
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
            cmbBeaverID.SelectedIndex = -1;
            txtForenameB.Clear();
            txtSurnameB.Clear();
            txtStreetB.Clear();
            txtPostcodeB.Clear();
        }

        void setControls(bool option)
        {
            txtForenameB.Enabled = option;
            txtSurnameB.Enabled = option;
            txtStreetB.Enabled = option;
            txtTownB.Enabled = option;
            txtPostcodeB.Enabled = option;
            txtCountyB.Enabled = option;
            dpDob.Enabled = option;

        }

        private void Book_Click(object sender, EventArgs e)
        {
            myBeaver = new Beavers();
            myClass = new Classes();
            bool ok = true;
            paidCapitation();

            try
            {
                myClass.ClassID = Convert.ToInt32(cmbClass.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbClass, MyEx.toString());
            }
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
                myBeaver.Dob = dpDob.Value.Date;
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(dpDob, MyEx.toString());
            }
            try
            {
                if (ok)
                {
                    
                    drBeaverData.BeginEdit();

                    drBeaverData["Forename"] = myBeaver.Forename;
                    drBeaverData["Surname"] = myBeaver.Surname;
                    drBeaverData["DOB"] = myBeaver.Dob;
                    drBeaverData["ClassID"] = myClass.classID;
                    drBeaverData["Street"] = myBeaver.Street;
                    drBeaverData["Town"] = myBeaver.Town;
                    drBeaverData["Postcode"] = myBeaver.Postcode;
                    drBeaverData["County"] = myBeaver.County;
                    drBeaverData["Allergens"] = myBeaver.Allergens;
                    drBeaverData["Capitation"] = myBeaver.captiation;

                    drBeaverData.EndEdit();
                    daBeaverData.Update(dsBeaversAdmin, "Beavers");

                    MessageBox.Show("Beaver Details Updated", "Beavers");

                    setControls(false);
                    clearForm();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);

            }
        }

        private void Find_Beaver(object sender, EventArgs e)
        {
            if (cmbBeaverID.SelectedIndex == -1)
            {
                txtForenameB.Text = "";
                txtSurnameB.Text = "";
                txtStreetB.Text = "";
                txtTownB.Text = "";
                txtPostcodeB.Text = "";
                txtCountyB.Text = "";
                
            }
            else
            {
                
                foreach (DataRow dr in dsBeaversAdmin.Tables["Beavers"].Rows)
                {
                    if(dr["BeaverID"].ToString() == cmbBeaverID.Text)
                    {
                        txtForenameB.Text = dr["Forename"].ToString();
                        txtSurnameB.Text = dr["Surname"].ToString();
                        txtStreetB.Text = dr["Street"].ToString();
                        txtTownB.Text = dr["Town"].ToString();
                        txtCountyB.Text = dr["County"].ToString();
                        txtPostcodeB.Text = dr["Postcode"].ToString();
                        dpDob.Text = dr["DOB"].ToString(); 
                        
                    }
                    
                }

                
            }

            
        }
        

        private void frmUpdateBeaver_Load(object sender, EventArgs e)
        {
            //-------------------Connection for Beavers------------//
            connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = BeaversAdmin; Integrated Security = true";
            //conn = new SqlConnection(connStr);
            sqlBeaverData = @"select * from Beavers";          
            daBeaverData = new SqlDataAdapter(sqlBeaverData, connStr);
            cmdBeaverData = new SqlCommandBuilder(daBeaverData);
            daBeaverData.FillSchema(dsBeaversAdmin, SchemaType.Source, "Beavers");
            daBeaverData.Fill(dsBeaversAdmin, "Beavers");

            //---------------------Connection for Class--------------//

            connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = BeaversAdmin; Integrated Security = true";
            sqlClassData = @"select * from Class";
            daClassData = new SqlDataAdapter(sqlClassData, connStr);
            cmdClassData = new SqlCommandBuilder(daClassData);
            daClassData.FillSchema(dsBeaversAdmin, SchemaType.Source, "Class");
            daClassData.Fill(dsBeaversAdmin, "Class");

            conn = new SqlConnection(connStr);

            selectClass();
            try
            {
                drBeaverData = dsBeaversAdmin.Tables["Beavers"].Rows.Find(cmbBeaverID.SelectedIndex);

                foreach (DataRow dr in dsBeaversAdmin.Tables["Beavers"].Rows)
                {
                    Beavers Beaver = new Beavers();
                    Beaver.BeaverID = int.Parse(dr["BeaverID"].ToString());
                    cmbBeaverID.Items.Add(Beaver.BeaverID);
                }
            }
            catch (NullReferenceException nRE)
            {
                MessageBox.Show("No Beavers in Database");
            }

            int noRows = dsBeaversAdmin.Tables["Beavers"].Rows.Count;
            if (noRows == 0)
            {
                MessageBox.Show("No Beavers in system");
            }
            else
            {
                getNumber(noRows);
            }
        }

        private void getNumber(int noRows)
        {
            drBeaverData = dsBeaversAdmin.Tables["Beavers"].Rows[noRows - 1];
            cmbBeaverID.Text = (int.Parse(drBeaverData["BeaverID"].ToString()) + 1).ToString();
        }
        private void paidCapitation()
        {
            if(ckCap.Checked)
            {
                myBeaver.captiation = 'Y';
            }
            else
            {
                myBeaver.captiation = 'N';
            }
        }
        private void selectClass()
        {
            try
            {
                drClassData = dsBeaversAdmin.Tables["Class"].Rows.Find(cmbClass.SelectedIndex);

                foreach (DataRow dr in dsBeaversAdmin.Tables["Class"].Rows)
                {
                    Classes myClass = new Classes();
                    myClass.classID = int.Parse(dr["ClassID"].ToString());
                    cmbClass.Items.Add(myClass.classID);
                }
            }
            catch (NullReferenceException nRE)
            {
                MessageBox.Show("No Classes in Database");
            }

        }
    }
}
