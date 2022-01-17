using System;
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

        private Boolean CheckTextBox()
        {
            var res = true;
            if (String.IsNullOrEmpty(textBox1.Text) && String.IsNullOrEmpty(textBox3.Text) && String.IsNullOrEmpty(textBox4.Text))
            {  
                if (String.IsNullOrEmpty(textBox5.Text) && String.IsNullOrEmpty(textBox6.Text) && String.IsNullOrEmpty(textBox7.Text) && String.IsNullOrEmpty(textBox8.Text))
                {
                    res = false;
                }
                res = false;
            }
            return res;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            // e.Graphics.DrawImage(Properties.Resources.h_001, 470, 242 , 710, 260);
            Font f = new Font("Arial" , 12 , FontStyle.Regular);
             e.Graphics.DrawString(dateTimePicker1.Text, f, Brushes.Black, 526, 255);
            e.Graphics.DrawString(textBox1.Text, f, Brushes.Black, 706, 255);
             e.Graphics.DrawString(textBox3.Text, f, Brushes.Black, 615, 276);
            e.Graphics.DrawString(textBox4.Text, f, Brushes.Black, 725, 307);
            e.Graphics.DrawString(textBox5.Text, f, Brushes.Black, 810, 338);
            e.Graphics.DrawString(textBox6.Text, f, Brushes.Black, 810, 374);
            e.Graphics.DrawString(textBox7.Text, f, Brushes.Black, 700, 433);
            e.Graphics.DrawString(textBox8.Text, f, Brushes.Black, 838, 433);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!CheckTextBox())
            {
                label1.Text = "أملاء البيانات الغير مكتملة";
                return;
            }
            label1.Text = "";
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
           // textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
