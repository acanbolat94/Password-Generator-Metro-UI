namespace PasswordGenerator.UI.UIforms
{
    partial class MainForm
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
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.gboxMultiple = new System.Windows.Forms.GroupBox();
            this.btnExporttoExcel = new MetroFramework.Controls.MetroButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.tboxUserName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.gboxSingle = new System.Windows.Forms.GroupBox();
            this.btnCopy = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.btnGeneratePassword = new MetroFramework.Controls.MetroButton();
            this.tboxPasswordCharacter = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tlpContainer.SuspendLayout();
            this.gboxMultiple.SuspendLayout();
            this.gboxSingle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpContainer
            // 
            this.tlpContainer.ColumnCount = 2;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContainer.Controls.Add(this.gboxMultiple, 1, 0);
            this.tlpContainer.Controls.Add(this.gboxSingle, 0, 0);
            this.tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainer.Location = new System.Drawing.Point(20, 60);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.RowCount = 1;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContainer.Size = new System.Drawing.Size(657, 344);
            this.tlpContainer.TabIndex = 1;
            // 
            // gboxMultiple
            // 
            this.gboxMultiple.Controls.Add(this.metroLabel3);
            this.gboxMultiple.Controls.Add(this.tboxPasswordCharacter);
            this.gboxMultiple.Controls.Add(this.btnExporttoExcel);
            this.gboxMultiple.Controls.Add(this.listView1);
            this.gboxMultiple.Controls.Add(this.btnAdd);
            this.gboxMultiple.Controls.Add(this.tboxUserName);
            this.gboxMultiple.Controls.Add(this.metroLabel2);
            this.gboxMultiple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxMultiple.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gboxMultiple.Location = new System.Drawing.Point(331, 3);
            this.gboxMultiple.Name = "gboxMultiple";
            this.gboxMultiple.Size = new System.Drawing.Size(323, 338);
            this.gboxMultiple.TabIndex = 1;
            this.gboxMultiple.TabStop = false;
            this.gboxMultiple.Text = "Multiple Generate Password";
            this.gboxMultiple.Enter += new System.EventHandler(this.gboxMultiple_Enter);
            // 
            // btnExporttoExcel
            // 
            this.btnExporttoExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExporttoExcel.Location = new System.Drawing.Point(171, 117);
            this.btnExporttoExcel.Name = "btnExporttoExcel";
            this.btnExporttoExcel.Size = new System.Drawing.Size(146, 23);
            this.btnExporttoExcel.TabIndex = 5;
            this.btnExporttoExcel.Text = "Export to Excel";
            this.btnExporttoExcel.UseSelectable = true;
            this.btnExporttoExcel.Click += new System.EventHandler(this.btnExporttoExcel_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.clPassword});
            this.listView1.Location = new System.Drawing.Point(6, 148);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(311, 184);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Username";
            this.columnHeader1.Width = 132;
            // 
            // clPassword
            // 
            this.clPassword.Text = "Password";
            this.clPassword.Width = 143;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(242, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tboxUserName
            // 
            this.tboxUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tboxUserName.CustomButton.Image = null;
            this.tboxUserName.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.tboxUserName.CustomButton.Name = "";
            this.tboxUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tboxUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tboxUserName.CustomButton.TabIndex = 1;
            this.tboxUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tboxUserName.CustomButton.UseSelectable = true;
            this.tboxUserName.CustomButton.Visible = false;
            this.tboxUserName.Lines = new string[0];
            this.tboxUserName.Location = new System.Drawing.Point(83, 30);
            this.tboxUserName.MaxLength = 32767;
            this.tboxUserName.Name = "tboxUserName";
            this.tboxUserName.PasswordChar = '\0';
            this.tboxUserName.PromptText = "Enter any username";
            this.tboxUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxUserName.SelectedText = "";
            this.tboxUserName.SelectionLength = 0;
            this.tboxUserName.SelectionStart = 0;
            this.tboxUserName.ShortcutsEnabled = true;
            this.tboxUserName.Size = new System.Drawing.Size(234, 23);
            this.tboxUserName.TabIndex = 2;
            this.tboxUserName.UseSelectable = true;
            this.tboxUserName.WaterMark = "Enter any username";
            this.tboxUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tboxUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 30);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Username:";
            // 
            // gboxSingle
            // 
            this.gboxSingle.Controls.Add(this.btnCopy);
            this.gboxSingle.Controls.Add(this.metroLabel1);
            this.gboxSingle.Controls.Add(this.lblPassword);
            this.gboxSingle.Controls.Add(this.btnGeneratePassword);
            this.gboxSingle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxSingle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gboxSingle.Location = new System.Drawing.Point(3, 3);
            this.gboxSingle.Name = "gboxSingle";
            this.gboxSingle.Size = new System.Drawing.Size(322, 338);
            this.gboxSingle.TabIndex = 0;
            this.gboxSingle.TabStop = false;
            this.gboxSingle.Text = "Single Generate Password";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(198, 30);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(37, 23);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseSelectable = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(6, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Password:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(89, 30);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(103, 19);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Click the button.";
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(198, 59);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(118, 23);
            this.btnGeneratePassword.TabIndex = 0;
            this.btnGeneratePassword.Text = "Generate Password";
            this.btnGeneratePassword.UseSelectable = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // tboxPasswordCharacter
            // 
            this.tboxPasswordCharacter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tboxPasswordCharacter.CustomButton.Image = null;
            this.tboxPasswordCharacter.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.tboxPasswordCharacter.CustomButton.Name = "";
            this.tboxPasswordCharacter.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tboxPasswordCharacter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tboxPasswordCharacter.CustomButton.TabIndex = 1;
            this.tboxPasswordCharacter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tboxPasswordCharacter.CustomButton.UseSelectable = true;
            this.tboxPasswordCharacter.CustomButton.Visible = false;
            this.tboxPasswordCharacter.Lines = new string[0];
            this.tboxPasswordCharacter.Location = new System.Drawing.Point(83, 59);
            this.tboxPasswordCharacter.MaxLength = 32767;
            this.tboxPasswordCharacter.Name = "tboxPasswordCharacter";
            this.tboxPasswordCharacter.PasswordChar = '\0';
            this.tboxPasswordCharacter.PromptText = "Type the password character that you want to use.";
            this.tboxPasswordCharacter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxPasswordCharacter.SelectedText = "";
            this.tboxPasswordCharacter.SelectionLength = 0;
            this.tboxPasswordCharacter.SelectionStart = 0;
            this.tboxPasswordCharacter.ShortcutsEnabled = true;
            this.tboxPasswordCharacter.Size = new System.Drawing.Size(234, 23);
            this.tboxPasswordCharacter.TabIndex = 6;
            this.tboxPasswordCharacter.UseSelectable = true;
            this.tboxPasswordCharacter.WaterMark = "Type the password character that you want to use.";
            this.tboxPasswordCharacter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tboxPasswordCharacter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 59);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(70, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Character:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 424);
            this.Controls.Add(this.tlpContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tlpContainer.ResumeLayout(false);
            this.gboxMultiple.ResumeLayout(false);
            this.gboxMultiple.PerformLayout();
            this.gboxSingle.ResumeLayout(false);
            this.gboxSingle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private System.Windows.Forms.GroupBox gboxSingle;
        private System.Windows.Forms.GroupBox gboxMultiple;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroButton btnGeneratePassword;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnCopy;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroTextBox tboxUserName;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader clPassword;
        private MetroFramework.Controls.MetroButton btnExporttoExcel;
        private MetroFramework.Controls.MetroTextBox tboxPasswordCharacter;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}