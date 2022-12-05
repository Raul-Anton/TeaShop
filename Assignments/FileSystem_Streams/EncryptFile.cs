using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.FileSystem_Streams
{
    public class EncryptFile
    {
        public void Encrypt(string path)
        {
            try
            {
                File.Encrypt(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Decrypt(string path)
        {
            try
            {
                File.Decrypt(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
