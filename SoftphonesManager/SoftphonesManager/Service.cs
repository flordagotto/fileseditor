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
            string path = @_base;
            return path;
        }
    }
}
