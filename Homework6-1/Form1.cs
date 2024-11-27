using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
namespace Homework6_1
{
    public partial class Form1 : Form
    {
        Button[] light = new Button[8];
        SoundPlayer ding = new SoundPlayer();
        SoundPlayer dong = new SoundPlayer();
        SoundPlayer doo = new SoundPlayer();
        int check = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 8; i++)
            {
                light[i] = new Button();
                light[i].SetBounds(118+ 50 * i, 110,40,40);
                Controls.Add(light[i]);
                if (i % 2 == 1)
                {
                    light[i].Visible = false;
                }
            }
            trackBar1.Minimum = 60;
            trackBar1.Maximum = 180;
            trackBar1.Value = 120;
            timer1.Enabled = false;
            timer1.Interval = 60 * 1000 / trackBar1.Value;
            radioButton1.Checked = true;
            ding.SoundLocation = "ding.wav";
            dong.SoundLocation = "dong.wav";
            doo.SoundLocation = "doo.wav";
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true) { timer1.Interval = 60 * 1000 / trackBar1.Value / 2; }
            else { timer1.Interval = 60 * 1000 / trackBar1.Value; }
            label1.Text = trackBar1.Value.ToString() + " BPM";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check == 0)
            {
                button1.Text = "Stop";
                check = 1;
                timer1.Enabled = true;
            }
            else
            {
                button1.Text = "Start";
                check = 0;
                timer1.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "4")
            {
                for(int i = 0; i < 8; i++)
                {
                    if (i % 2 == 1)
                    {
                        light[i].Visible = false;
                    }
                    else
                    {
                        light[i].Visible = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 8; i++)
                {
                    light[i].Visible = true;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                timer1.Interval = 60 * 1000 / trackBar1.Value;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                timer1.Interval = 60 * 1000 / trackBar1.Value /2;
            }
        }
        int index_before = 0;
        int index_after = 0;
        int beat = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                if (beat == 1)
                {
                    light[index_before].BackColor = Color.Gainsboro;
                    light[index_after].BackColor = Color.LightGreen;
                    if (comboBox1.Text == "4")
                    {
                        index_before = index_after;
                        index_after += 2;
                        if (index_after > 6) { index_after = 0; }
                    }
                    else
                    {
                        index_before = index_after;
                        index_after += 1;
                        if (index_after > 7) { index_after = 0; }
                    }
                    if (index_before == 0) {
                        ding.Play();
                    }
                    else
                    { 
                        dong.Play();
                    }
                    beat = (beat + 1) % 2;
                }
                else
                {
                    doo.Play();
                    beat = (beat + 1) % 2;
                }
            }
            else
            {
                light[index_before].BackColor = Color.Gainsboro;
                light[index_after].BackColor = Color.LightGreen;
                if (comboBox1.Text == "4")
                {
                    index_before = index_after;
                    index_after += 2;
                    if (index_after > 6) { index_after = 0; }
                }
                else
                {
                    index_before = index_after;
                    index_after += 1;
                    if (index_after > 7) { index_after = 0; }
                }
                if (index_before == 0) { ding.Play(); }
                else { dong.Play(); }
            }

        }
    }
}
