using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftphonesManager.FilesManager
{
    public class ValuesManager
    {
        public ValuesManager()
        {
        }

        public void ModifyFile(string path, Dictionary<string,string> values, string language, string appName)
        {
            try
            {
                var line = 0;
                var newPath = Service.GetPath() + "\\Media\\" + appName + "\\" + language;
                if (!Directory.Exists(newPath))
                {
                    DirectoryInfo di = Directory.CreateDirectory(newPath);
                }

                string[] lineas = File.ReadAllLines(path);

                foreach (var linea in lineas)
                {
                    foreach (var value in values)
                    {
                        if (linea.Contains(value.Key))
                            lineas[line] = "<string name=\"" + value.Key + "\">" + value.Value + "</string>";
                    }
                    line++;
                }
                File.WriteAllLines(newPath + "\\string.xml", lineas);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
