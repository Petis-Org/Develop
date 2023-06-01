namespace WinFormsApp1.Forms.FormsSecundar
{
    partial class controlVetRequest
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
            textBox1 = new TextBox();
            comboBox5 = new ComboBox();
            label4 = new Label();
            comboBox4 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(136, 138);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 45;
            // 
            // comboBox5
            // 
            comboBox5.Anchor = AnchorStyles.None;
            comboBox5.DropDownHeight = 80;
            comboBox5.DropDownWidth = 90;
            comboBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox5.FormattingEnabled = true;
            comboBox5.IntegralHeight = false;
            comboBox5.Items.AddRange(new object[] { "Cirurgia", "Consulta", "Exames", "Vacinação", "Castração", "Internações", "Transfusões", "Imunização", "Procedimentos Especiais" });
            comboBox5.Location = new Point(136, 59);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(152, 29);
            comboBox5.TabIndex = 44;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(69, 62);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 43;
            label4.Text = "Serviço";
            // 
            // comboBox4
            // 
            comboBox4.Anchor = AnchorStyles.None;
            comboBox4.DropDownHeight = 80;
            comboBox4.DropDownWidth = 90;
            comboBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox4.FormattingEnabled = true;
            comboBox4.IntegralHeight = false;
            comboBox4.Items.AddRange(new object[] { "Cachorro", "Rato", "Gato", "Macaco", "Coelho", "Elefante", "Leão", "Tigre" });
            comboBox4.Location = new Point(136, 94);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(152, 29);
            comboBox4.TabIndex = 42;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(71, 97);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 41;
            label3.Text = "Animal";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(81, 140);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 40;
            label2.Text = "Preço";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(315, 179);
            button1.Name = "button1";
            button1.Size = new Size(122, 39);
            button1.TabIndex = 39;
            button1.Text = "Confirma";
            button1.UseVisualStyleBackColor = true;
            // 
            // controlVetRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 293);
            Controls.Add(textBox1);
            Controls.Add(comboBox5);
            Controls.Add(label4);
            Controls.Add(comboBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "controlVetRequest";
            Text = "controlVetRequest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox comboBox5;
        private Label label4;
        private ComboBox comboBox4;
        private Label label3;
        private Label label2;
        private Button button1;
    }
}