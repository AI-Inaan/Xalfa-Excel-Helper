using System;
using System.Linq;
using System.Windows.Forms;

namespace Xalfa_Excel_Helper
{
    public partial class DescriptionSet : Form
    {
        public DescriptionSet()
        {
            InitializeComponent();
        }

        private void SetDescButton_Click(object sender, EventArgs e)
        {
            SetDescButton.Enabled = false;
            int item = DataBasee.Lister.Count();
            for (int i = 0; i < item; i++)
            {
                DataBasee.Lister[i].Description = DescText.Text;
            }
            SetDescButton.Enabled = true;
            MessageBox.Show("Desc has been applies", "Edit Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}