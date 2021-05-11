using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using Microsoft.Office.Interop;
using System.Runtime.InteropServices;
using System.Threading;

namespace PayManager
{
    public partial class frmMain : Form
    {
        public OleDbConnection conn;

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        public frmMain()
        {
            InitializeComponent();

            string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + System.Windows.Forms.Application.StartupPath + "\\db.mdb" + ";Jet OLEDB:Database Password=";
            conn = new System.Data.OleDb.OleDbConnection(connStr);
            conn.Open();
        }

        private void Log(string log) {
            lstLog.Items.Add(DateTime.Now.ToShortTimeString() + " : " + log);
        }

        private void btnPreContract_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK) {
                tbxPreContractFilePath.Text = ofd.FileName;
            }

        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbxContractFilePath.Text = ofd.FileName;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbxPayFile.Text = ofd.FileName;
            }
        }

        private void tbxPreContractFilePath_DragDrop(object sender, DragEventArgs e)
        {
            tbxPreContractFilePath.Text = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
        }

        private void tbxContractFilePath_DragDrop(object sender, DragEventArgs e)
        {
            tbxContractFilePath.Text = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
        }

        private void tbxPayFile_DragDrop(object sender, DragEventArgs e)
        {
            tbxPayFile.Text = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
        }

        private void btnDBUpload_Click(object sender, EventArgs e)
        {
            Log("사전 계약 파일을 읽고 있습니다.");
            UploadPreContract();
            progressBar1.Value = 100;
            Log("사전 계약 DB 저장 완료");

            Log("계약 파일을 읽고 있습니다.");
            UploadContract();
            progressBar2.Value = 100;
            Log("계약 DB 저장 완료");

            Log("정산 파일을 읽고 있습니다.");
            UploadPayTable();
            progressBar3.Value = 100;
            Log("정산 DB 저장 완료");

            Log("업로드가 완료되었습니다.");
        }

        private void UploadPreContract()
        {
            if (string.IsNullOrEmpty(tbxPreContractFilePath.Text))
                return;

            if (File.Exists(tbxPreContractFilePath.Text) == false)
                return;

            Dictionary<string, string> phoneNumber = new Dictionary<string, string>();

            string selectQuery = "SELECT phonenumber FROM precontract";
            DataSet ds = new DataSet();
            OleDbDataAdapter adp = new OleDbDataAdapter(selectQuery, conn);
            adp.Fill(ds);

            Log("사전 계약 DB에 " + ds.Tables[0].Rows.Count.ToString() + "개 데이터가 있습니다");

            foreach (DataRow row in ds.Tables[0].Rows) {
                foreach (object dat in row.ItemArray) {
                    if (string.IsNullOrEmpty(dat.ToString()) == false) {
                        try {
                            phoneNumber.Add(dat.ToString(), "");
                        } catch {
                            continue;
                        }
                    }
                }
            }

            Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = application.Workbooks.Open(tbxPreContractFilePath.Text);
            application.Visible = false;

            int insertCount = 0;

            string[] header = {"일자", "가게명(상호명)", "주 소", "연락처", "상담내용"};
            for (int i = 0; i < header.Length; i++) {
                string h = (workbook.Worksheets[1].UsedRange.Cells[1, i + 1] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                if (h != header[i]) {
                    Log("잘못된 사전 계약 파일 입니다.");
                    ExitExcel(application);
                    return;
                }
            }

            //foreach (Microsoft.Office.Interop.Excel.Worksheet worksheet1 in workbook.Worksheets)
            for (int k = 0; k < workbook.Worksheets.Count; k++)
            {
                Microsoft.Office.Interop.Excel.Range range = workbook.Worksheets[k + 1].UsedRange;
                int blankCount = 0;
                int stepValue = (100 / workbook.Worksheets.Count);

                for (int i = 2; i <= range.Rows.Count; ++i)
                {
                    progressBar1.Value = stepValue * k + (int)(((float)i / (float)range.Rows.Count) * (float)stepValue);
                    if (blankCount == 10) {
                        break;
                    }

                    string[] data = new string[10];
                    for (int j = 1; j <= 10; ++j)
                    {
                        object dat = (range.Cells[i, j] as Microsoft.Office.Interop.Excel.Range).Value2;
                        if (dat == null)
                            continue;

                        data[j - 1] = dat.ToString().Replace("\'", "\'\'");
                    }


                    bool bCheck = false;
                    foreach (string d in data)
                    {
                        if (string.IsNullOrEmpty(d) == false)
                        {
                            bCheck = true;
                            break;
                        }
                    }

                    if (bCheck == false)
                    {
                        blankCount++;
                        continue;
                    }

                    if (string.IsNullOrEmpty(data[3]) || phoneNumber.ContainsKey(data[3]))
                    {
                        continue;
                    }

                    DateTime current = new DateTime();

                    if (string.IsNullOrEmpty(data[0])) {
                        current = DateTime.Parse("1990-01-01");
                    } else {
                        double doubleDate;
                        if (double.TryParse(data[0], out doubleDate))
                        {
                            current = DateTime.FromOADate(doubleDate);
                        }
                    }

                    string insertQuery = String.Format("INSERT INTO precontract (inputdate, shopname, address, phonenumber, content, dbmanager, obmanager, salespersion, contractdate, resultcontent) VALUES(" +
                            "'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')",
                            current.ToShortDateString(), data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8], data[9]);

                    OleDbCommand OLECmd = new OleDbCommand(insertQuery, conn);
                    OLECmd.CommandType = CommandType.Text;
                    OLECmd.ExecuteNonQuery();
                    OLECmd.Dispose();
                    insertCount++;
                }
            }

            workbook.Close();

            Log("신규 사전 계약 데이터가 " + insertCount + "개 데이터가 DB에 저장 되었습니다.");

            ExitExcel(application);
        }

        private void UploadContract()
        {
            if (string.IsNullOrEmpty(tbxContractFilePath.Text))
                return;

            if (File.Exists(tbxContractFilePath.Text) == false)
                return;

            Dictionary<string, string> sotreid = new Dictionary<string, string>();

            string selectQuery = "SELECT storeid FROM contract";
            DataSet ds = new DataSet();
            OleDbDataAdapter adp = new OleDbDataAdapter(selectQuery, conn);
            adp.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                foreach (object dat in row.ItemArray)
                {
                    if (string.IsNullOrEmpty(dat.ToString()) == false)
                    {
                        if (sotreid.ContainsKey(dat.ToString()) == false)
                        {
                            try {
                                sotreid.Add(dat.ToString(), "");
                            } catch {
                                continue;
                            }
                        }
                    }
                }
            }

            Log("계약 DB에 " + sotreid.Count.ToString() + "개 데이터가 있습니다");

            Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = application.Workbooks.Open(tbxContractFilePath.Text);
            application.Visible = false;

            string[] header = { "일자", "서류수신", "가게명(상호명)", "분야", "사업자등록번호", "연락처", "주 소", "대표자"};

            for (int i = 0; i < header.Length; i++) {
                string h = (workbook.Worksheets[1].UsedRange.Cells[2, i + 1] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                if (h != header[i]) {
                    Log("잘못된 계약 파일 입니다.");
                    ExitExcel(application);
                    return;
                }
            }

            int insertDataCount = 0;

            for (int k = 0; k < workbook.Worksheets.Count; k++) {
                Microsoft.Office.Interop.Excel.Range range = workbook.Worksheets[k + 1].UsedRange;
                int blankCount = 0;
                int stepValue = (100 / workbook.Worksheets.Count);

                for (int i = 2; i <= range.Rows.Count; ++i)
                {
                    progressBar2.Value = stepValue * k + (int)(((float)i / (float)range.Rows.Count) * (float)stepValue);

                    if (blankCount == 10) {
                        break;
                    }

                    string[] data = new string[17];
                    for (int j = 1; j <= 17; ++j)
                    {
                        object dat = (range.Cells[i, j] as Microsoft.Office.Interop.Excel.Range).Value2;
                        if (dat == null)
                            continue;

                        data[j - 1] = dat.ToString().Replace("\'", "\'\'");
                    }


                    bool bCheck = false;
                    foreach (string d in data)
                    {
                        if (string.IsNullOrEmpty(d) == false)
                        {
                            bCheck = true;
                            break;
                        }
                    }

                    if (bCheck == false)
                    {
                        blankCount++;
                        continue;
                    }

                    if (string.IsNullOrEmpty(data[4]) || sotreid.ContainsKey(data[4]))
                    {
                        continue;
                    }

                    DateTime current = new DateTime();

                    if (string.IsNullOrEmpty(data[0]))
                    {
                        current = DateTime.Parse("1990-01-01");
                    }
                    else
                    {
                        double doubleDate;

                        if (double.TryParse(data[0], out doubleDate))
                        {
                            current = DateTime.FromOADate(doubleDate);
                        }
                        else if (DateTime.TryParse(data[0], out current))
                        {
                        }
                        else {
                            current = DateTime.Parse("1990-01-01");
                        }
                    }

                    string insertQuery = String.Format("INSERT INTO contract (inputdate, recevicedocument, shopname, type, registrationnumber, phonenumber, address, representative, salerpersion, storeid, newtoss, oletoss, offerdb, dbmanager, iscontract, pay, content) VALUES(" +
                            "'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}')",
                            current.ToShortDateString(), data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8], data[9], data[10], data[11], data[12], data[13], data[14], data[15], data[16]); 

                    OleDbCommand OLECmd = new OleDbCommand(insertQuery, conn);
                    OLECmd.CommandType = CommandType.Text;
                    OLECmd.ExecuteNonQuery();
                    OLECmd.Dispose();

                    insertDataCount++;
                }
            }

            Log("신규 계약 데이터가 " + insertDataCount + "개 업로드 되었습니다.");

            workbook.Close();
            ExitExcel(application);
        }

        public void ExitExcel(Microsoft.Office.Interop.Excel.Application application)
        {
            uint processId = 0;
            GetWindowThreadProcessId(new IntPtr(application.Hwnd), out processId);
            application.Quit();
            if (processId != 0) {
                System.Diagnostics.Process excelProcess = System.Diagnostics.Process.GetProcessById((int)processId);
                excelProcess.CloseMainWindow();
                excelProcess.Refresh();
                excelProcess.Kill();
            }
        }

        private void UploadPayTable() {
            if (string.IsNullOrEmpty(tbxPayFile.Text))
                return;

            if (File.Exists(tbxPayFile.Text) == false)
                return;
            {
                string deleteQuery = "DELETE FROM paytable";

                OleDbCommand OLECmd = new OleDbCommand(deleteQuery, conn);
                OLECmd.CommandType = CommandType.Text;
                OLECmd.ExecuteNonQuery();
                OLECmd.Dispose();
            }


            Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = application.Workbooks.Open(tbxPayFile.Text);
            application.Visible = false;

            string[] header = { "Storeid", "Storename", "지역1", "대행사별", "리스트업날짜", "정산가능"};

            for (int i = 0; i < header.Length; i++) {
                string h = (workbook.Worksheets[1].UsedRange.Cells[4, i + 1] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                if (h != header[i]) {
                    Log("잘못된 정산 파일 입니다.");
                    ExitExcel(application);
                    return;
                }
            }

            int dataCount = 0;
            for (int k = 0; k < workbook.Worksheets.Count; k++) {
                Microsoft.Office.Interop.Excel.Range range = workbook.Worksheets[k + 1].UsedRange;
                int blankCount = 0;
                bool bBegin = false;

                int stepValue = (100 / workbook.Worksheets.Count);

                for (int i = 1; i <= range.Rows.Count; ++i) {
                    progressBar3.Value = stepValue * k + (int)(((float)i / (float)range.Rows.Count) * (float)stepValue);

                    object temp = (range.Cells[i, 1] as Microsoft.Office.Interop.Excel.Range).Value2;
                    if (temp == null)
                        continue;

                    if (bBegin == false && temp.ToString() != "Storeid")
                        continue;

                    if (temp.ToString() == "Storeid") {
                        bBegin = true;
                        continue;
                    }

                    if (blankCount == 10)
                    {
                        break;
                    }

                    string[] data = new string[10];
                    for (int j = 1; j <= 10; ++j)
                    {
                        object dat = (range.Cells[i, j] as Microsoft.Office.Interop.Excel.Range).Value2;
                        if (dat == null)
                            continue;

                        int tryValue = 0;
                        if (i == 1)
                        {
                            if (int.TryParse(dat.ToString(), out tryValue) == false)
                                break;

                        }

                        data[j - 1] = dat.ToString().Replace("\'", "\'\'");
                    }


                    bool bCheck = false;
                    foreach (string d in data)
                    {
                        if (string.IsNullOrEmpty(d) == false)
                        {
                            bCheck = true;
                            break;
                        }
                    }

                    if (bCheck == false)
                    {
                        blankCount++;
                        continue;
                    }

                    DateTime dateTime = new DateTime();

                    if (string.IsNullOrEmpty(data[9]))
                    {
                        dateTime = DateTime.Parse("1990-01-01");
                    }
                    else
                    {
                        double doubleDate;

                        if (double.TryParse(data[9], out doubleDate))
                        {
                            dateTime = DateTime.FromOADate(doubleDate);
                        }
                        else if (DateTime.TryParse(data[0], out dateTime))
                        {
                        }
                        else
                        {
                            dateTime = DateTime.Parse("1990-01-01");
                        }
                    }

                    string insertQuery = String.Format("INSERT INTO paytable (storeid, storename, address, proxy, listupdate, avablecalc, fail, code, proxytype, currentDate) VALUES(" +
                            "'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')",
                            data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8], dateTime.ToShortDateString());

                    OleDbCommand OLECmd = new OleDbCommand(insertQuery, conn);
                    OLECmd.CommandType = CommandType.Text;
                    OLECmd.ExecuteNonQuery();
                    OLECmd.Dispose();

                    dataCount++;
                }
            }

            workbook.Close();

            Log("정산 데이터가 " + dataCount + "개 데이터가 있습니다");

            ExitExcel(application);
        }

        private void tbxPreContractFilePath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void tbxContractFilePath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void tbxPayFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DBPay pay = new DBPay(this);
            pay.ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OBPay pay = new OBPay(this);
            pay.ShowDialog();
            
        }

        private void btnResetPay_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("모든 정산 데이터를 초기화 하시겠습니까?", "정산", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                string query = "UPDATE precontract SET OBPay = null, DBPay = null";

                OleDbCommand OLECmd = new OleDbCommand(query, conn);
                OLECmd.CommandType = CommandType.Text;
                OLECmd.ExecuteNonQuery();
                OLECmd.Dispose();

                query = "UPDATE contract SET salerpay = null";

                OLECmd = new OleDbCommand(query, conn);
                OLECmd.CommandType = CommandType.Text;
                OLECmd.ExecuteNonQuery();
                OLECmd.Dispose();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SalerPay dlg = new SalerPay(this);
            dlg.ShowDialog();
        }

        private void btnAllReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("모든 데이터를 초기화 하시겠습니까?", "정산", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                string deleteQuery = "DELETE FROM precontract";

                OleDbCommand OLECmd = new OleDbCommand(deleteQuery, conn);
                OLECmd.CommandType = CommandType.Text;
                OLECmd.ExecuteNonQuery();
                OLECmd.Dispose();

                deleteQuery = "DELETE FROM contract";
                OLECmd = new OleDbCommand(deleteQuery, conn);
                OLECmd.CommandType = CommandType.Text;
                OLECmd.ExecuteNonQuery();
                OLECmd.Dispose();

                deleteQuery = "DELETE FROM paytable";
                OLECmd = new OleDbCommand(deleteQuery, conn);
                OLECmd.CommandType = CommandType.Text;
                OLECmd.ExecuteNonQuery();
                OLECmd.Dispose();
            }
        }
    }
}
