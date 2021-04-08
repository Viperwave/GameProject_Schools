using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainGames
{
    public partial class fmPart2 : Form
    {
        public fmPart2()
        {
            InitializeComponent();
        }
        int x, b1, b2, b3, b4;

        private void Form1_Load(object sender, EventArgs e)
        {
            ch = new CheckBox[4] { checkBox1, checkBox2, checkBox3, checkBox4 };
            start(10, 20);
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnChecked(checkBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnChecked(checkBox2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnChecked(checkBox3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            btnChecked(checkBox4);
        }

        CheckBox[] ch;

        private void btnNext_Click(object sender, EventArgs e)
        {
            fmPart3 part2 = new fmPart3();
            part2.Show();
            this.Hide();
            
        }

        void start(int min, int max)
        {
            Random S = new Random();
            x = S.Next(min, max);
            label1.Text = x.ToString();

            do
            {
                b1 = S.Next(1, x - 1);
                b2 = S.Next(1, x - 1);
                b3 = S.Next(1, x - 1);
                b4 = S.Next(1, x - 1);
            } while ((b1 + b2 != x & b1 + b3 != x & b1 + b4 != x & b2 + b3 != x & b2 + b4 != x & b3 + b4 != x) & (b1 + b2 + b3 != x & b1 + b2 + b4 != x & b1 + b2 + b4 != x & b2 + b3 + b4 != x & b3 + b4 + b1 != x));

            button1.Text = b1.ToString();
            button2.Text = b2.ToString();
            button3.Text = b3.ToString();
            button4.Text = b4.ToString();

        }

        void btnChecked(CheckBox ch)
        {
            if (ch.Checked)
            {
                ch.Checked = false;
            }
            else
            {
                ch.Checked = true;
            }
        }

        void answer(CheckBox[] check)
        {
            int sum = 0;
            int[] A = new int[5] { b1, b2, b3, b4, x };
            for (int i = 0; i < check.Length; i++)
            {
                if (check[i].Checked)
                {
                    sum += A[i];
                }
            }
            if (sum == A[4])
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = Color.Red;
                MessageBox.Show("Niet Juist!");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            answer(ch);
            start(10, 20);
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }
    }
}
