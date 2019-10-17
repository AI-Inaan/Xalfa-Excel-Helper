using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xalfa_Excel_Helper
{
    public partial class NameSelectCheckBox : UserControl
    {
        private string _Title;
        private bool _Checked;

        public NameSelectCheckBox()
        {
            InitializeComponent();
        }

        [Category("Settings")]
        public string Title
        {
            get { return _Title; }
            set { _Title = value; textBox1.Text = value; }
        }

        [Category("Settings")]
        public bool Checked
        {
            get { return _Checked; }
            set { _Checked = value; checkBox1.Checked = value; }
        }

        [Category("Settings")]
        public int Instance { get; set; }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            DataBasee.checkedNames[Instance].Checked = checkBox1.Checked;
            Console.WriteLine($"{DataBasee.Lister[Instance].Title} has been {checkBox1.Checked}");
        }
    }
}
