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

namespace Homework6_2
{
    public partial class Form1 : Form
    {
        Button[] key = new Button[15];
        int check = 0;
        int keydown_check = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MediaPlayer1.Visible = false;
            MediaPlayer2.Visible = false;
            for (int i = 0; i < 15; i++)
            {
                key[i] = new Button();
                key[i].SetBounds(210 + 50 * (i%3), 60 + 50 * (i/3), 40, 40);
                tabPage1.Controls.Add(key[i]);
                key[i].MouseDown += new MouseEventHandler(key_mousedown);
                key[i].MouseUp += new MouseEventHandler(key_mouseup);
                key[i].Image = imageList1.Images[i];
            }
        }

        public void key_mousedown(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int key_num = ((int)btn.TabIndex) - 3;

            switch (key_num)
            {
                case 0:
                    if (label1.Text == "Telephone" || label1.Text == "") { label1.Text = "1"; }
                    else { label1.Text += "1"; }
                    MediaPlayer1.URL = @"697.wav";
                    MediaPlayer2.URL = @"1209.wav";
                    MediaPlayer1.settings.setMode("loop", true);
                    MediaPlayer2.settings.setMode("loop", true);
                    MediaPlayer1.Ctlcontrols.play();
                    MediaPlayer2.Ctlcontrols.play();
                    break;
                case 1:
                    if (label1.Text == "Telephone" || label1.Text == "") { label1.Text = "2"; }
                    else { label1.Text += "2"; }
                    MediaPlayer1.URL = @"697.wav";
                    MediaPlayer2.URL = @"1336.wav";
                    MediaPlayer1.settings.setMode("loop", true);
                    MediaPlayer2.settings.setMode("loop", true);
                    MediaPlayer1.Ctlcontrols.play();
                    MediaPlayer2.Ctlcontrols.play();
                    break;
                case 2:
                    if (label1.Text == "Telephone" || label1.Text == "") { label1.Text = "3"; }
                    else { label1.Text += "3"; }
                    MediaPlayer1.URL = @"697.wav";
                    MediaPlayer2.URL = @"1477.wav";
                    MediaPlayer1.settings.setMode("loop", true);
                    MediaPlayer2.settings.setMode("loop", true);
                    MediaPlayer1.Ctlcontrols.play();
                    MediaPlayer2.Ctlcontrols.play();
                    break;
                case 3:
                    if (label1.Text == "Telephone" || label1.Text == "") { label1.Text = "4"; }
                    else { label1.Text += "4"; }
                    MediaPlayer1.URL = @"770.wav";
                    MediaPlayer2.URL = @"1209.wav";
                    MediaPlayer1.settings.setMode("loop", true);
                    MediaPlayer2.settings.setMode("loop", true);
                    MediaPlayer1.Ctlcontrols.play();
                    MediaPlayer2.Ctlcontrols.play();
                    break;
                case 4:
                    if (label1.Text == "Telephone" || label1.Text == "") { label1.Text = "5"; }
                    else { label1.Text += "5"; }
                    MediaPlayer1.URL = @"770.wav";
                    MediaPlayer2.URL = @"1336.wav";
                    MediaPlayer1.settings.setMode("loop", true);
                    MediaPlayer2.settings.setMode("loop", true);
                    MediaPlayer1.Ctlcontrols.play();
                    MediaPlayer2.Ctlcontrols.play();
                    break;
                case 5:
                    if (label1.Text == "Telephone" || label1.Text == "") { label1.Text = "6"; }
                    else { label1.Text += "6"; }
                    MediaPlayer1.URL = @"770.wav";
                    MediaPlayer2.URL = @"1477.wav";
                    MediaPlayer1.settings.setMode("loop", true);
                    MediaPlayer2.settings.setMode("loop", true);
                    MediaPlayer1.Ctlcontrols.play();
                    MediaPlayer2.Ctlcontrols.play();
                    break;
                case 6:
                    if (label1.Text == "Telephone" || label1.Text == "") { label1.Text = "7"; }
                    else { label1.Text += "7"; }
                    MediaPlayer1.URL = @"852.wav";
                    MediaPlayer2.URL = @"1209.wav";
                    MediaPlayer1.settings.setMode("loop", true);
                    MediaPlayer2.settings.setMode("loop", true);
                    MediaPlayer1.Ctlcontrols.play();
                    MediaPlayer2.Ctlcontrols.play();
                    break;
                case 7:
                    if (label1.Text == "Telephone" || label1.Text == "") { label1.Text = "8"; }
                    else { label1.Text += "8"; }
                    MediaPlayer1.URL = @"852.wav";
                    MediaPlayer2.URL = @"1336.wav";
                    MediaPlayer1.settings.setMode("loop", true);
                    MediaPlayer2.settings.setMode("loop", true);
                    MediaPlayer1.Ctlcontrols.play();
                    MediaPlayer2.Ctlcontrols.play();
                    break;
                case 8:
                    if (label1.Text == "Telephone" || label1.Text == "") { label1.Text = "9"; }
                    else { label1.Text += "9"; }
                    MediaPlayer1.URL = @"852.wav";
                    MediaPlayer2.URL = @"1477.wav";
                    MediaPlayer1.settings.setMode("loop", true);
                    MediaPlayer2.settings.setMode("loop", true);
                    MediaPlayer1.Ctlcontrols.play();
                    MediaPlayer2.Ctlcontrols.play();
                    break;
                case 9:
                    if (label1.Text == "Telephone" || label1.Text == "") { label1.Text = "*"; }
                    else { label1.Text += "*"; }
                    MediaPlayer1.URL = @"941.wav";
                    MediaPlayer2.URL = @"1209.wav";
                    MediaPlayer1.settings.setMode("loop", true);
                    MediaPlayer2.settings.setMode("loop", true);
                    MediaPlayer1.Ctlcontrols.play();
                    MediaPlayer2.Ctlcontrols.play();
                    break;
                case 10:
                    if (label1.Text == "Telephone" || label1.Text == "") { label1.Text = "0"; }
                    else { label1.Text += "0"; }
                    MediaPlayer1.URL = @"941.wav";
                    MediaPlayer2.URL = @"1336.wav";
                    MediaPlayer1.settings.setMode("loop", true);
                    MediaPlayer2.settings.setMode("loop", true);
                    MediaPlayer1.Ctlcontrols.play();
                    MediaPlayer2.Ctlcontrols.play();
                    break;
                case 11:
                    if (label1.Text == "Telephone" || label1.Text == "") { label1.Text = "#"; }
                    else { label1.Text += "#"; }
                    MediaPlayer1.URL = @"941.wav";
                    MediaPlayer2.URL = @"1477.wav";
                    MediaPlayer1.settings.setMode("loop", true);
                    MediaPlayer2.settings.setMode("loop", true);
                    MediaPlayer1.Ctlcontrols.play();
                    MediaPlayer2.Ctlcontrols.play();
                    break;
                case 12:
                    label1.Text = "";
                    break;
                case 13:
                    if (check == 0)
                    {
                        label3.Text = label3.Text + label1.Text + "\r\n";
                        for (int i = 0; i < 15; i++)
                        {
                            if (i != 13) { key[i].Enabled = false; }
                            else { key[i].Image = imageList1.Images[15]; }
                        }
                        check = 1;
                    }
                    else
                    {
                        label1.Text = "Telephone";
                        for (int i = 0; i < 15; i++)
                        {
                            if (i != 13) { key[i].Enabled = true; }
                            else { key[i].Image = imageList1.Images[13]; }
                        }
                        check = 0;
                    }
                    break;
                case 14:
                    if (label1.Text != "Telephone")
                    {
                        if (label1.Text != "") { label1.Text = label1.Text.Substring(0, label1.Text.Length - 1); }
                    }
                    break;
                default:
                    break;
            }
        }
        public void key_mouseup(object sender, EventArgs e)
        {
            tabControl1.Focus();
            MediaPlayer1.Ctlcontrols.stop();
            MediaPlayer2.Ctlcontrols.stop();
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (keydown_check == 0 && tabControl1.SelectedIndex==0)
            {
                if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
                {
                    keydown_check = 1;
                    if (label1.Text == "Telephone" || label1.Text == "") { label1.Text = "0"; }
                    else { label1.Text += "0"; }
                    MediaPlayer1.URL = @"941.wav";
                    MediaPlayer2.URL = @"1336.wav";
                    MediaPlayer1.settings.setMode("loop", true);
                    MediaPlayer2.settings.setMode("loop", true);
                    MediaPlayer1.Ctlcontrols.play();
                    MediaPlayer2.Ctlcontrols.play();
                }
                if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
                {
                    keydown_check = 1;
                    if (label1.Text == "Telephone" || label1.Text == "") { label1.Text = "1"; }
                    else { label1.Text += "1"; }
                    MediaPlayer1.URL = @"697.wav";
                    MediaPlayer2.URL = @"1209.wav";
                    MediaPlayer1.settings.setMode("loop", true);
                    MediaPlayer2.settings.setMode("loop", true);
                    MediaPlayer1.Ctlcontrols.play();
                    MediaPlayer2.Ctlcontrols.play();
                }
                if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
                {
                    keydown_check = 1;
                    if (label1.Text == "Telephone" || label1.Text == "") { label1.Text = "2"; }
                    else { label1.Text += "2"; }
                    MediaPlayer1.URL = @"697.wav";
                    MediaPlayer2.URL = @"1336.wav";
                    MediaPlayer1.settings.setMode("loop", true);
                    MediaPlayer2.settings.setMode("loop", true);
                    MediaPlayer1.Ctlcontrols.play();
                    MediaPlayer2.Ctlcontrols.play();
                }
                if ((e.Shift == false && e.KeyCode == Keys.D3) || (e.Shift == false && e.KeyCode == Keys.NumPad3))
                {
                    keydown_check = 1;
                    if (label1.Text == "Telephone" || label1.Text == "") { label1.Text = "3"; }
                    else { label1.Text += "3"; }
                    MediaPlayer1.URL = @"697.wav";
                    MediaPlayer2.URL = @"1477.wav";
                    MediaPlayer1.settings.setMode("loop", true);
                    MediaPlayer2.settings.setMode("loop", true);
                    MediaPlayer1.Ctlcontrols.play();
                    MediaPlayer2.Ctlcontrols.play();
                }
                if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
                {
                    keydown_check = 1;
                    if (label1.Text == "Telephone" || label1.Text == "") { label1.Text = "4"; }
                    else { label1.Text += "4"; }
                    MediaPlayer1.URL = @"770.wav";
                    MediaPlayer2.URL = @"1209.wav";
                    MediaPlayer1.settings.setMode("loop", true);
                    MediaPlayer2.settings.setMode("loop", true);
                    MediaPlayer1.Ctlcontrols.play();
                    MediaPlayer2.Ctlcontrols.play();
                }
                if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
                {
                    keydown_check = 1;
                    if (label1.Text == "Telephone" || label1.Text == "") { label1.Text = "5"; }
                    else { label1.Text += "5"; }
                    MediaPlayer1.URL = @"770.wav";
                    MediaPlayer2.URL = @"1336.wav";
                    MediaPlayer1.settings.setMode("loop", true);
                    MediaPlayer2.settings.setMode("loop", true);
                    MediaPlayer1.Ctlcontrols.play();
                    MediaPlayer2.Ctlcontrols.play();
                }
                if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
                {
                    keydown_check = 1;
                    if (label1.Text == "Telephone" || label1.Text == "") { label1.Text = "6"; }
                    else { label1.Text += "6"; }
                    MediaPlayer1.URL = @"770.wav";
                    MediaPlayer2.URL = @"1477.wav";
                    MediaPlayer1.settings.setMode("loop", true);
                    MediaPlayer2.settings.setMode("loop", true);
                    MediaPlayer1.Ctlcontrols.play();
                    MediaPlayer2.Ctlcontrols.play();
                }
                if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
                {
                    keydown_check = 1;
                    if (label1.Text == "Telephone" || label1.Text == "") { label1.Text = "7"; }
                    else { label1.Text += "7"; }
                    MediaPlayer1.URL = @"852.wav";
                    MediaPlayer2.URL = @"1209.wav";
                    MediaPlayer1.settings.setMode("loop", true);
                    MediaPlayer2.settings.setMode("loop", true);
                    MediaPlayer1.Ctlcontrols.play();
                    MediaPlayer2.Ctlcontrols.play();
                }
                if ((e.Shift == false && e.KeyCode == Keys.D8) ||(e.Shift == false && e.KeyCode == Keys.NumPad8))
                {
                    keydown_check = 1;
                    if (label1.Text == "Telephone" || label1.Text == "") { label1.Text = "8"; }
                    else { label1.Text += "8"; }
                    MediaPlayer1.URL = @"852.wav";
                    MediaPlayer2.URL = @"1336.wav";
                    MediaPlayer1.settings.setMode("loop", true);
                    MediaPlayer2.settings.setMode("loop", true);
                    MediaPlayer1.Ctlcontrols.play();
                    MediaPlayer2.Ctlcontrols.play();
                }
                if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
                {
                    keydown_check = 1;
                    if (label1.Text == "Telephone" || label1.Text == "") { label1.Text = "9"; }
                    else { label1.Text += "9"; }
                    MediaPlayer1.URL = @"852.wav";
                    MediaPlayer2.URL = @"1477.wav";
                    MediaPlayer1.settings.setMode("loop", true);
                    MediaPlayer2.settings.setMode("loop", true);
                    MediaPlayer1.Ctlcontrols.play();
                    MediaPlayer2.Ctlcontrols.play();
                }
                if (e.Shift == true && e.KeyCode == Keys.D8)
                {
                    keydown_check = 2;
                    if (label1.Text == "Telephone" || label1.Text == "") { label1.Text = "*"; }
                    else { label1.Text += "*"; }
                    MediaPlayer1.URL = @"941.wav";
                    MediaPlayer2.URL = @"1209.wav";
                    MediaPlayer1.settings.setMode("loop", true);
                    MediaPlayer2.settings.setMode("loop", true);
                    MediaPlayer1.Ctlcontrols.play();
                    MediaPlayer2.Ctlcontrols.play();
                }
                if (e.Shift==true && e.KeyCode == Keys.D3)
                {
                    keydown_check = 2;
                    if (label1.Text == "Telephone" || label1.Text == "") { label1.Text = "#"; }
                    else { label1.Text += "#"; }
                    MediaPlayer1.URL = @"941.wav";
                    MediaPlayer2.URL = @"1477.wav";
                    MediaPlayer1.settings.setMode("loop", true);
                    MediaPlayer2.settings.setMode("loop", true);
                    MediaPlayer1.Ctlcontrols.play();
                    MediaPlayer2.Ctlcontrols.play();
                }
                if (e.KeyCode == Keys.Back)
                {
                    keydown_check = 1;
                    if (label1.Text != "Telephone")
                    {
                        if (label1.Text != "") { label1.Text = label1.Text.Substring(0, label1.Text.Length - 1); }
                    }
                }
                if (e.KeyCode == Keys.Enter)
                {
                    keydown_check = 1;
                    if (check == 0)
                    {
                        label3.Text = label3.Text + label1.Text + "\r\n";
                        for (int i = 0; i < 15; i++)
                        {
                            if (i != 13) { key[i].Enabled = false; }
                            else { key[i].Image = imageList1.Images[15]; }
                        }
                        check = 1;
                    }
                    else
                    {
                        label1.Text = "Telephone";
                        for (int i = 0; i < 15; i++)
                        {
                            if (i != 13) { key[i].Enabled = true; }
                            else { key[i].Image = imageList1.Images[13]; }
                        }
                        check = 0;
                    }
                }
            }
        }

        private void tabControl1_KeyUp(object sender, KeyEventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                keydown_check--;
                MediaPlayer1.Ctlcontrols.stop();
                MediaPlayer2.Ctlcontrols.stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Empty String","", MessageBoxButtons.OK);
            }
            else
            {
                if (File.Exists(textBox1.Text))
                {
                    FileInfo info = new FileInfo(textBox1.Text);
                    StreamWriter writer = info.CreateText();
                    writer.Write(label3.Text);
                    MessageBox.Show("Done\r\n"+ info.FullName, "", MessageBoxButtons.OK);
                    writer.Flush();
                    writer.Close();
                }
                else
                {
                    MessageBox.Show("Directory Not Found", "", MessageBoxButtons.OK);
                }
            }
        }
    }
}
