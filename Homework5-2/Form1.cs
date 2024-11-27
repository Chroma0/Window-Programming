using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework5_2
{
    public partial class Form1 : Form
    {
        Button[] b = new Button[42];
        Chess_warrior[] warriors = new Chess_warrior[2];
        Chess_caster[] casters = new Chess_caster[2];
        Chess_ranger[] rangers = new Chess_ranger[2];
        int P1_time = 10;
        int P2_time = 10;
        int chess = 0,move=0;
        int P1_chess = 3, P2_chess = 3, turn = 0; //紀錄雙方剩餘棋子及回合
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button5.Enabled = false;
            button6.Visible = false;
            button6.Enabled = false;
            button7.Visible = false;
            button7.Enabled = false;
            timer1.Enabled = false;
            timer1.Interval = 1000;
            timer2.Enabled = false;
            timer2.Interval = 1000;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            //初始化物件
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            for(int i = 0; i < 42; i++)
            {
                b[i] = new Button();
                b[i].SetBounds(250 + 50 * (i % 6), 100 + 50 * (i / 6), 50, 50);
                if((i % 6) >= 3)
                {
                    b[i].Enabled = false;
                }
                b[i].Text = "";
                b[i].Click += new EventHandler(b1_Click);
                Controls.Add(b[i]);
            }
            //準備階段
            timer1.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = P1_time.ToString();
            P1_time--;
            if (button2.Enabled == false && button3.Enabled==false && button4.Enabled == false)
            {
                P1_time = 0;
            }
            if (P1_time == 0)
            {
                timer1.Enabled = false;
                int positon = 0;
                if (button2.Enabled == true)
                {
                    button2.Text = "戰士:0顆";
                    button2.Enabled = false;
                    b[positon].Text = "戰士";
                    b[positon].BackColor = Color.LightBlue;
                    positon += 6;
                }
                if (button3.Enabled == true)
                {
                    button3.Text = "法師:0顆";
                    button3.Enabled = false;
                    b[positon].Text = "法師";
                    b[positon].BackColor = Color.LightBlue;
                    positon += 6;
                }
                if (button4.Enabled == true)
                {
                    button4.Text = "遊俠:0顆";
                    button4.Enabled = false;
                    b[positon].Text = "遊俠";
                    b[positon].BackColor = Color.LightBlue;
                    positon += 6;
                }
                for(int i = 0; i < 42; i++)
                {
                    if ((i % 6) < 3)
                    {
                        b[i].Enabled = false;
                    }
                    else
                    {
                        b[i].Enabled = true;
                    }
                }
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                label3.Text = "P1";
                timer2.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = P2_time.ToString();
            P2_time--;
            if (button5.Enabled == false && button6.Enabled == false && button7.Enabled == false)
            {
                P2_time = 0;
            }
            if (P2_time == 0)
            {
                timer2.Enabled = false;
                label2.Text = "";
                int positon = 5;
                if (button5.Enabled == true)
                {
                    button5.Text = "戰士:0顆";
                    button5.Enabled = false;
                    b[positon].Text = "戰士";
                    b[positon].BackColor = Color.LightPink;
                    positon += 6;
                }
                if (button6.Enabled == true)
                {
                    button6.Text = "法師:0顆";
                    button6.Enabled = false;
                    b[positon].Text = "法師";
                    b[positon].BackColor = Color.LightPink;
                    positon += 6;
                }
                if (button7.Enabled == true)
                {
                    button7.Text = "遊俠:0顆";
                    button7.Enabled = false;
                    b[positon].Text = "遊俠";
                    b[positon].BackColor = Color.LightPink;
                    positon += 6;
                }
                for (int i = 0; i < 42; i++)
                {
                    if ((i % 6) < 3)
                    {
                        b[i].Enabled = true;
                    }
                }
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                label4.Text = "P2";
                button8.Visible = true;
                button9.Visible = true;
                button10.Visible = true;
                button11.Visible = true;
                button12.Visible = true;
                button13.Visible = true;
                button14.Visible = true;
                button15.Visible = true;
                button16.Visible = true;
                button16.Enabled = false;
                button17.Visible = true;
                button17.Enabled = false;
                label5.Visible = true;
                label6.Visible = true;
                game();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "P1" + "\r\n" + "戰士";
            chess = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "P1" + "\r\n" + "法師";
            chess = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "P1" + "\r\n" + "遊俠";
            chess = 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label4.Text = "P2" + "\r\n" + "戰士";
            chess = 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label4.Text = "P2" + "\r\n" + "法師";
            chess = 2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label4.Text = "P2" + "\r\n" + "遊俠";
            chess = 3;
        }

        public void b1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int index= ((int)btn.TabIndex) - 23;
            if (chess == 0 || chess == 1)
            {
                if (button2.Enabled == true || button5.Enabled == true)
                {
                    if (index % 6 < 3)
                    {
                        label3.Text = "P1" + "\r\n" + "戰士";
                        b[index].Text = "戰士";
                        b[index].BackColor = Color.LightBlue;
                        button2.Text = "戰士:0顆";
                        button2.Enabled = false;
                    }
                    else
                    {
                        label4.Text = "P2" + "\r\n" + "戰士";
                        b[index].Text = "戰士";
                        b[index].BackColor = Color.LightPink;
                        button5.Text = "戰士:0顆";
                        button5.Enabled = false;
                    }
                }
            }
            else if (chess == 2)
            {
                if (button3.Enabled == true || button6.Enabled == true)
                {
                    if (index % 6 < 3)
                    {
                        label3.Text = "P1" + "\r\n" + "法師";
                        b[index].Text = "法師";
                        b[index].BackColor = Color.LightBlue;
                        button3.Text = "法師:0顆";
                        button3.Enabled = false;
                    }
                    else
                    {
                        label4.Text = "P2" + "\r\n" + "法師";
                        b[index].Text = "法師";
                        b[index].BackColor = Color.LightPink;
                        button6.Text = "法師:0顆";
                        button6.Enabled = false;
                    }
                }
            }
            else if (chess == 3)
            {
                if (button4.Enabled == true || button7.Enabled == true)
                {
                    if (index % 6 < 3)
                    {
                        label3.Text = "P1" + "\r\n" + "遊俠";
                        b[index].Text = "遊俠";
                        b[index].BackColor = Color.LightBlue;
                        button4.Text = "遊俠:0顆";
                        button4.Enabled = false;
                    }
                    else
                    {
                        label4.Text = "P2" + "\r\n" + "遊俠";
                        b[index].Text = "遊俠";
                        b[index].BackColor = Color.LightPink;
                        button7.Text = "遊俠:0顆";
                        button7.Enabled = false;
                    }
                }
            }
        }

        public void b2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int index = ((int)btn.TabIndex) - 23;
            if (b[index].Text != "")
            {
                switch (turn)
                {
                    case 0:
                        int _position = 0;
                        int enemy = 0;
                        for (int i = 0; i < 42; i++)
                        {
                            if ((b[i].Text == "戰士") && (b[i].BackColor == Color.LightBlue))
                            {
                                _position = i;
                                break;
                            }
                        }
                        if ((b[index].Text == "戰士") && (b[index].BackColor == Color.LightPink)) { enemy = 1; }
                        else if ((b[index].Text == "法師") && (b[index].BackColor == Color.LightPink)) { enemy = 2; }
                        else if ((b[index].Text == "遊俠") && (b[index].BackColor == Color.LightPink)) { enemy = 3; }
                        if (enemy == 1)
                        {
                            label4.Text = "P2\r\n戰士";
                            label6.Text = "HP:" + warriors[1].hp.ToString() + "\r\n" +
                                     "MP:" + warriors[1].mp.ToString() + "\r\n" +
                                     "ATK:" + warriors[1].atk.ToString() + "\r\n" +
                                     "ATK Range:" + warriors[1].atkRange.ToString() + "\r\n" +
                                     "MOVE Range:" + warriors[1].moveRange.ToString() + "\r\n";
                            if (move == 1)
                            {
                                if (_position > index)
                                {
                                    if (((_position - index) <= warriors[0].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= warriors[0].atkRange)))
                                    {
                                        warriors[1].hp -= warriors[0].atk;
                                        label6.Text = "HP:" + warriors[1].hp.ToString() + "\r\n" +
                                                      "MP:" + warriors[1].mp.ToString() + "\r\n" +
                                                      "ATK:" + warriors[1].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + warriors[1].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + warriors[1].moveRange.ToString() + "\r\n";
                                        if (warriors[1].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button8.Enabled = false;
                                        button9.Enabled = false;
                                        button10.Enabled = false;
                                        button11.Enabled = false;
                                        button16.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                                else
                                {
                                    if (((index - _position) <= warriors[0].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= warriors[0].atkRange)))
                                    {
                                        warriors[1].hp -= warriors[0].atk;
                                        label6.Text = "HP:" + warriors[1].hp.ToString() + "\r\n" +
                                                      "MP:" + warriors[1].mp.ToString() + "\r\n" +
                                                      "ATK:" + warriors[1].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + warriors[1].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + warriors[1].moveRange.ToString() + "\r\n";
                                        if (warriors[1].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button8.Enabled = false;
                                        button9.Enabled = false;
                                        button10.Enabled = false;
                                        button11.Enabled = false;
                                        button16.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                            }
                            else if (move == 3)
                            {
                                if (warriors[0].mp >= 10)
                                {
                                    if (_position > index)
                                    {
                                        if (((_position - index) <= warriors[0].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= warriors[0].atkRange)))
                                        {
                                            warriors[0].Skill();
                                            warriors[0].mp -= 10;
                                            warriors[1].hp -= warriors[0].atk;
                                            label6.Text = "HP:" + warriors[1].hp.ToString() + "\r\n" +
                                                          "MP:" + warriors[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + warriors[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + warriors[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + warriors[1].moveRange.ToString() + "\r\n";
                                            label5.Text = "HP:" + warriors[0].hp.ToString() + "\r\n" +
                                                          "MP:" + warriors[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + warriors[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + warriors[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + warriors[0].moveRange.ToString() + "\r\n";
                                            if (warriors[1].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button8.Enabled = false;
                                            button9.Enabled = false;
                                            button10.Enabled = false;
                                            button11.Enabled = false;
                                            button16.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            move = 0;
                                        }
                                    }
                                    else
                                    {
                                        if (((index - _position) <= warriors[0].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= warriors[0].atkRange)))
                                        {
                                            warriors[0].Skill();
                                            warriors[0].mp -= 10;
                                            warriors[1].hp -= warriors[0].atk;
                                            label6.Text = "HP:" + warriors[1].hp.ToString() + "\r\n" +
                                                          "MP:" + warriors[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + warriors[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + warriors[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + warriors[1].moveRange.ToString() + "\r\n";
                                            label5.Text = "HP:" + warriors[0].hp.ToString() + "\r\n" +
                                                          "MP:" + warriors[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + warriors[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + warriors[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + warriors[0].moveRange.ToString() + "\r\n";
                                            if (warriors[1].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button8.Enabled = false;
                                            button9.Enabled = false;
                                            button10.Enabled = false;
                                            button11.Enabled = false;
                                            button16.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            move = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    move = 0;
                                }
                            }
                        }
                        else if (enemy == 2)
                        {
                            label4.Text = "P2\r\n法師";
                            label6.Text = "HP:" + casters[1].hp.ToString() + "\r\n" +
                                     "MP:" + casters[1].mp.ToString() + "\r\n" +
                                     "ATK:" + casters[1].atk.ToString() + "\r\n" +
                                     "ATK Range:" + casters[1].atkRange.ToString() + "\r\n" +
                                     "MOVE Range:" + casters[1].moveRange.ToString() + "\r\n";
                            if (move == 1)
                            {
                                if (_position > index)
                                {
                                    if (((_position - index) <= warriors[0].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= warriors[0].atkRange)))
                                    {
                                        casters[1].hp -= warriors[0].atk;
                                        label6.Text = "HP:" + casters[1].hp.ToString() + "\r\n" +
                                                      "MP:" + casters[1].mp.ToString() + "\r\n" +
                                                      "ATK:" + casters[1].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + casters[1].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + casters[1].moveRange.ToString() + "\r\n";
                                        if (casters[1].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button8.Enabled = false;
                                        button9.Enabled = false;
                                        button10.Enabled = false;
                                        button11.Enabled = false;
                                        button16.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                                else
                                {
                                    if (((index - _position) <= warriors[0].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= warriors[0].atkRange)))
                                    {
                                        casters[1].hp -= warriors[0].atk;
                                        label6.Text = "HP:" + casters[1].hp.ToString() + "\r\n" +
                                                      "MP:" + casters[1].mp.ToString() + "\r\n" +
                                                      "ATK:" + casters[1].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + casters[1].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + casters[1].moveRange.ToString() + "\r\n";
                                        if (casters[1].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button8.Enabled = false;
                                        button9.Enabled = false;
                                        button10.Enabled = false;
                                        button11.Enabled = false;
                                        button16.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                            }
                            else if (move == 3)
                            {
                                if (warriors[0].mp >= 10)
                                {
                                    if (_position > index)
                                    {
                                        if (((_position - index) <= warriors[0].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= warriors[0].atkRange)))
                                        {
                                            warriors[0].Skill();
                                            warriors[0].mp -= 10;
                                            casters[1].hp -= warriors[0].atk;
                                            label6.Text = "HP:" + casters[1].hp.ToString() + "\r\n" +
                                                          "MP:" + casters[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + casters[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + casters[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + casters[1].moveRange.ToString() + "\r\n";
                                            label5.Text = "HP:" + warriors[0].hp.ToString() + "\r\n" +
                                                          "MP:" + warriors[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + warriors[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + warriors[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + warriors[0].moveRange.ToString() + "\r\n";
                                            if (casters[1].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button8.Enabled = false;
                                            button9.Enabled = false;
                                            button10.Enabled = false;
                                            button11.Enabled = false;
                                            button16.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            move = 0;
                                        }
                                    }
                                    else
                                    {
                                        if (((index - _position) <= warriors[0].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= warriors[0].atkRange)))
                                        {
                                            warriors[0].Skill();
                                            warriors[0].mp -= 10;
                                            casters[1].hp -= warriors[0].atk;
                                            label6.Text = "HP:" + casters[1].hp.ToString() + "\r\n" +
                                                          "MP:" + casters[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + casters[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + casters[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + casters[1].moveRange.ToString() + "\r\n";
                                            label5.Text = "HP:" + warriors[0].hp.ToString() + "\r\n" +
                                                          "MP:" + warriors[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + warriors[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + warriors[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + warriors[0].moveRange.ToString() + "\r\n";
                                            if (casters[1].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button8.Enabled = false;
                                            button9.Enabled = false;
                                            button10.Enabled = false;
                                            button11.Enabled = false;
                                            button16.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            move = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    move = 0;
                                }
                            }
                        }
                        else if (enemy == 3)
                        {
                            label4.Text = "P2\r\n遊俠";
                            label6.Text = "HP:" + rangers[1].hp.ToString() + "\r\n" +
                                     "MP:" + rangers[1].mp.ToString() + "\r\n" +
                                     "ATK:" + rangers[1].atk.ToString() + "\r\n" +
                                     "ATK Range:" + rangers[1].atkRange.ToString() + "\r\n" +
                                     "MOVE Range:" + rangers[1].moveRange.ToString() + "\r\n";
                            if (move == 1)
                            {
                                if (_position > index)
                                {
                                    if (((_position - index) <= warriors[0].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= warriors[0].atkRange)))
                                    {
                                        rangers[1].hp -= warriors[0].atk;
                                        label6.Text = "HP:" + rangers[1].hp.ToString() + "\r\n" +
                                                      "MP:" + rangers[1].mp.ToString() + "\r\n" +
                                                      "ATK:" + rangers[1].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + rangers[1].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + rangers[1].moveRange.ToString() + "\r\n";
                                        if (rangers[1].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button8.Enabled = false;
                                        button9.Enabled = false;
                                        button10.Enabled = false;
                                        button11.Enabled = false;
                                        button16.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                                else
                                {
                                    if (((index - _position) <= warriors[0].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= warriors[0].atkRange)))
                                    {
                                        rangers[1].hp -= warriors[0].atk;
                                        label6.Text = "HP:" + rangers[1].hp.ToString() + "\r\n" +
                                                      "MP:" + rangers[1].mp.ToString() + "\r\n" +
                                                      "ATK:" + rangers[1].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + rangers[1].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + rangers[1].moveRange.ToString() + "\r\n";
                                        if (rangers[1].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button8.Enabled = false;
                                        button9.Enabled = false;
                                        button10.Enabled = false;
                                        button11.Enabled = false;
                                        button16.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                            }
                            else if (move == 3)
                            {
                                if (warriors[0].mp >= 10)
                                {
                                    if (_position > index)
                                    {
                                        if (((_position - index) <= warriors[0].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= warriors[0].atkRange)))
                                        {
                                            warriors[0].Skill();
                                            warriors[0].mp -= 10;
                                            rangers[1].hp -= warriors[0].atk;
                                            label6.Text = "HP:" + rangers[1].hp.ToString() + "\r\n" +
                                                          "MP:" + rangers[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + rangers[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + rangers[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + rangers[1].moveRange.ToString() + "\r\n";
                                            label5.Text = "HP:" + warriors[0].hp.ToString() + "\r\n" +
                                                          "MP:" + warriors[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + warriors[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + warriors[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + warriors[0].moveRange.ToString() + "\r\n";
                                            if (rangers[1].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button8.Enabled = false;
                                            button9.Enabled = false;
                                            button10.Enabled = false;
                                            button11.Enabled = false;
                                            button16.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            move = 0;
                                        }
                                    }
                                    else
                                    {
                                        if (((index - _position) <= warriors[0].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= warriors[0].atkRange)))
                                        {
                                            warriors[0].Skill();
                                            warriors[0].mp -= 10;
                                            rangers[1].hp -= warriors[0].atk;
                                            label6.Text = "HP:" + rangers[1].hp.ToString() + "\r\n" +
                                                          "MP:" + rangers[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + rangers[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + rangers[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + rangers[1].moveRange.ToString() + "\r\n";
                                            label5.Text = "HP:" + warriors[0].hp.ToString() + "\r\n" +
                                                          "MP:" + warriors[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + warriors[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + warriors[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + warriors[0].moveRange.ToString() + "\r\n";
                                            if (rangers[1].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button8.Enabled = false;
                                            button9.Enabled = false;
                                            button10.Enabled = false;
                                            button11.Enabled = false;
                                            button16.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            move = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    move = 0;
                                }
                            }
                        }
                        break;
                    case 1:
                        _position = 0;
                        enemy = 0;
                        for (int i = 0; i < 42; i++)
                        {
                            if ((b[i].Text == "法師") && (b[i].BackColor == Color.LightBlue))
                            {
                                _position = i;
                                break;
                            }
                        }
                        if ((b[index].Text == "戰士") && (b[index].BackColor == Color.LightPink)) { enemy = 1; }
                        else if ((b[index].Text == "法師") && (b[index].BackColor == Color.LightPink)) { enemy = 2; }
                        else if ((b[index].Text == "遊俠") && (b[index].BackColor == Color.LightPink)) { enemy = 3; }
                        if (enemy == 1)
                        {
                            label4.Text = "P2\r\n戰士";
                            label6.Text = "HP:" + warriors[1].hp.ToString() + "\r\n" +
                                     "MP:" + warriors[1].mp.ToString() + "\r\n" +
                                     "ATK:" + warriors[1].atk.ToString() + "\r\n" +
                                     "ATK Range:" + warriors[1].atkRange.ToString() + "\r\n" +
                                     "MOVE Range:" + warriors[1].moveRange.ToString() + "\r\n";
                            if (move == 1)
                            {
                                if (_position > index)
                                {
                                    if (((_position - index) <= casters[0].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= casters[0].atkRange)))
                                    {
                                        warriors[1].hp -= casters[0].atk;
                                        label6.Text = "HP:" + warriors[1].hp.ToString() + "\r\n" +
                                                      "MP:" + warriors[1].mp.ToString() + "\r\n" +
                                                      "ATK:" + warriors[1].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + warriors[1].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + warriors[1].moveRange.ToString() + "\r\n";
                                        if (warriors[1].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button8.Enabled = false;
                                        button9.Enabled = false;
                                        button10.Enabled = false;
                                        button11.Enabled = false;
                                        button16.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                                else
                                {
                                    if (((index - _position) <= casters[0].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= casters[0].atkRange)))
                                    {
                                        warriors[1].hp -= casters[0].atk;
                                        label6.Text = "HP:" + warriors[1].hp.ToString() + "\r\n" +
                                                      "MP:" + warriors[1].mp.ToString() + "\r\n" +
                                                      "ATK:" + warriors[1].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + warriors[1].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + warriors[1].moveRange.ToString() + "\r\n";
                                        if (warriors[1].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button8.Enabled = false;
                                        button9.Enabled = false;
                                        button10.Enabled = false;
                                        button11.Enabled = false;
                                        button16.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                            }
                            else if (move == 3)
                            {
                                if (casters[0].mp >= 10)
                                {
                                    if (_position > index)
                                    {
                                        if (((_position - index) <= casters[0].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= casters[0].atkRange)))
                                        {
                                            casters[0].Skill();
                                            casters[0].mp -= 10;
                                            warriors[1].hp -= casters[0].atk;
                                            casters[0].atk /= 2;
                                            label6.Text = "HP:" + warriors[1].hp.ToString() + "\r\n" +
                                                          "MP:" + warriors[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + warriors[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + warriors[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + warriors[1].moveRange.ToString() + "\r\n";
                                            label5.Text = "HP:" + casters[0].hp.ToString() + "\r\n" +
                                                          "MP:" + casters[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + casters[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + casters[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + casters[0].moveRange.ToString() + "\r\n";
                                            if (warriors[1].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button8.Enabled = false;
                                            button9.Enabled = false;
                                            button10.Enabled = false;
                                            button11.Enabled = false;
                                            button16.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            move = 0;
                                        }
                                    }
                                    else
                                    {
                                        if (((index - _position) <= casters[0].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= casters[0].atkRange)))
                                        {
                                            casters[0].Skill();
                                            casters[0].mp -= 10;
                                            warriors[1].hp -= casters[0].atk;
                                            casters[0].atk /= 2;
                                            label6.Text = "HP:" + warriors[1].hp.ToString() + "\r\n" +
                                                          "MP:" + warriors[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + warriors[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + warriors[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + warriors[1].moveRange.ToString() + "\r\n";
                                            label5.Text = "HP:" + casters[0].hp.ToString() + "\r\n" +
                                                          "MP:" + casters[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + casters[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + casters[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + casters[0].moveRange.ToString() + "\r\n";
                                            if (warriors[1].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button8.Enabled = false;
                                            button9.Enabled = false;
                                            button10.Enabled = false;
                                            button11.Enabled = false;
                                            button16.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            move = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    move = 0;
                                }
                            }
                        }
                        else if (enemy == 2)
                        {
                            label4.Text = "P2\r\n法師";
                            label6.Text = "HP:" + casters[1].hp.ToString() + "\r\n" +
                                     "MP:" + casters[1].mp.ToString() + "\r\n" +
                                     "ATK:" + casters[1].atk.ToString() + "\r\n" +
                                     "ATK Range:" + casters[1].atkRange.ToString() + "\r\n" +
                                     "MOVE Range:" + casters[1].moveRange.ToString() + "\r\n";
                            if (move == 1)
                            {
                                if (_position > index)
                                {
                                    if (((_position - index) <= casters[0].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= casters[0].atkRange)))
                                    {
                                        casters[1].hp -= casters[0].atk;
                                        label6.Text = "HP:" + casters[1].hp.ToString() + "\r\n" +
                                                      "MP:" + casters[1].mp.ToString() + "\r\n" +
                                                      "ATK:" + casters[1].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + casters[1].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + casters[1].moveRange.ToString() + "\r\n";
                                        if (casters[1].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button8.Enabled = false;
                                        button9.Enabled = false;
                                        button10.Enabled = false;
                                        button11.Enabled = false;
                                        button16.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                                else
                                {
                                    if (((index - _position) <= casters[0].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= casters[0].atkRange)))
                                    {
                                        casters[1].hp -= casters[0].atk;
                                        label6.Text = "HP:" + casters[1].hp.ToString() + "\r\n" +
                                                      "MP:" + casters[1].mp.ToString() + "\r\n" +
                                                      "ATK:" + casters[1].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + casters[1].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + casters[1].moveRange.ToString() + "\r\n";
                                        if (casters[1].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button8.Enabled = false;
                                        button9.Enabled = false;
                                        button10.Enabled = false;
                                        button11.Enabled = false;
                                        button16.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                            }
                            else if (move == 3)
                            {
                                if (casters[0].mp >= 10)
                                {
                                    if (_position > index)
                                    {
                                        if (((_position - index) <= casters[0].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= casters[0].atkRange)))
                                        {
                                            casters[0].Skill();
                                            casters[0].mp -= 10;
                                            casters[1].hp -= casters[0].atk;
                                            casters[0].atk /= 2;
                                            label6.Text = "HP:" + casters[1].hp.ToString() + "\r\n" +
                                                          "MP:" + casters[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + casters[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + casters[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + casters[1].moveRange.ToString() + "\r\n";
                                            label5.Text = "HP:" + casters[0].hp.ToString() + "\r\n" +
                                                          "MP:" + casters[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + casters[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + casters[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + casters[0].moveRange.ToString() + "\r\n";
                                            if (casters[1].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button8.Enabled = false;
                                            button9.Enabled = false;
                                            button10.Enabled = false;
                                            button11.Enabled = false;
                                            button16.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            move = 0;
                                        }
                                    }
                                    else
                                    {
                                        if (((index - _position) <= casters[0].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= casters[0].atkRange)))
                                        {
                                            casters[0].Skill();
                                            casters[0].mp -= 10;
                                            casters[1].hp -= casters[0].atk;
                                            casters[0].atk /= 2;
                                            label6.Text = "HP:" + casters[1].hp.ToString() + "\r\n" +
                                                          "MP:" + casters[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + casters[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + casters[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + casters[1].moveRange.ToString() + "\r\n";
                                            label5.Text = "HP:" + casters[0].hp.ToString() + "\r\n" +
                                                          "MP:" + casters[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + casters[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + casters[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + casters[0].moveRange.ToString() + "\r\n";
                                            if (casters[1].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button8.Enabled = false;
                                            button9.Enabled = false;
                                            button10.Enabled = false;
                                            button11.Enabled = false;
                                            button16.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            move = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    move = 0;
                                }
                            }
                        }
                        else if (enemy == 3)
                        {
                            label4.Text = "P2\r\n遊俠";
                            label6.Text = "HP:" + rangers[1].hp.ToString() + "\r\n" +
                                     "MP:" + rangers[1].mp.ToString() + "\r\n" +
                                     "ATK:" + rangers[1].atk.ToString() + "\r\n" +
                                     "ATK Range:" + rangers[1].atkRange.ToString() + "\r\n" +
                                     "MOVE Range:" + rangers[1].moveRange.ToString() + "\r\n";
                            if (move == 1)
                            {
                                if (_position > index)
                                {
                                    if (((_position - index) <= casters[0].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= casters[0].atkRange)))
                                    {
                                        rangers[1].hp -= casters[0].atk;
                                        label6.Text = "HP:" + rangers[1].hp.ToString() + "\r\n" +
                                                      "MP:" + rangers[1].mp.ToString() + "\r\n" +
                                                      "ATK:" + rangers[1].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + rangers[1].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + rangers[1].moveRange.ToString() + "\r\n";
                                        if (rangers[1].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button8.Enabled = false;
                                        button9.Enabled = false;
                                        button10.Enabled = false;
                                        button11.Enabled = false;
                                        button16.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                                else
                                {
                                    if (((index - _position) <= casters[0].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= casters[0].atkRange)))
                                    {
                                        rangers[1].hp -= casters[0].atk;
                                        label6.Text = "HP:" + rangers[1].hp.ToString() + "\r\n" +
                                                      "MP:" + rangers[1].mp.ToString() + "\r\n" +
                                                      "ATK:" + rangers[1].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + rangers[1].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + rangers[1].moveRange.ToString() + "\r\n";
                                        if (rangers[1].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button8.Enabled = false;
                                        button9.Enabled = false;
                                        button10.Enabled = false;
                                        button11.Enabled = false;
                                        button16.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                            }
                            else if (move == 3)
                            {
                                if (casters[0].mp >= 10)
                                {
                                    if (_position > index)
                                    {
                                        if (((_position - index) <= casters[0].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= casters[0].atkRange)))
                                        {
                                            casters[0].Skill();
                                            casters[0].mp -= 10;
                                            rangers[1].hp -= casters[0].atk;
                                            casters[0].atk /= 2;
                                            label6.Text = "HP:" + rangers[1].hp.ToString() + "\r\n" +
                                                          "MP:" + rangers[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + rangers[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + rangers[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + rangers[1].moveRange.ToString() + "\r\n";
                                            label5.Text = "HP:" + casters[0].hp.ToString() + "\r\n" +
                                                          "MP:" + casters[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + casters[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + casters[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + casters[0].moveRange.ToString() + "\r\n";
                                            if (rangers[1].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button8.Enabled = false;
                                            button9.Enabled = false;
                                            button10.Enabled = false;
                                            button11.Enabled = false;
                                            button16.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            move = 0;
                                        }
                                    }
                                    else
                                    {
                                        if (((index - _position) <= casters[0].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= casters[0].atkRange)))
                                        {
                                            casters[0].Skill();
                                            casters[0].mp -= 10;
                                            rangers[1].hp -= casters[0].atk;
                                            casters[0].atk /= 2;
                                            label6.Text = "HP:" + rangers[1].hp.ToString() + "\r\n" +
                                                          "MP:" + rangers[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + rangers[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + rangers[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + rangers[1].moveRange.ToString() + "\r\n";
                                            label5.Text = "HP:" + casters[0].hp.ToString() + "\r\n" +
                                                          "MP:" + casters[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + casters[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + casters[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + casters[0].moveRange.ToString() + "\r\n";
                                            if (rangers[1].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button8.Enabled = false;
                                            button9.Enabled = false;
                                            button10.Enabled = false;
                                            button11.Enabled = false;
                                            button16.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            move = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    move = 0;
                                }
                            }
                        }
                        break;
                    case 2:
                        _position = 0;
                        enemy = 0;
                        for (int i = 0; i < 42; i++)
                        {
                            if ((b[i].Text == "遊俠") && (b[i].BackColor == Color.LightBlue))
                            {
                                _position = i;
                                break;
                            }
                        }
                        if ((b[index].Text == "戰士") && (b[index].BackColor == Color.LightPink)) { enemy = 1; }
                        else if ((b[index].Text == "法師") && (b[index].BackColor == Color.LightPink)) { enemy = 2; }
                        else if ((b[index].Text == "遊俠") && (b[index].BackColor == Color.LightPink)) { enemy = 3; }
                        if (enemy == 1)
                        {
                            label4.Text = "P2\r\n戰士";
                            label6.Text = "HP:" + warriors[1].hp.ToString() + "\r\n" +
                                     "MP:" + warriors[1].mp.ToString() + "\r\n" +
                                     "ATK:" + warriors[1].atk.ToString() + "\r\n" +
                                     "ATK Range:" + warriors[1].atkRange.ToString() + "\r\n" +
                                     "MOVE Range:" + warriors[1].moveRange.ToString() + "\r\n";
                            if (move == 1)
                            {
                                if (_position > index)
                                {
                                    if (((_position - index) <= rangers[0].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= rangers[0].atkRange)))
                                    {
                                        warriors[1].hp -= rangers[0].atk;
                                        label6.Text = "HP:" + warriors[1].hp.ToString() + "\r\n" +
                                                      "MP:" + warriors[1].mp.ToString() + "\r\n" +
                                                      "ATK:" + warriors[1].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + warriors[1].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + warriors[1].moveRange.ToString() + "\r\n";
                                        if (warriors[1].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button8.Enabled = false;
                                        button9.Enabled = false;
                                        button10.Enabled = false;
                                        button11.Enabled = false;
                                        button16.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                                else
                                {
                                    if (((index - _position) <= rangers[0].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= rangers[0].atkRange)))
                                    {
                                        warriors[1].hp -= rangers[0].atk;
                                        label6.Text = "HP:" + warriors[1].hp.ToString() + "\r\n" +
                                                      "MP:" + warriors[1].mp.ToString() + "\r\n" +
                                                      "ATK:" + warriors[1].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + warriors[1].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + warriors[1].moveRange.ToString() + "\r\n";
                                        if (warriors[1].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button8.Enabled = false;
                                        button9.Enabled = false;
                                        button10.Enabled = false;
                                        button11.Enabled = false;
                                        button16.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                            }
                            else if (move == 3)
                            {
                                if (rangers[0].mp >= 10)
                                {
                                    if (_position > index)
                                    {
                                        rangers[0].Skill();
                                        label5.Text = "HP:" + rangers[0].hp.ToString() + "\r\n" +
                                                          "MP:" + rangers[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + rangers[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + rangers[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + rangers[0].moveRange.ToString() + "\r\n";
                                        if (((_position - index) <= rangers[0].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= rangers[0].atkRange)))
                                        {
                                            rangers[0].mp -= 10;
                                            warriors[1].hp -= rangers[0].atk;
                                            rangers[0].atkRange--;
                                            label6.Text = "HP:" + warriors[1].hp.ToString() + "\r\n" +
                                                          "MP:" + warriors[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + warriors[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + warriors[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + warriors[1].moveRange.ToString() + "\r\n";
                                            if (warriors[1].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button8.Enabled = false;
                                            button9.Enabled = false;
                                            button10.Enabled = false;
                                            button11.Enabled = false;
                                            button16.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            rangers[0].atkRange--;
                                            move = 0;
                                        }
                                    }
                                    else
                                    {
                                        rangers[0].Skill();
                                        label5.Text = "HP:" + rangers[0].hp.ToString() + "\r\n" +
                                                          "MP:" + rangers[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + rangers[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + rangers[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + rangers[0].moveRange.ToString() + "\r\n";
                                        if (((index - _position) <= rangers[0].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= rangers[0].atkRange)))
                                        {
                                            rangers[0].mp -= 10;
                                            warriors[1].hp -= rangers[0].atk;
                                            rangers[0].atkRange--;
                                            label6.Text = "HP:" + warriors[1].hp.ToString() + "\r\n" +
                                                          "MP:" + warriors[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + warriors[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + warriors[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + warriors[1].moveRange.ToString() + "\r\n";
                                            if (warriors[1].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button8.Enabled = false;
                                            button9.Enabled = false;
                                            button10.Enabled = false;
                                            button11.Enabled = false;
                                            button16.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            rangers[0].atkRange--;
                                            move = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    move = 0;
                                }
                            }
                        }
                        else if (enemy == 2)
                        {
                            label4.Text = "P2\r\n法師";
                            label6.Text = "HP:" + casters[1].hp.ToString() + "\r\n" +
                                     "MP:" + casters[1].mp.ToString() + "\r\n" +
                                     "ATK:" + casters[1].atk.ToString() + "\r\n" +
                                     "ATK Range:" + casters[1].atkRange.ToString() + "\r\n" +
                                     "MOVE Range:" + casters[1].moveRange.ToString() + "\r\n";
                            if (move == 1)
                            {
                                if (_position > index)
                                {
                                    if (((_position - index) <= rangers[0].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= rangers[0].atkRange)))
                                    {
                                        casters[1].hp -= rangers[0].atk;
                                        label6.Text = "HP:" + casters[1].hp.ToString() + "\r\n" +
                                                      "MP:" + casters[1].mp.ToString() + "\r\n" +
                                                      "ATK:" + casters[1].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + casters[1].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + casters[1].moveRange.ToString() + "\r\n";
                                        if (casters[1].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button8.Enabled = false;
                                        button9.Enabled = false;
                                        button10.Enabled = false;
                                        button11.Enabled = false;
                                        button16.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                                else
                                {
                                    if (((index - _position) <= rangers[0].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= rangers[0].atkRange)))
                                    {
                                        casters[1].hp -= rangers[0].atk;
                                        label6.Text = "HP:" + casters[1].hp.ToString() + "\r\n" +
                                                      "MP:" + casters[1].mp.ToString() + "\r\n" +
                                                      "ATK:" + casters[1].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + casters[1].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + casters[1].moveRange.ToString() + "\r\n";
                                        if (casters[1].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button8.Enabled = false;
                                        button9.Enabled = false;
                                        button10.Enabled = false;
                                        button11.Enabled = false;
                                        button16.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                            }
                            else if (move == 3)
                            {
                                if (rangers[0].mp >= 10)
                                {
                                    if (_position > index)
                                    {
                                        rangers[0].Skill();
                                        label5.Text = "HP:" + rangers[0].hp.ToString() + "\r\n" +
                                                          "MP:" + rangers[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + rangers[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + rangers[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + rangers[0].moveRange.ToString() + "\r\n";
                                        if (((_position - index) <= rangers[0].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= rangers[0].atkRange)))
                                        {
                                            rangers[0].mp -= 10;
                                            casters[1].hp -= rangers[0].atk;
                                            rangers[0].atkRange--;
                                            label6.Text = "HP:" + casters[1].hp.ToString() + "\r\n" +
                                                          "MP:" + casters[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + casters[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + casters[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + casters[1].moveRange.ToString() + "\r\n";
                                            if (casters[1].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button8.Enabled = false;
                                            button9.Enabled = false;
                                            button10.Enabled = false;
                                            button11.Enabled = false;
                                            button16.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            rangers[0].atkRange--;
                                            move = 0;
                                        }
                                    }
                                    else
                                    {
                                        rangers[0].Skill();
                                        label5.Text = "HP:" + rangers[0].hp.ToString() + "\r\n" +
                                                          "MP:" + rangers[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + rangers[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + rangers[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + rangers[0].moveRange.ToString() + "\r\n";
                                        if (((index - _position) <= rangers[0].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= rangers[0].atkRange)))
                                        {
                                            rangers[0].mp -= 10;
                                            casters[1].hp -= rangers[0].atk;
                                            rangers[0].atkRange--;
                                            label6.Text = "HP:" + casters[1].hp.ToString() + "\r\n" +
                                                          "MP:" + casters[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + casters[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + casters[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + casters[1].moveRange.ToString() + "\r\n";
                                            if (casters[1].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button8.Enabled = false;
                                            button9.Enabled = false;
                                            button10.Enabled = false;
                                            button11.Enabled = false;
                                            button16.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            rangers[0].atkRange--;
                                            move = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    move = 0;
                                }
                            }
                        }
                        else if (enemy == 3)
                        {
                            label4.Text = "P2\r\n遊俠";
                            label6.Text = "HP:" + rangers[1].hp.ToString() + "\r\n" +
                                     "MP:" + rangers[1].mp.ToString() + "\r\n" +
                                     "ATK:" + rangers[1].atk.ToString() + "\r\n" +
                                     "ATK Range:" + rangers[1].atkRange.ToString() + "\r\n" +
                                     "MOVE Range:" + rangers[1].moveRange.ToString() + "\r\n";
                            if (move == 1)
                            {
                                if (_position > index)
                                {
                                    if (((_position - index) <= rangers[0].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= rangers[0].atkRange)))
                                    {
                                        rangers[1].hp -= rangers[0].atk;
                                        label6.Text = "HP:" + rangers[1].hp.ToString() + "\r\n" +
                                                      "MP:" + rangers[1].mp.ToString() + "\r\n" +
                                                      "ATK:" + rangers[1].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + rangers[1].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + rangers[1].moveRange.ToString() + "\r\n";
                                        if (rangers[1].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button8.Enabled = false;
                                        button9.Enabled = false;
                                        button10.Enabled = false;
                                        button11.Enabled = false;
                                        button16.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                                else
                                {
                                    if (((index - _position) <= rangers[0].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= rangers[0].atkRange)))
                                    {
                                        rangers[1].hp -= rangers[0].atk;
                                        label6.Text = "HP:" + rangers[1].hp.ToString() + "\r\n" +
                                                      "MP:" + rangers[1].mp.ToString() + "\r\n" +
                                                      "ATK:" + rangers[1].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + rangers[1].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + rangers[1].moveRange.ToString() + "\r\n";
                                        if (rangers[1].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button8.Enabled = false;
                                        button9.Enabled = false;
                                        button10.Enabled = false;
                                        button11.Enabled = false;
                                        button16.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                            }
                            else if (move == 3)
                            {
                                if (rangers[0].mp >= 10)
                                {
                                    if (_position > index)
                                    {
                                        rangers[0].Skill();
                                        label5.Text = "HP:" + rangers[0].hp.ToString() + "\r\n" +
                                                          "MP:" + rangers[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + rangers[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + rangers[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + rangers[0].moveRange.ToString() + "\r\n";
                                        if (((_position - index) <= rangers[0].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= rangers[0].atkRange)))
                                        {
                                            rangers[0].mp -= 10;
                                            rangers[1].hp -= rangers[0].atk;
                                            rangers[0].atkRange--;
                                            label6.Text = "HP:" + rangers[1].hp.ToString() + "\r\n" +
                                                          "MP:" + rangers[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + rangers[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + rangers[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + rangers[1].moveRange.ToString() + "\r\n";
                                            if (rangers[1].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button8.Enabled = false;
                                            button9.Enabled = false;
                                            button10.Enabled = false;
                                            button11.Enabled = false;
                                            button16.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            rangers[0].atkRange--;
                                            move = 0;
                                        }
                                    }
                                    else
                                    {
                                        rangers[0].Skill();
                                        label5.Text = "HP:" + rangers[0].hp.ToString() + "\r\n" +
                                                          "MP:" + rangers[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + rangers[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + rangers[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + rangers[0].moveRange.ToString() + "\r\n";
                                        if (((index - _position) <= rangers[0].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= rangers[0].atkRange)))
                                        {
                                            rangers[0].mp -= 10;
                                            rangers[1].hp -= rangers[0].atk;
                                            rangers[0].atkRange--;
                                            label6.Text = "HP:" + rangers[1].hp.ToString() + "\r\n" +
                                                          "MP:" + rangers[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + rangers[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + rangers[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + rangers[1].moveRange.ToString() + "\r\n";
                                            if (rangers[1].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button8.Enabled = false;
                                            button9.Enabled = false;
                                            button10.Enabled = false;
                                            button11.Enabled = false;
                                            button16.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            rangers[0].atkRange--;
                                            move = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    move = 0;
                                }
                            }
                        }
                        break;
                    case 3:
                        _position = 0;
                        enemy = 0;
                        for (int i = 0; i < 42; i++)
                        {
                            if ((b[i].Text == "戰士") && (b[i].BackColor == Color.LightPink))
                            {
                                _position = i;
                                break;
                            }
                        }
                        if ((b[index].Text == "戰士") && (b[index].BackColor == Color.LightBlue)) { enemy = 1; }
                        else if ((b[index].Text == "法師") && (b[index].BackColor == Color.LightBlue)) { enemy = 2; }
                        else if ((b[index].Text == "遊俠") && (b[index].BackColor == Color.LightBlue)) { enemy = 3; }
                        if (enemy == 1)
                        {
                            label3.Text = "P1\r\n戰士";
                            label5.Text = "HP:" + warriors[0].hp.ToString() + "\r\n" +
                                     "MP:" + warriors[0].mp.ToString() + "\r\n" +
                                     "ATK:" + warriors[0].atk.ToString() + "\r\n" +
                                     "ATK Range:" + warriors[0].atkRange.ToString() + "\r\n" +
                                     "MOVE Range:" + warriors[0].moveRange.ToString() + "\r\n";
                            if (move == 1)
                            {
                                if (_position > index)
                                {
                                    if (((_position - index) <= warriors[1].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= warriors[1].atkRange)))
                                    {
                                        warriors[0].hp -= warriors[1].atk;
                                        label5.Text = "HP:" + warriors[0].hp.ToString() + "\r\n" +
                                                      "MP:" + warriors[0].mp.ToString() + "\r\n" +
                                                      "ATK:" + warriors[0].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + warriors[0].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + warriors[0].moveRange.ToString() + "\r\n";
                                        if (warriors[0].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button12.Enabled = false;
                                        button13.Enabled = false;
                                        button14.Enabled = false;
                                        button15.Enabled = false;
                                        button17.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                                else
                                {
                                    if (((index - _position) <= warriors[1].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= warriors[1].atkRange)))
                                    {
                                        warriors[0].hp -= warriors[1].atk;
                                        label5.Text = "HP:" + warriors[0].hp.ToString() + "\r\n" +
                                                      "MP:" + warriors[0].mp.ToString() + "\r\n" +
                                                      "ATK:" + warriors[0].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + warriors[0].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + warriors[0].moveRange.ToString() + "\r\n";
                                        if (warriors[0].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button12.Enabled = false;
                                        button13.Enabled = false;
                                        button14.Enabled = false;
                                        button15.Enabled = false;
                                        button17.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                            }
                            else if (move == 3)
                            {
                                if (warriors[1].mp >= 10)
                                {
                                    if (_position > index)
                                    {
                                        if (((_position - index) <= warriors[1].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= warriors[1].atkRange)))
                                        {
                                            warriors[1].Skill();
                                            warriors[1].mp -= 10;
                                            warriors[0].hp -= warriors[1].atk;
                                            label5.Text = "HP:" + warriors[0].hp.ToString() + "\r\n" +
                                                          "MP:" + warriors[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + warriors[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + warriors[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + warriors[0].moveRange.ToString() + "\r\n";
                                            label6.Text = "HP:" + warriors[1].hp.ToString() + "\r\n" +
                                                          "MP:" + warriors[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + warriors[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + warriors[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + warriors[1].moveRange.ToString() + "\r\n";
                                            if (warriors[0].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button12.Enabled = false;
                                            button13.Enabled = false;
                                            button14.Enabled = false;
                                            button15.Enabled = false;
                                            button17.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            move = 0;
                                        }
                                    }
                                    else
                                    {
                                        if (((index - _position) <= warriors[1].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= warriors[1].atkRange)))
                                        {
                                            warriors[1].Skill();
                                            warriors[1].mp -= 10;
                                            warriors[0].hp -= warriors[1].atk;
                                            label5.Text = "HP:" + warriors[0].hp.ToString() + "\r\n" +
                                                          "MP:" + warriors[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + warriors[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + warriors[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + warriors[0].moveRange.ToString() + "\r\n";
                                            label6.Text = "HP:" + warriors[1].hp.ToString() + "\r\n" +
                                                          "MP:" + warriors[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + warriors[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + warriors[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + warriors[1].moveRange.ToString() + "\r\n";
                                            if (warriors[0].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button12.Enabled = false;
                                            button13.Enabled = false;
                                            button14.Enabled = false;
                                            button15.Enabled = false;
                                            button17.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            move = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    move = 0;
                                }
                            }
                        }
                        else if (enemy == 2)
                        {
                            label3.Text = "P1\r\n法師";
                            label6.Text = "HP:" + casters[0].hp.ToString() + "\r\n" +
                                     "MP:" + casters[0].mp.ToString() + "\r\n" +
                                     "ATK:" + casters[0].atk.ToString() + "\r\n" +
                                     "ATK Range:" + casters[0].atkRange.ToString() + "\r\n" +
                                     "MOVE Range:" + casters[0].moveRange.ToString() + "\r\n";
                            if (move == 1)
                            {
                                if (_position > index)
                                {
                                    if (((_position - index) <= warriors[1].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= warriors[1].atkRange)))
                                    {
                                        casters[0].hp -= warriors[1].atk;
                                        label5.Text = "HP:" + casters[0].hp.ToString() + "\r\n" +
                                                      "MP:" + casters[0].mp.ToString() + "\r\n" +
                                                      "ATK:" + casters[0].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + casters[0].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + casters[0].moveRange.ToString() + "\r\n";
                                        if (casters[0].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button12.Enabled = false;
                                        button13.Enabled = false;
                                        button14.Enabled = false;
                                        button15.Enabled = false;
                                        button17.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                                else
                                {
                                    if (((index - _position) <= warriors[1].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= warriors[1].atkRange)))
                                    {
                                        casters[0].hp -= warriors[1].atk;
                                        label5.Text = "HP:" + casters[0].hp.ToString() + "\r\n" +
                                                      "MP:" + casters[0].mp.ToString() + "\r\n" +
                                                      "ATK:" + casters[0].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + casters[0].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + casters[0].moveRange.ToString() + "\r\n";
                                        if (casters[0].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button12.Enabled = false;
                                        button13.Enabled = false;
                                        button14.Enabled = false;
                                        button15.Enabled = false;
                                        button17.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                            }
                            else if (move == 3)
                            {
                                if (warriors[1].mp >= 10)
                                {
                                    if (_position > index)
                                    {
                                        if (((_position - index) <= warriors[1].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= warriors[1].atkRange)))
                                        {
                                            warriors[1].Skill();
                                            warriors[1].mp -= 10;
                                            casters[0].hp -= warriors[1].atk;
                                            label5.Text = "HP:" + casters[0].hp.ToString() + "\r\n" +
                                                          "MP:" + casters[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + casters[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + casters[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + casters[0].moveRange.ToString() + "\r\n";
                                            label6.Text = "HP:" + warriors[1].hp.ToString() + "\r\n" +
                                                          "MP:" + warriors[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + warriors[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + warriors[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + warriors[1].moveRange.ToString() + "\r\n";
                                            if (casters[0].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button12.Enabled = false;
                                            button13.Enabled = false;
                                            button14.Enabled = false;
                                            button15.Enabled = false;
                                            button17.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            move = 0;
                                        }
                                    }
                                    else
                                    {
                                        if (((index - _position) <= warriors[1].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= warriors[1].atkRange)))
                                        {
                                            warriors[1].Skill();
                                            warriors[1].mp -= 10;
                                            casters[0].hp -= warriors[1].atk;
                                            label5.Text = "HP:" + casters[0].hp.ToString() + "\r\n" +
                                                          "MP:" + casters[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + casters[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + casters[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + casters[0].moveRange.ToString() + "\r\n";
                                            label6.Text = "HP:" + warriors[1].hp.ToString() + "\r\n" +
                                                          "MP:" + warriors[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + warriors[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + warriors[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + warriors[1].moveRange.ToString() + "\r\n";
                                            if (casters[0].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button12.Enabled = false;
                                            button13.Enabled = false;
                                            button14.Enabled = false;
                                            button15.Enabled = false;
                                            button17.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            move = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    move = 0;
                                }
                            }
                        }
                        else if (enemy == 3)
                        {
                            label3.Text = "P1\r\n遊俠";
                            label5.Text = "HP:" + rangers[0].hp.ToString() + "\r\n" +
                                     "MP:" + rangers[0].mp.ToString() + "\r\n" +
                                     "ATK:" + rangers[0].atk.ToString() + "\r\n" +
                                     "ATK Range:" + rangers[0].atkRange.ToString() + "\r\n" +
                                     "MOVE Range:" + rangers[0].moveRange.ToString() + "\r\n";
                            if (move == 1)
                            {
                                if (_position > index)
                                {
                                    if (((_position - index) <= warriors[1].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= warriors[1].atkRange)))
                                    {
                                        rangers[0].hp -= warriors[1].atk;
                                        label6.Text = "HP:" + rangers[0].hp.ToString() + "\r\n" +
                                                      "MP:" + rangers[0].mp.ToString() + "\r\n" +
                                                      "ATK:" + rangers[0].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + rangers[0].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + rangers[0].moveRange.ToString() + "\r\n";
                                        if (rangers[0].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button12.Enabled = false;
                                        button13.Enabled = false;
                                        button14.Enabled = false;
                                        button15.Enabled = false;
                                        button17.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                                else
                                {
                                    if (((index - _position) <= warriors[1].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= warriors[1].atkRange)))
                                    {
                                        rangers[0].hp -= warriors[1].atk;
                                        label5.Text = "HP:" + rangers[0].hp.ToString() + "\r\n" +
                                                      "MP:" + rangers[0].mp.ToString() + "\r\n" +
                                                      "ATK:" + rangers[0].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + rangers[0].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + rangers[0].moveRange.ToString() + "\r\n";
                                        if (rangers[0].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button12.Enabled = false;
                                        button13.Enabled = false;
                                        button14.Enabled = false;
                                        button15.Enabled = false;
                                        button17.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                            }
                            else if (move == 3)
                            {
                                if (warriors[1].mp >= 10)
                                {
                                    if (_position > index)
                                    {
                                        if (((_position - index) <= warriors[1].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= warriors[1].atkRange)))
                                        {
                                            warriors[1].Skill();
                                            warriors[1].mp -= 10;
                                            rangers[0].hp -= warriors[1].atk;
                                            label5.Text = "HP:" + rangers[0].hp.ToString() + "\r\n" +
                                                          "MP:" + rangers[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + rangers[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + rangers[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + rangers[0].moveRange.ToString() + "\r\n";
                                            label6.Text = "HP:" + warriors[1].hp.ToString() + "\r\n" +
                                                          "MP:" + warriors[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + warriors[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + warriors[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + warriors[1].moveRange.ToString() + "\r\n";
                                            if (rangers[0].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button12.Enabled = false;
                                            button13.Enabled = false;
                                            button14.Enabled = false;
                                            button15.Enabled = false;
                                            button17.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            move = 0;
                                        }
                                    }
                                    else
                                    {
                                        if (((index - _position) <= warriors[1].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= warriors[1].atkRange)))
                                        {
                                            warriors[1].Skill();
                                            warriors[1].mp -= 10;
                                            rangers[0].hp -= warriors[1].atk;
                                            label5.Text = "HP:" + rangers[0].hp.ToString() + "\r\n" +
                                                          "MP:" + rangers[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + rangers[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + rangers[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + rangers[0].moveRange.ToString() + "\r\n";
                                            label6.Text = "HP:" + warriors[1].hp.ToString() + "\r\n" +
                                                          "MP:" + warriors[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + warriors[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + warriors[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + warriors[1].moveRange.ToString() + "\r\n";
                                            if (rangers[0].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button12.Enabled = false;
                                            button13.Enabled = false;
                                            button14.Enabled = false;
                                            button15.Enabled = false;
                                            button17.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            move = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    move = 0;
                                }
                            }
                        }
                        break;
                    case 4:
                        _position = 0;
                        enemy = 0;
                        for (int i = 0; i < 42; i++)
                        {
                            if ((b[i].Text == "法師") && (b[i].BackColor == Color.LightPink))
                            {
                                _position = i;
                                break;
                            }
                        }
                        if ((b[index].Text == "戰士") && (b[index].BackColor == Color.LightBlue)) { enemy = 1; }
                        else if ((b[index].Text == "法師") && (b[index].BackColor == Color.LightBlue)) { enemy = 2; }
                        else if ((b[index].Text == "遊俠") && (b[index].BackColor == Color.LightBlue)) { enemy = 3; }
                        if (enemy == 1)
                        {
                            label3.Text = "P1\r\n戰士";
                            label5.Text = "HP:" + warriors[0].hp.ToString() + "\r\n" +
                                     "MP:" + warriors[0].mp.ToString() + "\r\n" +
                                     "ATK:" + warriors[0].atk.ToString() + "\r\n" +
                                     "ATK Range:" + warriors[0].atkRange.ToString() + "\r\n" +
                                     "MOVE Range:" + warriors[0].moveRange.ToString() + "\r\n";
                            if (move == 1)
                            {
                                if (_position > index)
                                {
                                    if (((_position - index) <= casters[1].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= casters[1].atkRange)))
                                    {
                                        warriors[0].hp -= casters[1].atk;
                                        label5.Text = "HP:" + warriors[0].hp.ToString() + "\r\n" +
                                                      "MP:" + warriors[0].mp.ToString() + "\r\n" +
                                                      "ATK:" + warriors[0].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + warriors[0].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + warriors[0].moveRange.ToString() + "\r\n";
                                        if (warriors[0].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button12.Enabled = false;
                                        button13.Enabled = false;
                                        button14.Enabled = false;
                                        button15.Enabled = false;
                                        button17.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                                else
                                {
                                    if (((index - _position) <= casters[1].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= casters[1].atkRange)))
                                    {
                                        warriors[0].hp -= casters[1].atk;
                                        label5.Text = "HP:" + warriors[0].hp.ToString() + "\r\n" +
                                                      "MP:" + warriors[0].mp.ToString() + "\r\n" +
                                                      "ATK:" + warriors[0].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + warriors[0].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + warriors[0].moveRange.ToString() + "\r\n";
                                        if (warriors[0].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button12.Enabled = false;
                                        button13.Enabled = false;
                                        button14.Enabled = false;
                                        button15.Enabled = false;
                                        button17.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                            }
                            else if (move == 3)
                            {
                                if (casters[1].mp >= 10)
                                {
                                    if (_position > index)
                                    {
                                        if (((_position - index) <= casters[1].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= casters[1].atkRange)))
                                        {
                                            casters[1].Skill();
                                            casters[1].mp -= 10;
                                            warriors[0].hp -= casters[1].atk;
                                            casters[1].atk /= 2;
                                            label5.Text = "HP:" + warriors[0].hp.ToString() + "\r\n" +
                                                          "MP:" + warriors[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + warriors[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + warriors[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + warriors[0].moveRange.ToString() + "\r\n";
                                            label6.Text = "HP:" + casters[1].hp.ToString() + "\r\n" +
                                                          "MP:" + casters[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + casters[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + casters[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + casters[1].moveRange.ToString() + "\r\n";
                                            if (warriors[0].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button12.Enabled = false;
                                            button13.Enabled = false;
                                            button14.Enabled = false;
                                            button15.Enabled = false;
                                            button17.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            move = 0;
                                        }
                                    }
                                    else
                                    {
                                        if (((index - _position) <= casters[1].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= casters[1].atkRange)))
                                        {
                                            casters[1].Skill();
                                            casters[1].mp -= 10;
                                            warriors[0].hp -= casters[1].atk;
                                            casters[1].atk /= 2;
                                            label5.Text = "HP:" + warriors[0].hp.ToString() + "\r\n" +
                                                          "MP:" + warriors[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + warriors[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + warriors[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + warriors[0].moveRange.ToString() + "\r\n";
                                            label6.Text = "HP:" + casters[1].hp.ToString() + "\r\n" +
                                                          "MP:" + casters[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + casters[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + casters[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + casters[1].moveRange.ToString() + "\r\n";
                                            if (warriors[0].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button12.Enabled = false;
                                            button13.Enabled = false;
                                            button14.Enabled = false;
                                            button15.Enabled = false;
                                            button17.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            move = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    move = 0;
                                }
                            }
                        }
                        else if (enemy == 2)
                        {
                            label3.Text = "P1\r\n法師";
                            label5.Text = "HP:" + casters[0].hp.ToString() + "\r\n" +
                                     "MP:" + casters[0].mp.ToString() + "\r\n" +
                                     "ATK:" + casters[0].atk.ToString() + "\r\n" +
                                     "ATK Range:" + casters[0].atkRange.ToString() + "\r\n" +
                                     "MOVE Range:" + casters[0].moveRange.ToString() + "\r\n";
                            if (move == 1)
                            {
                                if (_position > index)
                                {
                                    if (((_position - index) <= casters[1].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= casters[1].atkRange)))
                                    {
                                        casters[0].hp -= casters[1].atk;
                                        label5.Text = "HP:" + casters[0].hp.ToString() + "\r\n" +
                                                      "MP:" + casters[0].mp.ToString() + "\r\n" +
                                                      "ATK:" + casters[0].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + casters[0].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + casters[0].moveRange.ToString() + "\r\n";
                                        if (casters[0].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button12.Enabled = false;
                                        button13.Enabled = false;
                                        button14.Enabled = false;
                                        button15.Enabled = false;
                                        button17.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                                else
                                {
                                    if (((index - _position) <= casters[1].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= casters[1].atkRange)))
                                    {
                                        casters[0].hp -= casters[1].atk;
                                        label5.Text = "HP:" + casters[0].hp.ToString() + "\r\n" +
                                                      "MP:" + casters[0].mp.ToString() + "\r\n" +
                                                      "ATK:" + casters[0].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + casters[0].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + casters[0].moveRange.ToString() + "\r\n";
                                        if (casters[0].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button12.Enabled = false;
                                        button13.Enabled = false;
                                        button14.Enabled = false;
                                        button15.Enabled = false;
                                        button17.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                            }
                            else if (move == 3)
                            {
                                if (casters[1].mp >= 10)
                                {
                                    if (_position > index)
                                    {
                                        if (((_position - index) <= casters[1].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= casters[1].atkRange)))
                                        {
                                            casters[1].Skill();
                                            casters[1].mp -= 10;
                                            casters[0].hp -= casters[1].atk;
                                            casters[1].atk /= 2;
                                            label5.Text = "HP:" + casters[0].hp.ToString() + "\r\n" +
                                                          "MP:" + casters[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + casters[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + casters[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + casters[0].moveRange.ToString() + "\r\n";
                                            label6.Text = "HP:" + casters[1].hp.ToString() + "\r\n" +
                                                          "MP:" + casters[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + casters[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + casters[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + casters[1].moveRange.ToString() + "\r\n";
                                            if (casters[0].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button12.Enabled = false;
                                            button13.Enabled = false;
                                            button14.Enabled = false;
                                            button15.Enabled = false;
                                            button17.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            move = 0;
                                        }
                                    }
                                    else
                                    {
                                        if (((index - _position) <= casters[1].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= casters[1].atkRange)))
                                        {
                                            casters[1].Skill();
                                            casters[1].mp -= 10;
                                            casters[0].hp -= casters[1].atk;
                                            casters[1].atk /= 2;
                                            label5.Text = "HP:" + casters[0].hp.ToString() + "\r\n" +
                                                          "MP:" + casters[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + casters[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + casters[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + casters[0].moveRange.ToString() + "\r\n";
                                            label6.Text = "HP:" + casters[1].hp.ToString() + "\r\n" +
                                                          "MP:" + casters[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + casters[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + casters[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + casters[1].moveRange.ToString() + "\r\n";
                                            if (casters[0].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button12.Enabled = false;
                                            button13.Enabled = false;
                                            button14.Enabled = false;
                                            button15.Enabled = false;
                                            button17.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            move = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    move = 0;
                                }
                            }
                        }
                        else if (enemy == 3)
                        {
                            label3.Text = "P1\r\n遊俠";
                            label5.Text = "HP:" + rangers[0].hp.ToString() + "\r\n" +
                                     "MP:" + rangers[0].mp.ToString() + "\r\n" +
                                     "ATK:" + rangers[0].atk.ToString() + "\r\n" +
                                     "ATK Range:" + rangers[0].atkRange.ToString() + "\r\n" +
                                     "MOVE Range:" + rangers[0].moveRange.ToString() + "\r\n";
                            if (move == 1)
                            {
                                if (_position > index)
                                {
                                    if (((_position - index) <= casters[1].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= casters[1].atkRange)))
                                    {
                                        rangers[1].hp -= casters[0].atk;
                                        label5.Text = "HP:" + rangers[0].hp.ToString() + "\r\n" +
                                                      "MP:" + rangers[0].mp.ToString() + "\r\n" +
                                                      "ATK:" + rangers[0].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + rangers[0].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + rangers[0].moveRange.ToString() + "\r\n";
                                        if (rangers[0].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button12.Enabled = false;
                                        button13.Enabled = false;
                                        button14.Enabled = false;
                                        button15.Enabled = false;
                                        button17.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                                else
                                {
                                    if (((index - _position) <= casters[1].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= casters[1].atkRange)))
                                    {
                                        rangers[0].hp -= casters[1].atk;
                                        label5.Text = "HP:" + rangers[0].hp.ToString() + "\r\n" +
                                                      "MP:" + rangers[0].mp.ToString() + "\r\n" +
                                                      "ATK:" + rangers[0].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + rangers[0].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + rangers[0].moveRange.ToString() + "\r\n";
                                        if (rangers[0].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button12.Enabled = false;
                                        button13.Enabled = false;
                                        button14.Enabled = false;
                                        button15.Enabled = false;
                                        button17.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                            }
                            else if (move == 3)
                            {
                                if (casters[1].mp >= 10)
                                {
                                    if (_position > index)
                                    {
                                        if (((_position - index) <= casters[1].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= casters[1].atkRange)))
                                        {
                                            casters[1].Skill();
                                            casters[1].mp -= 10;
                                            rangers[0].hp -= casters[1].atk;
                                            casters[1].atk /= 2;
                                            label5.Text = "HP:" + rangers[0].hp.ToString() + "\r\n" +
                                                          "MP:" + rangers[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + rangers[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + rangers[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + rangers[0].moveRange.ToString() + "\r\n";
                                            label6.Text = "HP:" + casters[1].hp.ToString() + "\r\n" +
                                                          "MP:" + casters[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + casters[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + casters[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + casters[1].moveRange.ToString() + "\r\n";
                                            if (rangers[0].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button12.Enabled = false;
                                            button13.Enabled = false;
                                            button14.Enabled = false;
                                            button15.Enabled = false;
                                            button17.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            move = 0;
                                        }
                                    }
                                    else
                                    {
                                        if (((index - _position) <= casters[1].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= casters[1].atkRange)))
                                        {
                                            casters[1].Skill();
                                            casters[1].mp -= 10;
                                            rangers[0].hp -= casters[1].atk;
                                            casters[1].atk /= 2;
                                            label5.Text = "HP:" + rangers[0].hp.ToString() + "\r\n" +
                                                          "MP:" + rangers[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + rangers[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + rangers[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + rangers[0].moveRange.ToString() + "\r\n";
                                            label6.Text = "HP:" + casters[1].hp.ToString() + "\r\n" +
                                                          "MP:" + casters[1].mp.ToString() + "\r\n" +
                                                          "ATK:" + casters[1].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + casters[1].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + casters[1].moveRange.ToString() + "\r\n";
                                            if (rangers[0].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button12.Enabled = false;
                                            button13.Enabled = false;
                                            button14.Enabled = false;
                                            button15.Enabled = false;
                                            button17.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            move = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    move = 0;
                                }
                            }
                        }
                        break;
                    case 5:
                        _position = 0;
                        enemy = 0;
                        for (int i = 0; i < 42; i++)
                        {
                            if ((b[i].Text == "遊俠") && (b[i].BackColor == Color.LightPink))
                            {
                                _position = i;
                                break;
                            }
                        }
                        if ((b[index].Text == "戰士") && (b[index].BackColor == Color.LightBlue)) { enemy = 1; }
                        else if ((b[index].Text == "法師") && (b[index].BackColor == Color.LightBlue)) { enemy = 2; }
                        else if ((b[index].Text == "遊俠") && (b[index].BackColor == Color.LightBlue)) { enemy = 3; }
                        if (enemy == 1)
                        {
                            label3.Text = "P1\r\n戰士";
                            label5.Text = "HP:" + warriors[0].hp.ToString() + "\r\n" +
                                     "MP:" + warriors[0].mp.ToString() + "\r\n" +
                                     "ATK:" + warriors[0].atk.ToString() + "\r\n" +
                                     "ATK Range:" + warriors[0].atkRange.ToString() + "\r\n" +
                                     "MOVE Range:" + warriors[0].moveRange.ToString() + "\r\n";
                            if (move == 1)
                            {
                                if (_position > index)
                                {
                                    if (((_position - index) <= rangers[1].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= rangers[1].atkRange)))
                                    {
                                        warriors[0].hp -= rangers[1].atk;
                                        label5.Text = "HP:" + warriors[0].hp.ToString() + "\r\n" +
                                                      "MP:" + warriors[0].mp.ToString() + "\r\n" +
                                                      "ATK:" + warriors[0].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + warriors[0].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + warriors[0].moveRange.ToString() + "\r\n";
                                        if (warriors[0].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button12.Enabled = false;
                                        button13.Enabled = false;
                                        button14.Enabled = false;
                                        button15.Enabled = false;
                                        button17.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                                else
                                {
                                    if (((index - _position) <= rangers[1].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= rangers[1].atkRange)))
                                    {
                                        warriors[0].hp -= rangers[1].atk;
                                        label5.Text = "HP:" + warriors[0].hp.ToString() + "\r\n" +
                                                      "MP:" + warriors[0].mp.ToString() + "\r\n" +
                                                      "ATK:" + warriors[0].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + warriors[0].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + warriors[0].moveRange.ToString() + "\r\n";
                                        if (warriors[0].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button12.Enabled = false;
                                        button13.Enabled = false;
                                        button14.Enabled = false;
                                        button15.Enabled = false;
                                        button17.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                            }
                            else if (move == 3)
                            {
                                if (rangers[1].mp >= 10)
                                {
                                    if (_position > index)
                                    {
                                        rangers[1].Skill();
                                        label6.Text = "HP:" + rangers[1].hp.ToString() + "\r\n" +
                                        "MP:" + rangers[1].mp.ToString() + "\r\n" +
                                        "ATK:" + rangers[1].atk.ToString() + "\r\n" +
                                        "ATK Range:" + rangers[1].atkRange.ToString() + "\r\n" +
                                        "MOVE Range:" + rangers[1].moveRange.ToString() + "\r\n";
                                        if (((_position - index) <= rangers[1].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= rangers[1].atkRange)))
                                        {
                                            rangers[1].mp -= 10;
                                            warriors[0].hp -= rangers[1].atk;
                                            rangers[1].atkRange--;
                                            label5.Text = "HP:" + warriors[0].hp.ToString() + "\r\n" +
                                                          "MP:" + warriors[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + warriors[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + warriors[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + warriors[0].moveRange.ToString() + "\r\n";
                                            if (warriors[0].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button12.Enabled = false;
                                            button13.Enabled = false;
                                            button14.Enabled = false;
                                            button15.Enabled = false;
                                            button17.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            rangers[1].atkRange--;
                                            move = 0;
                                        }
                                    }
                                    else
                                    {
                                        rangers[1].Skill();
                                        label6.Text = "HP:" + rangers[1].hp.ToString() + "\r\n" +
                                        "MP:" + rangers[1].mp.ToString() + "\r\n" +
                                        "ATK:" + rangers[1].atk.ToString() + "\r\n" +
                                        "ATK Range:" + rangers[1].atkRange.ToString() + "\r\n" +
                                        "MOVE Range:" + rangers[1].moveRange.ToString() + "\r\n";
                                        if (((index - _position) <= rangers[1].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= rangers[1].atkRange)))
                                        {
                                            rangers[1].mp -= 10;
                                            warriors[0].hp -= rangers[1].atk;
                                            rangers[1].atkRange--;
                                            label5.Text = "HP:" + warriors[0].hp.ToString() + "\r\n" +
                                                          "MP:" + warriors[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + warriors[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + warriors[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + warriors[0].moveRange.ToString() + "\r\n";
                                            if (warriors[0].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button12.Enabled = false;
                                            button13.Enabled = false;
                                            button14.Enabled = false;
                                            button15.Enabled = false;
                                            button17.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            rangers[1].atkRange--;
                                            move = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    move = 0;
                                }
                            }
                        }
                        else if (enemy == 2)
                        {
                            label3.Text = "P1\r\n法師";
                            label5.Text = "HP:" + casters[0].hp.ToString() + "\r\n" +
                                     "MP:" + casters[0].mp.ToString() + "\r\n" +
                                     "ATK:" + casters[0].atk.ToString() + "\r\n" +
                                     "ATK Range:" + casters[0].atkRange.ToString() + "\r\n" +
                                     "MOVE Range:" + casters[0].moveRange.ToString() + "\r\n";
                            if (move == 1)
                            {
                                if (_position > index)
                                {
                                    if (((_position - index) <= rangers[1].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= rangers[1].atkRange)))
                                    {
                                        casters[0].hp -= rangers[1].atk;
                                        label5.Text = "HP:" + casters[0].hp.ToString() + "\r\n" +
                                                      "MP:" + casters[0].mp.ToString() + "\r\n" +
                                                      "ATK:" + casters[0].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + casters[0].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + casters[0].moveRange.ToString() + "\r\n";
                                        if (casters[0].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button12.Enabled = false;
                                        button13.Enabled = false;
                                        button14.Enabled = false;
                                        button15.Enabled = false;
                                        button17.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                                else
                                {
                                    if (((index - _position) <= rangers[1].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= rangers[1].atkRange)))
                                    {
                                        casters[0].hp -= rangers[1].atk;
                                        label5.Text = "HP:" + casters[0].hp.ToString() + "\r\n" +
                                                      "MP:" + casters[0].mp.ToString() + "\r\n" +
                                                      "ATK:" + casters[0].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + casters[0].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + casters[0].moveRange.ToString() + "\r\n";
                                        if (casters[0].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button12.Enabled = false;
                                        button13.Enabled = false;
                                        button14.Enabled = false;
                                        button15.Enabled = false;
                                        button17.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                            }
                            else if (move == 3)
                            {
                                if (rangers[1].mp >= 10)
                                {
                                    if (_position > index)
                                    {
                                        rangers[1].Skill();
                                        label6.Text = "HP:" + rangers[1].hp.ToString() + "\r\n" +
                                        "MP:" + rangers[1].mp.ToString() + "\r\n" +
                                        "ATK:" + rangers[1].atk.ToString() + "\r\n" +
                                        "ATK Range:" + rangers[1].atkRange.ToString() + "\r\n" +
                                        "MOVE Range:" + rangers[1].moveRange.ToString() + "\r\n";
                                        if (((_position - index) <= rangers[1].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= rangers[1].atkRange)))
                                        {
                                            rangers[1].mp -= 10;
                                            casters[0].hp -= rangers[1].atk;
                                            rangers[1].atkRange--;
                                            label5.Text = "HP:" + casters[0].hp.ToString() + "\r\n" +
                                                          "MP:" + casters[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + casters[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + casters[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + casters[0].moveRange.ToString() + "\r\n";
                                            if (casters[0].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button12.Enabled = false;
                                            button13.Enabled = false;
                                            button14.Enabled = false;
                                            button15.Enabled = false;
                                            button17.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            rangers[1].atkRange--;
                                            move = 0;
                                        }
                                    }
                                    else
                                    {
                                        rangers[1].Skill();
                                        label6.Text = "HP:" + rangers[1].hp.ToString() + "\r\n" +
                                        "MP:" + rangers[1].mp.ToString() + "\r\n" +
                                        "ATK:" + rangers[1].atk.ToString() + "\r\n" +
                                        "ATK Range:" + rangers[1].atkRange.ToString() + "\r\n" +
                                        "MOVE Range:" + rangers[1].moveRange.ToString() + "\r\n";
                                        if (((index - _position) <= rangers[1].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= rangers[1].atkRange)))
                                        {
                                            rangers[1].mp -= 10;
                                            casters[0].hp -= rangers[1].atk;
                                            rangers[1].atkRange--;
                                            label5.Text = "HP:" + casters[0].hp.ToString() + "\r\n" +
                                                          "MP:" + casters[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + casters[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + casters[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + casters[0].moveRange.ToString() + "\r\n";
                                            if (casters[0].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button12.Enabled = false;
                                            button13.Enabled = false;
                                            button14.Enabled = false;
                                            button15.Enabled = false;
                                            button17.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            rangers[1].atkRange--;
                                            move = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    move = 0;
                                }
                            }
                        }
                        else if (enemy == 3)
                        {
                            label3.Text = "P1\r\n遊俠";
                            label5.Text = "HP:" + rangers[0].hp.ToString() + "\r\n" +
                                     "MP:" + rangers[0].mp.ToString() + "\r\n" +
                                     "ATK:" + rangers[0].atk.ToString() + "\r\n" +
                                     "ATK Range:" + rangers[0].atkRange.ToString() + "\r\n" +
                                     "MOVE Range:" + rangers[0].moveRange.ToString() + "\r\n";
                            if (move == 1)
                            {
                                if (_position > index)
                                {
                                    if (((_position - index) <= rangers[1].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= rangers[1].atkRange)))
                                    {
                                        rangers[0].hp -= rangers[1].atk;
                                        label6.Text = "HP:" + rangers[0].hp.ToString() + "\r\n" +
                                                      "MP:" + rangers[0].mp.ToString() + "\r\n" +
                                                      "ATK:" + rangers[0].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + rangers[0].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + rangers[0].moveRange.ToString() + "\r\n";
                                        if (rangers[0].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button12.Enabled = false;
                                        button13.Enabled = false;
                                        button14.Enabled = false;
                                        button15.Enabled = false;
                                        button17.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                                else
                                {
                                    if (((index - _position) <= rangers[1].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= rangers[1].atkRange)))
                                    {
                                        rangers[0].hp -= rangers[1].atk;
                                        label5.Text = "HP:" + rangers[0].hp.ToString() + "\r\n" +
                                                      "MP:" + rangers[0].mp.ToString() + "\r\n" +
                                                      "ATK:" + rangers[0].atk.ToString() + "\r\n" +
                                                      "ATK Range:" + rangers[0].atkRange.ToString() + "\r\n" +
                                                      "MOVE Range:" + rangers[0].moveRange.ToString() + "\r\n";
                                        if (rangers[0].hp <= 0)
                                        {
                                            b[index].Text = "";
                                            b[index].BackColor = Color.Gainsboro;
                                        }
                                        button12.Enabled = false;
                                        button13.Enabled = false;
                                        button14.Enabled = false;
                                        button15.Enabled = false;
                                        button17.Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                        move = 0;
                                    }
                                }
                            }
                            else if (move == 3)
                            {
                                if (rangers[1].mp >= 10)
                                {
                                    if (_position > index)
                                    {
                                        rangers[1].Skill();
                                        label6.Text = "HP:" + rangers[1].hp.ToString() + "\r\n" +
                                        "MP:" + rangers[1].mp.ToString() + "\r\n" +
                                        "ATK:" + rangers[1].atk.ToString() + "\r\n" +
                                        "ATK Range:" + rangers[1].atkRange.ToString() + "\r\n" +
                                        "MOVE Range:" + rangers[1].moveRange.ToString() + "\r\n";
                                        if (((_position - index) <= rangers[1].atkRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= rangers[1].atkRange)))
                                        {
                                            rangers[1].mp -= 10;
                                            rangers[0].hp -= rangers[1].atk;
                                            rangers[1].atkRange--;
                                            label5.Text = "HP:" + rangers[0].hp.ToString() + "\r\n" +
                                                          "MP:" + rangers[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + rangers[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + rangers[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + rangers[0].moveRange.ToString() + "\r\n";
                                            if (rangers[0].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button12.Enabled = false;
                                            button13.Enabled = false;
                                            button14.Enabled = false;
                                            button15.Enabled = false;
                                            button17.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            rangers[1].atkRange--;
                                            move = 0;
                                        }
                                    }
                                    else
                                    {
                                        rangers[1].Skill();
                                        label6.Text = "HP:" + rangers[1].hp.ToString() + "\r\n" +
                                        "MP:" + rangers[1].mp.ToString() + "\r\n" +
                                        "ATK:" + rangers[1].atk.ToString() + "\r\n" +
                                        "ATK Range:" + rangers[1].atkRange.ToString() + "\r\n" +
                                        "MOVE Range:" + rangers[1].moveRange.ToString() + "\r\n";
                                        if (((index - _position) <= rangers[1].atkRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= rangers[1].atkRange)))
                                        {
                                            rangers[1].mp -= 10;
                                            rangers[0].hp -= rangers[1].atk;
                                            rangers[1].atkRange--;
                                            label5.Text = "HP:" + rangers[0].hp.ToString() + "\r\n" +
                                                          "MP:" + rangers[0].mp.ToString() + "\r\n" +
                                                          "ATK:" + rangers[0].atk.ToString() + "\r\n" +
                                                          "ATK Range:" + rangers[0].atkRange.ToString() + "\r\n" +
                                                          "MOVE Range:" + rangers[0].moveRange.ToString() + "\r\n";
                                            if (rangers[0].hp <= 0)
                                            {
                                                b[index].Text = "";
                                                b[index].BackColor = Color.Gainsboro;
                                            }
                                            button12.Enabled = false;
                                            button13.Enabled = false;
                                            button14.Enabled = false;
                                            button15.Enabled = false;
                                            button17.Enabled = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK);
                                            rangers[1].atkRange--;
                                            move = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    move = 0;
                                }
                            }
                        }
                        break;
                }
                P1_chess = 3;
                P2_chess = 3;
                for (int i = 0; i < 2; i++)
                {
                    if (warriors[i].hp <= 0)
                    {
                        if (i == 0) { P1_chess--; }
                        else { P2_chess--; }
                    }
                    if (casters[i].hp <= 0)
                    {
                        if (i == 0) { P1_chess--; }
                        else { P2_chess--; }
                    }
                    if (rangers[i].hp <= 0)
                    {
                        if (i == 0) { P1_chess--; }
                        else { P2_chess--; }
                    }
                }
            }
            else
            {
                if (move == 2)
                {
                    switch (turn)
                    {
                        case 0:
                            int _position = 0;
                            for (int i = 0; i < 42; i++)
                            {
                                if ((b[i].Text == "戰士") && (b[i].BackColor == Color.LightBlue))
                                {
                                    _position = i;
                                    break;
                                }
                            }
                            if (_position > index)
                            {
                                if (((_position - index) <= warriors[0].moveRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= warriors[0].moveRange)))
                                {
                                    b[index].Text = b[_position].Text;
                                    b[index].BackColor = b[_position].BackColor;
                                    b[_position].Text = "";
                                    b[_position].BackColor = Color.Gainsboro;
                                    button8.Enabled = false;
                                    button9.Enabled = false;
                                    button10.Enabled = false;
                                    button11.Enabled = false;
                                    button16.Enabled = true;
                                }
                                else
                                {
                                    MessageBox.Show("超出移動範圍", "", MessageBoxButtons.OK);
                                    move = 0;
                                }
                            }
                            else
                            {
                                if (((index - _position) <= warriors[0].moveRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= warriors[0].moveRange)))
                                {
                                    b[index].Text = b[_position].Text;
                                    b[index].BackColor = b[_position].BackColor;
                                    b[_position].Text = "";
                                    b[_position].BackColor = Color.Gainsboro;
                                    button8.Enabled = false;
                                    button9.Enabled = false;
                                    button10.Enabled = false;
                                    button11.Enabled = false;
                                    button16.Enabled = true;
                                }
                                else
                                {
                                    MessageBox.Show("超出移動範圍", "", MessageBoxButtons.OK);
                                    move = 0;
                                }
                            }
                            break;
                        case 1:
                            _position = 0;
                            for (int i = 0; i < 42; i++)
                            {
                                if ((b[i].Text == "法師") && (b[i].BackColor == Color.LightBlue))
                                {
                                    _position = i;
                                    break;
                                }
                            }
                            if (_position > index)
                            {
                                if (((_position - index) <= casters[0].moveRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= casters[0].moveRange)))
                                {
                                    b[index].Text = b[_position].Text;
                                    b[index].BackColor = b[_position].BackColor;
                                    b[_position].Text = "";
                                    b[_position].BackColor = Color.Gainsboro;
                                    button8.Enabled = false;
                                    button9.Enabled = false;
                                    button10.Enabled = false;
                                    button11.Enabled = false;
                                    button16.Enabled = true;
                                }
                                else
                                {
                                    MessageBox.Show("超出移動範圍", "", MessageBoxButtons.OK);
                                    move = 0;
                                }
                            }
                            else
                            {
                                if (((index - _position) <= casters[0].moveRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= casters[0].moveRange)))
                                {
                                    b[index].Text = b[_position].Text;
                                    b[index].BackColor = b[_position].BackColor;
                                    b[_position].Text = "";
                                    b[_position].BackColor = Color.Gainsboro;
                                    button8.Enabled = false;
                                    button9.Enabled = false;
                                    button10.Enabled = false;
                                    button11.Enabled = false;
                                    button16.Enabled = true;
                                }
                                else
                                {
                                    MessageBox.Show("超出移動範圍", "", MessageBoxButtons.OK);
                                    move = 0;
                                }
                            }
                            break;
                        case 2:
                            _position = 0;
                            for (int i = 0; i < 42; i++)
                            {
                                if ((b[i].Text == "遊俠") && (b[i].BackColor == Color.LightBlue))
                                {
                                    _position = i;
                                    break;
                                }
                            }
                            if (_position > index)
                            {
                                if (((_position - index) <= rangers[0].moveRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= rangers[0].moveRange)))
                                {
                                    b[index].Text = b[_position].Text;
                                    b[index].BackColor = b[_position].BackColor;
                                    b[_position].Text = "";
                                    b[_position].BackColor = Color.Gainsboro;
                                    button8.Enabled = false;
                                    button9.Enabled = false;
                                    button10.Enabled = false;
                                    button11.Enabled = false;
                                    button16.Enabled = true;
                                }
                                else
                                {
                                    MessageBox.Show("超出移動範圍", "", MessageBoxButtons.OK);
                                    move = 0;
                                }
                            }
                            else
                            {
                                if (((index - _position) <= rangers[0].moveRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= rangers[0].moveRange)))
                                {
                                    b[index].Text = b[_position].Text;
                                    b[index].BackColor = b[_position].BackColor;
                                    b[_position].Text = "";
                                    b[_position].BackColor = Color.Gainsboro;
                                    button8.Enabled = false;
                                    button9.Enabled = false;
                                    button10.Enabled = false;
                                    button11.Enabled = false;
                                    button16.Enabled = true;
                                }
                                else
                                {
                                    MessageBox.Show("超出移動範圍", "", MessageBoxButtons.OK);
                                    move = 0;
                                }
                            }
                            break;
                        case 3:
                            _position = 0;
                            for (int i = 0; i < 42; i++)
                            {
                                if ((b[i].Text == "戰士") && (b[i].BackColor == Color.LightPink))
                                {
                                    _position = i;
                                    break;
                                }
                            }
                            if (_position > index)
                            {
                                if (((_position - index) <= warriors[1].moveRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= warriors[1].moveRange)))
                                {
                                    b[index].Text = b[_position].Text;
                                    b[index].BackColor = b[_position].BackColor;
                                    b[_position].Text = "";
                                    b[_position].BackColor = Color.Gainsboro;
                                    button12.Enabled = false;
                                    button13.Enabled = false;
                                    button14.Enabled = false;
                                    button15.Enabled = false;
                                    button17.Enabled = true;
                                }
                                else
                                {
                                    MessageBox.Show("超出移動範圍", "", MessageBoxButtons.OK);
                                    move = 0;
                                }
                            }
                            else
                            {
                                if (((index - _position) <= warriors[1].moveRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= warriors[1].moveRange)))
                                {
                                    b[index].Text = b[_position].Text;
                                    b[index].BackColor = b[_position].BackColor;
                                    b[_position].Text = "";
                                    b[_position].BackColor = Color.Gainsboro;
                                    button12.Enabled = false;
                                    button13.Enabled = false;
                                    button14.Enabled = false;
                                    button15.Enabled = false;
                                    button17.Enabled = true;
                                }
                                else
                                {
                                    MessageBox.Show("超出移動範圍", "", MessageBoxButtons.OK);
                                    move = 0;
                                }
                            }
                            break;
                        case 4:
                            _position = 0;
                            for (int i = 0; i < 42; i++)
                            {
                                if ((b[i].Text == "法師") && (b[i].BackColor == Color.LightPink))
                                {
                                    _position = i;
                                    break;
                                }
                            }
                            if (_position > index)
                            {
                                if (((_position - index) <= casters[1].moveRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= casters[1].moveRange)))
                                {
                                    b[index].Text = b[_position].Text;
                                    b[index].BackColor = b[_position].BackColor;
                                    b[_position].Text = "";
                                    b[_position].BackColor = Color.Gainsboro;
                                    button12.Enabled = false;
                                    button13.Enabled = false;
                                    button14.Enabled = false;
                                    button15.Enabled = false;
                                    button17.Enabled = true;
                                }
                                else
                                {
                                    MessageBox.Show("超出移動範圍", "", MessageBoxButtons.OK);
                                    move = 0;
                                }
                            }
                            else
                            {
                                if (((index - _position) <= casters[1].moveRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= casters[1].moveRange)))
                                {
                                    b[index].Text = b[_position].Text;
                                    b[index].BackColor = b[_position].BackColor;
                                    b[_position].Text = "";
                                    b[_position].BackColor = Color.Gainsboro;
                                    button12.Enabled = false;
                                    button13.Enabled = false;
                                    button14.Enabled = false;
                                    button15.Enabled = false;
                                    button17.Enabled = true;
                                }
                                else
                                {
                                    MessageBox.Show("超出移動範圍", "", MessageBoxButtons.OK);
                                    move = 0;
                                }
                            }
                            break;
                        case 5:
                            _position = 0;
                            for (int i = 0; i < 42; i++)
                            {
                                if ((b[i].Text == "遊俠") && (b[i].BackColor == Color.LightPink))
                                {
                                    _position = i;
                                    break;
                                }
                            }
                            if (_position > index)
                            {
                                if (((_position - index) <= rangers[1].moveRange) || (((_position - index) % 6 == 0) && ((_position - index) / 6 <= rangers[1].moveRange)))
                                {
                                    b[index].Text = b[_position].Text;
                                    b[index].BackColor = b[_position].BackColor;
                                    b[_position].Text = "";
                                    b[_position].BackColor = Color.Gainsboro;
                                    button12.Enabled = false;
                                    button13.Enabled = false;
                                    button14.Enabled = false;
                                    button15.Enabled = false;
                                    button17.Enabled = true;
                                }
                                else
                                {
                                    MessageBox.Show("超出移動範圍", "", MessageBoxButtons.OK);
                                    move = 0;
                                }
                            }
                            else
                            {
                                if (((index - _position) <= rangers[1].moveRange) || (((index - _position) % 6 == 0) && ((index - _position) / 6 <= rangers[1].moveRange)))
                                {
                                    b[index].Text = b[_position].Text;
                                    b[index].BackColor = b[_position].BackColor;
                                    b[_position].Text = "";
                                    b[_position].BackColor = Color.Gainsboro;
                                    button12.Enabled = false;
                                    button13.Enabled = false;
                                    button14.Enabled = false;
                                    button15.Enabled = false;
                                    button17.Enabled = true;
                                }
                                else
                                {
                                    MessageBox.Show("超出移動範圍", "", MessageBoxButtons.OK);
                                    move = 0;
                                }
                            }
                            break;
                    }
                }
            }
        }

        public void game()
        {
            //初始化棋子
            for(int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    warriors[i] = new Chess_warrior();
                    warriors[i].set("戰士", 100, 15, 30, 1, 2);
                    casters[i] = new Chess_caster();
                    casters[i].set("法師", 70, 25, 20, 2, 2);
                    rangers[i] = new Chess_ranger();
                    rangers[i].set("遊俠", 90, 10, 30, 3, 1);
                }
                else
                {
                    warriors[i] = new Chess_warrior();
                    warriors[i].set("戰士", 100, 15, 30, 1, 2);
                    casters[i] = new Chess_caster();
                    casters[i].set("法師", 70, 25, 20, 2, 2);
                    rangers[i] = new Chess_ranger();
                    rangers[i].set("遊俠", 90, 10, 30, 3, 1);
                }
            }
            for(int i = 0; i < 42; i++) {
                b[i].Click -= new EventHandler(b1_Click);
                b[i].Click += new EventHandler(b2_Click);
            }
            change_turn();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            move = 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            move = 2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            move = 3;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            move = 0;
            turn++;
            change_turn();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            move = 1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            move = 2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            move = 3;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            move = 0;
            turn++;
            change_turn();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            move = 4;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button17.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            move = 4;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button16.Enabled = true;
        }

        public void change_turn()
        {
            if (P1_chess == 0)
            {
                if (MessageBox.Show("P2 贏了", "", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            else if (P2_chess == 0)
            {
                if (MessageBox.Show("P1 贏了", "", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            check:
            turn = turn % 6;
            switch (turn)
            {
                case 0:
                    if (warriors[0].hp <= 0)
                    {
                        turn++;
                        goto check;
                    }
                    break;
                case 1:
                    if (casters[0].hp <= 0)
                    {
                        turn++;
                        goto check;
                    }
                    break;
                case 2:
                    if (rangers[0].hp <= 0)
                    {
                        turn++;
                        goto check;
                    }
                    break;
                case 3:
                    if (warriors[1].hp <= 0)
                    {
                        turn++;
                        goto check;
                    }
                    break;
                case 4:
                    if (casters[1].hp <= 0)
                    {
                        turn++;
                        goto check;
                    }
                    break;
                case 5:
                    if (rangers[1].hp <= 0)
                    {
                        turn++;
                        goto check;
                    }
                    break;
            }
            switch (turn)
            {
                case 0:
                    label1.Text = "P1 Turn";
                    label4.Text = "P2";
                    label6.Text = "";
                    label3.Text = "P1" + "\r\n" + "戰士";
                    button8.Enabled = true;
                    button9.Enabled = true;
                    button10.Enabled = true;
                    button11.Enabled = true;
                    button16.Enabled = false;
                    button12.Enabled = false;
                    button13.Enabled = false;
                    button14.Enabled = false;
                    button15.Enabled = false;
                    button17.Enabled = false;
                    label5.Text = "HP:" + warriors[0].hp.ToString() + "\r\n" +
                                "MP:" + warriors[0].mp.ToString() + "\r\n" +
                                "ATK:" + warriors[0].atk.ToString() + "\r\n" +
                                "ATK Range:" + warriors[0].atkRange.ToString() + "\r\n" +
                                "MOVE Range:" + warriors[0].moveRange.ToString() + "\r\n";
                    break;
                case 1:
                    label3.Text = "P1" + "\r\n" + "法師";
                    label4.Text = "P2";
                    label6.Text = "";
                    button8.Enabled = true;
                    button9.Enabled = true;
                    button10.Enabled = true;
                    button11.Enabled = true;
                    button16.Enabled = false;
                    button12.Enabled = false;
                    button13.Enabled = false;
                    button14.Enabled = false;
                    button15.Enabled = false;
                    button17.Enabled = false;
                    label5.Text = "HP:" + casters[0].hp.ToString() + "\r\n" +
                                "MP:" + casters[0].mp.ToString() + "\r\n" +
                                "ATK:" + casters[0].atk.ToString() + "\r\n" +
                                "ATK Range:" + casters[0].atkRange.ToString() + "\r\n" +
                                "MOVE Range:" + casters[0].moveRange.ToString() + "\r\n";
                    break;
                case 2:
                    label3.Text = "P1" + "\r\n" + "遊俠";
                    label4.Text = "P2";
                    label6.Text = "";
                    button8.Enabled = true;
                    button9.Enabled = true;
                    button10.Enabled = true;
                    button11.Enabled = true;
                    button16.Enabled = false;
                    button12.Enabled = false;
                    button13.Enabled = false;
                    button14.Enabled = false;
                    button15.Enabled = false;
                    button17.Enabled = false;
                    label5.Text = "HP:" + rangers[0].hp.ToString() + "\r\n" +
                                "MP:" + rangers[0].mp.ToString() + "\r\n" +
                                "ATK:" + rangers[0].atk.ToString() + "\r\n" +
                                "ATK Range:" + rangers[0].atkRange.ToString() + "\r\n" +
                                "MOVE Range:" + rangers[0].moveRange.ToString() + "\r\n";
                    break;
                case 3:
                    label1.Text = "P2 Turn";
                    label3.Text = "P1";
                    label5.Text = "";
                    label4.Text = "P2" + "\r\n" + "戰士";
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button10.Enabled = false;
                    button11.Enabled = false;
                    button16.Enabled = false;
                    button12.Enabled = true;
                    button13.Enabled = true;
                    button14.Enabled = true;
                    button15.Enabled = true;
                    button17.Enabled = false;
                    label6.Text = "HP:" + warriors[1].hp.ToString() + "\r\n" +
                                "MP:" + warriors[1].mp.ToString() + "\r\n" +
                                "ATK:" + warriors[1].atk.ToString() + "\r\n" +
                                "ATK Range:" + warriors[1].atkRange.ToString() + "\r\n" +
                                "MOVE Range:" + warriors[1].moveRange.ToString() + "\r\n";
                    break;
                case 4:
                    label4.Text = "P2" + "\r\n" + "法師";
                    label3.Text = "P1";
                    label5.Text = "";
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button10.Enabled = false;
                    button11.Enabled = false;
                    button16.Enabled = false;
                    button12.Enabled = true;
                    button13.Enabled = true;
                    button14.Enabled = true;
                    button15.Enabled = true;
                    button17.Enabled = false;
                    label6.Text = "HP:" + casters[1].hp.ToString() + "\r\n" +
                                "MP:" + casters[1].mp.ToString() + "\r\n" +
                                "ATK:" + casters[1].atk.ToString() + "\r\n" +
                                "ATK Range:" + casters[1].atkRange.ToString() + "\r\n" +
                                "MOVE Range:" + casters[1].moveRange.ToString() + "\r\n";
                    break;
                case 5:
                    label4.Text = "P2" + "\r\n" + "遊俠";
                    label3.Text = "P1";
                    label5.Text = "";
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button10.Enabled = false;
                    button11.Enabled = false;
                    button16.Enabled = false;
                    button12.Enabled = true;
                    button13.Enabled = true;
                    button14.Enabled = true;
                    button15.Enabled = true;
                    button17.Enabled = false;
                    label6.Text = "HP:" + rangers[1].hp.ToString() + "\r\n" +
                                "MP:" + rangers[1].mp.ToString() + "\r\n" +
                                "ATK:" + rangers[1].atk.ToString() + "\r\n" +
                                "ATK Range:" + rangers[1].atkRange.ToString() + "\r\n" +
                                "MOVE Range:" + rangers[1].moveRange.ToString() + "\r\n";
                    break;
            }
        }
    }
}
