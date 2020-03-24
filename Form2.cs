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
    public partial class RowData : Form
    {
        public string[] row = new string[6] {"","","","","",""};

        public RowData()
        {
            InitializeComponent();
        }

        private void RowData_Load(object sender, EventArgs e)
        {

        }




        private void addButt_Click(object sender, EventArgs e)
        {
            row[0] = residentText.Text;
            row[1] = coresidentText.Text;
            row[2] = lotNumText.Text;
            row[3] = purchaseDateText.Text;
            row[4] = currentResidentText.Text;
            row[5] = miscText.Text;

        }

        private void miscText_TextChanged(object sender, EventArgs e)
        {
            row[0] = residentText.Text;
            row[1] = coresidentText.Text;
            row[2] = lotNumText.Text;
            row[3] = purchaseDateText.Text;
            row[4] = currentResidentText.Text;
            row[5] = miscText.Text;
        }

        private void residentText_TextChanged(object sender, EventArgs e)
        {
            row[0] = residentText.Text;
            row[1] = coresidentText.Text;
            row[2] = lotNumText.Text;
            row[3] = purchaseDateText.Text;
            row[4] = currentResidentText.Text;
            row[5] = miscText.Text;
        }

        private void coresidentText_TextChanged(object sender, EventArgs e)
        {
            row[0] = residentText.Text;
            row[1] = coresidentText.Text;
            row[2] = lotNumText.Text;
            row[3] = purchaseDateText.Text;
            row[4] = currentResidentText.Text;
            row[5] = miscText.Text;
        }

        private void lotNumText_TextChanged(object sender, EventArgs e)
        {
            row[0] = residentText.Text;
            row[1] = coresidentText.Text;
            row[2] = lotNumText.Text;
            row[3] = purchaseDateText.Text;
            row[4] = currentResidentText.Text;
            row[5] = miscText.Text;
        }

        private void purchaseDateText_TextChanged(object sender, EventArgs e)
        {
            row[0] = residentText.Text;
            row[1] = coresidentText.Text;
            row[2] = lotNumText.Text;
            row[3] = purchaseDateText.Text;
            row[4] = currentResidentText.Text;
            row[5] = miscText.Text;
        }
    }
}
