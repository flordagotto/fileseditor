using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftphonesManager
{
    public static class Service
    {
        public static string GetPath()
        {
            string _base = Directory.GetCurrentDirectory();
            string path = "";
            var values = _base.Split('\\');
            int index = 0;
            foreach (var item in values)
            {
                if (item != "bin")
                {
                    if (index == 0)
                        path += item;
                    else
                        path += "\\" + item;
                }
                else
                    break;
                index++;
            }
            return path;
        }
    }
}
