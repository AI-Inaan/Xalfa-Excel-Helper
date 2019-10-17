using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Xalfa_Excel_Helper.Form1;

namespace Xalfa_Excel_Helper
{
    public static class DataBasee
    {
        public static List<Listingss> Lister = new List<Listingss>();
        public static string ImageDir;
        public static int WidthUpdate;
        public static bool ImageFolderSelected = false;
        public static int GlobalCounter;
        public static int StorageValue;
        public static List<CheckedNames> checkedNames = new List<CheckedNames>();
    }

    [Serializable]
    public class CheckedNames
    {
        public int Instence { get; set; }
        public int DatabaseIndex { get; set; }
        public bool Checked { get; set; }
    }
}
