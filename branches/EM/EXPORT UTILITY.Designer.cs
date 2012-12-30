namespace EM
{
    partial class EXPORT_UTILITY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EXPORT_UTILITY));
            this.CANCEL = new System.Windows.Forms.Button();
            this.EXPORT_XML = new System.Windows.Forms.Button();
            this.exportLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.TO = new System.Windows.Forms.DateTimePicker();
            this.FROM = new System.Windows.Forms.DateTimePicker();
            this.EXPORT_EXCEL = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // CANCEL
            // 
            this.CANCEL.Location = new System.Drawing.Point(12, 174);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(535, 26);
            this.CANCEL.TabIndex = 16;
            this.CANCEL.Text = "CANCEL";
            this.CANCEL.UseVisualStyleBackColor = true;
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click);
            // 
            // EXPORT_XML
            // 
            this.EXPORT_XML.Location = new System.Drawing.Point(12, 142);
            this.EXPORT_XML.Name = "EXPORT_XML";
            this.EXPORT_XML.Size = new System.Drawing.Size(535, 26);
            this.EXPORT_XML.TabIndex = 15;
            this.EXPORT_XML.Text = "EXPORT TO XML";
            this.EXPORT_XML.UseVisualStyleBackColor = true;
            this.EXPORT_XML.Click += new System.EventHandler(this.EXPORT_XML_Click);
            // 
            // exportLabel
            // 
            this.exportLabel.AutoSize = true;
            this.exportLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportLabel.Location = new System.Drawing.Point(166, 16);
            this.exportLabel.Name = "exportLabel";
            this.exportLabel.Size = new System.Drawing.Size(213, 26);
            this.exportLabel.TabIndex = 14;
            this.exportLabel.Text = "EXPORT UTILITY";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(295, 66);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(28, 13);
            this.toLabel.TabIndex = 13;
            this.toLabel.Text = "TO :";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(9, 66);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(44, 13);
            this.fromLabel.TabIndex = 12;
            this.fromLabel.Text = "FROM :";
            // 
            // TO
            // 
            this.TO.Location = new System.Drawing.Point(333, 63);
            this.TO.Name = "TO";
            this.TO.Size = new System.Drawing.Size(214, 20);
            this.TO.TabIndex = 11;
            // 
            // FROM
            // 
            this.FROM.Location = new System.Drawing.Point(65, 63);
            this.FROM.Name = "FROM";
            this.FROM.Size = new System.Drawing.Size(214, 20);
            this.FROM.TabIndex = 10;
            // 
            // EXPORT_EXCEL
            // 
            this.EXPORT_EXCEL.Location = new System.Drawing.Point(12, 110);
            this.EXPORT_EXCEL.Name = "EXPORT_EXCEL";
            this.EXPORT_EXCEL.Size = new System.Drawing.Size(535, 26);
            this.EXPORT_EXCEL.TabIndex = 9;
            this.EXPORT_EXCEL.Text = "EXPORT TO EXCEL";
            this.EXPORT_EXCEL.UseVisualStyleBackColor = true;
            this.EXPORT_EXCEL.Click += new System.EventHandler(this.EXPORT_EXCEL_Click);
            // 
            // EXPORT_UTILITY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 229);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.EXPORT_XML);
            this.Controls.Add(this.exportLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.TO);
            this.Controls.Add(this.FROM);
            this.Controls.Add(this.EXPORT_EXCEL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EXPORT_UTILITY";
            this.Text = "EXPORT UTILITY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.Button EXPORT_XML;
        private System.Windows.Forms.Label exportLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.DateTimePicker TO;
        private System.Windows.Forms.DateTimePicker FROM;
        private System.Windows.Forms.Button EXPORT_EXCEL;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}