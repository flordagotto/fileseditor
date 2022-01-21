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
            return path;
        }

        public void resizeImage(string path, int _size, string folder)
        {
            try
            {
                var newPath = Service.GetPath() + "\\Media\\" + folder + "\\ic_launcher.png";
                var newPath2 = Service.GetPath() + "\\Media\\" + folder + "\\ic_launcher_foreground.png";

                var newPath3 = Service.GetPath() + "\\Media\\" + folder + "\\pic_logo.png";
                var newPath4 = Service.GetPath() + "\\Media\\" + folder + "\\ic_launcher_s.png";
                if (!Directory.Exists(Service.GetPath() + "\\Media\\" + folder))
                {
                    DirectoryInfo di = Directory.CreateDirectory(Service.GetPath() + "\\Media\\" + folder);
                }

                var size = new Size(_size, _size);
                Image img = Image.FromFile(path);
                Bitmap imgbitmap = new Bitmap(img);
                Image resizedImage = new Bitmap(imgbitmap, size);
                if(folder == "drawable-nodpi")
                {
                    resizedImage.Save(newPath3, ImageFormat.Png);
                    resizedImage.Save(newPath4, ImageFormat.Png);
                }
                else
                {
                    resizedImage.Save(newPath, ImageFormat.Png);
                    resizedImage.Save(newPath2, ImageFormat.Png);
                }

                //if (_size == 512)
                //    File.Copy(path, Service.GetPath() + "\\Media\\drawable-nodpi\\pic_logo.png", true);
                //else
                //{
                //    File.Copy(path, newPath, true);
                //    File.Copy(path, newPath2, true);
                //    if (_size == 96)
                //    {
                //        File.Copy(path, Service.GetPath() + "\\Media\\drawable-nodpi\\ic_launcher_s.png", true);
                //    }
                //}
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
