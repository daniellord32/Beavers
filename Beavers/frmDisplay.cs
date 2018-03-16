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
    public partial class frmDisplay : Form
    {

        SqlDataAdapter daBeaverClass, daDoctorData, daClass, daDoctorClass, daParentClass;
        SqlConnection conn;
        DataSet dsBeaversAdmin = new DataSet();
        SqlCommandBuilder cmdDoctorData,cmdBClass;
        SqlCommand cmdBeaverClass, cmdDoctorClass, cmdParentClass;
        DataRow drDoctorData, drClass, drBeaverClass, drDoctorClass, drParentClass;
        string connStr, sqlBeaverClass, sqlDoctorData, sqlClass, sqlDoctorClass, sqlParentClass;
        int firstFill = 0;

        public frmDisplay()
        {
            InitializeComponent();
        }

        private void frmDisplay_Load(object sender, EventArgs e)
        {
            
            /////Connecton for doctor///////

            connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = BeaversAdmin; Integrated Security = true";
            sqlDoctorData = @"select * from Doctor";
            daDoctorData = new SqlDataAdapter(sqlDoctorData, connStr);
            cmdDoctorData = new SqlCommandBuilder(daDoctorData);
            daDoctorData.FillSchema(dsBeaversAdmin, SchemaType.Source, "Doctor");
            daDoctorData.Fill(dsBeaversAdmin, "Doctor");
        
            ////// Connection for Class////////

            sqlClass = @"select * from Class";
            daClass = new SqlDataAdapter(sqlClass, connStr);
            cmdBClass = new SqlCommandBuilder(daClass);
            daClass.FillSchema(dsBeaversAdmin, SchemaType.Source, "Class");
            daClass.Fill(dsBeaversAdmin, "Class");

            selectClass();

            conn = new SqlConnection(connStr);

            //------------ dataGridView Beavers--------------//

            sqlBeaverClass = @"select b.Forename, b.Surname, b.Street, b.Town, b.County, b.Postcode from Beavers b where DateLeft is NULL and ClassID = @classID ORDER BY BeaverID";
            cmdBeaverClass = new SqlCommand(sqlBeaverClass, conn);
            cmdBeaverClass.Parameters.Add("@ClassID", SqlDbType.Int);
            daBeaverClass = new SqlDataAdapter(cmdBeaverClass);
            daBeaverClass.FillSchema(dsBeaversAdmin, SchemaType.Source, "BeaverClass");

            //------------ DataGridView Doctor--------------//

            sqlDoctorClass = @"select distinct d.Forename, d.Surname, d.Street, d.Town, d.County, d.Postcode from Doctor d join Beavers b on d.DoctorID = b.DoctorID";
            cmdDoctorClass = new SqlCommand(sqlDoctorClass, conn);
            daDoctorClass = new SqlDataAdapter(cmdDoctorClass);
            daDoctorClass.FillSchema(dsBeaversAdmin, SchemaType.Source, "DoctorClass");

            //------------ dataGridView Parents ------------//

            sqlParentClass = @"select distinct p.forname, p.surname, p.telNo, p.Email from parents p join Beavers b on p.ParentID = b.ParentID";
            cmdParentClass = new SqlCommand(sqlParentClass, conn);
            daParentClass = new SqlDataAdapter(cmdParentClass);
            daParentClass.FillSchema(dsBeaversAdmin, SchemaType.Source, "ParentClass");
        
        }

        public void ChangeTab(int tabIndex)
        {
            tabControl1.SelectedIndex = tabIndex;
        }

        private void selectClass()
        {
            try
            {
                cmbClass.DataSource = dsBeaversAdmin.Tables["Class"];
                cmbClass.DisplayMember = "forename";
                cmbClass.ValueMember = "classID";
            }
            catch (NullReferenceException nRE)
            {
                MessageBox.Show("No Classes in Database");
            }

        }

        private void cmbClass_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == Beavers)
            {
                int selectedCellCount = dgvBeavers.GetCellCount(DataGridViewElementStates.Selected);

                if (dgvBeavers.AreAllCellsSelected(false))
                {
                    MessageBox.Show("Cells are not selected", null);
                }
                else
                {
                    fillDgvDocs();
                    fillDgvParents();
                }
            }
            

        }

        private void fillDgvDocs()
        {
            daDoctorClass.Fill(dsBeaversAdmin, "DoctorClass");
            dgvDetailsDoc.DataSource = dsBeaversAdmin.Tables["DoctorClass"];
            dgvDetailsDoc.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void fillDgvParents()
        {
            daParentClass.Fill(dsBeaversAdmin, "ParentClass");
            dgcDetailsParent.DataSource = dsBeaversAdmin.Tables["ParentClass"];
            dgcDetailsParent.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstFill == 2)
            {
                dsBeaversAdmin.Tables["BeaverClass"].Clear();
          

                cmdBeaverClass.Parameters["@ClassID"].Value = Convert.ToInt32(cmbClass.SelectedValue);

                daBeaverClass.Fill(dsBeaversAdmin, "BeaverClass");

                dgvBeavers.DataSource = dsBeaversAdmin.Tables["BeaverClass"];

                dgvBeavers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            else
                firstFill ++;
        }

        
    }
}
