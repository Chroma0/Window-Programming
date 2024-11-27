using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework5_1
{
    public partial class Form1 : Form
    {
        int[] array = new int[26];
        Button[] b = new Button[26];
        string answer="";
        int wrong = 0;
        int num = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                timer1.Enabled = true;
                timer1.Start();
                answer = textBox1.Text.ToUpper();
                label1.Visible = false;
                label1.Enabled = false;
                label2.Visible = false;
                label2.Enabled = false;
                textBox1.Visible = false;
                textBox1.Enabled = false;
                button1.Visible = false;
                button1.Enabled = false;
                //Set button
                char name = 'A';
                for (int i = 0; i < 26; i++)
                {
                    b[i] = new Button();
                    b[i].Text = Convert.ToString(name);
                    b[i].SetBounds(100 + 60 * (i % 10), 60 + 60 * (i / 10), 50, 50);
                    Controls.Add(b[i]);
                    name++;
                }
                label3.Visible = true;
                label4.Visible = true;
                label4.Text += "0次";
                label5.Visible = true;
                for(int i = 0; i < answer.Length; i++)
                {
                    label5.Text += "_ ";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            timer1.Enabled = false;
            timer1.Interval = 1000;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = "時間:" + num.ToString();
            num++;
        }

        private bool win()
        {
            int check = 0;
            for(int i = 0; i < (answer.Length * 2); i+=2)
            {
                char c = char.Parse(label5.Text.Substring(i, 1));
                if (c<'A' || c > 'Z')
                {
                    check++;
                    break;
                }
            }
            if (check > 0)
            {
                return false;
            }
            else
            {
                timer1.Enabled = false;
                return true;
            }
        }

        private void Reset()
        {
            for (int i = 0; i < 26; i++)
            {
                Controls.Remove(b[i]);
            }
            num = 0;
            textBox1.Text = "";
            label1.Visible = true;
            label1.Enabled = true;
            label2.Visible = true;
            label2.Enabled = true;
            textBox1.Visible = true;
            textBox1.Enabled = true;
            button1.Visible = true;
            button1.Enabled = true;
            label3.Visible = false;
            label3.Text = "時間:0";
            label4.Visible = false;
            label4.Text = "猜錯次數:";
            label5.Visible = false;
            label5.Text = "";
            wrong = 0;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (button1.Enabled == false)
            {
                char input = Char.Parse(e.KeyCode.ToString());
                if (input >= 'A' && input <= 'Z')
                {
                    int check = 0;
                    for (int i = 0; i < ((answer.Length) * 2); i += 2)
                    {
                        char compare = Char.Parse(answer.Substring(i/2, 1));
                        if (compare == input)
                        {
                            check++;
                            label5.Text=label5.Text.Remove(i, 1);
                            label5.Text=label5.Text.Insert(i, compare.ToString());
                            for (int j = 0; j < 26; j++)
                            {
                                if (b[j].Text == compare.ToString())
                                {
                                    b[j].BackColor = Color.LightGreen;
                                }
                            }
                            if (win())
                            {
                                string text = "花費" + label3.Text + "\r\n" + label4.Text.Substring(0, 2) + label4.Text.Substring(4, 3);
                                if (MessageBox.Show(text, "You win!", MessageBoxButtons.OK) == DialogResult.OK)
                                {
                                    Reset();
                                }
                            }
                        }
                    }
                    if (check == 0)
                    {
                        for (int j = 0; j < 26; j++)
                        {
                            if (b[j].Text == input.ToString() && b[j].Visible == true)
                            {
                                wrong++;
                                for (int i = 0; i < 26; i++)
                                {
                                    if (b[i].Text == input.ToString())
                                    {
                                        b[i].Visible = false;
                                    }
                                }
                                label4.Text=label4.Text.Remove(5, 1);
                                label4.Text=label4.Text.Insert(5, wrong.ToString());
                                if (wrong == 6)
                                {
                                    timer1.Enabled = false;
                                    if (MessageBox.Show("You Lose!", "", MessageBoxButtons.OK) == DialogResult.OK)
                                    {
                                        Reset();
                                    }
                                }
                            }
                        }
                    }
                }
                if (input >= 'a' && input <= 'z')
                {
                    int check = 0;
                    input = Char.Parse(e.KeyCode.ToString().ToUpper());
                    for (int i = 0; i < ((answer.Length) * 2); i += 2)
                    {
                        char compare = char.Parse(answer.Substring(i/2, 1));
                        if (compare == input)
                        {
                            check++;
                            label5.Text=label5.Text.Remove(i, 1);
                            label5.Text=label5.Text.Insert(i, compare.ToString());
                            for (int j = 0; j < 26; j++)
                            {
                                if (b[j].Text == compare.ToString())
                                {
                                    b[j].BackColor = Color.LightGreen;
                                }
                            }
                            if (win())
                            {
                                string text = "花費" + label3.Text + "\r\n" + label4.Text.Substring(0, 2) + label4.Text.Substring(4, 3);
                                if (MessageBox.Show(text, "You win!", MessageBoxButtons.OK) == DialogResult.OK)
                                {
                                    Reset();
                                }
                            }
                        }
                    }
                    if (check == 0 )
                    {
                        for (int j = 0; j < 26; j++)
                        {
                            if (b[j].Text == input.ToString() && b[j].Visible == true)
                            {
                                wrong++;
                                for (int i = 0; i < 26; i++)
                                {
                                    if (b[i].Text == input.ToString())
                                    {
                                        b[i].Visible = false;
                                    }
                                }
                                label4.Text=label4.Text.Remove(5, 1);
                                label4.Text=label4.Text.Insert(5, wrong.ToString());
                                if (wrong == 6)
                                {
                                    timer1.Enabled = false;
                                    if (MessageBox.Show("You Lose!", "", MessageBoxButtons.OK) == DialogResult.OK)
                                    {
                                        Reset();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
