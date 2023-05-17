namespace RPI_social__survey
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
            menuStrip1 = new MenuStrip();
            справочникToolStripMenuItem = new ToolStripMenuItem();
            редакторToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            labell1 = new Label();
            Age = new Label();
            floor = new Label();
            Education = new Label();
            Sity = new Label();
            label1 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            SEND = new Button();
            comboBox4 = new ComboBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { справочникToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(549, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // справочникToolStripMenuItem
            // 
            справочникToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { редакторToolStripMenuItem });
            справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            справочникToolStripMenuItem.Size = new Size(53, 20);
            справочникToolStripMenuItem.Text = "Меню";
            // 
            // редакторToolStripMenuItem
            // 
            редакторToolStripMenuItem.Name = "редакторToolStripMenuItem";
            редакторToolStripMenuItem.Size = new Size(139, 22);
            редакторToolStripMenuItem.Text = "Работа с БД";
            редакторToolStripMenuItem.Click += редакторToolStripMenuItem_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(117, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(243, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(117, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(332, 244);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(117, 23);
            textBox4.TabIndex = 4;
            // 
            // labell1
            // 
            labell1.AutoSize = true;
            labell1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labell1.Location = new Point(30, 73);
            labell1.Name = "labell1";
            labell1.Size = new Size(95, 25);
            labell1.TabIndex = 7;
            labell1.Text = "University";
            // 
            // Age
            // 
            Age.AutoSize = true;
            Age.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Age.Location = new Point(30, 114);
            Age.Name = "Age";
            Age.Size = new Size(207, 25);
            Age.TabIndex = 8;
            Age.Text = "What course are you in";
            // 
            // floor
            // 
            floor.AutoSize = true;
            floor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            floor.Location = new Point(32, 328);
            floor.Name = "floor";
            floor.Size = new Size(349, 25);
            floor.TabIndex = 9;
            floor.Text = "Will you stay in Russia after graduation?";
            // 
            // Education
            // 
            Education.AutoSize = true;
            Education.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Education.Location = new Point(32, 288);
            Education.Name = "Education";
            Education.Size = new Size(187, 25);
            Education.TabIndex = 10;
            Education.Text = "Do you like to study?";
            // 
            // Sity
            // 
            Sity.AutoSize = true;
            Sity.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Sity.Location = new Point(32, 242);
            Sity.Name = "Sity";
            Sity.Size = new Size(299, 25);
            Sity.TabIndex = 11;
            Sity.Text = "What country did you come from?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 205);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 12;
            label1.Text = "Do you work?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 157);
            label3.Name = "label3";
            label3.Size = new Size(257, 25);
            label3.TabIndex = 14;
            label3.Text = "Your academic performance?";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Yes.", "No." });
            comboBox2.Location = new Point(225, 290);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 16;
            comboBox2.Text = "choose";
            // 
            // SEND
            // 
            SEND.Location = new Point(212, 487);
            SEND.Name = "SEND";
            SEND.Size = new Size(98, 49);
            SEND.TabIndex = 17;
            SEND.Text = "DONE!";
            SEND.UseVisualStyleBackColor = true;
            SEND.Click += SEND_Click;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Yes.", "No, but I work part-time.", "No." });
            comboBox4.Location = new Point(168, 207);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 19;
            comboBox4.Text = "choose";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(387, 333);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(117, 23);
            textBox3.TabIndex = 20;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(295, 159);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(117, 23);
            textBox5.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 558);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(comboBox4);
            Controls.Add(SEND);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(Sity);
            Controls.Add(Education);
            Controls.Add(floor);
            Controls.Add(Age);
            Controls.Add(labell1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Sosial_survey";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem справочникToolStripMenuItem;
        private ToolStripMenuItem редакторToolStripMenuItem;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private Label labell1;
        private Label Age;
        private Label floor;
        private Label Education;
        private Label Sity;
        private Label label1;
        private Label label3;
        private ComboBox comboBox2;
        private Button SEND;
        private ComboBox comboBox4;
        private TextBox textBox3;
        private TextBox textBox5;
    }
}