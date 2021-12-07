using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pole_ukol_kolacka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButtonVzestupne_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonVzestupne.Checked)
            {
                listBox2.Items.Clear();
                Array.Sort(pole);
                foreach (int s in pole)
                {
                    listBox2.Items.Add(s);
                }
            }
        }

        private void radioButtonSestupne_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSestupne.Checked)
            {
                listBox2.Items.Clear();
                Array.Sort(pole);
                Array.Reverse(pole);
                foreach (int s in pole)
                {
                    listBox2.Items.Add(s);
                }
            }
        }

        int[] pole;

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rnd = new Random();
            int vstup = int.Parse(textBoxVstup.Text);
            pole = new int[vstup];
            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = rnd.Next(1, 51);
                listBox1.Items.Add(pole[i].ToString());
            }
            if (radioButtonSestupne.Checked)
            {
                listBox2.Items.Clear();
                Array.Sort(pole);
                Array.Reverse(pole);
                foreach (int s in pole)
                {
                    listBox2.Items.Add(s);
                }
            }
            if (radioButtonVzestupne.Checked)
            {
                listBox2.Items.Clear();
                Array.Sort(pole);
                foreach (int s in pole)
                {
                    listBox2.Items.Add(s);
                }
            }
        }
    }
}
