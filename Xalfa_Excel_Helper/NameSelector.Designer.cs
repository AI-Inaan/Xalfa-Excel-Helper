namespace Xalfa_Excel_Helper
{
    partial class NameSelector
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaWinSwitch1 = new Guna.UI.WinForms.GunaWinSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SubmitButton = new Guna.UI.WinForms.GunaButton();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(364, 476);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // gunaWinSwitch1
            // 
            this.gunaWinSwitch1.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaWinSwitch1.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.gunaWinSwitch1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaWinSwitch1.FillColor = System.Drawing.Color.White;
            this.gunaWinSwitch1.Location = new System.Drawing.Point(3, 3);
            this.gunaWinSwitch1.Name = "gunaWinSwitch1";
            this.gunaWinSwitch1.Size = new System.Drawing.Size(40, 22);
            this.gunaWinSwitch1.TabIndex = 1;
            this.gunaWinSwitch1.CheckedChanged += new System.EventHandler(this.gunaWinSwitch1_CheckedChanged);
            this.gunaWinSwitch1.Click += new System.EventHandler(this.gunaWinSwitch1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select all";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.gunaWinSwitch1);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(104, 28);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SubmitButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 476);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 34);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // SubmitButton
            // 
            this.SubmitButton.AnimationHoverSpeed = 0.07F;
            this.SubmitButton.AnimationSpeed = 0.03F;
            this.SubmitButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SubmitButton.BorderColor = System.Drawing.Color.Black;
            this.SubmitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SubmitButton.FocusedColor = System.Drawing.Color.Empty;
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Image = null;
            this.SubmitButton.ImageSize = new System.Drawing.Size(20, 20);
            this.SubmitButton.Location = new System.Drawing.Point(224, 3);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.SubmitButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SubmitButton.OnHoverForeColor = System.Drawing.Color.White;
            this.SubmitButton.OnHoverImage = null;
            this.SubmitButton.OnPressedColor = System.Drawing.Color.Black;
            this.SubmitButton.Size = new System.Drawing.Size(137, 28);
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // NameSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 510);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NameSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Name Settings";
            this.Load += new System.EventHandler(this.NameSelector_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaWinSwitch gunaWinSwitch1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaButton SubmitButton;
    }
}