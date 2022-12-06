using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.FileSystem_Streams
{
    public class CompressDecompressFile
    {
        public void Compress(string originalFileName, string compressedFileName)
        {
            using FileStream originalFileStream = File.Open(originalFileName, FileMode.Open);
            using FileStream compressedFileStream = File.Create(compressedFileName);
            using var compressor = new GZipStream(compressedFileStream, CompressionMode.Compress);
            originalFileStream.CopyTo(compressor);
        }

        public void Decompress(string compressedFileName, string decompressedFileName)
        {
            using FileStream compressedFileStream = File.Open(compressedFileName, FileMode.Open);
            using FileStream outputFileStream = File.Create(decompressedFileName);
            using var decompressor = new GZipStream(compressedFileStream, CompressionMode.Decompress);
            decompressor.CopyTo(outputFileStream);
        }
    }
}
