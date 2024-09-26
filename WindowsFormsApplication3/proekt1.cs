using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Connection connect = new Connection();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chain chain = new Chain();
            chain.number = textBox1.Text;
            chain.name = textBox2.Text;
            chain.owner_names = textBox3.Text;
            chain.address = textBox4.Text;
            chain.manufacturer = textBox5.Text;
            chain.amountinvested = textBox6.Text;
            chain.shareholding = textBox7.Text;
            chain.register_number = textBox8.Text;
            chain.DateOfRegistration = textBox9.Text;
            connect.Input(chain);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Chain chain = new Chain();
            chain.DateOfRegistration = textBox9.Text;
            chain.register_number = textBox8.Text;
            connect.Update(chain);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Chain chain = new Chain();

            chain.register_number = textBox8.Text;
            connect.Delete(chain);
        }


    }
}
