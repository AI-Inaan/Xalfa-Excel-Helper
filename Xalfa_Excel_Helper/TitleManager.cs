using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Xalfa_Excel_Helper
{
    public partial class TitleManager : Form
    {
        public TitleManager()
        {
            InitializeComponent();
        }

        private void PreviewButton_Click(object sender, EventArgs e)
        {
            PreviewTextBox.Text = $"{DataBasee.Lister[0].Title} {AddTitleText.Text}";
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            ApplyButton.Enabled = false;
            int item = DataBasee.Lister.Count();
            for (int i = 0; i < item; i++)
            {
                if (DataBasee.Lister[i].Title.Contains(AddTitleText.Text))
                {
                    DataBasee.Lister[i].Title.Replace(AddTitleText.Text,"");
                }
                else
                {
                    DataBasee.Lister[i].Title = $"{DataBasee.Lister[i].Title} {AddTitleText.Text}";
                }               
            }
            MessageBox.Show("All Titles Edited", "Edit Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ApplyButton.Enabled = true;
        }

        private void ApplyToSomeButton_Click(object sender, EventArgs e)
        {
            NameSelector nameSelector = new NameSelector();
            nameSelector.ShowDialog();
        }

        private void TitleManager_Load(object sender, EventArgs e)
        {
            PreviewTextBox.Text = DataBasee.Lister[0].Title;
        }
    }
}