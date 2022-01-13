﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // e.Graphics.DrawImage(Properties.Resources.h_001, 470, 242 , 710, 260);
            Font f = new Font("Arial" , 12 , FontStyle.Regular);
             e.Graphics.DrawString(textBox2.Text, f, Brushes.Black, 526, 255);
            e.Graphics.DrawString(textBox1.Text, f, Brushes.Black, 706, 255);
             e.Graphics.DrawString(textBox3.Text, f, Brushes.Black, 615, 276);
            e.Graphics.DrawString(textBox4.Text, f, Brushes.Black, 725, 307);
            e.Graphics.DrawString(textBox5.Text, f, Brushes.Black, 810, 348);
            e.Graphics.DrawString(textBox6.Text, f, Brushes.Black, 810, 384);
            e.Graphics.DrawString(textBox7.Text, f, Brushes.Black, 700, 433);
            e.Graphics.DrawString(textBox8.Text, f, Brushes.Black, 838, 433);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /* CaptureScreen();
             if (printDialog1.ShowDialog() == DialogResult.OK)
             {
                 printDocument1.Print();
             }*/
            PaperSize paperSize = new PaperSize("test", 1123, 370);
             paperSize.RawKind = (int)PaperKind.Custom;
             printDocument1.DefaultPageSettings.PaperSize = paperSize;
             printDocument1.DefaultPageSettings.Landscape = true;
             printDocument1.DefaultPageSettings.Margins = new Margins(0, 0, 20, 20);
            if (printDialog1.ShowDialog() == DialogResult.OK)
             {
                 printDocument1.Print();
             }
        }
    }
}