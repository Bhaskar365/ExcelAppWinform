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
    public partial class Form4 : Form
    {
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

            foreach(var d in projectData)
            {
                var row = dataTable.NewRow();

                row["projectName"] = d.ProjectName;

                dataTable.Rows.Add(row);
            }

            this.dataGridView1.DataSource = dataTable;
        }


        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        //{

        //}
    }
}
