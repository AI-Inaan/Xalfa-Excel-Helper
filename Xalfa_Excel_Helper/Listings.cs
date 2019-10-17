using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Xalfa_Excel_Helper
{
    public partial class Listings : UserControl
    {
        public Listings()
        {
            InitializeComponent();
        }

        private string _Title;
        //private string _Price;
        private string _Picture1;
        private string _Picture2;
        private string _Picture3;
        private string _Picture4;
        private Color _TitleColor;
        private string _Brand;
        private string _Model;
        private string _Storage;
        private string _Numb;

        #region Settings

        [Category("Settings")]
        public string Title
        {
            get { return _Title; }
            set { _Title = value; ItemText.Text = value; }
        }

        [Category("Settings")]
        public string Brand
        {
            get { return _Brand; }
            set { _Brand = value; BrandText.Text = value; }
        }

        [Category("Settings")]
        public string Storage
        {
            get { return _Storage; }
            set { _Storage = value; StorageLable.Text = value; }
        }

        [Category("Settings")]
        public string Model
        {
            get { return _Model; }
            set { _Model = value; ModelLable.Text = value; }
        }

        [Category("Settings")]
        public System.Drawing.Color TitleColor
        {
            get { return _TitleColor; }
            set { _TitleColor = value; ItemText.ForeColor = value; }
        }

        //[Category("Settings")]
        //public string Price
        //{
        //    get { return _Price; }
        //    set { _Price = value; PriceInput.Text = value; }
        //}

        [Category("Settings")]
        public string Picture1
        {
            get { return _Picture1; }
            set { _Picture1 = value; ItemPicture4.ImageLocation = value; }
        }

        [Category("Settings")]
        public string Picture2
        {
            get { return _Picture2; }
            set { _Picture2 = value; ItemPicture3.ImageLocation = value; }
        }

        [Category("Settings")]
        public string Picture3
        {
            get { return _Picture3; }
            set { _Picture3 = value; ItemPicture2.ImageLocation = value; }
        }

        [Category("Settings")]
        public string Picture4
        {
            get { return _Picture4; }
            set
            {
                _Picture4 = value;
                ItemPicture1.ImageLocation = value;
            }
        }

        [Category("Settings")]
        public int Instance { get; set; }

        [Category("Settings")]
        public string Numb
        {
            get { return _Numb; }
            set { _Numb = value; Nomber.Text = value; }
        }

        #endregion
        public void OpenImage(int img)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.InitialDirectory = DataBasee.ImageDir;
            open.RestoreDirectory = true;
            open.Filter = "Image (*.jpeg, *.jpg,*png)|*.jpeg;*.jpg;*.png";
            open.Multiselect = false;
            open.Title = "Import Image";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string location = open.FileName;
                string directory = location.Substring(0, location.LastIndexOf('\\'));
                directory = $"\\{location}";
                string newDir = directory.Replace(DataBasee.ImageDir, "");
                newDir = newDir.TrimStart('\\', '\\').Replace("\\", @"\").Replace("\\", @"\");

                #region Image Selector

                if (img == 1)
                {
                    ItemPicture4.ImageLocation = location;
                    DataBasee.Lister[Instance].Image_1 = newDir;
                    ItemPicture3.Enabled = true;
                    ItemPicture3.Cursor = Cursors.Hand;
                }
                else if (img == 2)
                {
                    ItemPicture3.ImageLocation = location;
                    DataBasee.Lister[Instance].Image_2 = newDir;
                    ItemPicture2.Enabled = true;
                    ItemPicture2.Cursor = Cursors.Hand;
                }
                else if (img == 3)
                {
                    ItemPicture2.ImageLocation = location;
                    DataBasee.Lister[Instance].Image_3 = newDir;
                    ItemPicture1.Enabled = true;
                    ItemPicture1.Cursor = Cursors.Hand;
                }
                else if (img == 4)
                {
                    ItemPicture1.ImageLocation = location;
                    DataBasee.Lister[Instance].Image_4 = newDir;
                }
                #endregion
            }
        }

        #region Image Cick

        private void ItemPicture4_Click(object sender, EventArgs e)
        {
            if (DataBasee.ImageFolderSelected == false)
            {
                MessageBox.Show($"Select An Image Folder To continue", "Image Folder Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                OpenImage(1);
            }
        }

        private void ItemPicture3_Click(object sender, EventArgs e)
        {
            OpenImage(2);
        }

        private void ItemPicture2_Click(object sender, EventArgs e)
        {
            OpenImage(3);
        }

        private void ItemPicture1_Click(object sender, EventArgs e)
        {
            OpenImage(4);
        }
        #endregion

        private void ItemText_TextChanged(object sender, EventArgs e)
        {
            if (ItemText.Text.Count() < 80)
            {
                ItemText.ForeColor = Color.Green;
                DataBasee.Lister[Instance].Title = ItemText.Text;
            }
            else
            {
                ItemText.ForeColor = Color.Red;
                DataBasee.Lister[Instance].Title = ItemText.Text;
            }
           // Console.WriteLine($"{DataBasee.Lister[0].Title} TextChange");
        }
    }
}