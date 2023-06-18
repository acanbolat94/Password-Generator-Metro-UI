using MetroFramework.Forms;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PasswordGenerator.UI.UIforms
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            ShadowType = MetroFormShadowType.AeroShadow;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            try
            {
                int lengthOfPassword = 8;
                string valid = "acnbssABCDEFGHIJKLMNOZ1234567890!$_-?";
                StringBuilder strB = new StringBuilder(100);
                Random random = new Random();
                while (0 < lengthOfPassword--)
                {
                    strB.Append(valid[random.Next(valid.Length)]);
                }
                lblPassword.Text = strB.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblPassword.Text);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Clipboard.GetText());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = new ListViewItem(tboxUserName.Text);


                int lengthOfPassword = 8;
                string valid = tboxPasswordCharacter.Text;
                StringBuilder strB = new StringBuilder(100);
                Random random = new Random();
                while (0 < lengthOfPassword--)
                {
                    strB.Append(valid[random.Next(valid.Length)]);
                }
                //lblPassword.Text = strB.ToString();

                string pass = strB.ToString();


                item.SubItems.Add(strB.ToString());



                tboxUserName.Clear();
                tboxUserName.Focus();


                listView1.Items.Add(item);

                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gboxMultiple_Enter(object sender, EventArgs e)
        {

        }

        private void btnExporttoExcel_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xls", ValidateNames = true })
            {
                if (sfd.ShowDialog()==DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Username";
                    ws.Cells[1, 2] = "Password";
                    int i = 2;
                    foreach (ListViewItem item in listView1.Items)
                    {
                        ws.Cells[i, 1] = item.SubItems[0].Text;
                        ws.Cells[i, 2] = item.SubItems[1].Text;
                        i++;
                    }
                    wb.SaveAs(sfd.FileName,XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                }
            }
            
        }
    }
}
