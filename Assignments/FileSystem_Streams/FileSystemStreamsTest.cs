using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Domain;

namespace Assignments.FileSystem_Streams
{
    public class FileSystemStreamsTest
    {
        public void Test()
        {
            User user = new User();
            user.Id = new Guid();
            user.Name = "John";

            string path = @".\_UserDetails.txt";

            string originalFileName = @".\_UserDetails.txt";

            string compressedFileName = @".\_CompressedUserDetails.gz";

            string decompressedFileName = @".\_DecompressedUserDetails.txt";


            ReadFile readFile = new ReadFile();

            WriteFile writeFile = new WriteFile();

            EncryptDecryptFile encryptDecryptFile = new EncryptDecryptFile();

            CompressDecompressFile compressDecompressFile = new CompressDecompressFile();

            writeFile.Write(path, user);
            encryptDecryptFile.Encrypt(path);
            compressDecompressFile.Compress(originalFileName, compressedFileName);

            compressDecompressFile.Decompress(compressedFileName, decompressedFileName);
            encryptDecryptFile.Decrypt(decompressedFileName);
            Console.WriteLine(readFile.Read(decompressedFileName));
        }
    }
}
