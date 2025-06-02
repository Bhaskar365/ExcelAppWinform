using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Models;
using WinFormsApp.Repositiories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp
{
    public partial class Form4 : Form
    {
        // private bool isDataLoaded = false;
        public Form4()
        {
            InitializeComponent();
            ReadProjects();
        }

        private void ReadProjects()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Project Name");

            var data = new ApiData();
            var projectData = data.GetData();

            //ListBox mylist = new ListBox();


            //mylist.Dock = DockStyle.Fill;
            //mylist.Location = new Point(33, 145); 
            //mylist.Size = new Size(50, 50); 
            //mylist.ForeColor = Color.Purple;

            List<string> apidataList = new List<string>();

            foreach (var d in projectData)
            {
                //  mylist.Items.Add(d.ProjectName);
                //var row = dataTable.NewRow();
                //row["Project Name"] = d.ProjectName;
                //dataTable.Rows.Add(row);

                bool alreadyExist = apidataList.Contains(d.ProjectName);

                if (alreadyExist)
                {
                    // skip
                }
                else
                {
                    apidataList.Add(d.ProjectName);
                }
            }

            listBox2.DataSource = apidataList;

            //isDataLoaded = true;

            //this.Controls.Add(mylist);

            //this.dataGridView1.DataSource = dataTable;
        }


        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(listBox2.SelectedItem != null)
            //{
            //    string selectedProject = listBox2.SelectedItem.ToString();
            //    Form5 form = new Form5(selectedProject);
            //    form.Show();
            //}
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBox2.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                string selectedProject = listBox2.Items[index].ToString();
                Form5 form5 = new Form5(selectedProject);
                form5.Show();
            }
        }


        //private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        //{

        //}
    }
}
