using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Text;


namespace WindowsFormsApp2
{
    class FileProcess
    {


        ArrayList kelimeler = new ArrayList();

        public void WordFileRead()
        {
            
            string path= @"C:\Users\pc\Desktop\WindowsFormsApp2\WindowsFormsApp2\bin\Debug\kelime.txt";

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("iso-8859-9"), false);



            
            string satir = sr.ReadLine();

            while (satir!=null)
            {
                kelimeler.Add(satir);
                
                satir = sr.ReadLine();
            }

            sr.Close();
            fs.Close();

        }

        public bool Control(string word)
        {
            if (kelimeler.Contains(word))
            {
                int a = kelimeler.IndexOf(word);
                return true;

            }
            else return false;
        }
        

    }
}
