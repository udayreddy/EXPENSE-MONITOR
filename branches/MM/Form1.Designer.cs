namespace MM
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.mMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DAY = new System.Windows.Forms.Label();
            this.CREDIT = new System.Windows.Forms.Label();
            this.YEAR = new System.Windows.Forms.Label();
            this.MONTH = new System.Windows.Forms.Label();
            this.DEBIT = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MONEY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REASON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREDIT_DEBIT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SAVE = new System.Windows.Forms.Button();
            this.CANCEL = new System.Windows.Forms.Button();
            this.day_credit = new System.Windows.Forms.TextBox();
            this.day_debit = new System.Windows.Forms.TextBox();
            this.year_debit = new System.Windows.Forms.TextBox();
            this.year_credit = new System.Windows.Forms.TextBox();
            this.month_debit = new System.Windows.Forms.TextBox();
            this.month_credit = new System.Windows.Forms.TextBox();
            this.CLEAR_ALL = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gRAPHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gRIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.mMDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(33, 40);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(10);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // DAY
            // 
            this.DAY.AutoSize = true;
            this.DAY.Location = new System.Drawing.Point(6, 241);
            this.DAY.Name = "DAY";
            this.DAY.Size = new System.Drawing.Size(32, 15);
            this.DAY.TabIndex = 3;
            this.DAY.Text = "DAY";
            // 
            // CREDIT
            // 
            this.CREDIT.AutoSize = true;
            this.CREDIT.Location = new System.Drawing.Point(87, 210);
            this.CREDIT.Name = "CREDIT";
            this.CREDIT.Size = new System.Drawing.Size(53, 15);
            this.CREDIT.TabIndex = 4;
            this.CREDIT.Text = "CREDIT";
            // 
            // YEAR
            // 
            this.YEAR.AutoSize = true;
            this.YEAR.Location = new System.Drawing.Point(6, 328);
            this.YEAR.Name = "YEAR";
            this.YEAR.Size = new System.Drawing.Size(40, 15);
            this.YEAR.TabIndex = 6;
            this.YEAR.Text = "YEAR";
            // 
            // MONTH
            // 
            this.MONTH.AutoSize = true;
            this.MONTH.Location = new System.Drawing.Point(-1, 282);
            this.MONTH.Name = "MONTH";
            this.MONTH.Size = new System.Drawing.Size(54, 15);
            this.MONTH.TabIndex = 7;
            this.MONTH.Text = "MONTH";
            // 
            // DEBIT
            // 
            this.DEBIT.AutoSize = true;
            this.DEBIT.Location = new System.Drawing.Point(208, 213);
            this.DEBIT.Name = "DEBIT";
            this.DEBIT.Size = new System.Drawing.Size(44, 15);
            this.DEBIT.TabIndex = 8;
            this.DEBIT.Text = "DEBIT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MONEY,
            this.REASON,
            this.CREDIT_DEBIT});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(297, 40);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = "ud";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(575, 482);
            this.dataGridView1.TabIndex = 9;
            // 
            // MONEY
            // 
            this.MONEY.DataPropertyName = "MONEY";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MONEY.DefaultCellStyle = dataGridViewCellStyle5;
            this.MONEY.HeaderText = "AMOUNT";
            this.MONEY.Name = "MONEY";
            // 
            // REASON
            // 
            this.REASON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.REASON.DataPropertyName = "REASON";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REASON.DefaultCellStyle = dataGridViewCellStyle6;
            this.REASON.HeaderText = "REASON";
            this.REASON.Name = "REASON";
            // 
            // CREDIT_DEBIT
            // 
            this.CREDIT_DEBIT.DataPropertyName = "CREDIT/DEBIT";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CREDIT_DEBIT.DefaultCellStyle = dataGridViewCellStyle7;
            this.CREDIT_DEBIT.HeaderText = "CREDIT/DEBIT";
            this.CREDIT_DEBIT.Items.AddRange(new object[] {
            "CREDIT",
            "DEBIT"});
            this.CREDIT_DEBIT.Name = "CREDIT_DEBIT";
            // 
            // SAVE
            // 
            this.SAVE.Location = new System.Drawing.Point(566, 533);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(126, 28);
            this.SAVE.TabIndex = 10;
            this.SAVE.Text = "SAVE";
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // CANCEL
            // 
            this.CANCEL.Location = new System.Drawing.Point(734, 533);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(115, 28);
            this.CANCEL.TabIndex = 11;
            this.CANCEL.Text = "CANCEL";
            this.CANCEL.UseVisualStyleBackColor = true;
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click);
            // 
            // day_credit
            // 
            this.day_credit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.day_credit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_credit.ForeColor = System.Drawing.Color.Green;
            this.day_credit.Location = new System.Drawing.Point(61, 238);
            this.day_credit.Name = "day_credit";
            this.day_credit.ReadOnly = true;
            this.day_credit.Size = new System.Drawing.Size(98, 21);
            this.day_credit.TabIndex = 12;
            // 
            // day_debit
            // 
            this.day_debit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.day_debit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_debit.ForeColor = System.Drawing.Color.Red;
            this.day_debit.Location = new System.Drawing.Point(174, 238);
            this.day_debit.Name = "day_debit";
            this.day_debit.ReadOnly = true;
            this.day_debit.Size = new System.Drawing.Size(107, 21);
            this.day_debit.TabIndex = 15;
            // 
            // year_debit
            // 
            this.year_debit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.year_debit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_debit.ForeColor = System.Drawing.Color.Red;
            this.year_debit.Location = new System.Drawing.Point(174, 325);
            this.year_debit.Name = "year_debit";
            this.year_debit.ReadOnly = true;
            this.year_debit.Size = new System.Drawing.Size(107, 21);
            this.year_debit.TabIndex = 16;
            // 
            // year_credit
            // 
            this.year_credit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.year_credit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_credit.ForeColor = System.Drawing.Color.Green;
            this.year_credit.Location = new System.Drawing.Point(61, 325);
            this.year_credit.Name = "year_credit";
            this.year_credit.ReadOnly = true;
            this.year_credit.Size = new System.Drawing.Size(98, 21);
            this.year_credit.TabIndex = 17;
            // 
            // month_debit
            // 
            this.month_debit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.month_debit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_debit.ForeColor = System.Drawing.Color.Red;
            this.month_debit.Location = new System.Drawing.Point(174, 279);
            this.month_debit.Name = "month_debit";
            this.month_debit.ReadOnly = true;
            this.month_debit.Size = new System.Drawing.Size(107, 21);
            this.month_debit.TabIndex = 18;
            // 
            // month_credit
            // 
            this.month_credit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.month_credit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_credit.ForeColor = System.Drawing.Color.Green;
            this.month_credit.Location = new System.Drawing.Point(61, 279);
            this.month_credit.Name = "month_credit";
            this.month_credit.ReadOnly = true;
            this.month_credit.Size = new System.Drawing.Size(98, 21);
            this.month_credit.TabIndex = 19;
            // 
            // CLEAR_ALL
            // 
            this.CLEAR_ALL.Location = new System.Drawing.Point(408, 533);
            this.CLEAR_ALL.Name = "CLEAR_ALL";
            this.CLEAR_ALL.Size = new System.Drawing.Size(127, 28);
            this.CLEAR_ALL.TabIndex = 20;
            this.CLEAR_ALL.Text = "CLEAR ALL";
            this.CLEAR_ALL.UseVisualStyleBackColor = true;
            this.CLEAR_ALL.Click += new System.EventHandler(this.CLEAR_ALL_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.vIEWToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sAVEToolStripMenuItem,
            this.eXPORTToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // sAVEToolStripMenuItem
            // 
            this.sAVEToolStripMenuItem.Name = "sAVEToolStripMenuItem";
            this.sAVEToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.sAVEToolStripMenuItem.Text = "SAVE";
            // 
            // eXPORTToolStripMenuItem
            // 
            this.eXPORTToolStripMenuItem.Name = "eXPORTToolStripMenuItem";
            this.eXPORTToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eXPORTToolStripMenuItem.Text = "EXPORT";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eXITToolStripMenuItem.Text = "EXIT";
            // 
            // vIEWToolStripMenuItem
            // 
            this.vIEWToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gRAPHToolStripMenuItem,
            this.gRIDToolStripMenuItem});
            this.vIEWToolStripMenuItem.Name = "vIEWToolStripMenuItem";
            this.vIEWToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.vIEWToolStripMenuItem.Text = "VIEW";
            // 
            // gRAPHToolStripMenuItem
            // 
            this.gRAPHToolStripMenuItem.Name = "gRAPHToolStripMenuItem";
            this.gRAPHToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.gRAPHToolStripMenuItem.Text = "GRAPH";
            // 
            // gRIDToolStripMenuItem
            // 
            this.gRIDToolStripMenuItem.Name = "gRIDToolStripMenuItem";
            this.gRIDToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.gRIDToolStripMenuItem.Text = "GRID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 565);
            this.Controls.Add(this.CLEAR_ALL);
            this.Controls.Add(this.month_credit);
            this.Controls.Add(this.month_debit);
            this.Controls.Add(this.year_credit);
            this.Controls.Add(this.year_debit);
            this.Controls.Add(this.day_debit);
            this.Controls.Add(this.day_credit);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DEBIT);
            this.Controls.Add(this.MONTH);
            this.Controls.Add(this.YEAR);
            this.Controls.Add(this.CREDIT);
            this.Controls.Add(this.DAY);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "EXPENSE MONITOR :: by UDAY REDDY (l.udayreddy@gmail.com)";
            ((System.ComponentModel.ISupportInitialize)(this.mMDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.BindingSource mMDataSetBindingSource;
        private System.Windows.Forms.Label DAY;
        private System.Windows.Forms.Label CREDIT;
        private System.Windows.Forms.Label YEAR;
        private System.Windows.Forms.Label MONTH;
        private System.Windows.Forms.Label DEBIT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.TextBox day_credit;
        private System.Windows.Forms.TextBox day_debit;
        private System.Windows.Forms.TextBox year_debit;
        private System.Windows.Forms.TextBox year_credit;
        private System.Windows.Forms.TextBox month_debit;
        private System.Windows.Forms.TextBox month_credit;
        private System.Windows.Forms.Button CLEAR_ALL;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vIEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONEY;
        private System.Windows.Forms.DataGridViewTextBoxColumn REASON;
        private System.Windows.Forms.DataGridViewComboBoxColumn CREDIT_DEBIT;
        private System.Windows.Forms.ToolStripMenuItem sAVEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gRAPHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gRIDToolStripMenuItem;
    }
}

