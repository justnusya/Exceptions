using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

namespace task2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
            Regex regexExtForImage = new Regex(@"^((bmp)|(gif)|(tiff?)|(jpe?g)|(png))$", RegexOptions.IgnoreCase);
            foreach(string file in files)
            {
                if (regexExtForImage.IsMatch(Path.GetExtension(file)))
                {

                }
            }
        }
    }
}
