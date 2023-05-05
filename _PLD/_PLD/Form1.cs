using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.calitha.goldparser;

namespace _PLD
{
    public partial class Form1 : Form
    {
        MyParser P;
        public Form1()
        {
            
            InitializeComponent();
            P = new MyParser("Task.cgt",listBox1);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            P.Parse(textBox1.Text);
        }
    }
}
