namespace FormBinhPhu
{
    partial class FrmVote
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnVote = new System.Windows.Forms.Button();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtcauhoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.labCode = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelco = new System.Windows.Forms.Label();
            this.labelko = new System.Windows.Forms.Label();
            this.labelkbiet = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btxcapnhat = new System.Windows.Forms.Button();
            this.GridResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 190);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(379, 181);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Câu trả lời";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // BtnVote
            // 
            this.BtnVote.Location = new System.Drawing.Point(369, 75);
            this.BtnVote.Name = "BtnVote";
            this.BtnVote.Size = new System.Drawing.Size(75, 23);
            this.BtnVote.TabIndex = 5;
            this.BtnVote.Text = "Vote";
            this.BtnVote.UseVisualStyleBackColor = true;
            this.BtnVote.Click += new System.EventHandler(this.BtnVote_Click);
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(369, 161);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(75, 23);
            this.BtnThoat.TabIndex = 7;
            this.BtnThoat.Text = "Exit";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Câu hỏi";
            // 
            // txtcauhoi
            // 
            this.txtcauhoi.Location = new System.Drawing.Point(117, 78);
            this.txtcauhoi.Name = "txtcauhoi";
            this.txtcauhoi.Size = new System.Drawing.Size(234, 20);
            this.txtcauhoi.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(129, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Thời gian vote còn lại";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(47, 345);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(0, 13);
            this.labID.TabIndex = 18;
            // 
            // labCode
            // 
            this.labCode.AutoSize = true;
            this.labCode.Location = new System.Drawing.Point(328, 345);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(0, 13);
            this.labCode.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 20;
            // 
            // labelco
            // 
            this.labelco.AutoSize = true;
            this.labelco.Location = new System.Drawing.Point(351, 122);
            this.labelco.Name = "labelco";
            this.labelco.Size = new System.Drawing.Size(0, 13);
            this.labelco.TabIndex = 21;
            // 
            // labelko
            // 
            this.labelko.AutoSize = true;
            this.labelko.Location = new System.Drawing.Point(366, 149);
            this.labelko.Name = "labelko";
            this.labelko.Size = new System.Drawing.Size(0, 13);
            this.labelko.TabIndex = 22;
            // 
            // labelkbiet
            // 
            this.labelkbiet.AutoSize = true;
            this.labelkbiet.Location = new System.Drawing.Point(379, 112);
            this.labelkbiet.Name = "labelkbiet";
            this.labelkbiet.Size = new System.Drawing.Size(0, 13);
            this.labelkbiet.TabIndex = 23;
            // 
            // btxcapnhat
            // 
            this.btxcapnhat.Location = new System.Drawing.Point(369, 117);
            this.btxcapnhat.Name = "btxcapnhat";
            this.btxcapnhat.Size = new System.Drawing.Size(75, 23);
            this.btxcapnhat.TabIndex = 24;
            this.btxcapnhat.Text = "Cập nhật";
            this.btxcapnhat.UseVisualStyleBackColor = true;
            this.btxcapnhat.Click += new System.EventHandler(this.btxcapnhat_Click);
            // 
            // GridResult
            // 
            this.GridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridResult.Location = new System.Drawing.Point(12, 377);
            this.GridResult.Name = "GridResult";
            this.GridResult.Size = new System.Drawing.Size(451, 150);
            this.GridResult.TabIndex = 25;
            // 
            // FrmVote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 509);
            this.Controls.Add(this.GridResult);
            this.Controls.Add(this.btxcapnhat);
            this.Controls.Add(this.labelkbiet);
            this.Controls.Add(this.labelko);
            this.Controls.Add(this.labelco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labCode);
            this.Controls.Add(this.labID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcauhoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.BtnVote);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "FrmVote";
            this.Text = "VOTE";
            this.Load += new System.EventHandler(this.FrmVote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnVote;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcauhoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Label labCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelco;
        private System.Windows.Forms.Label labelko;
        private System.Windows.Forms.Label labelkbiet;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btxcapnhat;
        private System.Windows.Forms.DataGridView GridResult;
    }
}