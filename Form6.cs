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
        string projectData;
        public Form6(string projectEl)
        {
            InitializeComponent();

            ApiData apiData = new ApiData();

            var a = apiData.GetData();

            var project = apiData.GetData().Where(x => x.ProjectName == projectEl);


        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxA = new CheckBox();
            checkBoxA.Top = 10;
            checkBoxA.Left = 50;
            checkBoxA.Text = "CheckBoxA";
            //Register the event handler for this checkbox
            checkBoxA.Click += new EventHandler(checkBoxA_Click);
            this.Controls.Add(checkBoxA);
        }

        void checkBoxA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CheckBoxA has been clicked!!!");
        }
    }
}
