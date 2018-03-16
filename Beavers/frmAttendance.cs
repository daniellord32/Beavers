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
    public partial class frmAttendBeaver : Form
    {

        SqlDataAdapter daBeaverData,daBAttendance , daClassData, daAttendance;
        SqlConnection conn;
        DataSet dsBeaversAdmin = new DataSet();
        SqlCommandBuilder cmdBeaverData, cmdClassData,cmdBAttendance;
        SqlCommand cmdAttendance, cmdClassData1;
        DataRow drBAttendance;
        string connStr, sqlBeaverData, sqlBAttendance,sqlClassData, sqlAttendance;
        int firstFill = 0;

        private int chkPaid;
        private int chkAttended;
        private string beaverID;

        public frmAttendBeaver()
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

        private void frmAttendBeaver_Load(object sender, EventArgs e)
        {

            //-------Beaver Connection-------//

            connStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = BeaversAdmin; Integrated Security = true";
            conn = new SqlConnection(connStr);

            sqlClassData = @"select s.Staffid, (s.forename + ' ' + s.surname) as Name, c.ClassID from staff s inner join StaffClass c ON s.staffID = c.staffID";
            cmdClassData1 = new SqlCommand(sqlClassData, conn);
            daClassData = new SqlDataAdapter(cmdClassData1);
            cmdClassData = new SqlCommandBuilder(daClassData);
            daClassData.FillSchema(dsBeaversAdmin, SchemaType.Source, "StaffClass");
            daClassData.Fill(dsBeaversAdmin, "StaffClass");

            selectClass();
            


            //------------- attendance Data Grid View ---------------//

            sqlAttendance = @"select distinct b.beaverID, b.forename, b.surname from Beavers b JOIN Class c on b.ClassID = @ClassID ORDER BY BeaverID";
            cmdAttendance = new SqlCommand(sqlAttendance, conn);
            cmdAttendance.Parameters.Add("@ClassID", SqlDbType.Int);
            daAttendance = new SqlDataAdapter(cmdAttendance);
            daAttendance.FillSchema(dsBeaversAdmin, SchemaType.Source, "BeaverAttendance");

            sqlBAttendance = @"select * from Attendance";
            daBAttendance = new SqlDataAdapter(sqlBAttendance, connStr);
            cmdBAttendance = new SqlCommandBuilder(daBAttendance);
            daBAttendance.FillSchema(dsBeaversAdmin, SchemaType.Source, "Attendance");
            daBAttendance.Fill(dsBeaversAdmin, "Attendance");





        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (firstFill == 2)
            {
                dsBeaversAdmin.Tables["BeaverAttendance"].Clear();

                setClass(); //allows the class to be selected to display beavers and save data to database.

                cmdAttendance.Parameters["@ClassID"].Value = cmbClassID.SelectedValue.ToString();

                daAttendance.Fill(dsBeaversAdmin, "BeaverAttendance");

                dgvBeaversAttendance.DataSource = dsBeaversAdmin.Tables["BeaverAttendance"];

                dgvBeaversAttendance.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                DataGridViewCheckBoxColumn weekPaid = new DataGridViewCheckBoxColumn();
                weekPaid.Name = "WeekPaid";
                weekPaid.HeaderText = "WeekPaid";
                weekPaid.Width = 60;
                weekPaid.ReadOnly = false;
                weekPaid.FillWeight = 10; //if the datagridview is resized (on form resize) the checkbox won't take up too much; value is relative to the other columns' fill values
                dgvBeaversAttendance.Columns.Add(weekPaid);

                DataGridViewCheckBoxColumn Attended = new DataGridViewCheckBoxColumn();
                Attended.Name = "Attended";
                Attended.HeaderText = "Attended";
                Attended.Width = 60;
                Attended.ReadOnly = false;
                Attended.FillWeight = 10; //if the datagridview is resized (on form resize) the checkbox won't take up too much; value is relative to the other columns' fill values
                dgvBeaversAttendance.Columns.Add(Attended);
            }
            else
                firstFill++;
        }


        private void selectClass()
        {
            try
            {
                cmbClassID.DataSource = dsBeaversAdmin.Tables["StaffClass"];
                cmbClassID.ValueMember = "ClassID";
                cmbClassID.DisplayMember = "Name";
            }
            catch (NullReferenceException nRE)
            {
                MessageBox.Show("No Classes in Database");
            }

        }

        private void setClass()
        {
            cmbClass.DataSource = dsBeaversAdmin.Tables["StaffClass"];
            cmbClass.ValueMember = "StaffID";
            cmbClass.DisplayMember = "Name";
        }

        

        
        private void btnConfirm(object sender, EventArgs e)
        {
           
             if (dtpClass.Capture.Equals("Tuesday") || dtpClass.Capture.Equals("Wednesday"))
            {
                MessageBox.Show("No classes on that day!");
            }
             else
            {
                   

                    foreach (DataGridViewRow row in dgvBeaversAttendance.Rows)
                    {
                        drBAttendance = dsBeaversAdmin.Tables["Attendance"].NewRow();

                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[3];
                        DataGridViewCheckBoxCell chkA = (DataGridViewCheckBoxCell)row.Cells[4];

                        if (row.Cells[0].Value != null)
                        {
                            beaverID = row.Cells[0].Value.ToString();
                        }


                        if (Convert.ToBoolean(chk.Value) == false)
                        {
                            chkPaid = 0;
                            drBAttendance["weekPaid"] = chkPaid;
                        }
                        else
                            chkPaid = 1;
                        drBAttendance["weekPaid"] = chkPaid;

                        if (Convert.ToBoolean(chkA.Value) == false)
                        {
                            chkAttended = 0;
                            drBAttendance["attended"] = chkAttended;
                        }
                        else
                        {
                            chkAttended = 1;
                            drBAttendance["attended"] = chkAttended;
                        }
                        drBAttendance["DateAtt"] = dtpClass.Value.ToShortDateString();
                        drBAttendance["BeaverID"] = beaverID;
                        drBAttendance["StaffID"] = int.Parse(cmbClass.SelectedValue.ToString());

                    }

                    dsBeaversAdmin.Tables["Attendance"].Rows.Add(drBAttendance);
                    daBAttendance.Update(dsBeaversAdmin, "Attendance");

            }
            
        }

       

        private void dgvBeaversAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<DataGridViewRow> rows_with_checked_column = new List<DataGridViewRow>();
            
                // cant delete makes program unusable.
        }

    }
}
