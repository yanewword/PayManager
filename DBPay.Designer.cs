namespace PayManager
{
    partial class DBPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBPay));
            this.lsvPay = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.payValue = new System.Windows.Forms.NumericUpDown();
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
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.payValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvPay
            // 
            this.lsvPay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
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
            this.columnHeader2.Text = "갯수";
            this.columnHeader2.Width = 126;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "총 금액";
            this.columnHeader3.Width = 134;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(709, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "정산";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(628, 13);
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
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "금액 : ";
            // 
            // payValue
            // 
            this.payValue.Location = new System.Drawing.Point(66, 20);
            this.payValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.payValue.Name = "payValue";
            this.payValue.Size = new System.Drawing.Size(111, 21);
            this.payValue.TabIndex = 5;
            this.payValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.payValue.Value = new decimal(new int[] {
            700,
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
            this.lsvPayList.Location = new System.Drawing.Point(12, 159);
            this.lsvPayList.MultiSelect = false;
            this.lsvPayList.Name = "lsvPayList";
            this.lsvPayList.Size = new System.Drawing.Size(776, 359);
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(183, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 37);
            this.button3.TabIndex = 7;
            this.button3.Text = "다시 계산";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DBPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 530);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lsvPayList);
            this.Controls.Add(this.payValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lsvPay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DBPay";
            this.Text = "DBPay";
            this.Load += new System.EventHandler(this.DBPay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payValue)).EndInit();
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
        private System.Windows.Forms.NumericUpDown payValue;
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
        private System.Windows.Forms.Button button3;
    }
}