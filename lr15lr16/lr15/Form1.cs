using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr15
{
    public partial class Form1 : Form
    {
        bool btnPressed = false;
        bool squareTool;
        bool ellipsTool;
        Color myColor = Color.FromArgb(100, Color.Red);// Задаем цвет
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics myg = this.CreateGraphics();// создаем холст для  рисования
            int CursorX = Cursor.Position.X; // координата X курсора мыши
            int CursorY = Cursor.Position.Y-20; // координата Y курсора мыши
            SolidBrush myb = new SolidBrush(myColor); // переменная инструмента Кисть
            Rectangle myrect = new Rectangle(CursorX, CursorY, 10, 10); // создаем квадратик, связываем его с координатами мыши
            if(btnPressed && squareTool)
            {
                myg.FillRectangle(myb, myrect); // рисуем квадрат кистью на холсте
            }
            if(btnPressed && ellipsTool)
            {
                myg.FillEllipse(myb, myrect);
            }
        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            btnPressed = !btnPressed;
        }

        private void квадратToolStripMenuItem_Click(object sender, EventArgs e)
        {
            squareTool = true;
            ellipsTool = false;

        }

        private void элипсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            squareTool = false;
            ellipsTool = true;

        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myColor = Color.FromArgb(100, Color.Red);
        }

        private void зеленыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myColor = Color.FromArgb(100, Color.Green);
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myColor = Color.FromArgb(100, Color.Blue);
        }
    }
}
