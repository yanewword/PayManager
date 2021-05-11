namespace PayManager
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPreContract = new System.Windows.Forms.Button();
            this.btnContract = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.tbxPreContractFilePath = new System.Windows.Forms.TextBox();
            this.tbxContractFilePath = new System.Windows.Forms.TextBox();
            this.tbxPayFile = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnDBUpload = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.btnResetPay = new System.Windows.Forms.Button();
            this.btnAllReset = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnPreContract
            // 
            this.btnPreContract.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPreContract.Location = new System.Drawing.Point(12, 37);
            this.btnPreContract.Name = "btnPreContract";
            this.btnPreContract.Size = new System.Drawing.Size(237, 56);
            this.btnPreContract.TabIndex = 0;
            this.btnPreContract.Text = "신규 업체 파일";
            this.btnPreContract.UseVisualStyleBackColor = true;
            this.btnPreContract.Click += new System.EventHandler(this.btnPreContract_Click);
            // 
            // btnContract
            // 
            this.btnContract.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnContract.Location = new System.Drawing.Point(12, 99);
            this.btnContract.Name = "btnContract";
            this.btnContract.Size = new System.Drawing.Size(237, 56);
            this.btnContract.TabIndex = 1;
            this.btnContract.Text = "계약 업체 파일";
            this.btnContract.UseVisualStyleBackColor = true;
            this.btnContract.Click += new System.EventHandler(this.btnContract_Click);
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPay.Location = new System.Drawing.Point(12, 161);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(237, 56);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "급여 정산표";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // tbxPreContractFilePath
            // 
            this.tbxPreContractFilePath.AllowDrop = true;
            this.tbxPreContractFilePath.Location = new System.Drawing.Point(255, 37);
            this.tbxPreContractFilePath.Name = "tbxPreContractFilePath";
            this.tbxPreContractFilePath.Size = new System.Drawing.Size(409, 21);
            this.tbxPreContractFilePath.TabIndex = 3;
            this.tbxPreContractFilePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbxPreContractFilePath_DragDrop);
            this.tbxPreContractFilePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbxPreContractFilePath_DragEnter);
            // 
            // tbxContractFilePath
            // 
            this.tbxContractFilePath.AllowDrop = true;
            this.tbxContractFilePath.Location = new System.Drawing.Point(255, 99);
            this.tbxContractFilePath.Name = "tbxContractFilePath";
            this.tbxContractFilePath.Size = new System.Drawing.Size(409, 21);
            this.tbxContractFilePath.TabIndex = 4;
            this.tbxContractFilePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbxContractFilePath_DragDrop);
            this.tbxContractFilePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbxContractFilePath_DragEnter);
            // 
            // tbxPayFile
            // 
            this.tbxPayFile.AllowDrop = true;
            this.tbxPayFile.Location = new System.Drawing.Point(255, 161);
            this.tbxPayFile.Name = "tbxPayFile";
            this.tbxPayFile.Size = new System.Drawing.Size(409, 21);
            this.tbxPayFile.TabIndex = 5;
            this.tbxPayFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbxPayFile_DragDrop);
            this.tbxPayFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbxPayFile_DragEnter);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(12, 285);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 56);
            this.button4.TabIndex = 6;
            this.button4.Text = "DB 정산";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(235, 285);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(207, 56);
            this.button5.TabIndex = 7;
            this.button5.Text = "OB 정산";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(457, 285);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(207, 56);
            this.button6.TabIndex = 8;
            this.button6.Text = "영업 정산";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnDBUpload
            // 
            this.btnDBUpload.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDBUpload.Location = new System.Drawing.Point(12, 223);
            this.btnDBUpload.Name = "btnDBUpload";
            this.btnDBUpload.Size = new System.Drawing.Size(652, 56);
            this.btnDBUpload.TabIndex = 9;
            this.btnDBUpload.Text = "DB 업로드";
            this.btnDBUpload.UseVisualStyleBackColor = true;
            this.btnDBUpload.Click += new System.EventHandler(this.btnDBUpload_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 349);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1144, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.ItemHeight = 12;
            this.lstLog.Location = new System.Drawing.Point(670, 37);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(462, 304);
            this.lstLog.TabIndex = 11;
            // 
            // btnResetPay
            // 
            this.btnResetPay.Location = new System.Drawing.Point(12, 8);
            this.btnResetPay.Name = "btnResetPay";
            this.btnResetPay.Size = new System.Drawing.Size(120, 23);
            this.btnResetPay.TabIndex = 12;
            this.btnResetPay.Text = "정산 데이터 초기화";
            this.btnResetPay.UseVisualStyleBackColor = true;
            this.btnResetPay.Click += new System.EventHandler(this.btnResetPay_Click);
            // 
            // btnAllReset
            // 
            this.btnAllReset.Location = new System.Drawing.Point(138, 8);
            this.btnAllReset.Name = "btnAllReset";
            this.btnAllReset.Size = new System.Drawing.Size(121, 23);
            this.btnAllReset.TabIndex = 13;
            this.btnAllReset.Text = "모든 데이터 초기화";
            this.btnAllReset.UseVisualStyleBackColor = true;
            this.btnAllReset.Click += new System.EventHandler(this.btnAllReset_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(255, 70);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(409, 23);
            this.progressBar1.TabIndex = 14;
            this.progressBar1.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbxPreContractFilePath_DragDrop);
            this.progressBar1.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbxPreContractFilePath_DragEnter);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(255, 132);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(409, 23);
            this.progressBar2.TabIndex = 15;
            this.progressBar2.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbxContractFilePath_DragDrop);
            this.progressBar2.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbxContractFilePath_DragEnter);
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(255, 194);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(409, 23);
            this.progressBar3.TabIndex = 16;
            this.progressBar3.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbxPayFile_DragDrop);
            this.progressBar3.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbxPayFile_DragEnter);
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 371);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnAllReset);
            this.Controls.Add(this.btnResetPay);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnDBUpload);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tbxPayFile);
            this.Controls.Add(this.tbxContractFilePath);
            this.Controls.Add(this.tbxPreContractFilePath);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnContract);
            this.Controls.Add(this.btnPreContract);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "정산 관리자";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPreContract;
        private System.Windows.Forms.Button btnContract;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox tbxPreContractFilePath;
        private System.Windows.Forms.TextBox tbxContractFilePath;
        private System.Windows.Forms.TextBox tbxPayFile;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnDBUpload;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Button btnResetPay;
        private System.Windows.Forms.Button btnAllReset;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
    }
}

