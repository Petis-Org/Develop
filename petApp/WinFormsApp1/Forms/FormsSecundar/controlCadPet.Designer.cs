namespace WinFormsApp1.Forms.FormsSecundar
{
    partial class controlCadPet
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
            comboBox6 = new ComboBox();
            label5 = new Label();
            comboBox5 = new ComboBox();
            label4 = new Label();
            comboBox4 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            Raça = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // comboBox6
            // 
            comboBox6.DropDownHeight = 80;
            comboBox6.DropDownWidth = 90;
            comboBox6.FlatStyle = FlatStyle.Flat;
            comboBox6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox6.FormattingEnabled = true;
            comboBox6.IntegralHeight = false;
            comboBox6.Items.AddRange(new object[] { "1 a 6 meses", "6 a 12 meses", "1 a 2 anos", "3 a 4 anos", "5 a 6 anos", "7 a 8 anos", "9 a 10 anos" });
            comboBox6.Location = new Point(276, 261);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(152, 29);
            comboBox6.TabIndex = 26;
            comboBox6.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(99, 264);
            label5.Name = "label5";
            label5.Size = new Size(171, 21);
            label5.TabIndex = 25;
            label5.Text = "Tempo (aproximado)";
            // 
            // comboBox5
            // 
            comboBox5.DropDownHeight = 80;
            comboBox5.DropDownWidth = 90;
            comboBox5.FlatStyle = FlatStyle.Flat;
            comboBox5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox5.FormattingEnabled = true;
            comboBox5.IntegralHeight = false;
            comboBox5.Items.AddRange(new object[] { "Cachorro", "Coelho", "Gato", "Macaco", "Leonardo" });
            comboBox5.Location = new Point(276, 82);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(152, 33);
            comboBox5.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(205, 82);
            label4.Name = "label4";
            label4.Size = new Size(65, 21);
            label4.TabIndex = 23;
            label4.Text = "Animal";
            // 
            // comboBox4
            // 
            comboBox4.FlatStyle = FlatStyle.Flat;
            comboBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Maculino", "Feminino" });
            comboBox4.Location = new Point(276, 226);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(152, 29);
            comboBox4.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(223, 226);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 21;
            label3.Text = "Sexo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(207, 191);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 19;
            label2.Text = "Cidade";
            // 
            // comboBox2
            // 
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" });
            comboBox2.Location = new Point(276, 156);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(152, 29);
            comboBox2.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(209, 156);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 17;
            label1.Text = "Estado";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(469, 252);
            button1.Name = "button1";
            button1.Size = new Size(122, 39);
            button1.TabIndex = 15;
            button1.Text = "Confirma";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Raça
            // 
            Raça.AutoSize = true;
            Raça.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Raça.Location = new Point(224, 121);
            Raça.Name = "Raça";
            Raça.Size = new Size(46, 21);
            Raça.TabIndex = 14;
            Raça.Text = "Raça";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(276, 191);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 29);
            textBox1.TabIndex = 27;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(276, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 29);
            textBox2.TabIndex = 28;
            // 
            // controlCadPet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 403);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox6);
            Controls.Add(label5);
            Controls.Add(comboBox5);
            Controls.Add(label4);
            Controls.Add(comboBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(Raça);
            Name = "controlCadPet";
            Text = "controlCadPet";
            Load += controlCadPet_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox6;
        private Label label5;
        private ComboBox comboBox5;
        private Label label4;
        private ComboBox comboBox4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox2;
        private Label label1;
        private Button button1;
        private Label Raça;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}