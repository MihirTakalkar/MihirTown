using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MihirTown
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            LogicforWT swag = new LogicforWT();
            Hide();
            swag.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogicforNT money = new LogicforNT();
            Hide();
            money.ShowDialog();
            Close();
        }
    }
}
