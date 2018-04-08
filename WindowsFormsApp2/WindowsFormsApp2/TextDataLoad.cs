using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WindowsFormsApp2
{
    class TextDataLoad
    {

        public int FileLength { get; set; }

        public void FileCount()
        {
            string path = @"metinler";
            DirectoryInfo dirInfo = new DirectoryInfo(path);

            FileInfo[] fileInfo = dirInfo.GetFiles();

            FileLength = fileInfo.Length;

            for(int i = 0; i < FileLength; i++) {
               string pathFiles = @"metinler\"+fileInfo[i]+".txt";
               FileStream fileStream = new FileStream(pathFiles,FileMode.Open, FileAccess.Read);
                StreamReader streamRead = new StreamReader(fileStream, Encoding.GetEncoding("iso-8859-9"), false);
        }


    }
}
