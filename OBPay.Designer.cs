namespace PayManager
{
    partial class OBPay
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
            if (disposing && (components != null)) {
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
            this.lsvPay = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mettingValue = new System.Windows.Forms.NumericUpDown();
            this.lsvPayList = new System.Windows.Forms.ListView();
            this.columnHeadder1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contractValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lsvContractList = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mettingValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvPay
            // 
            this.lsvPay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3});
            this.lsvPay.FullRowSelect = true;
            this.lsvPay.HideSelection = false;
            this.lsvPay.Location = new System.Drawing.Point(12, 56);
            this.lsvPay.Name = "lsvPay";
            this.lsvPay.Size = new System.Drawing.Size(776, 109);
            this.lsvPay.TabIndex = 0;
            this.lsvPay.UseCompatibleStateImageBehavior = false;
            this.lsvPay.View = System.Windows.Forms.View.Details;
            this.lsvPay.SelectedIndexChanged += new System.EventHandler(this.lsvPay_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "이름";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "미팅 약속 갯수";
            this.columnHeader2.Width = 126;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "계약 완료 갯수";
            this.columnHeader4.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "총 금액";
            this.columnHeader3.Width = 134;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "정산";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(632, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "파일 저장";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "미팅 금액 : ";
            // 
            // mettingValue
            // 
            this.mettingValue.Location = new System.Drawing.Point(78, 20);
            this.mettingValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.mettingValue.Name = "mettingValue";
            this.mettingValue.Size = new System.Drawing.Size(111, 21);
            this.mettingValue.TabIndex = 5;
            this.mettingValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mettingValue.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // lsvPayList
            // 
            this.lsvPayList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeadder1,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader20,
            this.columnHeader27});
            this.lsvPayList.FullRowSelect = true;
            this.lsvPayList.HideSelection = false;
            this.lsvPayList.LabelEdit = true;
            this.lsvPayList.Location = new System.Drawing.Point(12, 196);
            this.lsvPayList.MultiSelect = false;
            this.lsvPayList.Name = "lsvPayList";
            this.lsvPayList.Size = new System.Drawing.Size(776, 138);
            this.lsvPayList.TabIndex = 6;
            this.lsvPayList.UseCompatibleStateImageBehavior = false;
            this.lsvPayList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeadder1
            // 
            this.columnHeadder1.Text = "번호";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "일자";
            this.columnHeader18.Width = 89;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "가게명";
            this.columnHeader19.Width = 102;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "주소";
            this.columnHeader21.Width = 156;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "연락처";
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "상담내용";
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "DB작성자";
            this.columnHeader24.Width = 102;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "담당 O/B사원";
            this.columnHeader25.Width = 108;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "담당 영업사원";
            this.columnHeader26.Width = 94;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "방문일자";
            this.columnHeader20.Width = 96;
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "방문결과";
            this.columnHeader27.Width = 111;
            // 
            // contractValue
            // 
            this.contractValue.Location = new System.Drawing.Point(323, 20);
            this.contractValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.contractValue.Name = "contractValue";
            this.contractValue.Size = new System.Drawing.Size(111, 21);
            this.contractValue.TabIndex = 8;
            this.contractValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.contractValue.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "계약 완료 금액 : ";
            // 
            // lsvContractList
            // 
            this.lsvContractList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.lsvContractList.FullRowSelect = true;
            this.lsvContractList.HideSelection = false;
            this.lsvContractList.LabelEdit = true;
            this.lsvContractList.Location = new System.Drawing.Point(12, 364);
            this.lsvContractList.MultiSelect = false;
            this.lsvContractList.Name = "lsvContractList";
            this.lsvContractList.Size = new System.Drawing.Size(776, 159);
            this.lsvContractList.TabIndex = 9;
            this.lsvContractList.UseCompatibleStateImageBehavior = false;
            this.lsvContractList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "번호";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "일자";
            this.columnHeader6.Width = 89;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "가게명";
            this.columnHeader7.Width = 102;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "주소";
            this.columnHeader8.Width = 156;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "연락처";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "상담내용";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "DB작성자";
            this.columnHeader11.Width = 102;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "담당 O/B사원";
            this.columnHeader12.Width = 108;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "담당 영업사원";
            this.columnHeader13.Width = 94;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "방문일자";
            this.columnHeader14.Width = 96;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "방문결과";
            this.columnHeader15.Width = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "미팅 리스트 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "계약 리스트 : ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(440, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 37);
            this.button3.TabIndex = 13;
            this.button3.Text = "다시 계산";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // OBPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 535);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsvContractList);
            this.Controls.Add(this.contractValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsvPayList);
            this.Controls.Add(this.mettingValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lsvPay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OBPay";
            this.Text = "OBPay";
            this.Load += new System.EventHandler(this.OBPay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mettingValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvPay;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown mettingValue;
        private System.Windows.Forms.ListView lsvPayList;
        private System.Windows.Forms.ColumnHeader columnHeadder1;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.NumericUpDown contractValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lsvContractList;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
    }
}