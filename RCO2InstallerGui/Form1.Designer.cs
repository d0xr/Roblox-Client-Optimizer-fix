namespace RCO2InstallerGui
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            panel1 = new Panel();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(238, 238, 238);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(319, 41);
            label1.TabIndex = 0;
            label1.Text = "RCO2 Installer Gui | 1.0";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 30);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(richTextBox1);
            panel1.Location = new Point(12, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 353);
            panel1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(30, 30, 30);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.FromArgb(170, 170, 170);
            richTextBox1.Location = new Point(3, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(766, 343);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            richTextBox1.WordWrap = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 10, 10);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(17, 415);
            button1.Name = "button1";
            button1.Size = new Size(82, 32);
            button1.TabIndex = 2;
            button1.Text = "Install";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 10, 10);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(105, 415);
            button2.Name = "button2";
            button2.Size = new Size(82, 32);
            button2.TabIndex = 3;
            button2.Text = "Uninstall";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 32, 32);
            label2.Location = new Point(769, 9);
            label2.Name = "label2";
            label2.Size = new Size(19, 21);
            label2.TabIndex = 4;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 23, 23);
            ClientSize = new Size(800, 455);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "RCO2 Installer Gui";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private Label label2;
    }
}
