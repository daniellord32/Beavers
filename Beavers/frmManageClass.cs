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
    public partial class frmManageClass : Form
    {

        SqlDataAdapter daBeaverData, daStaffData, daAttendance, daBeaverClass, daClassData;
        SqlConnection conn;
        DataSet dsBeaversAdmin = new DataSet();
        SqlCommandBuilder cmdBeaverData, cmdStaffData, cmdClassData;
        SqlCommand cmdParent, cmdAttendance, cmdBeaverClass;
        DataRow drBeaverData, drStaffData, drDoctorData, drClassData;
        string connStr, sqlBeaverData, sqlStaffData, sqlAttendance, sqlClassData;
        int firstFill = 0;

        public frmManageClass()
        {
            InitializeComponent();
        }

        private void frmManageClass_Load(object sender, EventArgs e)
        {

            //--------------Beaver Connection---------------------//
            connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = BeaversAdmin; Integrated Security = true";
            sqlBeaverData = @"select b.forename, b.surname from Beavers";
            daBeaverData = new SqlDataAdapter(sqlBeaverData, connStr);
            cmdBeaverData = new SqlCommandBuilder(daBeaverData);
            daBeaverData.FillSchema(dsBeaversAdmin, SchemaType.Source, "Beavers");
            daBeaverData.Fill(dsBeaversAdmin, "Beavers");

            //--------------Staff Connection-------------------//

            sqlStaffData = @"select * from Staff";
            daStaffData = new SqlDataAdapter(sqlBeaverData, connStr);
            cmdStaffData = new SqlCommandBuilder(daBeaverData);
            daStaffData.FillSchema(dsBeaversAdmin, SchemaType.Source, "Staff");
            daStaffData.Fill(dsBeaversAdmin, "Staff");

            //-------------- Class Connection--------------------------//

            sqlClassData = @"select * from Class";
            daClassData = new SqlDataAdapter(sqlClassData, connStr);
            cmdClassData = new SqlCommandBuilder(daClassData);
            daClassData.FillSchema(dsBeaversAdmin, SchemaType.Source, "Class");
            daClassData.Fill(dsBeaversAdmin, "Class");

            conn = new SqlConnection(connStr);

            selectClass();

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //fill Beaver ListView (double check correct class is selected


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

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstFill == 2)
            {
                dsBeaversAdmin.Tables["BeaverClass"].Clear();


                cmdBeaverClass.Parameters["@ClassID"].Value = Convert.ToInt32(cmbClass.SelectedValue);

                daBeaverClass.Fill(dsBeaversAdmin, "Beaver");

                lstBeaver.DataSource = dsBeaversAdmin.Tables["Beaver"];
                lstBeaver.DisplayMember = "forename";
                lstBeaver.ValueMember = "beaverID";
            }
            else
                firstFill++;
        }
    }
}
