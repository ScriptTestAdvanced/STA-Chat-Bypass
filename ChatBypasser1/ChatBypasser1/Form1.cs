using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;






namespace ChatBypasser1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public static void dk()
        {
            MessageBox.Show("Copied to clipboard! Paste in roblox chat!", "Copied!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void copy(string copytext)
        {
            Clipboard.SetText(copytext);
        }

    private void button1_Click(object sender, EventArgs e)
        {
            // String to copy to clipboard
            string textToCopy = "ftuk";

            // Copy the string to clipboard
            Clipboard.SetText(textToCopy);

            // Optionally, provide feedback to the user
            dk();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            copy("Вӏтсн");
            dk();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            copy("Штf");

            dk();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            copy("I jerk 0ff too kids");


            dk();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            copy("vbibrator");

            dk();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = checkBox1.Checked;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            copy("You should kiII yousaIf now!");


            dk();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            copy("I jerk 0ff too CP");


            dk();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            copy("MoIest");

            dk();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("White Cat says hi, and good job for finding an easter egg!", "Secret!");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            copy("I jerk 0ff to IittIe kids");

            dk();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            copy("neiger");

            dk();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            copy("neigerss");

            dk();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            copy("porstar");

            dk();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            copy("dascard");

            dk();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            copy("addI m3 oIn dascard");

            dk();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            copy("kwkk ontop");

            dk();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            copy("i rpaped my mum");

            dk();
        }
    }
}
