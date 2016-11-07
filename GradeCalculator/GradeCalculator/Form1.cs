using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCalculator
{
    public partial class Form1 : Form
    {
        int[] a = new int[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label14.Text = "Numerical Grade: "+ CalculaterGrade();
            label15.Text = "Letter Grade: " + FindLetterGrade();
        }
        private void SaveResults()
        {
            if (textBox1.Text == null)
            {
                MessageBox.Show("No grade found for ICE's");
                MessageBox.Show("All assignments must have grade to calculate a grade");
            }
            else
            {
                string b = textBox1.Text;
                int c;
                bool d = int.TryParse(b, out c);
                if (d)
                {
                    a[0] = c;
                }
                else
                {
                    MessageBox.Show("Please enter a numerical grade");
                }
            }
            if (textBox2.Text == null)
            {
                MessageBox.Show("No grade found for HW 1");
                MessageBox.Show("All assignments must have grade to calculate a grade");
            }
            else
            {
                string d = textBox2.Text;
                int f;
                bool g = int.TryParse(d, out f);
                if (g)
                {
                    a[1] = f;
                }
                else
                {
                    MessageBox.Show("Please enter a numerical grade");
                }
            }
            if (textBox3.Text == null)
            {
                MessageBox.Show("No grade found for HW 2");
                MessageBox.Show("All assignments must have grade to calculate a grade");
            }
            else
            {
                string h = textBox3.Text;
                int i;
                bool j = int.TryParse(h, out i);
                if (j)
                {
                    a[2] = i;
                }
                else
                {
                    MessageBox.Show("Please enter a numerical grade");
                }
            }
            if (textBox4.Text == null)
            {
                MessageBox.Show("No grade found for HW 3");
                MessageBox.Show("All assignments must have grade to calculate a grade");
            }
            else
            {
                string k = textBox4.Text;
                int l;
                bool m = int.TryParse(k, out l);
                if (m)
                {
                    a[3] = l;
                }
                else
                {
                    MessageBox.Show("Please enter a numerical grade");
                }
            }
            if (textBox5.Text == null)
            {
                MessageBox.Show("No grade found for HW 4");
                MessageBox.Show("All assignments must have grade to calculate a grade");
            }
            else
            {
                string n = textBox5.Text;
                int o;
                bool p = int.TryParse(n, out o);
                if (p)
                {
                    a[4] = o;
                }
                else
                {
                    MessageBox.Show("Please enter a numerical grade");
                }
            }
            if (textBox6.Text == null)
            {
                MessageBox.Show("No grade found for HW 5");
                MessageBox.Show("All assignments must have grade to calculate a grade");
            }
            else
            {
                string q = textBox6.Text;
                int r;
                bool s = int.TryParse(q, out r);
                if (s)
                {
                    a[5] = r;
                }
                else
                {
                    MessageBox.Show("Please enter a numerical grade");
                }
            }
            if (textBox7.Text == null)
            {
                MessageBox.Show("No grade found for Exam 1");
                MessageBox.Show("All assignments must have grade to calculate a grade");
            }
            else
            {
                string t = textBox7.Text;
                int u;
                bool v = int.TryParse(t, out u);
                if (v)
                {
                    a[6] = u;
                }
                else
                {
                    MessageBox.Show("Please enter a numerical grade");
                }
            }
            if (textBox8.Text == null)
            {
                MessageBox.Show("No grade found for Exam 2");
                MessageBox.Show("All assignments must have grade to calculate a grade");
            }
            else
            {
                string w = textBox8.Text;
                int x;
                bool y = int.TryParse(w, out x);
                if (y)
                {
                    a[7] = x;
                }
                else
                {
                    MessageBox.Show("Please enter a numerical grade");
                }
            }
            if (textBox9.Text == null)
            {
                MessageBox.Show("No grade found for Final");
                MessageBox.Show("All assignments must have grade to calculate a grade");
            }
            else
            {
                string z = textBox9.Text;
                int aa;
                bool ab = int.TryParse(z, out aa);
                if (ab)
                {
                    a[8] = aa;
                }
                else
                {
                    MessageBox.Show("Please enter a numerical grade");
                }
            }
            if (textBox10.Text == null)
            {
                MessageBox.Show("No grade found for Paticipation");
                MessageBox.Show("All assignments must have grade to calculate a grade");
            }
            else
            {
                string ac = textBox10.Text;
                int ad;
                bool ae = int.TryParse(ac, out ad);
                if (ae)
                {
                    a[9] = ad;
                }
                else
                {
                    MessageBox.Show("Please enter a numerical grade");
                }
            }
        }
        private string CalculaterGrade()
        {
            SaveResults();
            int af = a[0] + a[1] + a[2] + a[3] + a[4] + a[5] + a[6] + a[7] + a[8] + a[9];
            string ag = af.ToString();
            return ag;
        }
        private string FindLetterGrade()
        {
            string ah;
            int Calculate = int.Parse(CalculaterGrade());
            if(93<=Calculate && 100>=Calculate)
            {
                ah = "A";
            }
            else if(90<=Calculate && 92>=Calculate)
            {
                ah = "A-";
            }
            else if(87<=Calculate && 89>=Calculate)
            {
                ah = "B+";
            }
            else if(83<=Calculate && 86>=Calculate)
            {
                ah = "B";
            }
            else if(80<=Calculate && 82>Calculate)
            {
                ah = "B-";
            }
            else if(77<=Calculate && 79>=Calculate)
            {
                ah = "C+";
            }
            else if(73<=Calculate && 76>=Calculate)
            {
                ah = "C";
            }
            else if(70<=Calculate && 72>=Calculate)
            {
                ah = "C-";
            }
            else if(60<=Calculate && 69>=Calculate)
            {
                ah = "D";
            }
            else
            {
                ah = "F";
            }
            return ah;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }
    }
}
