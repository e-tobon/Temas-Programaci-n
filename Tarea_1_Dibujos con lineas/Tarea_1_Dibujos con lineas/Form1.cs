using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_1_Dibujos_con_lineas
{
    public partial class Form1 : Form
    {
        Graphics papel;
        Pen lapiz = new Pen(Color.Black);

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Dibujo_1(papel, lapiz);
            Dibujo_2(papel, lapiz);
            Dibujo_3(papel, lapiz);
            Dibujo_4(papel, lapiz);
            Dibujo_5(papel, lapiz);
            Dibujo_6(papel, lapiz);
            Dibujo_7(papel, lapiz);
            Dibujo_8(papel, lapiz);
        }

        private void Dibujo_1(Graphics Papel, Pen lapiz)
        {
            Papel = pictureBox1.CreateGraphics();
            for (int i = 0; i < pictureBox1.Height; i = i + 8)
            {
                Papel.DrawLine(lapiz, 0, i, pictureBox1.Width, i);

            }

        }

        private void Dibujo_2(Graphics Papel, Pen lapiz)
        {
            Papel = pictureBox2.CreateGraphics();

            for(int i = 0; i < pictureBox2.Width; i = i + 5)
            {
                Papel.DrawLine(lapiz, i, 0, i, pictureBox2.Height);
            }
        }

        private void Dibujo_3(Graphics Papel, Pen lapiz)
        {
            Papel = pictureBox3.CreateGraphics();
            for(int i = 0; i<pictureBox1.Height; i = i+ 5)
            {
                Papel.DrawLine(lapiz, 0, i, pictureBox3.Width, i);
            }

            for(int j = 0; j<pictureBox3.Width; j = j + 5)
            {
                Papel.DrawLine(lapiz,j,0,j,pictureBox3.Height);
            }
        }

        private void Dibujo_4(Graphics Papel, Pen lapiz)
        {
            Papel = pictureBox4.CreateGraphics();
            for(int i = 0; i < pictureBox4.Width; i = i + 8)
            {
                Papel.DrawLine(lapiz, i, 0, pictureBox4.Width / 2, pictureBox4.Height / 2);
                Papel.DrawLine(lapiz, i, pictureBox4.Height, pictureBox4.Width / 2, pictureBox4.Height / 2);
               
            }
        }

        private void Dibujo_5(Graphics Papel, Pen lapiz)
        {
            Papel = pictureBox5.CreateGraphics();
            for(int i=0; i<pictureBox5.Height; i = i + 5)
            {
                Papel.DrawLine(lapiz, 0, i, i, 0);
            }
            for (int j = 0; j <= pictureBox5.Height; j = j + 5)
            {
                Papel.DrawLine(lapiz, pictureBox5.Width, pictureBox5.Height-j, pictureBox5.Width-j, pictureBox5.Height);
            }
        }

        private void Dibujo_6(Graphics Papel, Pen Lapiz)
        {
            Papel = pictureBox6.CreateGraphics();
            for(int i = 0; i< pictureBox6.Width; i = i + 5)
            {
                Papel.DrawLine(Lapiz, pictureBox6.Width, i, i, 0);
                
            }
        }
        
        private void Dibujo_7(Graphics Papel, Pen Lapiz)
        {
            Papel = pictureBox7.CreateGraphics();
            for (int i = 0; i < pictureBox7.Width; i = i + 5)
            {
                
                Papel.DrawLine(Lapiz, pictureBox7.Width, i, i, 0);
                Papel.DrawLine(Lapiz, 0,i, pictureBox7.Width - i, 0);
                Papel.DrawLine(Lapiz, 0, pictureBox7.Height - i, pictureBox7.Width - i, pictureBox7.Height);
                Papel.DrawLine(Lapiz, pictureBox7.Width, i, pictureBox7.Width-i, pictureBox7.Height);

            }

        }



        private void Dibujo_8(Graphics Papel, Pen Lapiz)
        {
            Papel = pictureBox8.CreateGraphics();
            for(int i = 0; i < pictureBox8.Height; i = i + 5)
            {
                Papel.DrawLine(Lapiz, 0, i, pictureBox8.Width / 2, pictureBox8.Height / 2);
                Papel.DrawLine(Lapiz, pictureBox8.Width, i, pictureBox8.Width / 2, pictureBox8.Height / 2);
            }
        }


    }
}
