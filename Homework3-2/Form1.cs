using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int check = 0;
        int choose;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 7 || textBox3.Text.Length > 7 || textBox4.Text.Length > 7 || textBox5.Text.Length > 7)
            {
                textBox1.Text = "測資錯誤";
            }
            else
            {
                int check1 = 0;
                int check2 = 0;
                int check3 = 0;
                for(int i=0;i<textBox2.Text.Length;i+=2)
                {
                    char a = textBox2.Text[i];
                    if (a == '1') { check1++; }
                    if (a == '2') { check2++; }
                    if (a == '3') { check3++; }
                }
                for (int i = 0; i < textBox3.Text.Length; i += 2)
                {
                    char a = textBox3.Text[i];
                    if (a == '1') { check1++; }
                    if (a == '2') { check2++; }
                    if (a == '3') { check3++; }
                }
                for (int i = 0; i < textBox4.Text.Length; i += 2)
                {
                    char a = textBox4.Text[i];
                    if (a == '1') { check1++; }
                    if (a == '2') { check2++; }
                    if (a == '3') { check3++; }
                }
                for (int i = 0; i < textBox5.Text.Length; i += 2)
                {
                    char a = textBox5.Text[i];
                    if (a == '1') { check1++; }
                    if (a == '2') { check2++; }
                    if (a == '3') { check3++; }
                }
                if (check1 == 3 && check2 == 3 && check3 == 3)
                {
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    button1.Visible = false;

                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    label11.Visible = true;
                    label12.Visible = true;
                    textBox10.Visible = true;
                    textBox10.Text = "...";
                    button2.Visible = true;
                    button2.Enabled = true;
                    button3.Visible = true;
                    button3.Enabled = true;
                    button4.Visible = true;
                    button4.Enabled = true;
                    button5.Visible = true;
                    button5.Enabled = true;
                    button6.Visible = true;
                    button2.Text = "選取";
                    button3.Text = "選取";
                    button4.Text = "選取";
                    button5.Text = "選取";
                    check = 0;

                    string[] input = new string[] { textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text };
                    Game start = new Game(input);
                    label9.Text = start.output(0);
                    label10.Text = start.output(1);
                    label11.Text = start.output(2);
                    label12.Text = start.output(3);

                    if (start.cantake(0) == false)
                    {
                        button2.Enabled = false;
                    }
                    if (start.cantake(1) == false)
                    {
                        button3.Enabled = false;
                    }
                    if (start.cantake(2) == false)
                    {
                        button4.Enabled = false;
                    }
                    if (start.cantake(3) == false)
                    {
                        button5.Enabled = false;
                    }
                }
                else
                {
                    textBox1.Text = "測資錯誤";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "1 1 2";
            textBox3.Text = "2 2";
            textBox4.Text = "";
            textBox5.Text = "3 3 3 1";
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            textBox10.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            button1.Visible = true;
            textBox2.Text = "1 1 2";
            textBox3.Text = "2 2";
            textBox4.Text = "";
            textBox5.Text = "3 3 3 1";

            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            textBox10.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str_9 = new string(label9.Text.Reverse().ToArray());
            string str_10 = new string(label10.Text.Reverse().ToArray());
            string str_11 = new string(label11.Text.Reverse().ToArray());
            string str_12 = new string(label12.Text.Reverse().ToArray());
            string[] input = new string[] { str_9, str_10, str_11, str_12 };
            Game start = new Game(input);
            if (check == 0)
            {
                check=(check+1)%2;
                choose = 0;
                button2.Text = "放置";
                button3.Text = "放置";
                button4.Text = "放置";
                button5.Text = "放置";
                textBox10.Text = "你選了堆疊1";

                if (start.canplace(0) == false)
                {
                    button2.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                }
                if (start.canplace(1) == false)
                {
                    button3.Enabled = false;
                }
                else
                {
                    button3.Enabled = true;
                }
                if (start.canplace(2) == false)
                {
                    button4.Enabled = false;
                }
                else
                {
                    button4.Enabled = true;
                }
                if (start.canplace(3) == false)
                {
                    button5.Enabled = false;
                }
                else
                {
                    button5.Enabled = true;
                }
            }
            else
            {
                check = (check + 1) % 2;
                button2.Text = "選取";
                button3.Text = "選取";
                button4.Text = "選取";
                button5.Text = "選取";
                textBox10.Text = "...";
                start.move(choose, 0);
                label9.Text = start.output(0);
                label10.Text = start.output(1);
                label11.Text = start.output(2);
                label12.Text = start.output(3);
                if (start.win() == true)
                {
                    button2.Enabled = false;
                    button2.Text = "贏";
                    button3.Enabled = false;
                    button3.Text = "贏";
                    button4.Enabled = false;
                    button4.Text = "贏";
                    button5.Enabled = false;
                    button5.Text = "贏";
                    textBox10.Text = "你贏了";
                }
                else
                {
                    if (start.cantake(0) == true)
                    {
                        button2.Enabled = true;
                    }
                    else
                    {
                        button2.Enabled = false;
                    }
                    if (start.cantake(1) == true)
                    {
                        button3.Enabled = true;
                    }
                    else
                    {
                        button3.Enabled = false;
                    }
                    if (start.cantake(2) == true)
                    {
                        button4.Enabled = true;
                    }
                    else
                    {
                        button4.Enabled = false;
                    }
                    if (start.cantake(3) == true)
                    {
                        button5.Enabled = true;
                    }
                    else
                    {
                        button5.Enabled = false;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str_9 = new string(label9.Text.Reverse().ToArray());
            string str_10 = new string(label10.Text.Reverse().ToArray());
            string str_11 = new string(label11.Text.Reverse().ToArray());
            string str_12 = new string(label12.Text.Reverse().ToArray());
            string[] input = new string[] { str_9, str_10, str_11, str_12 };
            Game start = new Game(input);
            if (check == 0)
            {
                check = (check + 1) % 2;
                choose = 1;
                button2.Text = "放置";
                button3.Text = "放置";
                button4.Text = "放置";
                button5.Text = "放置";
                textBox10.Text = "你選了堆疊2";

                if (start.canplace(0) == false)
                {
                    button2.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                }
                if (start.canplace(1) == false)
                {
                    button3.Enabled = false;
                }
                else
                {
                    button3.Enabled = true;
                }
                if (start.canplace(2) == false)
                {
                    button4.Enabled = false;
                }
                else
                {
                    button4.Enabled = true;
                }
                if (start.canplace(3) == false)
                {
                    button5.Enabled = false;
                }
                else
                {
                    button5.Enabled = true;
                }
            }
            else
            {
                check = (check + 1) % 2;
                button2.Text = "選取";
                button3.Text = "選取";
                button4.Text = "選取";
                button5.Text = "選取";
                textBox10.Text = "...";
                start.move(choose, 1);
                label9.Text = start.output(0);
                label10.Text = start.output(1);
                label11.Text = start.output(2);
                label12.Text = start.output(3);
                if (start.win() == true)
                {
                    button2.Enabled = false;
                    button2.Text = "贏";
                    button3.Enabled = false;
                    button3.Text = "贏";
                    button4.Enabled = false;
                    button4.Text = "贏";
                    button5.Enabled = false;
                    button5.Text = "贏";
                    textBox10.Text = "你贏了";
                }
                else
                {
                    if (start.cantake(0) == true)
                    {
                        button2.Enabled = true;
                    }
                    else
                    {
                        button2.Enabled = false;
                    }
                    if (start.cantake(1) == true)
                    {
                        button3.Enabled = true;
                    }
                    else
                    {
                        button3.Enabled = false;
                    }
                    if (start.cantake(2) == true)
                    {
                        button4.Enabled = true;
                    }
                    else
                    {
                        button4.Enabled = false;
                    }
                    if (start.cantake(3) == true)
                    {
                        button5.Enabled = true;
                    }
                    else
                    {
                        button5.Enabled = false;
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str_9 = new string(label9.Text.Reverse().ToArray());
            string str_10 = new string(label10.Text.Reverse().ToArray());
            string str_11 = new string(label11.Text.Reverse().ToArray());
            string str_12 = new string(label12.Text.Reverse().ToArray());
            string[] input = new string[] { str_9, str_10, str_11, str_12 };
            Game start = new Game(input);
            if (check == 0)
            {
                check = (check + 1) % 2;
                choose = 2;
                button2.Text = "放置";
                button3.Text = "放置";
                button4.Text = "放置";
                button5.Text = "放置";
                textBox10.Text = "你選了堆疊3";

                if (start.canplace(0) == false)
                {
                    button2.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                }
                if (start.canplace(1) == false)
                {
                    button3.Enabled = false;
                }
                else
                {
                    button3.Enabled = true;
                }
                if (start.canplace(2) == false)
                {
                    button4.Enabled = false;
                }
                else
                {
                    button4.Enabled = true;
                }
                if (start.canplace(3) == false)
                {
                    button5.Enabled = false;
                }
                else
                {
                    button5.Enabled = true;
                }
            }
            else
            {
                check = (check + 1) % 2;
                button2.Text = "選取";
                button3.Text = "選取";
                button4.Text = "選取";
                button5.Text = "選取";
                textBox10.Text = "...";
                start.move(choose, 2);
                label9.Text = start.output(0);
                label10.Text = start.output(1);
                label11.Text = start.output(2);
                label12.Text = start.output(3);
                if (start.win() == true)
                {
                    button2.Enabled = false;
                    button2.Text = "贏";
                    button3.Enabled = false;
                    button3.Text = "贏";
                    button4.Enabled = false;
                    button4.Text = "贏";
                    button5.Enabled = false;
                    button5.Text = "贏";
                    textBox10.Text = "你贏了";
                }
                else
                {
                    if (start.cantake(0) == true)
                    {
                        button2.Enabled = true;
                    }
                    else
                    {
                        button2.Enabled = false;
                    }
                    if (start.cantake(1) == true)
                    {
                        button3.Enabled = true;
                    }
                    else
                    {
                        button3.Enabled = false;
                    }
                    if (start.cantake(2) == true)
                    {
                        button4.Enabled = true;
                    }
                    else
                    {
                        button4.Enabled = false;
                    }
                    if (start.cantake(3) == true)
                    {
                        button5.Enabled = true;
                    }
                    else
                    {
                        button5.Enabled = false;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str_9 = new string(label9.Text.Reverse().ToArray());
            string str_10 = new string(label10.Text.Reverse().ToArray());
            string str_11 = new string(label11.Text.Reverse().ToArray());
            string str_12 = new string(label12.Text.Reverse().ToArray());
            string[] input = new string[] { str_9, str_10, str_11, str_12 };
            Game start = new Game(input);
            if (check == 0)
            {
                check = (check + 1) % 2;
                choose = 3;
                button2.Text = "放置";
                button3.Text = "放置";
                button4.Text = "放置";
                button5.Text = "放置";
                textBox10.Text = "你選了堆疊4";

                if (start.canplace(0) == false)
                {
                    button2.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                }
                if (start.canplace(1) == false)
                {
                    button3.Enabled = false;
                }
                else
                {
                    button3.Enabled = true;
                }
                if (start.canplace(2) == false)
                {
                    button4.Enabled = false;
                }
                else
                {
                    button4.Enabled = true;
                }
                if (start.canplace(3) == false)
                {
                    button5.Enabled = false;
                }
                else
                {
                    button5.Enabled = true;
                }
            }
            else
            {
                check = (check + 1) % 2;
                button2.Text = "選取";
                button3.Text = "選取";
                button4.Text = "選取";
                button5.Text = "選取";
                textBox10.Text = "...";
                start.move(choose, 3);
                label9.Text = start.output(0);
                label10.Text = start.output(1);
                label11.Text = start.output(2);
                label12.Text = start.output(3);
                if (start.win() == true)
                {
                    button2.Enabled = false;
                    button2.Text = "贏";
                    button3.Enabled = false;
                    button3.Text = "贏";
                    button4.Enabled = false;
                    button4.Text = "贏";
                    button5.Enabled = false;
                    button5.Text = "贏";
                    textBox10.Text = "你贏了";
                }
                else
                {
                    if (start.cantake(0) == true)
                    {
                        button2.Enabled = true;
                    }
                    else
                    {
                        button2.Enabled = false;
                    }
                    if (start.cantake(1) == true)
                    {
                        button3.Enabled = true;
                    }
                    else
                    {
                        button3.Enabled = false;
                    }
                    if (start.cantake(2) == true)
                    {
                        button4.Enabled = true;
                    }
                    else
                    {
                        button4.Enabled = false;
                    }
                    if (start.cantake(3) == true)
                    {
                        button5.Enabled = true;
                    }
                    else
                    {
                        button5.Enabled = false;
                    }
                }
            }
        }
    }
}
