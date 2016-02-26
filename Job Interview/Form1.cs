using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Interview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //User sending response button
        private void answerButton_Click(object sender, EventArgs e)
        {
            //If nothing has been entered into the box, pop up error message
            if(responseBox.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Please enter a response");
            }
            else
            {   //Text from response enters into the conversation box, on a new line
                conversationBox.Text += "You: " + responseBox.Text + "\n";
                responseBox.Text = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void conversationBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
