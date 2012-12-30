using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EM
{
    public partial class EXPORT_UTILITY : Form
    {
       enum file_type {EXCEL,XML};
        public EXPORT_UTILITY()
        {
            InitializeComponent();
        }

        private void EXPORT_EXCEL_Click(object sender, EventArgs e)
        {
            this.saveFileDialog.InitialDirectory = Convert.ToString(Environment.SpecialFolder.MyDocuments);
            this.saveFileDialog.Filter = "Comma Seperated (*.CSV)|*.csv|Text File (*.TXT)|*.txt|All Files (*.*)|*.*"; 
            this.saveFileDialog.FilterIndex = 1; 

                if(this.saveFileDialog.ShowDialog() == DialogResult.OK) 
                {


                } 
        }

        private void EXPORT_XML_Click(object sender, EventArgs e)
        {

        }

        private void CANCEL_Click(object sender, EventArgs e)
        {

        }

    private void export ()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\uday\Documents\Visual Studio 2008\Projects\MM\MM\MM.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        con.Open();
        string query = @"select MONEY,REASON,[CREDIT/DEBIT] from MM where date ='" + dateTime + "'";
        SqlDataAdapter adp = new SqlDataAdapter(query, con);
        SqlCommandBuilder cmdb = new SqlCommandBuilder(adp);
        DataTable dT = new DataTable();
        adp.Fill(dT);
        BindingSource bs = new BindingSource();
        bs.DataSource = dT;
                        new excelfile    
                    DataGrid grid = new DataGrid();
                     grid.DataSource = bs; 
                    // render the DataGrid control to a file
                    using (StreamWriter sw = new StreamWriter("c:\\test.xls"))
                    {
                        using (HtmlTextWriter hw = new HtmlTextWriter(sw))
                        {
                            grid.RenderControl(hw);
                        }
                    }


    }
    }
}
