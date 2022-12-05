using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Domain;

namespace Assignments.FileSystem_Streams
{
    public class WriteFile
    {
        public void Write(string path, User user)
        {
            string s = "" + user.Id + user.Name;
            byte[] bytes = Encoding.UTF8.GetBytes(s);

            using (FileStream fs = File.OpenWrite(path))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
        }
    }
}
