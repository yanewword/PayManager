using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using Microsoft.Office.Interop;

namespace PayManager
{
    public partial class SalerPay : Form
    {
        private frmMain Main;
        public SalerPay(frmMain main)
        {
            InitializeComponent();
            Main = main;
        }

        class DataCount
        {
            public int dbCount;
            public int noneDbCount;
        };

        private void Init()
        {
            lsvPay.Items.Clear();
            lsvPayList.Items.Clear();
            lsvFailList.Items.Clear();

            Dictionary<string, DataCount> dataList = new Dictionary<string, DataCount>();
            string query = "select contract.salerpersion, contract.offerdb from contract, paytable where contract.storeid = paytable.storeid and contract.salerpay is null and paytable.avablecalc = 'O'";
            DataSet ds = new DataSet();
            OleDbDataAdapter adp = new OleDbDataAdapter(query, Main.conn);
            adp.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows) {
                object[] itemArry = row.ItemArray;

                string obManager = itemArry[0].ToString();

                if (string.IsNullOrEmpty(obManager))
                    continue;

                if (dataList.ContainsKey(obManager) == false) {
                    dataList.Add(obManager, new DataCount());
                }

                DataCount dat = dataList[obManager];

                string result = itemArry[1].ToString().Replace(" ", "").Trim();
                if (result.ToLower() == "true") {
                    dat.dbCount++;
                } else {
                    dat.noneDbCount++;
                }

            }

            foreach (string key in dataList.Keys.ToArray()) {
                DataCount data = dataList[key];
                ListViewItem lsvItem = lsvPay.Items.Add(key);
                lsvItem.SubItems.Add(data.dbCount.ToString());
                lsvItem.SubItems.Add(data.noneDbCount.ToString());
                lsvItem.SubItems.Add(String.Format("{0:#,0}", (data.dbCount* dbPay.Value + data.noneDbCount * noneDbPay.Value)));
            }
        }

        private void OBPay_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void lsvPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvPay.SelectedItems.Count == 0)
                return;

            lsvPayList.Items.Clear();
            lsvFailList.Items.Clear();            

            string id = lsvPay.SelectedItems[0].Text;

            string query = "SELECT contract.ID, contract.inputdate, contract.recevicedocument, contract.shopname, contract.type, contract.registrationnumber, contract.phonenumber, contract.address, contract.representative, contract.salerpersion, contract.storeid, contract.offerdb, contract.dbmanager, contract.iscontract, contract.content FROM contract, paytable where contract.storeid = paytable.storeid and paytable.avablecalc = 'O' and contract.salerpersion = '" + id +"'";
            DataSet ds = new DataSet();
            OleDbDataAdapter adp = new OleDbDataAdapter(query, Main.conn);
            adp.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows) {
                ListViewItem lsvItem = lsvPayList.Items.Add(row.ItemArray[0].ToString());
                int index = 0;
                foreach (object colItem in row.ItemArray) {
                    if (index == 0) {
                        index++;
                        continue;
                    }
                    string str = colItem.ToString();
                    lsvItem.SubItems.Add(str);
                    index++;
                }
            }

            query = "SELECT contract.ID, contract.inputdate, contract.recevicedocument, contract.shopname, contract.type, contract.registrationnumber, contract.phonenumber, contract.address, contract.representative, contract.salerpersion, contract.storeid, contract.offerdb, contract.dbmanager, contract.iscontract, contract.content FROM contract, paytable where contract.storeid = paytable.storeid and paytable.avablecalc = 'X' and contract.salerpersion = '" + id + "'";
            ds = new DataSet();
            adp = new OleDbDataAdapter(query, Main.conn);
            adp.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows) {
                ListViewItem lsvItem = lsvFailList.Items.Add(row.ItemArray[0].ToString());
                int index = 0;
                foreach (object colItem in row.ItemArray) {
                    if (index == 0) {
                        index++;
                        continue;
                    }
                    string str = colItem.ToString();
                    lsvItem.SubItems.Add(str);
                    index++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정산 완료 체크를 하시겠습니까?", "정산", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                string query = "UPDATE contract, paytable SET contract.salerpay = 'TRUE' where contract.storeid = paytable.storeid and contract.salerpay is null and paytable.avablecalc = 'O'";

                OleDbCommand OLECmd = new OleDbCommand(query, Main.conn);
                OLECmd.CommandType = CommandType.Text;
                OLECmd.ExecuteNonQuery();
                OLECmd.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel | *.xls";
            if (sfd.ShowDialog() == DialogResult.OK) {
                string fileName = sfd.FileName;

                Microsoft.Office.Interop.Excel.Workbook workBook = Main.ExcelApp.Workbooks.Add(); // 워크북 추가 
                Microsoft.Office.Interop.Excel.Worksheet workSheet;

                for (int i = 0; i < lsvPay.Items.Count; i++) {
                    string name = lsvPay.Items[i].SubItems[0].Text;
                    if (workBook.Worksheets.Count <= i) {
                        workBook.Worksheets.Add();
                    }

                    workSheet = workBook.Worksheets.get_Item(1) as Microsoft.Office.Interop.Excel.Worksheet;
                    workSheet.Name = name;


                    string query = "SELECT contract.ID, contract.inputdate, contract.recevicedocument, contract.shopname, contract.type, contract.registrationnumber, contract.phonenumber, contract.address, contract.representative, contract.salerpersion, contract.storeid, contract.offerdb, contract.dbmanager, contract.iscontract, contract.content FROM contract, paytable where contract.storeid = paytable.storeid and paytable.avablecalc = 'O' and contract.salerpersion = '" + name + "'";
                    DataSet ds = new DataSet();
                    OleDbDataAdapter adp = new OleDbDataAdapter(query, Main.conn);
                    adp.Fill(ds);

                    workSheet.Cells[1, 1] = lsvPay.Columns[0].Text;
                    workSheet.Cells[1, 2] = lsvPay.Columns[1].Text;
                    workSheet.Cells[1, 3] = lsvPay.Columns[2].Text;
                    workSheet.Cells[1, 4] = lsvPay.Columns[3].Text;
                    workSheet.Cells[2, 1] = lsvPay.Items[i].SubItems[0].Text;
                    workSheet.Cells[2, 2] = lsvPay.Items[i].SubItems[1].Text;
                    workSheet.Cells[2, 3] = lsvPay.Items[i].SubItems[2].Text;
                    workSheet.Cells[2, 4] = lsvPay.Items[i].SubItems[3].Text;


                    int colIndex = 1;
                    foreach (ColumnHeader col in lsvPayList.Columns) {
                        workSheet.Cells[3, colIndex] = col.Text;
                        colIndex++;
                    }

                    int rowIndex = 4;
                    foreach (DataRow row in ds.Tables[0].Rows) {
                        colIndex = 1;
                        foreach (object colItem in row.ItemArray) {
                            string str = colItem.ToString();
                            workSheet.Cells[rowIndex, colIndex] = str;
                            colIndex++;
                        }
                        rowIndex++;
                    }

                }
                workBook.SaveAs(fileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                workBook.Close(true);
                MessageBox.Show("저장 완료");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Init();
        }
    }
}
