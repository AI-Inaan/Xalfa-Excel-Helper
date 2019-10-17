using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xalfa_Excel_Helper
{
    public partial class NameSelector : Form
    {
        public NameSelector()
        {
            InitializeComponent();
        }

        public void NameSelector_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            int n = DataBasee.Lister.Count();
            NameSelectCheckBox[] checkBox = new NameSelectCheckBox[n];
            GunaSeparator[] separator = new GunaSeparator[n];
            for (int i = 0; i < n; i++)
            {
                checkBox[i] = new NameSelectCheckBox
                {
                    Title = DataBasee.Lister[i].Title,
                    Checked = false,
                    Instance = i,
                };

                var Temp = new CheckedNames()
                {
                    Instence = i,
                    DatabaseIndex = i,
                };

                DataBasee.checkedNames.Add(Temp);

                separator[i] = new GunaSeparator
                {
                    Width = 340,
                };
                // Console.WriteLine(checkBox[i].Text);
                flowLayoutPanel1.Controls.Add(checkBox[i]);
                flowLayoutPanel1.Controls.Add(separator[i]);
            }
        }

        public void SubmitButton_Click(object sender, EventArgs e)
        {
            int count = DataBasee.checkedNames.Count();
            for (int i = 0; i < count; i++)
            {
                if (DataBasee.checkedNames[i].Checked == true)
                {

                }
                else
                {
                    
                }
            }
            LoadData();
        }

        private void gunaWinSwitch1_Click(object sender, EventArgs e)
        {
            //if (gunaWinSwitch1.Checked == true)
            //{
            //    gunaWinSwitch1.Checked = false;
            //    //unselect all
            //}
            //else
            //    gunaWinSwitch1.Checked = true;
            ////select all
        }

        private void gunaWinSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (gunaWinSwitch1.Checked == true)
            {         
                int n = DataBasee.Lister.Count();
                NameSelectCheckBox[] checkBox = new NameSelectCheckBox[n];
                GunaSeparator[] separator = new GunaSeparator[n];
                for (int i = 0; i < n; i++)
                {
                    checkBox[i] = new NameSelectCheckBox
                    {
                        Title = DataBasee.Lister[i].Title,
                        Checked = true,
                        Instance = i,
                    };

                    separator[i] = new GunaSeparator
                    {
                        Width = 340,
                    };
                    // Console.WriteLine(checkBox[i].Text);
                    flowLayoutPanel1.Controls.Add(checkBox[i]);
                    flowLayoutPanel1.Controls.Add(separator[i]);
                }
            }
            else if (gunaWinSwitch1.Checked == false)
            {
                int n = DataBasee.Lister.Count();
                NameSelectCheckBox[] checkBox = new NameSelectCheckBox[n];
                GunaSeparator[] separator = new GunaSeparator[n];
                for (int i = 0; i < n; i++)
                {
                    checkBox[i] = new NameSelectCheckBox
                    {
                        Title = DataBasee.Lister[i].Title,
                        Checked = false,
                        Instance = i,
                    };

                    separator[i] = new GunaSeparator
                    {
                        Width = 340,
                    };
                    // Console.WriteLine(checkBox[i].Text);
                    flowLayoutPanel1.Controls.Add(checkBox[i]);
                    flowLayoutPanel1.Controls.Add(separator[i]);
                }
            }
        }
    }
}
