namespace Xalfa_Excel_Helper
{
    partial class DescriptionSet
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
            this.DescText = new System.Windows.Forms.TextBox();
            this.SetDescButton = new Guna.UI.WinForms.GunaButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DescText
            // 
            this.DescText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescText.Location = new System.Drawing.Point(3, 3);
            this.DescText.Multiline = true;
            this.DescText.Name = "DescText";
            this.DescText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescText.Size = new System.Drawing.Size(496, 367);
            this.DescText.TabIndex = 0;
            // 
            // SetDescButton
            // 
            this.SetDescButton.AnimationHoverSpeed = 0.07F;
            this.SetDescButton.AnimationSpeed = 0.03F;
            this.SetDescButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SetDescButton.BorderColor = System.Drawing.Color.Black;
            this.SetDescButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SetDescButton.FocusedColor = System.Drawing.Color.Empty;
            this.SetDescButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SetDescButton.ForeColor = System.Drawing.Color.White;
            this.SetDescButton.Image = null;
            this.SetDescButton.ImageSize = new System.Drawing.Size(20, 20);
            this.SetDescButton.Location = new System.Drawing.Point(339, 376);
            this.SetDescButton.Name = "SetDescButton";
            this.SetDescButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.SetDescButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SetDescButton.OnHoverForeColor = System.Drawing.Color.White;
            this.SetDescButton.OnHoverImage = null;
            this.SetDescButton.OnPressedColor = System.Drawing.Color.Black;
            this.SetDescButton.Size = new System.Drawing.Size(160, 47);
            this.SetDescButton.TabIndex = 1;
            this.SetDescButton.Text = "Give All Same Desc";
            this.SetDescButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SetDescButton.Click += new System.EventHandler(this.SetDescButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.SetDescButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DescText, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(498, 422);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // DescriptionSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 426);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(518, 465);
            this.MinimumSize = new System.Drawing.Size(518, 465);
            this.Name = "DescriptionSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DescriptionSet";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox DescText;
        private Guna.UI.WinForms.GunaButton SetDescButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}