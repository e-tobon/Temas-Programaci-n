using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Ejecutar_Click(object sender, EventArgs e)
        {
            Graphics Papel;
            Papel = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);
           
            

            for(int i=0; i<pictureBox1.Width/2; i= i+5)
            {
                Papel.DrawLine(lapiz, 0, 0+i, 0+i, pictureBox1.Height/2);
            }

            for (int j = 0; j < pictureBox1.Height/2; j = j + 5)
            {
                Papel.DrawLine(lapiz, (pictureBox1.Width-j)/2, (pictureBox1.Height)/2, 0, (pictureBox1.Height-j)/2);
                
            }


        }
    }
}
