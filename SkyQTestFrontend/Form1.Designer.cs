namespace SkyQTestFrontend
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
            this.cmdGetPvrList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtSynopsis = new System.Windows.Forms.TextBox();
            this.lstPvr = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRat = new System.Windows.Forms.TextBox();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdGetPvrList
            // 
            this.cmdGetPvrList.Location = new System.Drawing.Point(80, 35);
            this.cmdGetPvrList.Name = "cmdGetPvrList";
            this.cmdGetPvrList.Size = new System.Drawing.Size(186, 26);
            this.cmdGetPvrList.TabIndex = 0;
            this.cmdGetPvrList.Text = "Get PVR Listing";
            this.cmdGetPvrList.UseVisualStyleBackColor = true;
            this.cmdGetPvrList.Click += new System.EventHandler(this.cmdGetPvrList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sky Q IP:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(80, 9);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(186, 20);
            this.txtIP.TabIndex = 2;
            this.txtIP.Text = "192.168.79.103";
            // 
            // txtSynopsis
            // 
            this.txtSynopsis.Location = new System.Drawing.Point(360, 214);
            this.txtSynopsis.Multiline = true;
            this.txtSynopsis.Name = "txtSynopsis";
            this.txtSynopsis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSynopsis.Size = new System.Drawing.Size(401, 149);
            this.txtSynopsis.TabIndex = 3;
            // 
            // lstPvr
            // 
            this.lstPvr.FormattingEnabled = true;
            this.lstPvr.Location = new System.Drawing.Point(81, 79);
            this.lstPvr.Name = "lstPvr";
            this.lstPvr.Size = new System.Drawing.Size(261, 342);
            this.lstPvr.TabIndex = 4;
            this.lstPvr.SelectedIndexChanged += new System.EventHandler(this.lstPvr_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Channel:";
            // 
            // txtChan
            // 
            this.txtChan.Location = new System.Drawing.Point(414, 159);
            this.txtChan.Name = "txtChan";
            this.txtChan.Size = new System.Drawing.Size(346, 20);
            this.txtChan.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rating:";
            // 
            // txtRat
            // 
            this.txtRat.Location = new System.Drawing.Point(414, 188);
            this.txtRat.Name = "txtRat";
            this.txtRat.Size = new System.Drawing.Size(86, 20);
            this.txtRat.TabIndex = 8;
            // 
            // cboFilter
            // 
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Location = new System.Drawing.Point(83, 426);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(258, 21);
            this.cboFilter.TabIndex = 9;
            this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(354, 83);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(405, 52);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cboFilter);
            this.Controls.Add(this.txtRat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstPvr);
            this.Controls.Add(this.txtSynopsis);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdGetPvrList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdGetPvrList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtSynopsis;
        private System.Windows.Forms.ListBox lstPvr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRat;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.Label lblTitle;
    }
}

