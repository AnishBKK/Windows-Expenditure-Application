namespace WinFormsApp1
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
            label1 = new Label();
            AddEntryButtn = new Button();
            ShowEntryButtn = new Button();
            groupBox1 = new GroupBox();
            DataEnterButtn = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(339, 9);
            label1.MinimumSize = new Size(0, 50);
            label1.Name = "label1";
            label1.Padding = new Padding(50, 0, 50, 0);
            label1.Size = new Size(535, 55);
            label1.TabIndex = 0;
            label1.Text = "Expenditure Tracking";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // AddEntryButtn
            // 
            AddEntryButtn.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddEntryButtn.Location = new Point(95, 80);
            AddEntryButtn.Name = "AddEntryButtn";
            AddEntryButtn.Size = new Size(180, 75);
            AddEntryButtn.TabIndex = 1;
            AddEntryButtn.Text = "Add Entry";
            AddEntryButtn.UseVisualStyleBackColor = true;
            AddEntryButtn.Click += AddEntryButtn_Click;
            // 
            // ShowEntryButtn
            // 
            ShowEntryButtn.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ShowEntryButtn.Location = new Point(947, 80);
            ShowEntryButtn.Name = "ShowEntryButtn";
            ShowEntryButtn.Size = new Size(180, 75);
            ShowEntryButtn.TabIndex = 2;
            ShowEntryButtn.Text = "View Entry";
            ShowEntryButtn.UseVisualStyleBackColor = true;
            ShowEntryButtn.Click += ShowEntryButtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DataEnterButtn);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(262, 161);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(703, 685);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Visible = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // DataEnterButtn
            // 
            DataEnterButtn.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DataEnterButtn.Location = new Point(245, 435);
            DataEnterButtn.Name = "DataEnterButtn";
            DataEnterButtn.Size = new Size(180, 75);
            DataEnterButtn.TabIndex = 4;
            DataEnterButtn.Text = "Enter Data";
            DataEnterButtn.UseVisualStyleBackColor = true;
            DataEnterButtn.Click += DataEnterButtn_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(245, 175);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter Expentiture Name";
            textBox2.Size = new Size(433, 31);
            textBox2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 161);
            label4.Name = "label4";
            label4.Size = new Size(203, 45);
            label4.TabIndex = 7;
            label4.Text = "Enter Value";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(245, 301);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter Amount";
            textBox1.Size = new Size(433, 31);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 288);
            label3.Name = "label3";
            label3.Size = new Size(233, 45);
            label3.TabIndex = 5;
            label3.Text = "Enter Amount";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(378, 49);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 38);
            label2.Name = "label2";
            label2.Size = new Size(349, 45);
            label2.TabIndex = 3;
            label2.Text = "Enter Date and Time";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(262, 176);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(703, 664);
            dataGridView1.TabIndex = 4;
            dataGridView1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 912);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(ShowEntryButtn);
            Controls.Add(AddEntryButtn);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button AddEntryButtn;
        private Button ShowEntryButtn;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Button DataEnterButtn;
        private TextBox textBox2;
        private DataGridView dataGridView1;
    }
}