using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.FileSystem_Streams
{
    public class ReadFile
    {
        public string Read(string path)
        {
            string read = File.ReadAllText(path);

            return read;
        }
    }
}
