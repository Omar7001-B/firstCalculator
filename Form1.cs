using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numDot_Click(object sender, EventArgs e)
        {
            // Adding Dot Whenever the dot button is clicked
            textStore.Text += ". ";
        }

        private void numZero_Click(object sender, EventArgs e)
        {
            // Adding Zero Whenever the dot button is clicked
            textStore.Text += "0 ";
        }

        private void numTwo_Click(object sender, EventArgs e)
        {
            // Adding Two Whenever the dot button is clicked
            textStore.Text += "2";
        }

        private void numThree_Click(object sender, EventArgs e)
        {
            // Adding Three Whenever the dot button is clicked
            textStore.Text += "3";
        }

        private void numFour_Click(object sender, EventArgs e)
        {
            // Adding Four Whenever the dot button is clicked
            textStore.Text += "4";
        }

        private void numFive_Click(object sender, EventArgs e)
        {
            // Adding One Whenever the dot button is clicked
            textStore.Text += "5";
        }

        private void numSix_Click(object sender, EventArgs e)
        {
            // Adding Six Whenever the dot button is clicked
            textStore.Text += "6";
        }

        private void numSeven_Click(object sender, EventArgs e)
        {
            // Adding Seven Whenever the dot button is clicked
            textStore.Text += "7";

        }

        private void numEight_Click(object sender, EventArgs e)
        {
            // Adding Eight Whenever the dot button is clicked
            textStore.Text += "8";

        }

        private void numNine_Click(object sender, EventArgs e)
        {
            // Adding Nine Whenever the dot button is clicked
            textStore.Text += "9";
        }

        private void numOne_Click(object sender, EventArgs e)
        {
            // Adding One Whenever the dot button is clicked
            textStore.Text += "1";
        }

        private void numClear_Click(object sender, EventArgs e)
        {

            textResult.Clear();
            textStore.Clear();
        }
        float num;
        int count;
        private void numMinus_Click(object sender, EventArgs e)
        {
            if(textStore.Text != "")
            {
                num = float.Parse(textStore.Text.Trim());
                textResult.Text = textStore.Text + " - ";
                textStore.Clear();
                count = 1;
            }
        }

        private void numPlus_Click(object sender, EventArgs e)
        {
            if (textStore.Text != "")
            {
                num = float.Parse(textStore.Text.Trim());
                textResult.Text = textStore.Text + " + ";
                textStore.Clear();
                count = 2;
            }

        }

        private void numMul_Click(object sender, EventArgs e)
        {
            if (textStore.Text != "")
            {
                num = float.Parse(textStore.Text.Trim());
                textResult.Text = textStore.Text + " * ";
                textStore.Clear();
                count = 3;
            }

        }

        private void numDiv_Click(object sender, EventArgs e)
        {
            if (textStore.Text != "")
            {
                num = float.Parse(textStore.Text.Trim());
                textResult.Text = textStore.Text + " / ";
                textStore.Clear();
                count = 4;
            }

        }

        private void numMod_Click(object sender, EventArgs e)
        {
            if (textStore.Text != "")
            {
                num = float.Parse(textStore.Text.Trim());
                textResult.Text = textStore.Text + " % ";
                textStore.Clear();
                count = 5;
            }

        }

        private void numEqual_Click(object sender, EventArgs e)
        {
            double ans = 0;
            if (count == 1)
            {
                ans = num - float.Parse(textStore.Text.Trim());
                textResult.Text = textResult.Text + textStore.Text + " = " + ans;
                textStore.Text = ans.ToString();
            }

            if (count == 2)
            {
                ans = num + float.Parse(textStore.Text.Trim());
                textResult.Text = textResult.Text + textStore.Text + " = " + ans;
                textStore.Text = ans.ToString();
            }
            if (count == 3)
            {
                ans = num * float.Parse(textStore.Text.Trim());
                textResult.Text = textResult.Text + textStore.Text + " = " + ans;
                textStore.Text = ans.ToString();
            }
            if (count == 4)
            {
                ans = num / float.Parse(textStore.Text.Trim());
                textResult.Text = textResult.Text + textStore.Text + " = " + ans;
                textStore.Text = ans.ToString();
            }
            if (count == 5)
            {
                ans = num % float.Parse(textStore.Text.Trim());
                textResult.Text = textResult.Text + textStore.Text + " = " + ans;
                textStore.Text = ans.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
