namespace RPI_social__survey
{
    partial class Form2
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox5 = new TextBox();
            labell1 = new Label();
            textBox3 = new TextBox();
            textBox7 = new TextBox();
            label3 = new Label();
            Sity = new Label();
            label4 = new Label();
            Education = new Label();
            textBox6 = new TextBox();
            floor = new Label();
            textBox4 = new TextBox();
            Age = new Label();
            groupBox3 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column8, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(965, 318);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "member_id";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "name_univer";
            Column2.Name = "Column2";
            Column2.Width = 140;
            // 
            // Column3
            // 
            Column3.HeaderText = "course";
            Column3.Name = "Column3";
            // 
            // Column8
            // 
            Column8.HeaderText = "perfomance";
            Column8.Name = "Column8";
            // 
            // Column4
            // 
            Column4.HeaderText = "work";
            Column4.Name = "Column4";
            Column4.Width = 140;
            // 
            // Column5
            // 
            Column5.HeaderText = "country";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "sty";
            Column6.Name = "Column6";
            Column6.Width = 140;
            // 
            // Column7
            // 
            Column7.HeaderText = "doafter";
            Column7.Name = "Column7";
            // 
            // button1
            // 
            button1.Location = new Point(13, 114);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Найти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(87, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(20, 17);
            button2.Name = "button2";
            button2.Size = new Size(91, 23);
            button2.TabIndex = 4;
            button2.Text = "Очистить поле";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 17);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 5;
            label1.Text = "Select";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 57);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 6;
            label2.Text = "Where";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(536, 331);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(241, 143);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Поиск по условиям";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox10);
            groupBox2.Controls.Add(textBox9);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(labell1);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(Sity);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(Education);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(floor);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(Age);
            groupBox2.Location = new Point(13, 331);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(497, 334);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Редактор";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(8, 36);
            label5.Name = "label5";
            label5.Size = new Size(30, 25);
            label5.TabIndex = 39;
            label5.Text = "ID";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(44, 41);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(117, 23);
            textBox10.TabIndex = 38;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(201, 239);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(117, 23);
            textBox9.TabIndex = 37;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(141, 170);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(117, 23);
            textBox8.TabIndex = 36;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(269, 131);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(117, 23);
            textBox5.TabIndex = 35;
            // 
            // labell1
            // 
            labell1.AutoSize = true;
            labell1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labell1.Location = new Point(8, 65);
            labell1.Name = "labell1";
            labell1.Size = new Size(95, 25);
            labell1.TabIndex = 25;
            labell1.Text = "University";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(361, 281);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(117, 23);
            textBox3.TabIndex = 34;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(109, 70);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(117, 23);
            textBox7.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 129);
            label3.Name = "label3";
            label3.Size = new Size(257, 25);
            label3.TabIndex = 31;
            label3.Text = "Your academic performance?";
            // 
            // Sity
            // 
            Sity.AutoSize = true;
            Sity.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Sity.Location = new Point(6, 199);
            Sity.Name = "Sity";
            Sity.Size = new Size(299, 25);
            Sity.TabIndex = 29;
            Sity.Text = "What country did you come from?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(8, 165);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 30;
            label4.Text = "Do you work?";
            // 
            // Education
            // 
            Education.AutoSize = true;
            Education.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Education.Location = new Point(8, 234);
            Education.Name = "Education";
            Education.Size = new Size(187, 25);
            Education.TabIndex = 28;
            Education.Text = "Do you like to study?";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(219, 100);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(117, 23);
            textBox6.TabIndex = 23;
            // 
            // floor
            // 
            floor.AutoSize = true;
            floor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            floor.Location = new Point(6, 276);
            floor.Name = "floor";
            floor.Size = new Size(349, 25);
            floor.TabIndex = 27;
            floor.Text = "Will you stay in Russia after graduation?";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(306, 201);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(117, 23);
            textBox4.TabIndex = 24;
            // 
            // Age
            // 
            Age.AutoSize = true;
            Age.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Age.Location = new Point(6, 95);
            Age.Name = "Age";
            Age.Size = new Size(207, 25);
            Age.TabIndex = 26;
            Age.Text = "What course are you in";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button2);
            groupBox3.Location = new Point(805, 331);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(131, 162);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Основные кнопки";
            // 
            // button6
            // 
            button6.Location = new Point(20, 133);
            button6.Name = "button6";
            button6.Size = new Size(91, 23);
            button6.TabIndex = 8;
            button6.Text = "INSERT";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(20, 104);
            button5.Name = "button5";
            button5.Size = new Size(91, 23);
            button5.TabIndex = 7;
            button5.Text = "DELETE";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(20, 75);
            button4.Name = "button4";
            button4.Size = new Size(91, 23);
            button4.TabIndex = 6;
            button4.Text = "UPDATE";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(20, 46);
            button3.Name = "button3";
            button3.Size = new Size(91, 23);
            button3.TabIndex = 5;
            button3.Text = "Показать БД";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 668);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Работа с БД";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button3;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox5;
        private Label labell1;
        private TextBox textBox3;
        private TextBox textBox7;
        private Label label3;
        private Label Sity;
        private Label label4;
        private Label Education;
        private TextBox textBox6;
        private Label floor;
        private TextBox textBox4;
        private Label Age;
        private Label label5;
        private TextBox textBox10;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button button5;
        private Button button4;
        private Button button6;
    }
}