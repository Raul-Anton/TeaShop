using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.FileSystem_Streams
{
    public class WriteFile
    {
        public void Write(string path, string s)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(s);

            using (FileStream fs = File.OpenWrite(path))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
        }
    }
}
