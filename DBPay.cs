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
    public partial class DBPay : Form
    {
        private frmMain Main;
        public DBPay(frmMain main)
        {
            InitializeComponent();
            Main = main;
        }

        private void DBPay_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            lsvPay.Items.Clear();
            lsvPayList.Items.Clear();

            string query = "select dbmanager, count(shopname) from precontract where dbmanager <> '' and dbpay is null group by dbmanager";
            DataSet ds = new DataSet();
            OleDbDataAdapter adp = new OleDbDataAdapter(query, Main.conn);
            adp.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows) {
                ListViewItem lsvItem = lsvPay.Items.Add(row.ItemArray[0].ToString());
                int index = 0;
                foreach (object colItem in row.ItemArray) {
                    if (index == 0) {
                        index++;
                        continue;
                    }
                    string str = colItem.ToString();
                    lsvItem.SubItems.Add(str);
                    index++;
                    if (index == 2) {
                        lsvItem.SubItems.Add((payValue.Value * int.Parse(str)).ToString());
                    }
                }
            }
        }
        private void lsvPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvPay.SelectedItems.Count == 0)
                return;

            lsvPayList.Items.Clear();

            string id = lsvPay.SelectedItems[0].Text;

            string query = "select ID, inputdate, shopname, address, phonenumber, content, dbmanager, obmanager, salespersion, contractdate, resultcontent, inputdate  from precontract where dbmanager = '" + id + "'";
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정산 완료 체크를 하시겠습니까?", "정산", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                string query = "UPDATE precontract SET dbpay = 'TRUE' where dbmanager <> '' and dbpay is null";

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
                    string tempName = name;
                    char[] changeChar = { '\\', '/', '?', '*', '[', ']' };
                    foreach (char c in changeChar)
                        tempName = tempName.Replace(c, ' ');

                    workSheet.Name = tempName;


                    string query = "select ID, inputdate, shopname, address, phonenumber, content, dbmanager, obmanager, salespersion, contractdate, resultcontent from precontract where dbmanager = '" + name + "'";
                    DataSet ds = new DataSet();
                    OleDbDataAdapter adp = new OleDbDataAdapter(query, Main.conn);
                    adp.Fill(ds);

                    workSheet.Cells[1, 1] = lsvPay.Columns[0].Text;
                    workSheet.Cells[1, 2] = lsvPay.Columns[1].Text;
                    workSheet.Cells[1, 3] = lsvPay.Columns[2].Text;
                    workSheet.Cells[2, 1] = lsvPay.Items[i].SubItems[0].Text;
                    workSheet.Cells[2, 2] = lsvPay.Items[i].SubItems[1].Text;
                    workSheet.Cells[2, 3] = lsvPay.Items[i].SubItems[2].Text;


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
