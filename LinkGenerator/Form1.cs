using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LinkGenerator
{
    public partial class Form1 : Form
    {
        string EachPartSizeValue;
        string FinalPartSizeValue;
        int numlines = 0;
        public Form1()
        {
            //button2.Click += new EventHandler(button2_Click);
            //textBox2.TextChanged += new EventHandler(textBox2_TextChanged);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int line;
            int j;
            //given value = 5;
            //numlines = 5;
            // 1 <= 5, true;
            // 
            for (line = 1; line <= numlines; line++)
            {

                if (textBox2.Text.Length != 0 && textBox3.Text.Length != 0)
                {
                    string value = "Part " + line;
                    string FinalPartSize = "[" + FinalPartSizeValue + "]";
                    string EachPartSize = "[" + EachPartSizeValue + "]";

  //<div><span style="color: #2b00fe; font-family: verdana;"><b><a href="https://drivebank.net/file/131072000123" target="_blank">PART 1</a></b></span></div>
                    string LinksValue = LinksBox.Lines[line - 1] + " ";
                    ResultBox.Items.Add(value + " ");
                    ResultBox.Items.Add(LinksValue + "" + EachPartSize);
                //ResultBox.Items.Add(LinksValue + "" + value + " " + EachPartSize);
                    if (numlines == line)
                    {
                        ResultBox.Items.Add("[Final]" + " " + FinalPartSize);

                    }
                }
                else
                {
                    MessageBox.Show("Please Enter the Final Part Size or Each Part Size !!",
      "LINK GENERATOR",
      MessageBoxButtons.OK,
      MessageBoxIcon.Error);
                }
            }
            //while (line <= numlines)
            //{
                
               // ResultBox.Items.Add(LinksBox.Lines[line - 1]);
                
                //line++;
            //}
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void LinksBox_TextChanged(object sender, EventArgs e)
        {
            numlines = LinksBox.Lines.Count();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            EachPartSizeValue = textBox2.Text;
            textBox2.Enabled = false; 
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FinalPartSizeValue = textBox3.Text;
            textBox3.Enabled = false; 
        }

        private void button6_Click(object sender, EventArgs e)
        {

            //<div><span style="color: #2b00fe; font-family: verdana;"><b><a href="https://drivebank.net/file/131072000123" target="_blank">PART 1</a></b></span></div>           
            OptionalBox.Text = "a";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to close the program ?", "LINK GENERATOR", MessageBoxButtons.YesNo,
 MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LinksBox.Clear();
            textBox2.Clear();
            textBox2.Enabled = true;
            textBox3.Clear();
            textBox3.Enabled = true;
            ResultBox.Items.Clear();
            ResultBox.ClearSelected();
            OptionalBox.Clear();

            

        }

        private void ResultBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void OptionalBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
