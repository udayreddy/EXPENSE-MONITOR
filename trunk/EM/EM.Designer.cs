namespace MM
{
    partial class EM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EM));
            this.CALENDAR = new System.Windows.Forms.MonthCalendar();
            this.DAY = new System.Windows.Forms.Label();
            this.CREDIT = new System.Windows.Forms.Label();
            this.YEAR = new System.Windows.Forms.Label();
            this.MONTH = new System.Windows.Forms.Label();
            this.DEBIT = new System.Windows.Forms.Label();
            this.CashGrid = new System.Windows.Forms.DataGridView();
            this.MONEY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REASON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREDIT_DEBIT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SAVE = new System.Windows.Forms.Button();
            this.CANCEL = new System.Windows.Forms.Button();
            this.day_credit = new System.Windows.Forms.TextBox();
            this.year_debit = new System.Windows.Forms.TextBox();
            this.year_credit = new System.Windows.Forms.TextBox();
            this.month_debit = new System.Windows.Forms.TextBox();
            this.month_credit = new System.Windows.Forms.TextBox();
            this.MENU = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLEARALLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gRAPHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gRIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.month_saving = new System.Windows.Forms.TextBox();
            this.year_saving = new System.Windows.Forms.TextBox();
            this.day_saving = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.day_debit = new System.Windows.Forms.TextBox();
            this.aUTHORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.CashGrid)).BeginInit();
            this.MENU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mMDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CALENDAR
            // 
            this.CALENDAR.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CALENDAR.Location = new System.Drawing.Point(61, 40);
            this.CALENDAR.Margin = new System.Windows.Forms.Padding(10);
            this.CALENDAR.Name = "CALENDAR";
            this.CALENDAR.TabIndex = 0;
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
            this.CREDIT.Location = new System.Drawing.Point(74, 212);
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
            this.DEBIT.Location = new System.Drawing.Point(161, 212);
            this.DEBIT.Name = "DEBIT";
            this.DEBIT.Size = new System.Drawing.Size(44, 15);
            this.DEBIT.TabIndex = 8;
            this.DEBIT.Text = "DEBIT";
            // 
            // CashGrid
            // 
            this.CashGrid.AllowUserToOrderColumns = true;
            this.CashGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CashGrid.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.CashGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CashGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CashGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MONEY,
            this.REASON,
            this.CREDIT_DEBIT});
            this.CashGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.CashGrid.GridColor = System.Drawing.Color.LightSlateGray;
            this.CashGrid.Location = new System.Drawing.Point(318, 40);
            this.CashGrid.Name = "CashGrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "ud";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CashGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CashGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CashGrid.Size = new System.Drawing.Size(583, 482);
            this.CashGrid.TabIndex = 9;
            // 
            // MONEY
            // 
            this.MONEY.DataPropertyName = "MONEY";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.MONEY.DefaultCellStyle = dataGridViewCellStyle1;
            this.MONEY.HeaderText = "AMOUNT";
            this.MONEY.Name = "MONEY";
            // 
            // REASON
            // 
            this.REASON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.REASON.DataPropertyName = "REASON";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REASON.DefaultCellStyle = dataGridViewCellStyle2;
            this.REASON.HeaderText = "REASON";
            this.REASON.Name = "REASON";
            // 
            // CREDIT_DEBIT
            // 
            this.CREDIT_DEBIT.DataPropertyName = "CREDIT/DEBIT";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CREDIT_DEBIT.DefaultCellStyle = dataGridViewCellStyle3;
            this.CREDIT_DEBIT.HeaderText = "CREDIT/DEBIT";
            this.CREDIT_DEBIT.Items.AddRange(new object[] {
            "INCOME",
            "EXPENSE",
            "SAVINGS"});
            this.CREDIT_DEBIT.Name = "CREDIT_DEBIT";
            // 
            // SAVE
            // 
            this.SAVE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SAVE.Location = new System.Drawing.Point(568, 539);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(126, 28);
            this.SAVE.TabIndex = 10;
            this.SAVE.Text = "SAVE";
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // CANCEL
            // 
            this.CANCEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CANCEL.Location = new System.Drawing.Point(734, 539);
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
            this.day_credit.Size = new System.Drawing.Size(79, 21);
            this.day_credit.TabIndex = 12;
            // 
            // year_debit
            // 
            this.year_debit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.year_debit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_debit.ForeColor = System.Drawing.Color.Red;
            this.year_debit.Location = new System.Drawing.Point(146, 325);
            this.year_debit.Name = "year_debit";
            this.year_debit.ReadOnly = true;
            this.year_debit.Size = new System.Drawing.Size(77, 21);
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
            this.year_credit.Size = new System.Drawing.Size(79, 21);
            this.year_credit.TabIndex = 17;
            // 
            // month_debit
            // 
            this.month_debit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.month_debit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_debit.ForeColor = System.Drawing.Color.Red;
            this.month_debit.Location = new System.Drawing.Point(146, 279);
            this.month_debit.Name = "month_debit";
            this.month_debit.ReadOnly = true;
            this.month_debit.Size = new System.Drawing.Size(77, 21);
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
            this.month_credit.Size = new System.Drawing.Size(79, 21);
            this.month_credit.TabIndex = 19;
            // 
            // MENU
            // 
            this.MENU.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MENU.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MENU.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.vIEWToolStripMenuItem,
            this.aBOUTToolStripMenuItem});
            this.MENU.Location = new System.Drawing.Point(0, 0);
            this.MENU.Name = "MENU";
            this.MENU.Size = new System.Drawing.Size(919, 24);
            this.MENU.TabIndex = 21;
            this.MENU.Text = "MENU";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sAVEToolStripMenuItem,
            this.eXPORTToolStripMenuItem,
            this.cLEARALLToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // sAVEToolStripMenuItem
            // 
            this.sAVEToolStripMenuItem.Name = "sAVEToolStripMenuItem";
            this.sAVEToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.sAVEToolStripMenuItem.Text = "SAVE";
            this.sAVEToolStripMenuItem.Click += new System.EventHandler(this.sAVEToolStripMenuItem_Click);
            // 
            // eXPORTToolStripMenuItem
            // 
            this.eXPORTToolStripMenuItem.Name = "eXPORTToolStripMenuItem";
            this.eXPORTToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.eXPORTToolStripMenuItem.Text = "EXPORT";
            this.eXPORTToolStripMenuItem.Click += new System.EventHandler(this.eXPORTToolStripMenuItem_Click);
            // 
            // cLEARALLToolStripMenuItem
            // 
            this.cLEARALLToolStripMenuItem.Name = "cLEARALLToolStripMenuItem";
            this.cLEARALLToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.cLEARALLToolStripMenuItem.Text = "CLEAR ALL";
            this.cLEARALLToolStripMenuItem.Click += new System.EventHandler(this.cLEARALLToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // vIEWToolStripMenuItem
            // 
            this.vIEWToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gRAPHToolStripMenuItem,
            this.gRIDToolStripMenuItem});
            this.vIEWToolStripMenuItem.Name = "vIEWToolStripMenuItem";
            this.vIEWToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.vIEWToolStripMenuItem.Text = "VIEW";
            // 
            // gRAPHToolStripMenuItem
            // 
            this.gRAPHToolStripMenuItem.Name = "gRAPHToolStripMenuItem";
            this.gRAPHToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.gRAPHToolStripMenuItem.Text = "GRAPH";
            this.gRAPHToolStripMenuItem.Click += new System.EventHandler(this.gRAPHToolStripMenuItem_Click);
            // 
            // gRIDToolStripMenuItem
            // 
            this.gRIDToolStripMenuItem.Checked = true;
            this.gRIDToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gRIDToolStripMenuItem.Name = "gRIDToolStripMenuItem";
            this.gRIDToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.gRIDToolStripMenuItem.Text = "GRID";
            this.gRIDToolStripMenuItem.Click += new System.EventHandler(this.gRIDToolStripMenuItem_Click);
            // 
            // aBOUTToolStripMenuItem
            // 
            this.aBOUTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aUTHORToolStripMenuItem});
            this.aBOUTToolStripMenuItem.Name = "aBOUTToolStripMenuItem";
            this.aBOUTToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.aBOUTToolStripMenuItem.Text = "ABOUT";
            // 
            // month_saving
            // 
            this.month_saving.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.month_saving.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_saving.ForeColor = System.Drawing.Color.MediumBlue;
            this.month_saving.Location = new System.Drawing.Point(235, 279);
            this.month_saving.Name = "month_saving";
            this.month_saving.ReadOnly = true;
            this.month_saving.Size = new System.Drawing.Size(77, 21);
            this.month_saving.TabIndex = 25;
            // 
            // year_saving
            // 
            this.year_saving.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.year_saving.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_saving.ForeColor = System.Drawing.Color.MediumBlue;
            this.year_saving.Location = new System.Drawing.Point(235, 325);
            this.year_saving.Name = "year_saving";
            this.year_saving.ReadOnly = true;
            this.year_saving.Size = new System.Drawing.Size(77, 21);
            this.year_saving.TabIndex = 24;
            // 
            // day_saving
            // 
            this.day_saving.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.day_saving.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_saving.ForeColor = System.Drawing.Color.MediumBlue;
            this.day_saving.Location = new System.Drawing.Point(235, 238);
            this.day_saving.Name = "day_saving";
            this.day_saving.ReadOnly = true;
            this.day_saving.Size = new System.Drawing.Size(77, 21);
            this.day_saving.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "SAVINGS";
            // 
            // day_debit
            // 
            this.day_debit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.day_debit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_debit.ForeColor = System.Drawing.Color.Red;
            this.day_debit.Location = new System.Drawing.Point(146, 238);
            this.day_debit.Name = "day_debit";
            this.day_debit.ReadOnly = true;
            this.day_debit.Size = new System.Drawing.Size(77, 21);
            this.day_debit.TabIndex = 15;
            // 
            // aUTHORToolStripMenuItem
            // 
            this.aUTHORToolStripMenuItem.Name = "aUTHORToolStripMenuItem";
            this.aUTHORToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aUTHORToolStripMenuItem.Text = "AUTHOR";
            this.aUTHORToolStripMenuItem.Click += new System.EventHandler(this.aUTHORToolStripMenuItem_Click);
            // 
            // EM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 579);
            this.Controls.Add(this.month_saving);
            this.Controls.Add(this.year_saving);
            this.Controls.Add(this.day_saving);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.month_credit);
            this.Controls.Add(this.month_debit);
            this.Controls.Add(this.year_credit);
            this.Controls.Add(this.year_debit);
            this.Controls.Add(this.day_debit);
            this.Controls.Add(this.day_credit);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.CashGrid);
            this.Controls.Add(this.DEBIT);
            this.Controls.Add(this.MONTH);
            this.Controls.Add(this.YEAR);
            this.Controls.Add(this.CREDIT);
            this.Controls.Add(this.DAY);
            this.Controls.Add(this.CALENDAR);
            this.Controls.Add(this.MENU);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MENU;
            this.Name = "EM";
            this.Text = "EXPENSE MONITOR";
            ((System.ComponentModel.ISupportInitialize)(this.CashGrid)).EndInit();
            this.MENU.ResumeLayout(false);
            this.MENU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mMDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar CALENDAR;
        private System.Windows.Forms.BindingSource mMDataSetBindingSource;
        private System.Windows.Forms.Label DAY;
        private System.Windows.Forms.Label CREDIT;
        private System.Windows.Forms.Label YEAR;
        private System.Windows.Forms.Label MONTH;
        private System.Windows.Forms.Label DEBIT;
        private System.Windows.Forms.DataGridView CashGrid;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.TextBox day_credit;
        private System.Windows.Forms.TextBox year_debit;
        private System.Windows.Forms.TextBox year_credit;
        private System.Windows.Forms.TextBox month_debit;
        private System.Windows.Forms.TextBox month_credit;
        private System.Windows.Forms.MenuStrip MENU;
        private System.Windows.Forms.ToolStripMenuItem vIEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAVEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gRAPHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gRIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLEARALLToolStripMenuItem;
        private System.Windows.Forms.TextBox month_saving;
        private System.Windows.Forms.TextBox year_saving;
        private System.Windows.Forms.TextBox day_saving;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONEY;
        private System.Windows.Forms.DataGridViewTextBoxColumn REASON;
        private System.Windows.Forms.DataGridViewComboBoxColumn CREDIT_DEBIT;
        private System.Windows.Forms.TextBox day_debit;
        private System.Windows.Forms.ToolStripMenuItem aBOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aUTHORToolStripMenuItem;
    }
}

