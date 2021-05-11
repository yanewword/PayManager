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
            lstLog.Items.Add("사전 계약 파일을 올리고 있습니다.");

            UploadPreContract();
            lstLog.Items.Add("사전 계약 파일을 올리고 있습니다.");

            UploadContract();
            lstLog.Items.Add("계약 파일을 올리고 있습니다.");

            UploadPayTable();
            lstLog.Items.Add("정산 파일을 올리고 있습니다.");

            lstLog.Items.Add("업로드가 완료되었습니다.");
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

            lstLog.Items.Add("DB에 " + ds.Tables[0].Rows.Count.ToString() + "개 데이터가 있습니다");

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                foreach (object dat in row.ItemArray)
                {
                    if (string.IsNullOrEmpty(dat.ToString()) == false)
                    {
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

            foreach (Microsoft.Office.Interop.Excel.Worksheet worksheet1 in workbook.Worksheets)
            {
                int blankCount = 0;
                Microsoft.Office.Interop.Excel.Range range = worksheet1.UsedRange;

                for (int i = 2; i <= range.Rows.Count; ++i)
                {
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

            lstLog.Items.Add("신규 사전 계약 데이터가 " + insertCount + "개 데이터가 업로드 되었습니다.");

            uint processId = 0;
            GetWindowThreadProcessId(new IntPtr(application.Hwnd), out processId);
            application.Quit();
            if (processId != 0)
            {
                System.Diagnostics.Process excelProcess = System.Diagnostics.Process.GetProcessById((int)processId);
                excelProcess.CloseMainWindow();
                excelProcess.Refresh();
                excelProcess.Kill();
            }
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

            Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = application.Workbooks.Open(tbxContractFilePath.Text);
            application.Visible = false;

            int insertDataCount = 0; 

            foreach (Microsoft.Office.Interop.Excel.Worksheet worksheet1 in workbook.Worksheets)
            {
                int blankCount = 0;
                Microsoft.Office.Interop.Excel.Range range = worksheet1.UsedRange;

                for (int i = 2; i <= range.Rows.Count; ++i)
                {
                    if (blankCount == 10)
                    {
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

            lstLog.Items.Add("신규 계약 데이터가 " + insertDataCount + "개 업로드 되었습니다.");

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

            int dataCount = 0;
            foreach (Microsoft.Office.Interop.Excel.Worksheet worksheet1 in workbook.Worksheets)
            {
                int blankCount = 0;
                Microsoft.Office.Interop.Excel.Range range = worksheet1.UsedRange;
                bool bBegin = false;
                for (int i = 1; i <= range.Rows.Count; ++i)
                {
                    
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

            lstLog.Items.Add("정산 데이터가 " + dataCount + "개 데이터가 있습니다");

            uint processId = 0;
            GetWindowThreadProcessId(new IntPtr(application.Hwnd), out processId);
            application.Quit();
            if (processId != 0)
            {
                System.Diagnostics.Process excelProcess = System.Diagnostics.Process.GetProcessById((int)processId);
                excelProcess.CloseMainWindow();
                excelProcess.Refresh();
                excelProcess.Kill();
            }
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
