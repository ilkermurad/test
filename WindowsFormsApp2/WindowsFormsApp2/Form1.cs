using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {


        FileProcess fp = new FileProcess();

        public Form1()
        {
            InitializeComponent();

            
            fp.WordFileRead();
        }

        
        private void Button1_Click(object sender, EventArgs e)
        {
            if (fp.Control(kelimegir.Text)) Aciklama.Text = "var";
            else Aciklama.Text = "yök";
            
            
        }

       
    }
}
