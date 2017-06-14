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
        int[] brr = new int[37];
        


        

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
            for(int i=1; i<=5; i++)
            {
                if (arr[i-1] == 1)
                {
                    panel[i + 1].BackColor = Color.Orange;
                }
                if (arr[i-1] == 2)
                {
                    panel[i + 1].BackColor = Color.Green;
                }
                if (arr[i-1] == 3)
                {
                    panel[i + 1].BackColor = Color.Blue;
                }
                if (arr[i-1] == 0)
                {
                    panel[i + 1].BackColor = Color.White;
                }
            }
            if (arr[5] == 1)
            {
                panel[1].BackColor = Color.Orange;
            }
            if (arr[5] == 2)
            {
                panel[1].BackColor = Color.Green;
            }
            if (arr[5] == 3)
            {
                panel[1].BackColor = Color.Blue;
            }
            if (arr[5] == 0)
            {
                panel[1].BackColor = Color.White;
            }
            for (int i = 1; i <= 5; i++)
            {
                arr[i] = brr[i - 1];
            }
            arr[0] = brr[5];
            for (int i =0; i<=5; i++)
            {
                brr[i] = arr[i];
                    }

        }
        private void buttonb_Click(object sender, EventArgs e)
        {
            for (int i = 7; i <= 11; i++)
            {
                if (arr[i - 1] == 1)
                {
                    panel[i + 1].BackColor = Color.Orange;
                }
                if (arr[i - 1] == 2)
                {
                    panel[i + 1].BackColor = Color.Green;
                }
                if (arr[i - 1] == 3)
                {
                    panel[i + 1].BackColor = Color.Blue;
                }
                if (arr[i - 1] == 0)
                {
                    panel[i + 1].BackColor = Color.White;
                }
            }
            if (arr[11] == 1)
            {
                panel[7].BackColor = Color.Orange;
            }
            if (arr[11] == 2)
            {
                panel[7].BackColor = Color.Green;
            }
            if (arr[11] == 3)
            {
                panel[7].BackColor = Color.Blue;
            }
            if (arr[11] == 0)
            {
                panel[7].BackColor = Color.White;
            }
            for (int i = 7; i <= 11; i++)
            {
                arr[i] = brr[i - 1];
            }
            arr[6] = brr[11];
            for (int i = 6; i <= 11; i++)
            {
                brr[i] = arr[i];
            }

        }

        private void buttonc_Click(object sender, EventArgs e)
        {
            for (int i = 13; i <= 17; i++)
            {
                if (arr[i - 1] == 1)
                {
                    panel[i + 1].BackColor = Color.Orange;
                }
                if (arr[i - 1] == 2)
                {
                    panel[i + 1].BackColor = Color.Green;
                }
                if (arr[i - 1] == 3)
                {
                    panel[i + 1].BackColor = Color.Blue;
                }
                if (arr[i - 1] == 0)
                {
                    panel[i + 1].BackColor = Color.White;
                }
            }
            if (arr[17] == 1)
            {
                panel[13].BackColor = Color.Orange;
            }
            if (arr[17] == 2)
            {
                panel[13].BackColor = Color.Green;
            }
            if (arr[17] == 3)
            {
                panel[13].BackColor = Color.Blue;
            }
            if (arr[17] == 0)
            {
                panel[13].BackColor = Color.White;
            }
            for (int i = 13; i <= 17; i++)
            {
                arr[i] = brr[i - 1];
            }
            arr[12] = brr[17];
            for (int i = 12; i <= 17; i++)
            {
                brr[i] = arr[i];
            }
        }

        private void buttond_Click(object sender, EventArgs e)
        {
            for (int i = 19; i <= 23; i++)
            {
                if (arr[i - 1] == 1)
                {
                    panel[i + 1].BackColor = Color.Orange;
                }
                if (arr[i - 1] == 2)
                {
                    panel[i + 1].BackColor = Color.Green;
                }
                if (arr[i - 1] == 3)
                {
                    panel[i + 1].BackColor = Color.Blue;
                }
                if (arr[i - 1] == 0)
                {
                    panel[i + 1].BackColor = Color.White;
                }
            }
            if (arr[23] == 1)
            {
                panel[19].BackColor = Color.Orange;
            }
            if (arr[23] == 2)
            {
                panel[19].BackColor = Color.Green;
            }
            if (arr[23] == 3)
            {
                panel[19].BackColor = Color.Blue;
            }
            if (arr[23] == 0)
            {
                panel[19].BackColor = Color.White;
            }
            for (int i = 19; i <= 23; i++)
            {
                arr[i] = brr[i - 1];
            }
            arr[18] = brr[23];
            for (int i = 18; i <= 23; i++)
            {
                brr[i] = arr[i];
            }

        }

        private void buttone_Click(object sender, EventArgs e)
        {
            for (int i = 25; i <= 29; i++)
            {
                if (arr[i - 1] == 1)
                {
                    panel[i + 1].BackColor = Color.Orange;
                }
                if (arr[i - 1] == 2)
                {
                    panel[i + 1].BackColor = Color.Green;
                }
                if (arr[i - 1] == 3)
                {
                    panel[i + 1].BackColor = Color.Blue;
                }
                if (arr[i - 1] == 0)
                {
                    panel[i + 1].BackColor = Color.White;
                }
            }
            if (arr[29] == 1)
            {
                panel[25].BackColor = Color.Orange;
            }
            if (arr[29] == 2)
            {
                panel[25].BackColor = Color.Green;
            }
            if (arr[29] == 3)
            {
                panel[25].BackColor = Color.Blue;
            }
            if (arr[29] == 0)
            {
                panel[25].BackColor = Color.White;
            }
            for (int i = 25; i <= 29; i++)
            {
                arr[i] = brr[i - 1];
            }
            arr[24] = brr[29];
            for (int i = 24; i <= 29; i++)
            {
                brr[i] = arr[i];
            }

        }

        private void buttonf_Click(object sender, EventArgs e)
        {
            for (int i = 31; i <= 35; i++)
            {
                if (arr[i - 1] == 1)
                {
                    panel[i + 1].BackColor = Color.Orange;
                }
                if (arr[i - 1] == 2)
                {
                    panel[i + 1].BackColor = Color.Green;
                }
                if (arr[i - 1] == 3)
                {
                    panel[i + 1].BackColor = Color.Blue;
                }
                if (arr[i - 1] == 0)
                {
                    panel[i + 1].BackColor = Color.White;
                }
            }
            if (arr[35] == 1)
            {
                panel[31].BackColor = Color.Orange;
            }
            if (arr[35] == 2)
            {
                panel[31].BackColor = Color.Green;
            }
            if (arr[35] == 3)
            {
                panel[31].BackColor = Color.Blue;
            }
            if (arr[35] == 0)
            {
                panel[31].BackColor = Color.White;
            }
            for (int i = 31; i <= 35; i++)
            {
                arr[i] = brr[i - 1];
            }
            arr[30] = brr[35];
            for (int i = 30; i <= 35; i++)
            {
                brr[i] = arr[i];
            }
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
            for (int i=0; i<=35; i++)
            {
                brr[i] = arr[i];
            }
            


        }
    }

}


