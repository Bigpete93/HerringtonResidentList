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
    public partial class Main : Form
    {
        List<string[]> residents = new List<string[]>();
        public Main()
        {
            InitializeComponent();
        }

        /************************************
         * 
         * On load it finds the CSV file, and populates the table.
         * 
         *************************************/
        private void Form1_Load(object sender, EventArgs e)
        {

            string residentsFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                @"\VillaFarms,LeaseMaker\BaseFolder\SellDates.CSV";
            string[] lines = System.IO.File.ReadAllLines(residentsFile);
            foreach (string line in lines)
            {
                string[] splitLine = line.Split(',');
                if(splitLine[2].Length == 1)
                {
                    splitLine[2] = '0' + splitLine[2];
                }
                residents.Add(splitLine);
                residentGrid.Rows.Add(splitLine);
            }
            searchDrop.SelectedIndex = 1;
            residentGrid.Sort(residentGrid.Columns[2], ListSortDirection.Ascending);
        }

        /************************************
         * 
         * Whenever a change is made to the dropdown menu, drops and reloads the table.
         * 
         *************************************/
        private void searchDrop_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Search Resident
            if (searchDrop.SelectedIndex == 1)
            {
                residentGrid.Rows.Clear();
                //(var item in Model.Select((value, i) => new { i, value }))
                foreach (var item in residents.Select((value, i) => new {value, i }))
                {
                    string[] line = item.value;
                    int i = item.i;
                    if(line[0].ToLower().Contains(searchText.Text.ToLower()))
                    {
                        residentGrid.Rows.Add(line);
                    }
                }
            }
            //Search Coresident
            if (searchDrop.SelectedIndex == 2)
            {
                residentGrid.Rows.Clear();
                //(var item in Model.Select((value, i) => new { i, value }))
                foreach (var item in residents.Select((value, i) => new { value, i }))
                {
                    string[] line = item.value;
                    int i = item.i;
                    if (line[1].ToLower().Contains(searchText.Text.ToLower()))
                    {
                        residentGrid.Rows.Add(line);
                    }
                }
            }
            //Search Lot Number
            if (searchDrop.SelectedIndex == 3)
            {
                if (searchText.TextLength != 0)
                {
                    string searching = searchText.Text;
                    if(searching.Length == 1)
                    {
                        searching = '0' + searching;
                    }
                    residentGrid.Rows.Clear();
                    //(var item in Model.Select((value, i) => new { i, value }))
                    foreach (var item in residents.Select((value, i) => new { value, i }))
                    {
                        string[] line = item.value;
                        int i = item.i;
                        if (line[2] == searching)
                        {
                            residentGrid.Rows.Add(line);
                        }
                    }
                }
            }
            //Search Purchase Date
            if (searchDrop.SelectedIndex == 4)
            {
                residentGrid.Rows.Clear();
                //(var item in Model.Select((value, i) => new { i, value }))
                foreach (var item in residents.Select((value, i) => new { value, i }))
                {
                    string[] line = item.value;
                    int i = item.i;
                    string tempDate = searchText.Text;
                    if (tempDate.Length == 4)
                    {
                        tempDate = tempDate.Substring(2);
                    }
                    if (line[3].Contains(tempDate))
                    {
                        residentGrid.Rows.Add(line);
                    }
                }
            }
            //Search Misc Notes
            if (searchDrop.SelectedIndex == 5)
            {
                residentGrid.Rows.Clear();
                //(var item in Model.Select((value, i) => new { i, value }))
                foreach (var item in residents.Select((value, i) => new { value, i }))
                {
                    string[] line = item.value;
                    int i = item.i;
                    if (line[4].ToLower().Contains(searchText.Text.ToLower()))
                    {
                        residentGrid.Rows.Add(line);
                    }
                }
            }
            //Search Current Resident
            if (searchDrop.SelectedIndex == 6)
            {
                residentGrid.Rows.Clear();
                //(var item in Model.Select((value, i) => new { i, value }))
                foreach (var item in residents.Select((value, i) => new { value, i }))
                {
                    string[] line = item.value;
                    int i = item.i;
                    if (line[5].ToLower().Contains(searchText.Text.ToLower()))
                    {
                        residentGrid.Rows.Add(line);
                    }
                }
            }
            if (searchDrop.SelectedIndex == 0)
            {
                residentGrid.Rows.Clear();
                //(var item in Model.Select((value, i) => new { i, value }))
                foreach (var item in residents.Select((value, i) => new { value, i }))
                {
                    string[] line = item.value;
                    int i = item.i;
                    residentGrid.Rows.Add(line);
                }
              
            }
        }

        /************************************
     * 
     * When the form is closing, it asks to saves then does so.
     * 
     *************************************/
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult dr = MessageBox.Show("Do you wish to save your edits?", "System Exit", MessageBoxButtons.YesNo,
   MessageBoxIcon.Information);
            if(dr ==DialogResult.Yes)
            {
                using (System.IO.StreamWriter file =
        new System.IO.StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                    @"\VillaFarms,LeaseMaker\BaseFolder\SellDates.CSV"))
                {
                    foreach (string[] row in residents)
                    {
                        string conjoined = String.Join(",", row);
                        file.WriteLine(conjoined);
                    }
                }
                MessageBox.Show("Successfully Saved!");
            }
            else
            {
                DialogResult dr2 = MessageBox.Show("Warning: Won't save. Hit YES to save. Hit NO to continue without saving.", "System Exit", MessageBoxButtons.YesNo,
   MessageBoxIcon.Information);
                if (dr2 == DialogResult.Yes)
                {
                    using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                        @"\VillaFarms,LeaseMaker\BaseFolder\SellDates.CSV"))
                    {
                        foreach (string[] row in residents)
                        {
                            string conjoined = String.Join(",", row);
                            file.WriteLine(conjoined);
                        }
                    }
                    MessageBox.Show("Successfully Saved!");
                }

            }

        }
        /************************************
     * 
     * When a add row is clicked, a new form appears
     * 
     *************************************/
        private void addButt_Click(object sender, EventArgs e)
        {
            RowData form2 = new RowData();
            string[] incRow = new string[6] { "", "", "", "", "", "" };
            if (form2.ShowDialog() == DialogResult.OK)
            {
                incRow = form2.row;
                MessageBox.Show("Row Added: " + incRow[0] + " - " + incRow[1] + " - " + incRow[2] + " - " + incRow[3] + " - " + incRow[4] + " - " + incRow[5]);

            }
            residents.Add(incRow);
            //residentGrid.Sort(residentGrid.Columns.GetFirstColumn(), ListSortDirection.Descending);
            residentGrid.Rows.Add(incRow);
            residentGrid.Sort(residentGrid.Columns[2], ListSortDirection.Ascending);

        }


       

        /************************************
     * 
     * Whenever a cell is clicked ,it pops up an edit form
     * 
     *************************************/
        private void residentGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex==-1)
            {
                return;
            }

            Form3 f3 = new Form3(residentGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            if(f3.ShowDialog() == DialogResult.OK)
            {
                int index = 0;
                foreach(string[] line in residents)
                {
                    
                    if (residentGrid.Rows[e.RowIndex].Cells[0].Value.ToString() == line[0] &&
                        residentGrid.Rows[e.RowIndex].Cells[3].Value.ToString() == line[3] )
                    {

                        residents.ElementAt(index)[e.ColumnIndex] = f3.data;
                        residentGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = f3.data;
                        if(e.ColumnIndex == 2 && f3.data.Length == 1)
                        {
                            residents.ElementAt(index)[e.ColumnIndex] = 
                                "0" + residents.ElementAt(index)[e.ColumnIndex];
                            residentGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 
                                "0" + residentGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        }

                        //Now, kill it if its empty
                        if(residents.ElementAt(index)[0] == "" &&
                            residents.ElementAt(index)[1] == "" &&
                            residents.ElementAt(index)[3] == "")
                        {
                            residentGrid.Rows.RemoveAt(e.RowIndex);
                            residents.RemoveAt(index);
                        
                        }
                        //if we've found it, we need to get out of the foreach loop
                        break;
                    }
                    index++;
                }
                
            }

        }
    }
}
