namespace FormBinhPhu
{
    partial class FrmLoadOption
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
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnThem = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.TxtAns = new System.Windows.Forms.TextBox();
            this.GridResult = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbAns = new System.Windows.Forms.ComboBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.CmbOption = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelsau = new System.Windows.Forms.Label();
            this.labelbay = new System.Windows.Forms.Label();
            this.labeltam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Deadline";
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(16, 12);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(59, 23);
            this.BtnLoad.TabIndex = 1;
            this.BtnLoad.Text = "Load";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Content";
            // 
            // TxtCt
            // 
            this.TxtCt.Location = new System.Drawing.Point(81, 88);
            this.TxtCt.Name = "TxtCt";
            this.TxtCt.Size = new System.Drawing.Size(200, 20);
            this.TxtCt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Answer";
            // 
            // BtnThem
            // 
            this.BtnThem.Location = new System.Drawing.Point(81, 153);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(51, 23);
            this.BtnThem.TabIndex = 9;
            this.BtnThem.Text = "Add";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.Location = new System.Drawing.Point(138, 153);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(51, 23);
            this.BtnSua.TabIndex = 10;
            this.BtnSua.Text = "Edit";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Location = new System.Drawing.Point(195, 153);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(64, 23);
            this.BtnXoa.TabIndex = 11;
            this.BtnXoa.Text = "Remove";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(436, 12);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(75, 23);
            this.BtnThoat.TabIndex = 12;
            this.BtnThoat.Text = "Close";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // TxtAns
            // 
            this.TxtAns.Location = new System.Drawing.Point(81, 127);
            this.TxtAns.Name = "TxtAns";
            this.TxtAns.Size = new System.Drawing.Size(200, 20);
            this.TxtAns.TabIndex = 6;
            // 
            // GridResult
            // 
            this.GridResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridResult.Location = new System.Drawing.Point(12, 208);
            this.GridResult.Name = "GridResult";
            this.GridResult.Size = new System.Drawing.Size(499, 287);
            this.GridResult.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Result";
            // 
            // CmbAns
            // 
            this.CmbAns.FormattingEnabled = true;
            this.CmbAns.Location = new System.Drawing.Point(301, 127);
            this.CmbAns.Name = "CmbAns";
            this.CmbAns.Size = new System.Drawing.Size(200, 21);
            this.CmbAns.TabIndex = 15;
            this.CmbAns.SelectedIndexChanged += new System.EventHandler(this.CmbAns_SelectedIndexChanged);
            this.CmbAns.SelectedValueChanged += new System.EventHandler(this.CmbAns_SelectedValueChanged);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(208, 12);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(51, 23);
            this.BtnNew.TabIndex = 16;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // CmbOption
            // 
            this.CmbOption.FormattingEnabled = true;
            this.CmbOption.Location = new System.Drawing.Point(81, 14);
            this.CmbOption.Name = "CmbOption";
            this.CmbOption.Size = new System.Drawing.Size(121, 21);
            this.CmbOption.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // labelsau
            // 
            this.labelsau.AutoSize = true;
            this.labelsau.Location = new System.Drawing.Point(340, 63);
            this.labelsau.Name = "labelsau";
            this.labelsau.Size = new System.Drawing.Size(0, 13);
            this.labelsau.TabIndex = 20;
            // 
            // labelbay
            // 
            this.labelbay.AutoSize = true;
            this.labelbay.Location = new System.Drawing.Point(368, 67);
            this.labelbay.Name = "labelbay";
            this.labelbay.Size = new System.Drawing.Size(0, 13);
            this.labelbay.TabIndex = 21;
            // 
            // labeltam
            // 
            this.labeltam.AutoSize = true;
            this.labeltam.Location = new System.Drawing.Point(403, 64);
            this.labeltam.Name = "labeltam";
            this.labeltam.Size = new System.Drawing.Size(0, 13);
            this.labeltam.TabIndex = 22;
            // 
            // FrmLoadOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 507);
            this.Controls.Add(this.labeltam);
            this.Controls.Add(this.labelbay);
            this.Controls.Add(this.labelsau);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CmbOption);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.CmbAns);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GridResult);
            this.Controls.Add(this.TxtAns);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtCt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.label2);
            this.Name = "FrmLoadOption";
            this.Text = "OPTION";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLoadOption_FormClosed);
            this.Load += new System.EventHandler(this.FrmLoadOption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.TextBox TxtAns;
        private System.Windows.Forms.DataGridView GridResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbAns;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.ComboBox CmbOption;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelsau;
        private System.Windows.Forms.Label labelbay;
        private System.Windows.Forms.Label labeltam;
    }
}