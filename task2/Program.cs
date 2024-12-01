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
                try
                {
                    using (Bitmap bitmap = new Bitmap(file))
                    {
                        bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
                        string newName = Path.GetFileNameWithoutExtension(file) + "-mirrored.gif";
                        bitmap.Save(newName, System.Drawing.Imaging.ImageFormat.Gif);
                    }
                }
                if (regexExtForImage.IsMatch(Path.GetExtension(file)))
                {

                }
            }
        }
    }
}
