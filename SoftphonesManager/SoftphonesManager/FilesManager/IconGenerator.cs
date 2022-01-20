using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftphonesManager.FilesManager
{
    public class IconGenerator
    {
        public string path;
        public IconGenerator(string path)
        {
            this.path = path;
        }

        public string GetConvertedPNGFile()
        {
            var bitmap = Bitmap.FromFile(path);
            bitmap.Save(Path.GetFileName(path) + ".png", ImageFormat.Png);
            return Path.GetFileName(path) + ".png";
        }

        public void resizeImage(string path, int _size, string folder)
        {
            var newPath = Service.GetPath() + "\\Media\\" + folder + "\\ic_launcher";
            var newPath2 = Service.GetPath() + "\\Media\\" + folder + "\\ic_launcher_foreground";

            var size = new Size(_size, _size);
            Image img = Image.FromFile(path);
            Bitmap imgbitmap = new Bitmap(img);
            Image resizedImage = new Bitmap(imgbitmap, size);
            imgbitmap.Save(Path.GetFileName(path) + ".png", ImageFormat.Png);
            if (_size == 512)
            {
                File.Copy(path, Service.GetPath() + "\\Media\\drawable-nodpi\\pic_logo", true);
            }
            else
            {
                File.Copy(path, newPath, true);
                File.Copy(path, newPath2, true);
                if (_size == 96)
                {
                    File.Copy(path, Service.GetPath() + "\\Media\\drawable-nodpi\\ic_launcher_s", true);
                }
            }
        }
    }
}
