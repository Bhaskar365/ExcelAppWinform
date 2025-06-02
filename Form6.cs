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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;

namespace WinFormsApp
{
    public partial class Form6 : Form
    {
        List<string> projectTestname = new List<string>();

        public Form6(string projectEl)
        {
            InitializeComponent();

            ApiData apiData = new ApiData();

            var project = apiData.GetBreakdownAPIData().Where(x => x.ProjectName == projectEl).ToList();

            foreach (var p in project)
            {
                projectTestname.Add(p.Testname);
            }

            Load += PopulateCheckboxes;
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //CheckBox checkBoxA = new CheckBox();

            //this.checkBox1SingleBox.Text = projectTestname;



            //checkBoxA.Top = 10;
            //checkBoxA.Left = 50;
            //checkBoxA.Text = projectTestname;
            ////Register the event handler for this checkbox
            //checkBoxA.Click += new EventHandler(checkBoxA_Click);
            //this.Controls.Add(checkBoxA);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


        }

        void checkBoxA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CheckBoxA has been clicked!!!");
        }

        private void PopulateCheckboxes(Object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();

            foreach (var item in projectTestname) 
            {
                CheckBox cb = new CheckBox();
                cb.Text = item;
                cb.AutoSize = true;
                flowLayoutPanel1.Controls.Add(cb);
            }

        }

    }
}
