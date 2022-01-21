using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftphonesManager.FilesManager
{
    public class ColorsManager
    {
        private string ColorPrimary;
        private string ColorAccent;
        public ColorsManager(string primaryColor, string accentColor)
        {
            ColorPrimary = primaryColor;
            ColorAccent = accentColor;
        }

        public void ModifyFile(string path, string appName)
        {
            try
            {
                var line = 0;
                var newPath = Service.GetPath() + "\\Media\\" + appName;
                if (!Directory.Exists(newPath))
                {
                    DirectoryInfo di = Directory.CreateDirectory(newPath);
                }

                string[] lineas = File.ReadAllLines(path);

                foreach (var linea in lineas)
                {
                    if (linea.Contains("colorAccent"))
                        lineas[line] = "<color name=\"colorAccent\">" + ColorAccent + "</color>";
                    else if (linea.Contains("colorPrimary"))
                        lineas[line] = "<color name=\"colorPrimary\">" + ColorPrimary + "</color>";

                    line++;
                }
                File.WriteAllLines(newPath + "\\colors.xml", lineas);

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
