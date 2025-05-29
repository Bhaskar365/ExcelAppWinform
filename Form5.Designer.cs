namespace WinFormsApp
{
    partial class Form5
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            listBox1 = new ListBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            listBox2 = new ListBox();
            Label2 = new Label();
            buttonDropdown = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(200, 32);
            button2.TabIndex = 1;
            button2.Text = "Load Raw Answers";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(218, 12);
            button3.Name = "button3";
            button3.Size = new Size(72, 32);
            button3.TabIndex = 2;
            button3.Text = "Code";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 59);
            label1.Name = "label1";
            label1.Size = new Size(214, 25);
            label1.TabIndex = 4;
            label1.Text = "Surveys in Current Project";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(listBox1);
            flowLayoutPanel1.Location = new Point(12, 75);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(444, 348);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(1, 11);
            listBox1.Margin = new Padding(1, 11, 2, 11);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(420, 329);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(listBox2);
            flowLayoutPanel2.Location = new Point(473, 75);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(300, 347);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(2, 14);
            listBox2.Margin = new Padding(2, 14, 2, 5);
            listBox2.Name = "listBox2";
            listBox2.ScrollAlwaysVisible = true;
            listBox2.Size = new Size(298, 329);
            listBox2.TabIndex = 0;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(491, 61);
            Label2.Name = "Label2";
            Label2.Size = new Size(100, 25);
            Label2.TabIndex = 7;
            Label2.Text = "Breakdown";
            // 
            // buttonDropdown
            // 
            buttonDropdown.Location = new Point(296, 12);
            buttonDropdown.Name = "buttonDropdown";
            buttonDropdown.Size = new Size(91, 32);
            buttonDropdown.TabIndex = 8;
            buttonDropdown.Text = "Tools";
            buttonDropdown.UseVisualStyleBackColor = true;
            buttonDropdown.Click += buttonDropdown_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            contextMenuStrip1.Text = "contextMenuStrip1";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 495);
            Controls.Add(buttonDropdown);
            Controls.Add(Label2);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            Load += Form5_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button3;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ListBox listBox1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label Label2;
        private ListBox listBox2;
        private Button buttonDropdown;
        private ContextMenuStrip contextMenuStrip1;
    }
}