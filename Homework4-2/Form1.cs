using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework4_2
{
    public partial class Form1 : Form
    {
        int[] array = new int[16];
        Button[] b = new Button[16];
        int k = 0, check = 0,score=100;
        string name = "";
        public void Win()
        {
            int w = 0;
            for (int i = 0; i < 16; i++)
            {
                if (b[i].Enabled == true)
                {
                    w++;
                    break;
                }
            }
            if(w==0)
            {
                textBox2.Text = textBox2.Text + textBox1.Text + "得分為:" + score+"\r\n"+"\r\n";
                if(MessageBox.Show("分數:"+score, "遊戲結束", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information) == DialogResult.Retry)
                {
                    button1.Enabled = true;
                    textBox1.Enabled = true;
                    textBox1.Text = "";
                    label2.Text = "分數:100";
                    score = 100;
                    for (int i = 0; i < 16; i++)
                    {
                        tabPage1.Controls.Remove(b[i]);
                    }
                }
            }
        }
        public void b_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (k == 0)
            {
                check = ((int)btn.TabIndex) - 12;
                btn.Image = imageList1.Images[array[check] / 2];
                k = (k + 1) % 2;
            }
            else
            {
                if ((array[(int)btn.TabIndex - 12] / 2) == (array[check] / 2))
                {
                    score += 10;
                    label2.Text = "分數:" + score;
                    b[(int)btn.TabIndex - 12].Image = imageList1.Images[array[(int)btn.TabIndex - 12] / 2];
                    b[(int)btn.TabIndex - 12].Enabled = false;
                    b[check].Enabled = false;
                    Win();
                }
                else
                {
                    score -= 5;
                    label2.Text = "分數:" + score;
                    b[(int)btn.TabIndex - 12].Image = imageList1.Images[array[(int)btn.TabIndex - 12] / 2];
                    button2.Enabled = true;
                }
                k = (k + 1) % 2;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            if (name == "")
            {
                MessageBox.Show("名稱不能為空白", "錯誤",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (name.Length < 3 || name.Length > 10)
            {
                MessageBox.Show("名稱不合格式( >= 3 && <= 10 )", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBox1.Enabled = false;
                button1.Enabled = false;
                for (int i = 0; i < 16; i++)
                {
                    b[i] = new Button();
                    b[i].SetBounds(59 + 68 * (i % 4), 72 + 85 * (i / 4), 64, 81);
                    b[i].ImageList = imageList1;
                    b[i].Image = imageList1.Images[8];
                    b[i].Click += new EventHandler(b_Click);
                    tabPage1.Controls.Add(b[i]);
                }
                Random rnd = new Random();
                for (int i = 0; i < 16; i++)
                {
                    array[i] = i;
                }
                for (int i = 0; i < 16; i++)
                {
                    int random = rnd.Next(0, 16);
                    int random_num = array[random];
                    array[random] = array[i];
                    array[i] = random_num;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++)
            {
                if (b[i].Enabled == true && b[i].Image != imageList1.Images[8])
                {
                    b[i].Image = imageList1.Images[8];
                }
            }
            button2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Text = "";
            label2.Text = "分數:100";
            score = 100;
            for(int i = 0; i < 16; i++)
            {
                tabPage1.Controls.Remove(b[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要離開遊戲嗎?", "離開遊戲", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }
    }
}
