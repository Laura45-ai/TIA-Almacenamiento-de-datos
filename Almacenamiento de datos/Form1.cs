//Laura Cristina Colorado Sánchez
//TIA-Almacenamiento de datos
// 17.09.2024

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacenamiento_de_datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TXT TXT = new TXT();
            TXT.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CSV CSV = new CSV();
            CSV.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XML XML = new XML();
            XML.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RTF RTF = new RTF();
            RTF.Show();
        }
    }
}
