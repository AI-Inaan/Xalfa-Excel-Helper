namespace Xalfa_Excel_Helper
{
    partial class TitleManager
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
            this.PreviewTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.PreviewButton = new Guna.UI.WinForms.GunaButton();
            this.ApplyButton = new Guna.UI.WinForms.GunaButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddTitleText = new Guna.UI.WinForms.GunaTextBox();
            this.ApplyToSomeButton = new Guna.UI.WinForms.GunaButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreviewTextBox
            // 
            this.PreviewTextBox.BaseColor = System.Drawing.Color.White;
            this.PreviewTextBox.BorderColor = System.Drawing.Color.Silver;
            this.PreviewTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PreviewTextBox.Enabled = false;
            this.PreviewTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.PreviewTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PreviewTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.PreviewTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PreviewTextBox.Location = new System.Drawing.Point(3, 83);
            this.PreviewTextBox.Name = "PreviewTextBox";
            this.PreviewTextBox.PasswordChar = '\0';
            this.PreviewTextBox.Size = new System.Drawing.Size(454, 30);
            this.PreviewTextBox.TabIndex = 0;
            this.PreviewTextBox.Text = "Text";
            // 
            // PreviewButton
            // 
            this.PreviewButton.AnimationHoverSpeed = 0.07F;
            this.PreviewButton.AnimationSpeed = 0.03F;
            this.PreviewButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PreviewButton.BorderColor = System.Drawing.Color.Black;
            this.PreviewButton.FocusedColor = System.Drawing.Color.Empty;
            this.PreviewButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PreviewButton.ForeColor = System.Drawing.Color.White;
            this.PreviewButton.Image = null;
            this.PreviewButton.ImageSize = new System.Drawing.Size(20, 20);
            this.PreviewButton.Location = new System.Drawing.Point(3, 35);
            this.PreviewButton.Name = "PreviewButton";
            this.PreviewButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.PreviewButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.PreviewButton.OnHoverForeColor = System.Drawing.Color.White;
            this.PreviewButton.OnHoverImage = null;
            this.PreviewButton.OnPressedColor = System.Drawing.Color.Black;
            this.PreviewButton.Size = new System.Drawing.Size(454, 42);
            this.PreviewButton.TabIndex = 2;
            this.PreviewButton.Text = "Preview";
            this.PreviewButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PreviewButton.Click += new System.EventHandler(this.PreviewButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.AnimationHoverSpeed = 0.07F;
            this.ApplyButton.AnimationSpeed = 0.03F;
            this.ApplyButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ApplyButton.BorderColor = System.Drawing.Color.Black;
            this.ApplyButton.FocusedColor = System.Drawing.Color.Empty;
            this.ApplyButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ApplyButton.ForeColor = System.Drawing.Color.White;
            this.ApplyButton.Image = null;
            this.ApplyButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ApplyButton.Location = new System.Drawing.Point(3, 119);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ApplyButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ApplyButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ApplyButton.OnHoverImage = null;
            this.ApplyButton.OnPressedColor = System.Drawing.Color.Black;
            this.ApplyButton.Size = new System.Drawing.Size(234, 42);
            this.ApplyButton.TabIndex = 3;
            this.ApplyButton.Text = "Apply to all Items";
            this.ApplyButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.AddTitleText);
            this.flowLayoutPanel1.Controls.Add(this.PreviewButton);
            this.flowLayoutPanel1.Controls.Add(this.PreviewTextBox);
            this.flowLayoutPanel1.Controls.Add(this.ApplyButton);
            this.flowLayoutPanel1.Controls.Add(this.ApplyToSomeButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(462, 170);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // AddTitleText
            // 
            this.AddTitleText.BaseColor = System.Drawing.Color.White;
            this.AddTitleText.BorderColor = System.Drawing.Color.Silver;
            this.AddTitleText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddTitleText.FocusedBaseColor = System.Drawing.Color.White;
            this.AddTitleText.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AddTitleText.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.AddTitleText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddTitleText.Location = new System.Drawing.Point(3, 3);
            this.AddTitleText.Name = "AddTitleText";
            this.AddTitleText.PasswordChar = '\0';
            this.AddTitleText.Size = new System.Drawing.Size(454, 26);
            this.AddTitleText.TabIndex = 4;
            // 
            // ApplyToSomeButton
            // 
            this.ApplyToSomeButton.AnimationHoverSpeed = 0.07F;
            this.ApplyToSomeButton.AnimationSpeed = 0.03F;
            this.ApplyToSomeButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ApplyToSomeButton.BorderColor = System.Drawing.Color.Black;
            this.ApplyToSomeButton.FocusedColor = System.Drawing.Color.Empty;
            this.ApplyToSomeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ApplyToSomeButton.ForeColor = System.Drawing.Color.White;
            this.ApplyToSomeButton.Image = null;
            this.ApplyToSomeButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ApplyToSomeButton.Location = new System.Drawing.Point(243, 119);
            this.ApplyToSomeButton.Name = "ApplyToSomeButton";
            this.ApplyToSomeButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ApplyToSomeButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ApplyToSomeButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ApplyToSomeButton.OnHoverImage = null;
            this.ApplyToSomeButton.OnPressedColor = System.Drawing.Color.Black;
            this.ApplyToSomeButton.Size = new System.Drawing.Size(212, 42);
            this.ApplyToSomeButton.TabIndex = 5;
            this.ApplyToSomeButton.Text = "Apply to selected Items";
            this.ApplyToSomeButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ApplyToSomeButton.Click += new System.EventHandler(this.ApplyToSomeButton_Click);
            // 
            // TitleManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 170);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TitleManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TitleManager";
            this.Load += new System.EventHandler(this.TitleManager_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox PreviewTextBox;
        private Guna.UI.WinForms.GunaButton PreviewButton;
        private Guna.UI.WinForms.GunaButton ApplyButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaTextBox AddTitleText;
        private Guna.UI.WinForms.GunaButton ApplyToSomeButton;
    }
}