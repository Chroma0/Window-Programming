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

namespace Homework7
{
    public partial class Form1 : Form
    {
        public string route = "";
        public string record = "";
        public string record2 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Visible = false;
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            route = "";
            this.Text = "未命名*-待辦清單";
        }

        private void 開啟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "開啟";
            dialog.Filter = "Todo Files(*.todo)|*.todo|Text Files(*.txt)|*.txt|All File(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                route = dialog.FileName;
                textBox1.Text = "";
                this.Text = Path.GetFileNameWithoutExtension(route) + "-待辦清單";
                StreamReader str = new StreamReader(route);
                string text = str.ReadLine();
                while(text != null)
                {
                    char check = char.Parse(text.Substring(0, 1));
                    if (check == '+')
                    {
                        textBox1.Text += " [√] " + text.Substring(1, text.Length - 1) + "\r\n";
                    }
                    else
                    {
                        textBox1.Text += " [ ] " + text.Substring(1, text.Length - 1) + "\r\n";
                    }
                    text = str.ReadLine();
                }
                str.Close();
                record = textBox1.Text;
            }
        }

        private void 儲存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (route != "")
            {
                StreamWriter str = new StreamWriter(route);
                StringReader sr = new StringReader(textBox1.Text);
                string text = sr.ReadLine();
                while(text != null)
                {
                    if (text.Substring(2, 1) == " ")
                    {
                        str.Write("-" + text.Substring(5, text.Length - 5)+"\r\n");
                    }
                    else
                    {
                        str.Write("+" + text.Substring(5, text.Length - 5)+"\r\n");
                    }
                    text = sr.ReadLine();
                }
                sr.Close();
                str.Close();
            }
            else
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Title = "另存新檔";
                dialog.Filter = "Todo Files(*.todo)|*.todo|Text Files(*.txt)|*.txt|All File(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    route = dialog.FileName;
                    this.Text = Path.GetFileNameWithoutExtension(route) + "-待辦清單";
                    StreamWriter str = new StreamWriter(route);
                    StringReader sr = new StringReader(textBox1.Text);
                    string text = sr.ReadLine();
                    while (text != null)
                    {
                        if (text.Substring(2, 1) == " ")
                        {
                            str.Write("-" + text.Substring(5, text.Length - 5)+"\r\n");
                        }
                        else
                        {
                            str.Write("+" + text.Substring(5, text.Length - 5)+"\r\n");
                        }
                        text = sr.ReadLine();
                    }
                    sr.Close();
                    str.Close();
                }
            }
        }

        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "另存新檔";
            dialog.Filter = "Todo Files(*.todo)|*.todo|Text Files(*.txt)|*.txt|All File(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                route = dialog.FileName;
                this.Text = Path.GetFileNameWithoutExtension(route) + "-待辦清單";
                StreamWriter str = new StreamWriter(route);
                StringReader sr = new StringReader(textBox1.Text);
                string text = sr.ReadLine();
                while (text != null)
                {
                    if (text.Substring(2, 1) == " ")
                    {
                        str.Write("-" + text.Substring(5, text.Length - 5)+"\r\n");
                    }
                    else
                    {
                        str.Write("+" + text.Substring(5, text.Length - 5)+"\r\n");
                    }
                    text = sr.ReadLine();
                }
                sr.Close();
                str.Close();
            }
        }

        private void 離開ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 字型大小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = dialog.Font;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Enabled = false;
            f2.Text = "新增待辦事項";
            f2.ShowDialog();
            if (f2.DialogResult == DialogResult.Cancel)
            {
                this.Enabled = true;
            }
            else if (f2.DialogResult == DialogResult.OK && (f2.new_event != ""))
            {
                textBox1.Text += " [ ] " + f2.new_event + "\r\n";
                record += " [ ] " + f2.new_event + "\r\n";
                this.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Enabled = false;
            f2.Text = "待辦事項";
            f2.ShowDialog();
            if (f2.DialogResult == DialogResult.Cancel)
            {
                this.Enabled = true;
            }
            else if (f2.DialogResult == DialogResult.OK && (f2.new_event != ""))
            {
                StringReader sr = new StringReader(textBox1.Text);
                string text = sr.ReadLine();
                int line_count = 0;
                string[] replace_str = new string[textBox1.Lines.Length];
                while (text != null)
                {
                    if (text.Substring(5, text.Length - 5) == f2.new_event)
                    { 
                        replace_str[line_count] = " [√] " + f2.new_event;
                    }
                    else
                    {
                        replace_str[line_count] = text;
                    }
                    text = sr.ReadLine();
                    line_count++;
                }
                textBox1.Lines = replace_str;
                sr.Close();
                this.Enabled = true;
                StringReader _sr = new StringReader(record);
                text = _sr.ReadLine();
                string replace_string = "";
                while (text != null)
                {
                    if (text.Substring(5, text.Length - 5) == f2.new_event)
                    {
                        replace_string += " [√] " + f2.new_event + "\r\n";
                    }
                    else
                    {
                        replace_string += text + "\r\n";
                    }
                    text = _sr.ReadLine();
                }
                record = replace_string;
                sr.Close();
            }
        }

        private void 顯示完成事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = record;
        }

        private void 隱藏完成事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringReader sr = new StringReader(textBox1.Text);
            string text = sr.ReadLine();
            string final_text = "";
            while (text != null)
            {
                if (text.Substring(2, 1) == " ")
                {
                    final_text += text + "\r\n";
                }
                text = sr.ReadLine();
            }
            textBox1.Text = final_text;
            sr.Close();
        }

        private void 尋找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Enabled = false;
            f2.Text = "待辦事項";
            f2.ShowDialog();
            if (f2.DialogResult == DialogResult.Cancel)
            {
                this.Enabled = true;
            }
            else if (f2.DialogResult == DialogResult.OK && (f2.new_event != ""))
            {
                int count = 0;
                StringReader sr = new StringReader(textBox1.Text);
                string text = sr.ReadLine();
                string replace_str = "";
                while(text != null)
                {
                    if (text.Contains(f2.new_event))
                    {
                        count++;
                        replace_str += text + "\r\n";
                    }
                    text = sr.ReadLine();
                }
                sr.Close();
                if (count > 0)
                {
                    record2 = textBox1.Text;
                    textBox1.Text = replace_str;
                    menuStrip1.Enabled = false;
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = true;
                }
                this.Enabled = true;
            }
        }

        private void 新增事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Enabled = false;
            f2.Text = "新增待辦事項";
            f2.ShowDialog();
            if (f2.DialogResult == DialogResult.Cancel)
            {
                this.Enabled = true;
            }
            else if (f2.DialogResult == DialogResult.OK && (f2.new_event != ""))
            {
                textBox1.Text += " [ ] " + f2.new_event + "\r\n";
                record += " [ ] " + f2.new_event + "\r\n";
                this.Enabled = true;
            }
        }

        private void 完成事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Enabled = false;
            f2.Text = "待辦事項";
            f2.ShowDialog();
            if (f2.DialogResult == DialogResult.Cancel)
            {
                this.Enabled = true;
            }
            else if (f2.DialogResult == DialogResult.OK && (f2.new_event != ""))
            {
                StringReader sr = new StringReader(textBox1.Text);
                string text = sr.ReadLine();
                int line_count = 0;
                string[] replace_str = new string[textBox1.Lines.Length];
                while (text != null)
                {
                    if (text.Substring(5, text.Length - 5) == f2.new_event)
                    {
                        replace_str[line_count] = " [√] " + f2.new_event;
                    }
                    else
                    {
                        replace_str[line_count] = text;
                    }
                    text = sr.ReadLine();
                    line_count++;
                }
                textBox1.Lines = replace_str;
                sr.Close();
                this.Enabled = true;
                StringReader _sr = new StringReader(record);
                text = _sr.ReadLine();
                string replace_string = "";
                while (text != null)
                {
                    if (text.Substring(5, text.Length - 5) == f2.new_event)
                    {
                        replace_string += " [√] " + f2.new_event + "\r\n";
                    }
                    else
                    {
                        replace_string += text + "\r\n";
                    }
                    text = _sr.ReadLine();
                }
                record = replace_string;
                sr.Close();
            }
        }

        private void 刪除事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Enabled = false;
            f2.Text = "待辦事項";
            f2.ShowDialog();
            if (f2.DialogResult == DialogResult.Cancel)
            {
                this.Enabled = true;
            }
            else if (f2.DialogResult == DialogResult.OK && (f2.new_event != ""))
            {
                StringReader sr = new StringReader(textBox1.Text);
                string text = sr.ReadLine();
                string replace_str = "";
                while (text != null)
                {
                    if (text.Substring(5, text.Length - 5) != f2.new_event)
                    {
                        replace_str += text + "\r\n";
                    }
                    text = sr.ReadLine();
                }
                textBox1.Text = replace_str;
                sr.Close();
                this.Enabled = true;
                StringReader _sr = new StringReader(record);
                text = _sr.ReadLine();
                replace_str = "";
                while (text != null)
                {
                    if (text.Substring(5, text.Length - 5) != f2.new_event)
                    {
                        replace_str += text + "\r\n";
                    }
                    text = _sr.ReadLine();
                }
                record = replace_str;
                sr.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menuStrip1.Enabled = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = false;
            textBox1.Text = record2;
        }
    }
}
