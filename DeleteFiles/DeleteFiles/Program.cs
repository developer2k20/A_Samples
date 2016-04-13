using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DeleteFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filename = File.ReadAllLines(@"C:\Users\Administrator\Desktop\RxList.txt");
            //string[] arrFilename = filename.Split(',');

            string[] filePaths = Directory.GetFiles(@"C:\Users\Administrator\Desktop\GeneratedRxList\");

            foreach (string filepath in filePaths)
            {
                if(filepath.Contains("_Doc"))
                {
                    //string name = filepath;
                    File.Delete(filepath);
                }
            }
            foreach (string filePath in filePaths)
            {
                for (int i = 0; i < filename.Length; i++)
                {
                    if (filePath.Contains(filename[i] + "_Rx.pdf"))
                    {
                        File.Move(filePath, @"C:\Users\Administrator\Desktop\GeneratedRxList\Currect Rx\" + filename[i] + "_Rx.pdf");
                    }
                }
            }
        }
    }
}
