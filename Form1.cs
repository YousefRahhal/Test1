using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Room1 : Form
    {
        public Room1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Turn ON Successful");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Turn OFF Successful");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
