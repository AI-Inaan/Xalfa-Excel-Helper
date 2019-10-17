namespace Xalfa_Excel_Helper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ExcelFileImportLocation = new Guna.UI.WinForms.GunaTextBox();
            this.ImageFolderSelect = new Guna.UI.WinForms.GunaButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ImportExcelButton = new Guna.UI.WinForms.GunaButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.TitleManagerButton = new Guna.UI.WinForms.GunaButton();
            this.BrandManagerButton = new Guna.UI.WinForms.GunaButton();
            this.SaveButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.DescManagerButton = new Guna.UI.WinForms.GunaButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExcelFileImportLocation
            // 
            this.ExcelFileImportLocation.BackColor = System.Drawing.Color.Transparent;
            this.ExcelFileImportLocation.BaseColor = System.Drawing.Color.White;
            this.ExcelFileImportLocation.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.ExcelFileImportLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ExcelFileImportLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExcelFileImportLocation.Enabled = false;
            this.ExcelFileImportLocation.FocusedBaseColor = System.Drawing.Color.White;
            this.ExcelFileImportLocation.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ExcelFileImportLocation.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.ExcelFileImportLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExcelFileImportLocation.Location = new System.Drawing.Point(3, 3);
            this.ExcelFileImportLocation.Name = "ExcelFileImportLocation";
            this.ExcelFileImportLocation.PasswordChar = '\0';
            this.ExcelFileImportLocation.Size = new System.Drawing.Size(642, 34);
            this.ExcelFileImportLocation.TabIndex = 1;
            // 
            // ImageFolderSelect
            // 
            this.ImageFolderSelect.AnimationHoverSpeed = 0.07F;
            this.ImageFolderSelect.AnimationSpeed = 0.03F;
            this.ImageFolderSelect.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ImageFolderSelect.BorderColor = System.Drawing.Color.Black;
            this.ImageFolderSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageFolderSelect.Enabled = false;
            this.ImageFolderSelect.FocusedColor = System.Drawing.Color.Empty;
            this.ImageFolderSelect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ImageFolderSelect.ForeColor = System.Drawing.Color.White;
            this.ImageFolderSelect.Image = null;
            this.ImageFolderSelect.ImageSize = new System.Drawing.Size(20, 20);
            this.ImageFolderSelect.Location = new System.Drawing.Point(706, 3);
            this.ImageFolderSelect.Name = "ImageFolderSelect";
            this.ImageFolderSelect.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ImageFolderSelect.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ImageFolderSelect.OnHoverForeColor = System.Drawing.Color.White;
            this.ImageFolderSelect.OnHoverImage = null;
            this.ImageFolderSelect.OnPressedColor = System.Drawing.Color.Black;
            this.ImageFolderSelect.Size = new System.Drawing.Size(95, 34);
            this.ImageFolderSelect.TabIndex = 2;
            this.ImageFolderSelect.Text = "Image Folder";
            this.ImageFolderSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ImageFolderSelect.Click += new System.EventHandler(this.ImageFolderSelect_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(2, 48);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(800, 422);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0002F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.22185F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.77795F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 512);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.10827F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.891728F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.ImageFolderSelect, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.ImportExcelButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ExcelFileImportLocation, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(804, 40);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // ImportExcelButton
            // 
            this.ImportExcelButton.AnimationHoverSpeed = 0.07F;
            this.ImportExcelButton.AnimationSpeed = 0.03F;
            this.ImportExcelButton.BackColor = System.Drawing.Color.Transparent;
            this.ImportExcelButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ImportExcelButton.BorderColor = System.Drawing.Color.Black;
            this.ImportExcelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportExcelButton.FocusedColor = System.Drawing.Color.Empty;
            this.ImportExcelButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ImportExcelButton.ForeColor = System.Drawing.Color.White;
            this.ImportExcelButton.Image = ((System.Drawing.Image)(resources.GetObject("ImportExcelButton.Image")));
            this.ImportExcelButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ImportExcelButton.ImageSize = new System.Drawing.Size(25, 25);
            this.ImportExcelButton.Location = new System.Drawing.Point(651, 3);
            this.ImportExcelButton.Name = "ImportExcelButton";
            this.ImportExcelButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ImportExcelButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ImportExcelButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ImportExcelButton.OnHoverImage = null;
            this.ImportExcelButton.OnPressedColor = System.Drawing.Color.Black;
            this.ImportExcelButton.Size = new System.Drawing.Size(49, 34);
            this.ImportExcelButton.TabIndex = 0;
            this.ImportExcelButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ImportExcelButton.Click += new System.EventHandler(this.ImportExcelButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.67669F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.78446F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.35088F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.TitleManagerButton, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.BrandManagerButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.SaveButton, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.DescManagerButton, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 475);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(798, 34);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // TitleManagerButton
            // 
            this.TitleManagerButton.AnimationHoverSpeed = 0.07F;
            this.TitleManagerButton.AnimationSpeed = 0.03F;
            this.TitleManagerButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TitleManagerButton.BorderColor = System.Drawing.Color.Black;
            this.TitleManagerButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.TitleManagerButton.Enabled = false;
            this.TitleManagerButton.FocusedColor = System.Drawing.Color.Empty;
            this.TitleManagerButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TitleManagerButton.ForeColor = System.Drawing.Color.White;
            this.TitleManagerButton.Image = null;
            this.TitleManagerButton.ImageSize = new System.Drawing.Size(20, 20);
            this.TitleManagerButton.Location = new System.Drawing.Point(278, 3);
            this.TitleManagerButton.Name = "TitleManagerButton";
            this.TitleManagerButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.TitleManagerButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.TitleManagerButton.OnHoverForeColor = System.Drawing.Color.White;
            this.TitleManagerButton.OnHoverImage = null;
            this.TitleManagerButton.OnPressedColor = System.Drawing.Color.Black;
            this.TitleManagerButton.Size = new System.Drawing.Size(104, 28);
            this.TitleManagerButton.TabIndex = 8;
            this.TitleManagerButton.Text = "Title Manager";
            this.TitleManagerButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TitleManagerButton.Click += new System.EventHandler(this.TitleManagerButton_Click);
            // 
            // BrandManagerButton
            // 
            this.BrandManagerButton.AnimationHoverSpeed = 0.07F;
            this.BrandManagerButton.AnimationSpeed = 0.03F;
            this.BrandManagerButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BrandManagerButton.BorderColor = System.Drawing.Color.Black;
            this.BrandManagerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrandManagerButton.Enabled = false;
            this.BrandManagerButton.FocusedColor = System.Drawing.Color.Empty;
            this.BrandManagerButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BrandManagerButton.ForeColor = System.Drawing.Color.White;
            this.BrandManagerButton.Image = null;
            this.BrandManagerButton.ImageSize = new System.Drawing.Size(20, 20);
            this.BrandManagerButton.Location = new System.Drawing.Point(168, 3);
            this.BrandManagerButton.Name = "BrandManagerButton";
            this.BrandManagerButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BrandManagerButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BrandManagerButton.OnHoverForeColor = System.Drawing.Color.White;
            this.BrandManagerButton.OnHoverImage = null;
            this.BrandManagerButton.OnPressedColor = System.Drawing.Color.Black;
            this.BrandManagerButton.Size = new System.Drawing.Size(104, 28);
            this.BrandManagerButton.TabIndex = 7;
            this.BrandManagerButton.Text = "Brand Manager";
            this.BrandManagerButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BrandManagerButton.Click += new System.EventHandler(this.BrandManagerButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.AnimationHoverSpeed = 0.07F;
            this.SaveButton.AnimationSpeed = 0.03F;
            this.SaveButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SaveButton.BorderColor = System.Drawing.Color.Black;
            this.SaveButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.SaveButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.SaveButton.CheckedForeColor = System.Drawing.Color.White;
            this.SaveButton.CheckedImage = null;
            this.SaveButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveButton.Enabled = false;
            this.SaveButton.FocusedColor = System.Drawing.Color.Empty;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Image = null;
            this.SaveButton.ImageSize = new System.Drawing.Size(20, 20);
            this.SaveButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SaveButton.Location = new System.Drawing.Point(618, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.SaveButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SaveButton.OnHoverForeColor = System.Drawing.Color.White;
            this.SaveButton.OnHoverImage = null;
            this.SaveButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SaveButton.OnPressedColor = System.Drawing.Color.Black;
            this.SaveButton.Size = new System.Drawing.Size(177, 28);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DescManagerButton
            // 
            this.DescManagerButton.AnimationHoverSpeed = 0.07F;
            this.DescManagerButton.AnimationSpeed = 0.03F;
            this.DescManagerButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DescManagerButton.BorderColor = System.Drawing.Color.Black;
            this.DescManagerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescManagerButton.Enabled = false;
            this.DescManagerButton.FocusedColor = System.Drawing.Color.Empty;
            this.DescManagerButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DescManagerButton.ForeColor = System.Drawing.Color.White;
            this.DescManagerButton.Image = null;
            this.DescManagerButton.ImageSize = new System.Drawing.Size(20, 20);
            this.DescManagerButton.Location = new System.Drawing.Point(3, 3);
            this.DescManagerButton.Name = "DescManagerButton";
            this.DescManagerButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.DescManagerButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.DescManagerButton.OnHoverForeColor = System.Drawing.Color.White;
            this.DescManagerButton.OnHoverImage = null;
            this.DescManagerButton.OnPressedColor = System.Drawing.Color.Black;
            this.DescManagerButton.Size = new System.Drawing.Size(159, 28);
            this.DescManagerButton.TabIndex = 6;
            this.DescManagerButton.Text = "Describ Manager";
            this.DescManagerButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DescManagerButton.Click += new System.EventHandler(this.DescManagerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 512);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(820, 551);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xalfa Excel Helper";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaButton ImportExcelButton;
        private Guna.UI.WinForms.GunaButton ImageFolderSelect;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaAdvenceButton SaveButton;
        private Guna.UI.WinForms.GunaTextBox ExcelFileImportLocation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI.WinForms.GunaButton DescManagerButton;
        private Guna.UI.WinForms.GunaButton BrandManagerButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Guna.UI.WinForms.GunaButton TitleManagerButton;
    }
}

