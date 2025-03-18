namespace WinFormsApp
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBoxSearch = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.Location = new Point(29, 60);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.Size = new Size(384, 31);
            txtBoxSearch.TabIndex = 0;
            txtBoxSearch.TextChanged += txtBoxSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 29);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 1;
            label1.Text = "Search";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 109);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 3;
            label2.Text = "Load Project";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 454);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBoxSearch);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxSearch;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private ListBox listBox1;
        private ListBox listBoxControl1;
    }
}