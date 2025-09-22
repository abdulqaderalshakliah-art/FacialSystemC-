using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.Reporting.WinForms;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class ReportsManagement : Form
    {
       
        
        public ReportsManagement()
        {
            InitializeComponent();
        }

        private void ReportsManagement_Load(object sender, EventArgs e)
        {

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            REP_VIEW ee = new REP_VIEW();
            try
            {
                

                string connectionString = DBconnection.conn;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Instructors";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // إعداد مصدر البيانات لـ ReportViewer
                    ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                    ee.reportViewer1.LocalReport.DataSources.Clear();
                    ee.reportViewer1.LocalReport.DataSources.Add(rds);
                    ee.reportViewer1.LocalReport.ReportPath = @"C:\Users\yahya\source\repos\FacialSystemC-\WindowsFormsApp1\InstructorsRep.rdlc"; 
                    ee.reportViewer1.RefreshReport();
                    ee.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("an error Accour: " + ex.Message);
            }
        }
    }
}
