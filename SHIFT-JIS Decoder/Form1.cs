using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHIFT_JIS_Decoder
{
    public partial class Form1 : Form
    {
        private Encoding shiftjisenc1;
        private Encoding shiftjicenc2;
        private Encoding ascii;

        public Form1()
        {
            InitializeComponent();
            shiftjisenc1 = Encoding.GetEncoding(1252);
            shiftjicenc2 = Encoding.GetEncoding(932);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Decode clicked
            if (textBox1.Text != "")
            {
                string jap_text = textBox1.Text;
                var nearreadable = shiftjisenc1.GetBytes(jap_text);
                string readable = shiftjicenc2.GetString(nearreadable);
                textBox2.Text = readable;
            }
            else
            {
                MessageBox.Show("Provide some input");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Copy to clipboard clicked
            if (textBox2.Text != "")
                Clipboard.SetText(textBox2.Text);
            else
                MessageBox.Show("Output empty");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
