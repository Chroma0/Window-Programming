using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework4_1
{
    public partial class Form1 : Form
    {
        int[] array = new int[16];
        Button[] b = new Button[16];
        int k = 0,check=0;
        public bool Win()
        {
            int w = 0;
            for(int i = 0; i < 16; i++)
            {
                if(b[i].Enabled == true)
                {
                    w++;
                    break;
                }
            }
            if (w > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void b_Click(object sender,EventArgs e)
        {
            Button btn = sender as Button;
            if (k==0)
            {
                check =((int)btn.TabIndex)-4;
                btn.Image = imageList1.Images[array[check] / 2];
                k = (k + 1) % 2;
            }
            else
            {
                if ((array[(int)btn.TabIndex-4] / 2) == (array[check]/2))
                {
                    b[(int)btn.TabIndex-4].Image = imageList1.Images[array[(int)btn.TabIndex-4] / 2];
                    b[(int)btn.TabIndex-4].Enabled = false;
                    b[check].Enabled = false;
                    if (Win()==true)
                    {
                        MessageBox.Show("你贏了!");
                    }
                }
                else
                {
                    b[(int)btn.TabIndex-4].Image = imageList1.Images[array[(int)btn.TabIndex-4] / 2];
                    button2.Enabled = true;
                }
                k = (k + 1) % 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            for (int i = 0; i < 16; i++)
            {
                b[i] = new Button();
                b[i].SetBounds(59+68*(i%4), 72+85*(i/4), 64, 81);
                b[i].ImageList = imageList1;
                b[i].Image = imageList1.Images[8];
                b[i].Click += new EventHandler(b_Click);
                Controls.Add(b[i]);
            }
            Random rnd = new Random();
            for(int i = 0; i < 16; i++)
            {
                array[i] = i ;
            }
            for(int i = 0; i < 16; i++)
            {
                int random = rnd.Next(0, 16);
                int random_num = array[random];
                array[random] = array[i];
                array[i] = random_num;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 16; i++)
            {
                if(b[i].Enabled==true && b[i].Image != imageList1.Images[8])
                {
                    b[i].Image = imageList1.Images[8];
                }
            }
            button2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

    }
}
