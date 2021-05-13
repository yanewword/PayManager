namespace PayManager
{
    partial class SalerPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalerPay));
            this.lsvPay = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dbPay = new System.Windows.Forms.NumericUpDown();
            this.lsvPayList = new System.Windows.Forms.ListView();
            this.columnHeader33 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.noneDbPay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lsvFailList = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader31 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader34 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noneDbPay)).BeginInit();
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
            this.lsvPay.Size = new System.Drawing.Size(776, 97);
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
            this.columnHeader2.Text = "DB 제공 갯수";
            this.columnHeader2.Width = 126;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DB 미 제공 갯수";
            this.columnHeader4.Width = 113;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "총 금액";
            this.columnHeader3.Width = 134;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 12);
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
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "DB 제공 금액 : ";
            // 
            // dbPay
            // 
            this.dbPay.Location = new System.Drawing.Point(99, 20);
            this.dbPay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.dbPay.Name = "dbPay";
            this.dbPay.Size = new System.Drawing.Size(111, 21);
            this.dbPay.TabIndex = 5;
            this.dbPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dbPay.Value = new decimal(new int[] {
            35000,
            0,
            0,
            0});
            // 
            // lsvPayList
            // 
            this.lsvPayList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader33,
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
            this.columnHeader17,
            this.columnHeader28,
            this.columnHeader29,
            this.columnHeader15});
            this.lsvPayList.FullRowSelect = true;
            this.lsvPayList.HideSelection = false;
            this.lsvPayList.LabelEdit = true;
            this.lsvPayList.Location = new System.Drawing.Point(12, 184);
            this.lsvPayList.MultiSelect = false;
            this.lsvPayList.Name = "lsvPayList";
            this.lsvPayList.Size = new System.Drawing.Size(776, 169);
            this.lsvPayList.TabIndex = 6;
            this.lsvPayList.UseCompatibleStateImageBehavior = false;
            this.lsvPayList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader33
            // 
            this.columnHeader33.Text = "번호";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "일자";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "서류수신";
            this.columnHeader6.Width = 83;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "가게명(상호명)";
            this.columnHeader7.Width = 108;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "분야";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "사업자등록번호";
            this.columnHeader9.Width = 101;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "연락처";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "주소";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "대표자";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "영업담당";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "스토어ID";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "DB제공여부";
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "DB담당자";
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "계약완";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "비고";
            // 
            // noneDbPay
            // 
            this.noneDbPay.Location = new System.Drawing.Point(328, 20);
            this.noneDbPay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.noneDbPay.Name = "noneDbPay";
            this.noneDbPay.Size = new System.Drawing.Size(111, 21);
            this.noneDbPay.TabIndex = 8;
            this.noneDbPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.noneDbPay.Value = new decimal(new int[] {
            55000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "DB 미 제공 금액 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "정산 목록 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "실패 목록 : ";
            // 
            // lsvFailList
            // 
            this.lsvFailList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader27,
            this.columnHeader30,
            this.columnHeader31,
            this.columnHeader32,
            this.columnHeader34});
            this.lsvFailList.FullRowSelect = true;
            this.lsvFailList.HideSelection = false;
            this.lsvFailList.LabelEdit = true;
            this.lsvFailList.Location = new System.Drawing.Point(12, 386);
            this.lsvFailList.MultiSelect = false;
            this.lsvFailList.Name = "lsvFailList";
            this.lsvFailList.Size = new System.Drawing.Size(776, 169);
            this.lsvFailList.TabIndex = 11;
            this.lsvFailList.UseCompatibleStateImageBehavior = false;
            this.lsvFailList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "번호";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "일자";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "서류수신";
            this.columnHeader19.Width = 83;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "가게명(상호명)";
            this.columnHeader20.Width = 108;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "분야";
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "사업자등록번호";
            this.columnHeader22.Width = 101;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "연락처";
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "주소";
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "대표자";
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "영업담당";
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "스토어ID";
            // 
            // columnHeader30
            // 
            this.columnHeader30.Text = "DB제공여부";
            // 
            // columnHeader31
            // 
            this.columnHeader31.Text = "DB담당자";
            // 
            // columnHeader32
            // 
            this.columnHeader32.Text = "계약완료";
            // 
            // columnHeader34
            // 
            this.columnHeader34.Text = "비고";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(445, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 37);
            this.button3.TabIndex = 14;
            this.button3.Text = "다시 계산";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SalerPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 567);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lsvFailList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.noneDbPay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsvPayList);
            this.Controls.Add(this.dbPay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lsvPay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalerPay";
            this.Text = "SalerPay";
            this.Load += new System.EventHandler(this.OBPay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noneDbPay)).EndInit();
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
        private System.Windows.Forms.NumericUpDown dbPay;
        private System.Windows.Forms.ListView lsvPayList;
        private System.Windows.Forms.NumericUpDown noneDbPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
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
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.ColumnHeader columnHeader29;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader33;
        private System.Windows.Forms.ListView lsvFailList;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader30;
        private System.Windows.Forms.ColumnHeader columnHeader31;
        private System.Windows.Forms.ColumnHeader columnHeader32;
        private System.Windows.Forms.ColumnHeader columnHeader34;
        private System.Windows.Forms.Button button3;
    }
}