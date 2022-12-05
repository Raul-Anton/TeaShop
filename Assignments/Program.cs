using Assignments.FileSystem_Streams;
using System.Runtime.CompilerServices;
using TeaShop.Core.Domain;

User user = new User();
user.Id = new Guid();
user.Name = "John";

string path = @".\_UserDetails.txt";

string originalFileName = @".\_UserDetails.txt";

string compressedFileName = @".\_CompressedUserDetails.gz";

string decompressedFileName = @".\_DecompressedUserDetails.txt";


ReadFile readFile = new ReadFile();

WriteFile writeFile = new WriteFile();

EncryptFile encryptDecryptFile = new EncryptFile();

CompressFile compressDecompressFile = new CompressFile();

writeFile.Write(path, user);
encryptDecryptFile.Encrypt(path);
compressDecompressFile.Compress(originalFileName, compressedFileName);

compressDecompressFile.Decompress(compressedFileName,decompressedFileName);
encryptDecryptFile.Decrypt(decompressedFileName);
Console.WriteLine(readFile.Read(decompressedFileName));


