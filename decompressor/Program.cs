using System;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace decompressor
{
    class Program
    {
        static void Main(string[] args)
        {
            String userprofileFolder = Environment.GetEnvironmentVariable("USERPROFILE");
            String[] fileEntries = Directory.GetFiles(userprofileFolder + "\\Downloads\\", "28DaySubscription*.zip");

            ZipArchive archive = ZipFile.OpenRead(fileEntries[0]);
            ZipArchiveEntry entry = archive.GetEntry(args[0]);
            entry.ExtractToFile(args[0], true);
        }
    }
}
