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
    public partial class frmDeleteBeaver : Form
    {

        SqlDataAdapter daBeaverData;
        SqlConnection conn;
        DataSet dsBeaversAdmin = new DataSet();
        SqlCommandBuilder cmdBeaverData;
        DataRow drBeaverData;
        string connStr, sqlBeaverData;

        Beavers myBeaver;

        public frmDeleteBeaver()
        {
            InitializeComponent();
        }

        private void frmDeleteBeaver_Load(object sender, EventArgs e)
        {
            //-------------------Connection for Beavers------------//
            connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = BeaversAdmin; Integrated Security = true";
            //conn = new SqlConnection(connStr);
            sqlBeaverData = @"select * from Beavers";
            daBeaverData = new SqlDataAdapter(sqlBeaverData, connStr);
            cmdBeaverData = new SqlCommandBuilder(daBeaverData);
            daBeaverData.FillSchema(dsBeaversAdmin, SchemaType.Source, "Beavers");
            daBeaverData.Fill(dsBeaversAdmin, "Beavers");

            conn = new SqlConnection(connStr);

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

        private void getNumber(int noRows)
        {
            drBeaverData = dsBeaversAdmin.Tables["Beavers"].Rows[noRows - 1];
            cmbBeaverID.Text = (int.Parse(drBeaverData["BeaverID"].ToString()) + 1).ToString();
        }

        private void btnDeleteB_Click(object sender, EventArgs e)
        {
            bool ok = true;
            myBeaver = new Beavers();

                try
                {
                    myBeaver.DateLeft = dpDateLeft.Value.Date;
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(dpDateLeft, MyEx.toString());
                }
            
            if (ok)
            {
                 
                string tempName = drBeaverData["Forename"].ToString() + " " + drBeaverData["Surname"].ToString() + "\'s";

                if (MessageBox.Show("Are you sure you want to delete " + tempName + " details?", "add Beaver", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    drBeaverData = dsBeaversAdmin.Tables["Beavers"].Rows.Find(cmbBeaverID.SelectedItem);

                    drBeaverData.BeginEdit();

                    drBeaverData["DateLeft"] = myBeaver.DateLeft;

                    drBeaverData.EndEdit();
                    daBeaverData.Update(dsBeaversAdmin, "Beavers");

                    MessageBox.Show("Beaver Deleted", "Beavers");

                    clearForm();
                 }
            
            }
        }

        private void clearForm()
        {

            txtForenameB.Clear();
            txtForenameB.Clear();
            txtSurnameB.Clear();
            txtStreetB.Clear();
            txtTownB.Clear();
            txtCountyB.Clear();
            txtPostcodeB.Clear();
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

        private void populateBeavers(object sender, EventArgs e)
        {
            if (cmbBeaverID.SelectedIndex == -1)
            {
                txtForenameB.Text = "";
                txtSurnameB.Text = "";
                txtStreetB.Text = "";
                txtTownB.Text = "";
                txtCountyB.Text = "";
                txtPostcodeB.Text = "";
            }
            else
            {

                foreach (DataRow dr in dsBeaversAdmin.Tables["Beavers"].Rows)
                {
                    if (dr["BeaverID"].ToString() == cmbBeaverID.Text)
                    {
                        cmbBeaverID.Text = dr["BeaverID"].ToString();
                        txtForenameB.Text = dr["forename"].ToString();
                        txtSurnameB.Text = dr["surname"].ToString();
                        txtStreetB.Text = dr["Street"].ToString();
                        txtCountyB.Text = dr["County"].ToString();
                        txtPostcodeB.Text = dr["PostCode"].ToString();
                        dpDob.Text = dr["DOB"].ToString();

                    }

                }


            }


        }
    }
}
