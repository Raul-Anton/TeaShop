using Assignments.FileSystem_Streams;
using System.Runtime.CompilerServices;
using TeaShop.Core.Domain;

User user = new User();
user.Name = "John";

string path = @".\_UserName.txt";

string originalFileName = @".\_UserName.txt";

string compressedFileName = @".\_CompressedUserName.gz";

string decompressedFileName = @".\_DecompressedUserName.txt";


ReadFile readFile = new ReadFile();

WriteFile writeFile = new WriteFile();

EncryptFile encryptDecryptFile = new EncryptFile();

CompressFile compressDecompressFile = new CompressFile();

writeFile.Write(path, user.Name);
encryptDecryptFile.Encrypt(path);
compressDecompressFile.Compress(originalFileName, compressedFileName);

compressDecompressFile.Decompress(compressedFileName,decompressedFileName);
encryptDecryptFile.Decrypt(decompressedFileName);
Console.WriteLine(readFile.Read(decompressedFileName));


