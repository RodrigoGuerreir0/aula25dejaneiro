using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula25deJaneiro
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            nomes.Visible= false;
            button2.Visible= false;
            textBox1.Visible= false;
            textBox2.Visible= false;
            textBox3.Visible= false;
            button3.Visible= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nomes.Visible= true;
            nomes.Text = "Rodrigo, Samuel, Alex";
            nomes.ForeColor= Color.Red;
            button2.Visible = true;
        }

        private void nomes_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible=true;
            textBox2.Visible= true;
            button3.Visible= true;
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Visible= true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
