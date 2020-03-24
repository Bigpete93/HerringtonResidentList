using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerringtonResidents
{
    public partial class Form3 : Form
    {
        public string data;
        public Form3(string incData)
        {
            InitializeComponent();
            data = incData;
        }

        private void addButt_Click(object sender, EventArgs e)
        {
            data = cellText.Text;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cellText.Text = data;
        }

        private void cellText_TextChanged(object sender, EventArgs e)
        {
            data = cellText.Text;
        }

        private void cellText_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cellText_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                EditButt.PerformClick();
            }
        }
    }
}
