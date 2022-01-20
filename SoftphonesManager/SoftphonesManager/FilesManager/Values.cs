using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftphonesManager.FilesManager
{
    public class Values
    {
        public Values()
        {
        }

        public void ModifyFile(string path, Dictionary<string,string> values)
        {
            try
            {
                var line = 0;
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
                File.WriteAllLines(path, lineas);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
