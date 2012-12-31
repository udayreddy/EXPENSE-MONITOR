using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;

namespace MM
{
    public partial class EM : Form
    {
        DataTable dt;
        SqlDataAdapter da;
        SqlCommandBuilder cb;
        SqlConnection con;
        bool unsaved = false;
        public EM()
        {
            try
            {
                InitializeComponent();
                this.DisplayGrid(this.CALENDAR.TodayDate);
                this.fillStats(this.CALENDAR.TodayDate);
                this.CALENDAR.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.CALENDAR_DateSelected);
                this.CALENDAR.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CALENDAR_DateChanged);               
                this.CashGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.CashGrid_DataError);
                this.CashGrid.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(CashGrid_EditingControlShowing);
                this.CashGrid.CellValueChanged += new DataGridViewCellEventHandler(CashGrid_CellValueChanged);
                this.CashGrid.CurrentCellDirtyStateChanged += new EventHandler(CashGrid_CurrentCellDirtyStateChanged);
            }
            catch (Exception ex)
            {

            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (unsaved == true)
            {
                DialogResult result = MessageBox.Show("SAVE CHANGES ?", "SAVE", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.save_items(e);
                }
                else if (result == DialogResult.No)
                {

                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
        private object getstat(string query, SqlConnection con)
        {
            con.Open();
            da = new SqlDataAdapter(query, con);
            DataTable MM = new DataTable();
            da.Fill(MM);
            object totalCount = MM.Compute("Sum(MONEY)", "");
            con.Close();
            return totalCount;
        }

        private void fillStats(DateTime dateTime)
        {
       try
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\uday\Documents\Visual Studio 2008\Projects\MM\MM\MM.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
                string query_year_credit = @"SELECT * FROM MM WHERE YEAR(DATE) = '" + dateTime.Year + "' and [CREDIT/DEBIT] = 'INCOME'";
                string query_month_credit = @"SELECT * FROM MM WHERE MONTH(DATE) = '" + dateTime.Month + "' and [CREDIT/DEBIT] = 'INCOME'";
                string query_day_credit = @"SELECT * FROM MM WHERE DATE = '" + dateTime + "' and [CREDIT/DEBIT] = 'INCOME'";
                string query_year_debit = @"SELECT * FROM MM WHERE YEAR(DATE) = '" + dateTime.Year + "' and [CREDIT/DEBIT] = 'EXPENSE'";
                string query_month_debit = @"SELECT * FROM MM WHERE MONTH(DATE) = '" + dateTime.Month + "' and [CREDIT/DEBIT] = 'EXPENSE'";
                string query_day_debit = @"SELECT * FROM MM WHERE DATE = '" + dateTime + "' and [CREDIT/DEBIT] = 'EXPENSE'";
                string query_year_saving = @"SELECT * FROM MM WHERE YEAR(DATE) = '" + dateTime.Year + "' and [CREDIT/DEBIT] = 'SAVINGS'";
                string query_month_saving = @"SELECT * FROM MM WHERE MONTH(DATE) = '" + dateTime.Month + "' and [CREDIT/DEBIT] = 'SAVINGS'";
                string query_day_saving = @"SELECT * FROM MM WHERE DATE = '" + dateTime + "' and [CREDIT/DEBIT] = 'SAVINGS'";
     

                this.day_credit.Clear();
                this.month_credit.Clear();
                this.year_credit.Clear();

                this.day_debit.Clear();
                this.month_debit.Clear();
                this.year_debit.Clear();
                
                this.day_saving.Clear();
                this.month_saving.Clear();
                this.year_saving.Clear();

                object y_d = getstat(query_year_debit,con);
                object m_d = getstat(query_month_debit,con);
                object d_d = getstat(query_day_debit,con);
                object y_c = getstat(query_year_credit,con);
                object m_c = getstat(query_month_credit,con);
                object d_c = getstat(query_day_credit,con);
                object y_s = getstat(query_year_saving,con);
                object m_s = getstat(query_month_saving,con);
                object d_s = getstat(query_day_saving,con);

                this.month_credit.AppendText(m_c.ToString());
                this.month_debit.AppendText(m_d.ToString());
                this.year_credit.AppendText(y_c.ToString());
                this.year_debit.AppendText(y_d.ToString());
                this.day_credit.AppendText(d_c.ToString());
                this.day_debit.AppendText(d_d.ToString());
                this.day_saving.AppendText(d_s.ToString());
                this.month_saving.AppendText(m_s.ToString());
                this.year_saving.AppendText(y_s.ToString());


            }
            catch (Exception ex)
            {

            }

        }

        private void DisplayGrid(DateTime dateTime)
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\uday\Documents\Visual Studio 2008\Projects\MM\MM\MM.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
                con.Open();
                string query = @"select MONEY,REASON,[CREDIT/DEBIT] from MM where date ='" + dateTime + "'";
                da = new SqlDataAdapter(query, con);
                cb = new SqlCommandBuilder(da);
                dt = new DataTable();
                da.Fill(dt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                this.CashGrid.DataSource = bs; 
                con.Close();
               
            }
            catch (Exception ex)
            {

            }

        }
        private void CALENDAR_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                DateTime currentselect = this.CALENDAR.SelectionEnd.Date;
                this.DisplayGrid(currentselect);
                this.fillStats(currentselect);
            }
            catch (Exception ex)
            {

            }
        }

        private void CALENDAR_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            try
            {
            DateTime currentselect = this.CALENDAR.SelectionEnd.Date;
            this.DisplayGrid(currentselect);
            this.fillStats(currentselect);
            }
            catch (Exception ex)
            {

            }
        }

        private void save_items(EventArgs e)
        {
            try
            {
                DateTime currentselect = this.CALENDAR.SelectionEnd.Date;
                con = new SqlConnection();
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\uday\Documents\Visual Studio 2008\Projects\MM\MM\MM.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
                con.Open();
                string deleteData = @"DELETE FROM MM WHERE DATE = '" + currentselect + "'";
                SqlCommand cmd1 = new SqlCommand(deleteData, con);
                da.InsertCommand = cmd1;
                cmd1.ExecuteNonQuery();
                for (int i = 0; i < CashGrid.Rows.Count; i++)
                {

                    string money = "", reason = "", c_d = "";
                    int rownum = i + 1;

                    String insertData = @"INSERT INTO MM(DATE, MONEY, REASON, [CREDIT/DEBIT]) VALUES ('" + currentselect + "',@MONEY, @REASON, @C_D)";
                    SqlCommand cmd = new SqlCommand(insertData, con);
                    if (this.CashGrid.Rows[i].Cells["MONEY"].Value != null && this.CashGrid.Rows[i].Cells["REASON"].Value != null && this.CashGrid.Rows[i].Cells["CREDIT_DEBIT"].Value != null)
                    {
                        money = this.CashGrid.Rows[i].Cells["MONEY"].Value.ToString();
                        reason = this.CashGrid.Rows[i].Cells["REASON"].Value.ToString();
                        c_d = this.CashGrid.Rows[i].Cells["CREDIT_DEBIT"].Value.ToString();

                        //ANY SINGLE COLUMN IS EMPTY
                        if (c_d == "" && (money != "" || reason != ""))
                        {
                            MessageBox.Show("PLEASE SELECT CREDIT/DEBIT OPTION IN THE ROW ::  " + rownum);
                            FormClosingEventArgs close_event = (FormClosingEventArgs)e;
                            close_event.Cancel = true;
                            continue;
                        }
                        else if (money == "" && (c_d != "" || reason != ""))
                        {
                            MessageBox.Show("PLEASE ENTER THE AMOUNT IN THE ROW ::  " + rownum);
                            FormClosingEventArgs close_event = (FormClosingEventArgs)e;
                            close_event.Cancel = true;
                            continue;
                        }
                        else if (reason == "" && (money != "" || c_d != ""))
                        {
                            MessageBox.Show("PLEASE PROVIDE A REASON FOR THE CREDIT/DEBIT IN THE ROW ::  " + rownum);
                            FormClosingEventArgs close_event = (FormClosingEventArgs)e;
                            close_event.Cancel = true;
                            continue;
                        }
                        cmd.Parameters.AddWithValue("@MONEY", CashGrid.Rows[i].Cells["MONEY"].Value);
                        cmd.Parameters.AddWithValue("@REASON", CashGrid.Rows[i].Cells["REASON"].Value);
                        cmd.Parameters.AddWithValue("@C_D", CashGrid.Rows[i].Cells["CREDIT_DEBIT"].Value);
                        da.InsertCommand = cmd;
                        cmd.ExecuteNonQuery();
                    }

                }
                con.Close();
                this.fillStats(currentselect);
            }
            catch (Exception ex)
            {

            }
        }
        private void SAVE_Click(object sender, EventArgs e)
        {
            this.save_items(e);
            if (unsaved == true)
            unsaved = false;

        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            DateTime currentselect = this.CALENDAR.SelectionEnd.Date;
            this.DisplayGrid(currentselect);
            if (unsaved == true)
                unsaved = false;

        }

        private void CashGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            {
                string value = CashGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                CashGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = value.Trim();
            }
        }

        private void CashGrid_CurrentCellDirtyStateChanged(object sender,EventArgs e)
        {
            if (CashGrid.IsCurrentCellDirty)
            {
                if (unsaved == false)
                    unsaved = true;
            }
        }

        // If a check box cell is clicked, this event handler disables   
        // or enables the button in the same row as the clicked cell. 
        private void CashGrid_CellValueChanged(object sender,DataGridViewCellEventArgs e)
        {
            if(unsaved == false)
            unsaved = true;
        }
        
        void CashGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox)
            {
                TextBox tb = e.Control as TextBox;
                tb.KeyPress -= new KeyPressEventHandler(tb_KeyPress);
                if (this.CashGrid.CurrentCell.ColumnIndex == 0)
                {
                    tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
                }
            }
        }

        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != '\b' && e.KeyChar != char.Parse(".")) //allow the backspace key  
                {
                    e.Handled = true;
                }
            }
        }

        private void sAVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.save_items(e);
            if (unsaved == true)
                unsaved = false;
        }

        private void eXPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WILL be IMPLEMENTED in the NEXT PATCH");
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (unsaved == true)
            {
                DialogResult result = MessageBox.Show("SAVE CHANGES ?", "SAVE", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.save_items(e);
                    Application.Exit();
                }
                else if (result == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void gRAPHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WILL be IMPLEMENTED in the NEXT PATCH");
        }

        private void gRIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.CashGrid.Visible == false)
                this.CashGrid.Visible = true;

            if (this.gRIDToolStripMenuItem.Checked == false)
                this.gRIDToolStripMenuItem.Checked = true;
        }

        private void cLEARALLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult clearall = MessageBox.Show("THIS WILL DELETE ALL THE DATA IN THE DATABASE ","WARNING!!",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);
            if (clearall == DialogResult.OK)
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\uday\Documents\Visual Studio 2008\Projects\MM\MM\MM.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
                con.Open();
                string deleteData = @"TRUNCATE TABLE MM";
                SqlCommand cmd = new SqlCommand(deleteData, con);
                da.InsertCommand = cmd;
                cmd.ExecuteNonQuery();
                con.Close();
                DateTime currentselect = this.CALENDAR.SelectionEnd.Date;
                this.DisplayGrid(currentselect);
                this.fillStats(currentselect);
                if (unsaved == true)
                    unsaved = false;
            }
        }

        private void aUTHORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process myProcess = new Process();
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = "http://www.facebook.com/uday.L.reddy";
                myProcess.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
        }
    }
}
