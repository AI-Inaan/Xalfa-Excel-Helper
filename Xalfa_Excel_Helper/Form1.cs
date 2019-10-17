using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;
using OfficeOpenXml;
using System.Text.RegularExpressions;

namespace Xalfa_Excel_Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog open = new OpenFileDialog();

        private void ImportExcelButton_Click(object sender, EventArgs e)
        {
            Clear();
            open.Filter = "Excel| *.xlsx";
            open.Multiselect = false;
            open.Title = "Import Excel Sheet";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string location = open.FileName;
                string directory = location.Substring(0, location.LastIndexOf('\\'));
                directory = $"\\{location}";
                ExcelFileImportLocation.Text = open.FileName;
                ImageFolderSelect.Enabled = true;
                SaveButton.Enabled = true;
                DescManagerButton.Enabled = true;
                BrandManagerButton.Enabled = true;
                TitleManagerButton.Enabled = true;
                // int n = DataBasee.Lister.Count();
                Excel(location);
            }
        }

        public void Clear()
        {
            ExcelFileImportLocation.Text = "";
            flowLayoutPanel2.Controls.Clear();
            DataBasee.Lister.Clear();
            ImageFolderSelect.Enabled = false;
            SaveButton.Enabled = false;
            DescManagerButton.Enabled = false;
            BrandManagerButton.Enabled = false;
            DataBasee.ImageFolderSelected = false;
            TitleManagerButton.Enabled = false;
        }

        FolderBrowserDialog openFolder = new FolderBrowserDialog();

        private void ImageFolderSelect_Click(object sender, EventArgs e)
        {
            if (openFolder.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(openFolder.SelectedPath);
                DataBasee.ImageDir = openFolder.SelectedPath;
                MessageBox.Show($"{openFolder.SelectedPath} Succesfully Selected", "Folder Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBasee.ImageFolderSelected = true;
                ExcelFileImportLocation.Text = ($"{ExcelFileImportLocation.Text}  ||  {openFolder.SelectedPath}");
            }
        }

        [Serializable]
        public class Listingss
        {
            //public static string Title { get; set; }

            //public static string Description { get; set; }

            //public static string Price { get; set; }

            //public static string Brand { get; set; }

            //public static string Model { get; set; }

            //public static string Internal { get; set; }

            //public static string Image_1 { get; set; }

            //public static string Image_2 { get; set; }

            //public static string Image_3 { get; set; }

            //public static string Image_4 { get; set; }

            public string Title { get; set; }

            public string Price { get; set; }

            public string Description { get; set; }

            public string Brand { get; set; }

            public string Model { get; set; }

            public string Internal { get; set; }

            public string Image_1 { get; set; }

            public string Image_2 { get; set; }

            public string Image_3 { get; set; }

            public string Image_4 { get; set; }

            public int InternalStorage { get; set; }
        }

        public class Storage
        {
            public int InternalStorage;
        }

        public void Excel(string path)
        {
            try
            {
                FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read);
                IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                // DataSet result = excelReader.AsDataSet();
                // var n = result.Tables;

                //var listss = new List<Listingss>();
                while (excelReader.Read())
                {
                    if (excelReader.GetValue(0) == null)
                    {
                        break;
                    }
                    else
                    {
                        var temp = new Listingss()
                        {
                            Title = excelReader?.GetString(0),
                            Price = excelReader?.GetValue(1)?.ToString(),
                            Description = excelReader?.GetString(2),
                            Brand = excelReader?.GetString(3),
                            Model = excelReader?.GetString(4),
                            Internal = excelReader?.GetValue(5)?.ToString(),
                            Image_1 = excelReader?.GetString(6),
                            Image_2 = excelReader?.GetString(7),
                            Image_3 = excelReader?.GetString(8),
                            Image_4 = excelReader?.GetString(9),
                            InternalStorage = 0
                        };

                        if (temp.Title.ToLower() != "title")
                        {
                            DataBasee.Lister.Add(temp);
                        }
                        else
                        {

                        }
                    }
                }
                stream.Dispose();
                Console.WriteLine($"{DataBasee.Lister[0].Title} Read");
                TestArea();
            }
            catch (IOException)
            {
                MessageBox.Show("The Sheet you're trying to view is already in use", "File Already Open", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown Error", "Error 0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
            }

        }

        public void TestArea()
        {
            int n = DataBasee.Lister.Count();

            Listings[] listitems = new Listings[n];
            for (int i = 0; i < listitems.Length; i++)
            {
                listitems[i] = new Listings
                {
                    //listitems[i].Price = DataBasee.Lister[i].Price;
                    Dock = DockStyle.Top,
                    Instance = i,
                    Title = DataBasee.Lister[i].Title,
                    Model = DataBasee.Lister[i].Model,
                    Brand = DataBasee.Lister[i].Brand,
                    Storage = DataBasee.Lister[i].Internal,
                };

                flowLayoutPanel2.Controls.Add(listitems[i]);
            }
            Console.WriteLine($"{DataBasee.Lister[0].Title} TestArea");
            MessageBox.Show($"{n} Iistings Succesfully Imported \nSelect Image Folder to Continue", "Sheet Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Saver();
        }

        public void Saver()
        {
            SaveButton.Text = "Saving...";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Excel| *.xlsx";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(saveFileDialog1.FileName);
                using (var excelFile = new ExcelPackage(fileInfo))
                {
                    var worksheet = excelFile.Workbook.Worksheets.Add("Sheet1");
                    worksheet.Cells["A1"].LoadFromCollection(Collection: DataBasee.Lister, PrintHeaders: true);
                    worksheet.DeleteColumn(11);
                    try
                    {
                        excelFile.Save();
                        MessageBox.Show($"Succesfully Saved \nPLEASE REVIEW FILE BEFORE IMPORTING TO XALFA", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SaveButton.Text = "Save";
                    }
                    catch
                    {
                        MessageBox.Show("Failed to Save \nPlease Select a New Save Location", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Saver();
                    }
                }
            }
        }

        private void DescManagerButton_Click(object sender, EventArgs e)
        {
            DescriptionSet descriptionSet = new DescriptionSet();
            descriptionSet.ShowDialog();
        }

        private void BrandManagerButton_Click(object sender, EventArgs e)
        {
            int item = DataBasee.Lister.Count();
            for (int i = 0; i < item; i++)
            {
                #region Brand And Model Setter
                if (DataBasee.Lister[i].Title.ToLower().Contains("apple"))
                {
                    DataBasee.Lister[i].Brand = "Apple";

                    #region iPhone Model
                    if (DataBasee.Lister[i].Title.ToLower().Contains("iphone 3gs"))
                    {
                        DataBasee.Lister[i].Model = "iPhone 3GS";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("iphone 3g"))
                    {
                        DataBasee.Lister[i].Model = "iPhone 3G";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("iphone 4s"))
                    {
                        DataBasee.Lister[i].Model = "iPhone 4S";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("iphone 4"))
                    {
                        DataBasee.Lister[i].Model = "iPhone 4";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("iphone 5c"))
                    {
                        DataBasee.Lister[i].Model = "iPhone 5c";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("iphone 5"))
                    {
                        DataBasee.Lister[i].Model = "iPhone 5";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("iphone 6s plus") || DataBasee.Lister[i].Title.ToLower().Contains("iphone 6s+"))
                    {
                        DataBasee.Lister[i].Model = "iPhone 6s Plus";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("iphone 6s"))
                    {
                        DataBasee.Lister[i].Model = "iPhone 6s";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("iphone 6 plus") || DataBasee.Lister[i].Title.ToLower().Contains("iphone 6+"))
                    {
                        DataBasee.Lister[i].Model = "iPhone 6 Plus";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("iphone 6"))
                    {
                        DataBasee.Lister[i].Model = "iPhone 6";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("iphone 7 plus") || DataBasee.Lister[i].Title.ToLower().Contains("iphone 7+"))
                    {
                        DataBasee.Lister[i].Model = "iPhone 7 Plus";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("iphone 7"))
                    {
                        DataBasee.Lister[i].Model = "iPhone 7";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("iphone 8 plus") || DataBasee.Lister[i].Title.ToLower().Contains("iphone 8+"))
                    {
                        DataBasee.Lister[i].Model = "iPhone 8 Plus";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("iphone 8"))
                    {
                        DataBasee.Lister[i].Model = "iPhone 8";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("iphone 11 Pro"))
                    {
                        DataBasee.Lister[i].Model = "iPhone 11 Pro";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("iphone 11"))
                    {
                        DataBasee.Lister[i].Model = "iPhone 11";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("iphone se"))
                    {
                        DataBasee.Lister[i].Model = "iPhone SE";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("iphone xs max"))
                    {
                        DataBasee.Lister[i].Model = "iPhone XS Max";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("iphone xs"))
                    {
                        DataBasee.Lister[i].Model = "iPhone XS";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("iphone xr"))
                    {
                        DataBasee.Lister[i].Model = "iPhone XR";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("iphone x"))
                    {
                        DataBasee.Lister[i].Model = "iPhone X";
                    }
                    else
                    {
                        DataBasee.Lister[i].Model = "Not Stated";
                    }
                    #endregion
                }
                //Sam Model Done
                else if (DataBasee.Lister[i].Title.ToLower().Contains("samsung"))
                {
                    DataBasee.Lister[i].Brand = "Samsung";

                    #region Sam Model
                    if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy a5"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy A5";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy c5"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy C5";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy c7"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy C7";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy c9 pro"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy C9 Pro";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy grand prime"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy Grand Prime";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy note 10+") || DataBasee.Lister[i].Title.ToLower().Contains("galaxy note 10 plus"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy Note 10+";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy note 10"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy Note 10";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy note 9"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy Note 9";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy note 8"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy Note 8";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy note 7"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy Note 7";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy note 5"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy Note 5";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy note 4"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy Note 4";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy note 3"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy Note 3";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy grand alpha"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy Grand Alpha";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy s10+") || DataBasee.Lister[i].Title.ToLower().Contains("galaxy s10 plus"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy S10+";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy s8+") || DataBasee.Lister[i].Title.ToLower().Contains("galaxy s8 plus"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy S8+";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy s9+") || DataBasee.Lister[i].Title.ToLower().Contains("galaxy s9 plus"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy S9+";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy s3 mini"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy S3 Mini";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy s4 mini"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy S4 Mini";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy s6 edge"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy S6 Edge";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy s7 edge"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy S7 Edge";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy s9"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy S9";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy s10"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy S10";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy s8"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy S8";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy s7"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy S7";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy s6"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy S6";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy s5"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy S5";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy s4"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy S4";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy s3"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy S3";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("galaxy s2"))
                    {
                        DataBasee.Lister[i].Model = "Galaxy S2";
                    }
                    else
                    {
                        DataBasee.Lister[i].Model = "Not Stated";
                    }
                    #endregion

                }
                // OP Model Done
                else if (DataBasee.Lister[i].Title.ToLower().Contains("oneplus"))
                {
                    DataBasee.Lister[i].Brand = "OnePlus";

                    #region Oneplus Model Manager 

                    if (DataBasee.Lister[i].Title.ToLower().Contains("oneplus 2"))
                    {
                        DataBasee.Lister[i].Model = "OnePlus 2";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("oneplus 3t"))
                    {
                        DataBasee.Lister[i].Model = "OnePlus 3T";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("oneplus 3"))
                    {
                        DataBasee.Lister[i].Model = "OnePlus 3";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("oneplus 5t"))
                    {
                        DataBasee.Lister[i].Model = "OnePlus 5T";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("oneplus 5"))
                    {
                        DataBasee.Lister[i].Model = "OnePlus 5";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("oneplus 6t"))
                    {
                        DataBasee.Lister[i].Model = "OnePlus 6T";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("oneplus 6"))
                    {
                        DataBasee.Lister[i].Model = "OnePlus 6";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("oneplus 7 pro"))
                    {
                        DataBasee.Lister[i].Model = "OnePlus 7 Pro";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("oneplus 7"))
                    {
                        DataBasee.Lister[i].Model = "OnePlus 7";
                    }
                    else
                    {
                        DataBasee.Lister[i].Model = "Not Stated";
                    }
                    #endregion
                }
                // Huawei Model Done
                else if (DataBasee.Lister[i].Title.ToLower().Contains("huawei"))
                {
                    DataBasee.Lister[i].Brand = "Huawei";

                    #region Huawei Model Manager
                    if (DataBasee.Lister[i].Title.ToLower().Contains("huawei mate 20 pro"))
                    {
                        DataBasee.Lister[i].Model = "Huawei Mate 20 Pro";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("huawei mate 20"))
                    {
                        DataBasee.Lister[i].Model = "Huawei Mate 20";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("huawei p9 plus"))
                    {
                        DataBasee.Lister[i].Model = "Huawei P9 Plus";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("huawei p9"))
                    {
                        DataBasee.Lister[i].Model = "Huawei P9";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("huawei p10 plus"))
                    {
                        DataBasee.Lister[i].Model = "Huawei P10 Plus";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("huawei p10"))
                    {
                        DataBasee.Lister[i].Model = "Huawei P10";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("huawei p20 pro"))
                    {
                        DataBasee.Lister[i].Model = "Huawei P20 Pro";
                    }
                    else if (DataBasee.Lister[i].Title.ToLower().Contains("huawei p20"))
                    {
                        DataBasee.Lister[i].Model = "Huawei P20";
                    }
                    else
                    {
                        DataBasee.Lister[i].Model = "Not Stated";
                    }
                    #endregion
                }
                // Model Done
                else if (DataBasee.Lister[i].Title.ToLower().Contains("sony"))
                {
                    DataBasee.Lister[i].Brand = "Sony";
                    DataBasee.Lister[i].Model = "Not Stated";
                }
                // Model Done
                else if (DataBasee.Lister[i].Title.ToLower().Contains("google"))
                {
                    DataBasee.Lister[i].Brand = "Google";
                }
                // Model Done
                else if (DataBasee.Lister[i].Title.ToLower().Contains("lg"))
                {
                    DataBasee.Lister[i].Brand = "LG";
                    DataBasee.Lister[i].Model = "Not Stated";
                }
                // Model Done
                else if (DataBasee.Lister[i].Title.ToLower().Contains("xiaomi"))
                {
                    DataBasee.Lister[i].Brand = "Xiaomi";
                    DataBasee.Lister[i].Model = "Not Stated";
                }
                // Model Done
                else if (DataBasee.Lister[i].Title.ToLower().Contains("lenovo"))
                {
                    DataBasee.Lister[i].Brand = "Lenovo";
                    DataBasee.Lister[i].Model = "Not Stated";
                }
                // Model Done
                else if (DataBasee.Lister[i].Title.ToLower().Contains("htc"))
                {
                    DataBasee.Lister[i].Brand = "HTC";
                    DataBasee.Lister[i].Model = "Not Stated";
                }
                // Model Done
                else if (DataBasee.Lister[i].Title.ToLower().Contains("motorola"))
                {
                    DataBasee.Lister[i].Brand = "Motorola";
                    DataBasee.Lister[i].Model = "Not Stated";
                }
                // Model Done
                else if (DataBasee.Lister[i].Title.ToLower().Contains("nokia"))
                {
                    DataBasee.Lister[i].Brand = "Nokia";
                    DataBasee.Lister[i].Model = "Not Stated";
                }
                // Model Done
                else
                {
                    DataBasee.Lister[i].Brand = "Other Brands";
                    DataBasee.Lister[i].Model = "Not Stated";
                }
                #endregion

                if (DataBasee.Lister[i].Title.ToLower().Contains("gb"))
                {
                    DataBasee.GlobalCounter = 0;
                    DataBasee.StorageValue = 0;
                    string[] split = DataBasee.Lister[i].Title.Split(' ');
                    int n = split.Length;
                    for (int b = 0; b < n; b++)
                    {

                        if (split[b].ToLower().Contains("gb"))
                        {
                            //DataBasee.Lister[i].StorageLocation[i].Location = b;
                            string value = Regex.Match(split[b], @"\d+").Value;
                            if (value == "")
                            {
                                int B = b - 1;
                                value = Regex.Match(split[B], @"\d+").Value;
                            }
                            int InternalMem = int.Parse(value);
                            DataBasee.GlobalCounter++;
                            if (DataBasee.GlobalCounter > 1)
                            {
                                if (InternalMem > DataBasee.Lister[i].InternalStorage)
                                {
                                    DataBasee.Lister[i].InternalStorage = InternalMem;
                                }
                                else
                                {

                                }
                            }
                            else
                            {
                                DataBasee.Lister[i].InternalStorage = InternalMem;
                            }
                        }
                    }

                    if (DataBasee.GlobalCounter == 1)
                    {
                        //remove value and see if storage is a valid value
                        int InternalMem = DataBasee.Lister[i].InternalStorage;

                        if (InternalMem == 4)
                        {
                            DataBasee.Lister[i].Internal = "4";
                        }
                        else if (InternalMem == 8)
                        {
                            DataBasee.Lister[i].Internal = "8";
                        }
                        else if (InternalMem == 16)
                        {
                            DataBasee.Lister[i].Internal = "16";
                        }
                        else if (InternalMem == 32)
                        {
                            DataBasee.Lister[i].Internal = "32";
                        }
                        else if (InternalMem == 64)
                        {
                            DataBasee.Lister[i].Internal = "64";
                        }
                        else if (InternalMem == 128)
                        {
                            DataBasee.Lister[i].Internal = "128";
                        }
                        else if (InternalMem == 256)
                        {
                            DataBasee.Lister[i].Internal = "256";
                        }
                        else if (InternalMem == 512)
                        {
                            DataBasee.Lister[i].Internal = "512";
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        int InternalMem = DataBasee.Lister[i].InternalStorage;

                        if (InternalMem == 4)
                        {
                            DataBasee.Lister[i].Internal = "4";
                        }
                        else if (InternalMem == 8)
                        {
                            DataBasee.Lister[i].Internal = "8";
                        }
                        else if (InternalMem == 16)
                        {
                            DataBasee.Lister[i].Internal = "16";
                        }
                        else if (InternalMem == 32)
                        {
                            DataBasee.Lister[i].Internal = "32";
                        }
                        else if (InternalMem == 64)
                        {
                            DataBasee.Lister[i].Internal = "64";
                        }
                        else if (InternalMem == 128)
                        {
                            DataBasee.Lister[i].Internal = "128";
                        }
                        else if (InternalMem == 256)
                        {
                            DataBasee.Lister[i].Internal = "256";
                        }
                        else if (InternalMem == 512)
                        {
                            DataBasee.Lister[i].Internal = "512";
                        }
                        else
                        {

                        }
                    }
                }
                else
                {
                    DataBasee.Lister[i].Internal = "4";
                }
            }
            Console.WriteLine($"{DataBasee.Lister[0].Title} Brand");
            MessageBox.Show($"Brands And Models AutoCompleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Reload();
        }

        public void Reload()
        {
            int n = DataBasee.Lister.Count();
            flowLayoutPanel2.Controls.Clear();
            Listings[] listitems = new Listings[n];
            for (int i = 0; i < listitems.Length; i++)
            {
                listitems[i] = new Listings
                {
                    //listitems[i].Price = DataBasee.Lister[i].Price;
                    Dock = DockStyle.Top,
                    Instance = i,
                    Title = DataBasee.Lister[i].Title,
                    Brand = DataBasee.Lister[i].Brand,
                    Model = DataBasee.Lister[i].Model,
                    Storage = DataBasee.Lister[i].Internal,
                };
                flowLayoutPanel2.Controls.Add(listitems[i]);
            }
            Console.WriteLine($"{DataBasee.Lister[0].Title} Reload");
        }

        private void TitleManagerButton_Click(object sender, EventArgs e)
        {
            TitleManager title = new TitleManager();
            title.ShowDialog();
            Reload();
        }
    }
}