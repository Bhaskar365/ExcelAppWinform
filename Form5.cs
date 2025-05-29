using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Repositiories;

namespace WinFormsApp
{
    public partial class Form5 : Form
    {
        //public Form5()
        //{
        //    InitializeComponent();
        //    //ReadProjects();
        //}

        private string selectedProject;

        public Form5(string project)
        {
            InitializeComponent();
            selectedProject = project;
            ShowProject(selectedProject);
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShowProject(string project)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Project Name");

            var data = new ApiData();
            var projectData = data.GetData().Where(p => p.ProjectName == project);

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

                apidataList.Add(d.ProjectName);
            }

            listBox1.DataSource = apidataList;

            List<string> breakdownList = new List<string>();

            DataTable dataTable2 = new DataTable();

            dataTable2.Columns.Add("Breakdown");

            var data2 = new ApiData();
            var projectData2 = data2.GetBreakdownAPIData().Where(p => p.ProjectName == project);


            foreach (var d in projectData2)
            {
                //  mylist.Items.Add(d.ProjectName);
                //var row = dataTable.NewRow();
                //row["Project Name"] = d.ProjectName;
                //dataTable.Rows.Add(row);

                breakdownList.Add(d.Breakdown);
            }

            listBox2.DataSource = breakdownList;

            //this.Controls.Add(mylist);

            //this.dataGridView1.DataSource = dataTable;

        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

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

                apidataList.Add(d.ProjectName);
            }

            listBox1.DataSource = apidataList;

            //this.Controls.Add(mylist);

            //this.dataGridView1.DataSource = dataTable;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void buttonDropdown_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Items.Clear();

            List<string> projects = new List<string>() { "Generation Panel" };

            // Populate the dropdown menu
            foreach (var project in projects)
            {
                var menuItem = new ToolStripMenuItem(project);
                menuItem.Click += (s, args) =>
                {
                    // Open Form5 with selected project
                    //Form5 form5 = new Form5(project.ProjectName);
                    //form5.Show();
                };

                contextMenuStrip1.Items.Add(menuItem);
            }

            // Show dropdown under the button
            contextMenuStrip1.Show(buttonDropdown, new Point(0, buttonDropdown.Height));



        }
    }
}
