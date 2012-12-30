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

namespace MM
{
    public partial class Form1 : Form
    {
        DataTable dt;
        SqlDataAdapter da;
        SqlCommandBuilder cb;
        SqlConnection con;
        public Form1()
        {
            try
            {
                InitializeComponent();
                //System.Windows.Forms.Application.ApplicationExit += new System.EventHandler(this.shutdown);
                this.DisplayGrid(this.monthCalendar1.TodayDate);
                this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
                this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);               
                this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
                //this.month_credit.Clear();
                //this.month_debit.Clear();
                //this.year_credit.Clear();
                //this.year_debit.Clear();
                //this.day_credit.Clear();
                //this.day_debit.Clear();
               // DateTime selecteddate = this.monthCalendar1.SelectionEnd.Date;
                this.fillStats(this.monthCalendar1.TodayDate);
            }
            catch (Exception ex)
            {

            }
        }

        //private void shutdown(object sender, EventArgs e)
        //{
            protected override void OnFormClosing(FormClosingEventArgs e)
            {
            DialogResult result =  MessageBox.Show("SAVE CHANGES ?","SAVE",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
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
                string query_year_credit = @"SELECT * FROM MM WHERE YEAR(DATE) = '" + dateTime.Year + "' and [CREDIT/DEBIT] = 'CREDIT'";
                string query_month_credit = @"SELECT * FROM MM WHERE MONTH(DATE) = '" + dateTime.Month + "' and [CREDIT/DEBIT] = 'CREDIT'";
                string query_day_credit = @"SELECT * FROM MM WHERE DATE = '" + dateTime + "' and [CREDIT/DEBIT] = 'CREDIT'";
                string query_year_debit = @"SELECT * FROM MM WHERE YEAR(DATE) = '" + dateTime.Year + "' and [CREDIT/DEBIT] = 'DEBIT'";
                string query_month_debit = @"SELECT * FROM MM WHERE MONTH(DATE) = '" + dateTime.Month + "' and [CREDIT/DEBIT] = 'DEBIT'";
                string query_day_debit = @"SELECT * FROM MM WHERE DATE = '" + dateTime + "' and [CREDIT/DEBIT] = 'DEBIT'";

                this.month_credit.Clear();
                this.month_debit.Clear();
                this.year_credit.Clear();
                this.year_debit.Clear();
                this.day_credit.Clear();
                this.day_debit.Clear();

                object y_d = getstat(query_year_debit,con);
                object m_d = getstat(query_month_debit, con);
                object d_d = getstat(query_day_debit, con);
                object y_c = getstat(query_year_credit ,con);
                object m_c = getstat(query_month_credit,con);
                object d_c = getstat(query_day_credit ,con);


                this.month_credit.AppendText(m_c.ToString());
                this.month_debit.AppendText(m_d.ToString());
                this.year_credit.AppendText(y_c.ToString());
                this.year_debit.AppendText(y_d.ToString());
                this.day_credit.AppendText(d_c.ToString());
                this.day_debit.AppendText(d_d.ToString());

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
                this.dataGridView1.DataSource = bs;
               // //hide a particular datagridview column
               // this.dataGridView1.Columns[0].Visible = false;
               // //this.dataGridView1.Columns[3].Visible = false;
               // this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
               // // // copy over any properties from existing column now at index + 1
               // DataGridViewComboBoxColumn ComboBoxCell = new DataGridViewComboBoxColumn();
               // ComboBoxCell.Items.AddRange(new string[] { "CREDIT", "DEBIT" });
               // this.dataGridView1.Columns.Insert(3, ComboBoxCell); // insert at the appropriate place
               // this.dataGridView1.Columns[3].HeaderText = dataGridView1.Columns[4].HeaderText;
               // this.dataGridView1.Columns.RemoveAt(4);
               // // DataGridViewComboBoxCell test = new DataGridViewComboBoxCell();
               //// test.Items.Add("uday");
               //// test.Selected = true;
               //// row.Cells[col.Name].Value =
               //// this.dataGridView1.Rows[0].Cells[3] = (this.dataGridView1.Rows[1].Cells[3] as DataGridViewComboBoxCell).Items[0];
               ////// string test = ComboBoxCell.DisplayMember;
               //// //this.dataGridView1.Columns[3].
               //// //this.dataGridView1[0, 3] = ComboBoxCell;
                //DataGridViewTextBoxColumn S_No = new DataGridViewTextBoxColumn();
                //this.dataGridView1.Columns.Insert(0, S_No);
                //this.dataGridView1.Columns[0].HeaderText = "S.No";
                //this.dataGridView1.Columns[0].Visible = true;
                //this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                //if (this.dataGridView1.RowCount != 0)
                //{
                //    for (int y = 0; y < this.dataGridView1.RowCount; y++)
                //    {
                //        int row = y + 1;
                //        this.dataGridView1.Rows[y].Cells[2].Value = row.ToString();
                //    }

                //} 
                con.Close();
               
            }
            catch (Exception ex)
            {

            }

        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                DateTime currentselect = this.monthCalendar1.SelectionEnd.Date;
                this.DisplayGrid(currentselect);
                this.fillStats(currentselect);
            }
            catch (Exception ex)
            {

            }
        }

        private void monthCalendar1_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            try
            {
            DateTime currentselect = this.monthCalendar1.SelectionEnd.Date;
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
                DateTime currentselect = this.monthCalendar1.SelectionEnd.Date;
                con = new SqlConnection();
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\uday\Documents\Visual Studio 2008\Projects\MM\MM\MM.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
                con.Open();
                string deleteData = @"DELETE FROM MM WHERE DATE = '" + currentselect + "'";
                SqlCommand cmd1 = new SqlCommand(deleteData, con);
                da.InsertCommand = cmd1;
                cmd1.ExecuteNonQuery();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {

                    string money = "", reason = "", c_d = "";
                    int rownum = i + 1;

                    String insertData = @"INSERT INTO MM(DATE, MONEY, REASON, [CREDIT/DEBIT]) VALUES ('" + currentselect + "',@MONEY, @REASON, @C_D)";
                    SqlCommand cmd = new SqlCommand(insertData, con);
                    if (this.dataGridView1.Rows[i].Cells["MONEY"].Value != null && this.dataGridView1.Rows[i].Cells["REASON"].Value != null && this.dataGridView1.Rows[i].Cells["CREDIT_DEBIT"].Value != null)
                    {
                        money = this.dataGridView1.Rows[i].Cells["MONEY"].Value.ToString();
                        reason = this.dataGridView1.Rows[i].Cells["REASON"].Value.ToString();
                        c_d = this.dataGridView1.Rows[i].Cells["CREDIT_DEBIT"].Value.ToString();

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
                        //ANY TWO COLUMNs ARE EMPTY
                        //if (dataGridView1.Rows[i].Cells[2].Value.ToString() != "" && (dataGridView1.Rows[i].Cells[0].Value.ToString() == "" || dataGridView1.Rows[i].Cells[1].Value.ToString() == ""))
                        //    MessageBox.Show("PLEASE ENTER THE AMOUNT AND REASON FOR EXPENDITURE IN THE ROW ::  " + rownum);
                        //if (money != "" && (c_d == "" || reason == ""))
                        //    MessageBox.Show("PLEASE ENTER THE REASON AND SELECT CREDIT/DEBIT OPTION IN THE ROW ::  " + rownum);
                        //if (reason != "" && (money == "" || c_d == ""))
                        //    MessageBox.Show("PLEASE ENTER THE AMOUNT AND SELECT CREDIT/DEBIT OPTION IN THE ROW ::  " + rownum);

                        cmd.Parameters.AddWithValue("@MONEY", dataGridView1.Rows[i].Cells["MONEY"].Value);
                        cmd.Parameters.AddWithValue("@REASON", dataGridView1.Rows[i].Cells["REASON"].Value);
                        cmd.Parameters.AddWithValue("@C_D", dataGridView1.Rows[i].Cells["CREDIT_DEBIT"].Value);
                        da.InsertCommand = cmd;
                        cmd.ExecuteNonQuery();
                    }

                }
                con.Close();
                //this.month_credit.Clear();
                //this.month_debit.Clear();
                //this.year_credit.Clear();
                //this.year_debit.Clear();
                //this.day_credit.Clear();
                //this.day_debit.Clear();
                this.fillStats(currentselect);
            }
            catch (Exception ex)
            {

            }
        }
        private void SAVE_Click(object sender, EventArgs e)
        {
            this.save_items(e);
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            DateTime currentselect = this.monthCalendar1.SelectionEnd.Date;
            this.DisplayGrid(currentselect);
            this.fillStats(currentselect);

        }

        private void CLEAR_ALL_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\uday\Documents\Visual Studio 2008\Projects\MM\MM\MM.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            con.Open();
            string deleteData = @"TRUNCATE TABLE MM";
            SqlCommand cmd1 = new SqlCommand(deleteData, con);
            da.InsertCommand = cmd1;
            cmd1.ExecuteNonQuery();
            con.Close();
            DateTime currentselect = this.monthCalendar1.SelectionEnd.Date;
            this.DisplayGrid(currentselect);
            //this.month_credit.Clear();
            //this.month_debit.Clear();
            //this.year_credit.Clear();
            //this.year_debit.Clear();
            //this.day_credit.Clear();
            //this.day_debit.Clear();
            this.fillStats(currentselect);
        }

        private void REFRESH_Click(object sender, EventArgs e)
        {
            //this.month_credit.Clear();
            //this.month_debit.Clear();
            //this.year_credit.Clear();
            //this.year_debit.Clear();
            //this.day_credit.Clear();
            //this.day_debit.Clear();

            DateTime currentselect = this.monthCalendar1.SelectionEnd.Date;
            this.fillStats(currentselect);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            {
                string value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = value.Trim();
            }
        }
    }
}
