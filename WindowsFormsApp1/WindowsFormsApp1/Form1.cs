using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
   
    public partial class Form1 : Form
    {
        Random random = new Random();
        int[] arr = Enumerable.Range(0, 36).ToArray();
        Panel[] panel = new Panel[37];
        


        

        public Form1()
        {
            InitializeComponent();
            panel[1] = a1;
            panel[2] = a2;
            panel[3] = a3;
            panel[4] = a4;
            panel[5] = a5;
            panel[6] = a6;
            panel[7] = b1;
            panel[8] = b2;
            panel[9] = b3;
            panel[10] = b4;
            panel[11] = b5;
            panel[12] = b6;
            panel[13] = c1;
            panel[14] = c2;
            panel[15] = c3;
            panel[16] = c4;
            panel[17] = c5;
            panel[18] = c6;
            panel[19] = d1;
            panel[20] = d2;
            panel[21] = d3;
            panel[22] = d4;
            panel[23] = d5;
            panel[24] = d6;
            panel[25] = e1;
            panel[26] = e2;
            panel[27] = e3;
            panel[28] = e4;
            panel[29] = e5;
            panel[30] = e6;
            panel[31] = f1;
            panel[32] = f2;
            panel[33] = f3;
            panel[34] = f4;
            panel[35] = f5;
            panel[36] = f6;

            for (int i=0; i <= 34; i++)
            {
                arr[i] = arr[i] % 4;
            }
            
        }

        private void buttona_Click(object sender, EventArgs e)
        {
            
        }
        private void buttonb_Click(object sender, EventArgs e)
        {

        }

        private void buttonc_Click(object sender, EventArgs e)
        {

        }

        private void buttond_Click(object sender, EventArgs e)
        {

        }

        private void buttone_Click(object sender, EventArgs e)
        {

        }

        private void buttonf_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            arr = arr.OrderBy(c => random.Next()).ToArray();
            for (int i = 0; i <= 35; i++)
            {
                if (arr[i] == 1)
                {
                    panel[i+1].BackColor = Color.Orange;
                }
                if (arr[i] == 2)
                {
                    panel[i + 1].BackColor = Color.Green;
                }
                if (arr[i] == 3)
                {
                    panel[i + 1].BackColor = Color.Blue;
                }
                if (arr[i] == 0)
                {
                    panel[i + 1].BackColor = Color.White;
                }

            }
            if (arr[1]==2)
            {
                panel[1].BackColor = Color.Blue;
            }
            


        }
    }

}


