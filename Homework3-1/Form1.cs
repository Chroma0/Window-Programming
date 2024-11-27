using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3_1
{
    public partial class Form1 : Form
    {
        List<Account> MyAccount = new List<Account>();
        int k = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            foreach (Account item in MyAccount)
            {
                if (item.link.Contains(textBox1.Text))
                {
                    label4.Text = label4.Text + item.Data();
                }
            }
            textBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Text = "新增或刪除";
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            int[] check = new int[MyAccount.Count];
            for(int i = 0; i < MyAccount.Count; i++)
            {
                check[i] = 0;
            }
            for(int i = 0; i < MyAccount.Count-1; i++)
            {
                for(int j = i+1; j < MyAccount.Count; j++)
                {
                    if((MyAccount[i].pass == MyAccount[j].pass) && check[i]==0 && check[j]==0)
                    {
                        label4.Text = label4.Text + MyAccount[i].Data() + MyAccount[j].Data();
                        check[i] = 1;
                        check[j] = 1;
                    }
                    else if ((MyAccount[i].pass == MyAccount[j].pass) && check[i] == 0 && check[j] != 0)
                    {
                        label4.Text = label4.Text + MyAccount[i].Data();
                        check[i] = 1;
                    }
                    else if ((MyAccount[i].pass == MyAccount[j].pass) && check[i] != 0 && check[j] == 0)
                    {
                        label4.Text = label4.Text + MyAccount[j].Data();
                        check[j] = 1;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            k = (k + 1) % 2;
            if (k == 0)
            {
                textBox2.Text = "我是狀態列";
                button3.Text = "回到主畫面";
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                button4.Visible = true;
                button5.Visible = true;

                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                textBox1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
            }
            else if (k == 1)
            {
                label4.Text = "";
                button3.Text = "新增或刪除";
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                button4.Visible = false;
                button5.Visible = false;

                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                textBox1.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int _check = 0;
            foreach(Account item in MyAccount)
            {
                if(item.link==textBox3.Text && item.user==textBox4.Text)
                {
                    textBox2.Text = "帳號已存在";
                    _check++;
                    break;
                }
            }
            if (_check == 0)
            {
                textBox2.Text = "新增完成";
                MyAccount.Add(new Account(textBox3.Text, textBox4.Text, textBox5.Text));
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int _check = 0;
            foreach (Account item in MyAccount)
            {
                if (item.link == textBox3.Text && item.user == textBox4.Text && item.pass == textBox5.Text)
                {
                    textBox2.Text = "刪除完成";
                    MyAccount.Remove(item);
                    _check++;
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    break;
                }
            }
            if (_check == 0)
            {
                textBox2.Text = "帳號不存在或密碼錯誤";
            }
        }
    }
}
