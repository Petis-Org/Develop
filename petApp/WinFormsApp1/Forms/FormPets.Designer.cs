namespace WinFormsApp1.Forms
{
    partial class FormPets
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(252, 380);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 7, 10, 7);
            button1.Size = new Size(129, 49);
            button1.TabIndex = 0;
            button1.Text = "Adote";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(457, 380);
            button2.Name = "button2";
            button2.Size = new Size(129, 49);
            button2.TabIndex = 1;
            button2.Text = "Adicionar Pet";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(659, 380);
            button3.Name = "button3";
            button3.Size = new Size(129, 49);
            button3.TabIndex = 2;
            button3.Text = "Fotos";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(52, 104);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 4;
            label1.Text = "Estado";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(50, 133);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 6;
            label3.Text = "Cidade";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(43, 162);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 8;
            label2.Text = "Petshop";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(252, 23);
            label4.Name = "label4";
            label4.Size = new Size(272, 28);
            label4.TabIndex = 12;
            label4.Text = "Tabela de Pets para Adoção";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.DropDownHeight = 80;
            comboBox1.DropDownWidth = 90;
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Items.AddRange(new object[] { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" });
            comboBox1.Location = new Point(114, 104);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(118, 23);
            comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.None;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(114, 133);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(118, 23);
            comboBox2.TabIndex = 14;
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.None;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(114, 162);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(118, 23);
            comboBox3.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.ControlDarkDark;
            dataGridView1.Location = new Point(252, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(536, 320);
            dataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Column1.DefaultCellStyle = dataGridViewCellStyle2;
            Column1.HeaderText = "Petshop";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Column5";
            Column5.Name = "Column5";
            // 
            // FormPets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormPets";
            Text = "FormPets";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}