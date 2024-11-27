using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    public partial class Form2 : Form
    {
        public string new_event = "";
        public Form2()
        {
            InitializeComponent();
            button2.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("請輸入事項", "", MessageBoxButtons.OK);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                new_event = textBox1.Text;
            }
        }
    }
}
