using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void buttonCollor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Clear();
                string fileName = openFileDialog1.FileName;
                richTextBox1.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251));
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.DefaultExt = ".txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var name = saveFileDialog1.FileName;
                File.WriteAllText(name, richTextBox1.Text, Encoding.GetEncoding(1251));
            }
            richTextBox1.Clear();
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void Color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void Font_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Clear();
                string fileName = openFileDialog1.FileName;
                richTextBox1.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251));
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.DefaultExt = ".txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var name = saveFileDialog1.FileName;
                File.WriteAllText(name, richTextBox1.Text, Encoding.GetEncoding(1251));
            }
            richTextBox1.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void PrinterSettings_Click(object sender, EventArgs e)
        {

        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Tahoma", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            string Hello = "Hello World!";
            e.Graphics.DrawString(Hello, myFont, Brushes.Black, 20, 20);
        }

        private void PrintPage_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        private void Preview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }
        private void AboutTheProgram_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void Cut1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void Copy1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void Paste1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void Clear1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void поПравомуКраюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void поЦентруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void поЛевомуКраюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Clear();
                string fileName = openFileDialog1.FileName;
                richTextBox1.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251));
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.DefaultExt = ".txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var name = saveFileDialog1.FileName;
                File.WriteAllText(name, richTextBox1.Text, Encoding.GetEncoding(1251));
            }
            richTextBox1.Clear();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }
    }
}