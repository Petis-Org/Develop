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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            gridPets = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            listEstado = new ListBox();
            listCidade = new ListBox();
            listPetshop = new ListBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridPets).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(252, 380);
            button1.Name = "button1";
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
            // gridPets
            // 
            gridPets.Anchor = AnchorStyles.None;
            gridPets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPets.Location = new Point(252, 53);
            gridPets.Name = "gridPets";
            gridPets.RowTemplate.Height = 25;
            gridPets.Size = new Size(536, 320);
            gridPets.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 104);
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
            label3.Location = new Point(44, 135);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 6;
            label3.Text = "Cidade";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(35, 168);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 8;
            label2.Text = "Petshop";
            label2.Click += label2_Click;
            // 
            // listEstado
            // 
            listEstado.Anchor = AnchorStyles.None;
            listEstado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listEstado.FormattingEnabled = true;
            listEstado.ItemHeight = 21;
            listEstado.Location = new Point(106, 104);
            listEstado.Name = "listEstado";
            listEstado.Size = new Size(94, 25);
            listEstado.TabIndex = 9;
            // 
            // listCidade
            // 
            listCidade.Anchor = AnchorStyles.None;
            listCidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listCidade.FormattingEnabled = true;
            listCidade.ItemHeight = 21;
            listCidade.Location = new Point(106, 135);
            listCidade.Name = "listCidade";
            listCidade.Size = new Size(94, 25);
            listCidade.TabIndex = 10;
            // 
            // listPetshop
            // 
            listPetshop.Anchor = AnchorStyles.None;
            listPetshop.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listPetshop.FormattingEnabled = true;
            listPetshop.ItemHeight = 21;
            listPetshop.Location = new Point(106, 164);
            listPetshop.Name = "listPetshop";
            listPetshop.Size = new Size(94, 25);
            listPetshop.TabIndex = 11;
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
            // FormPets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(listPetshop);
            Controls.Add(listCidade);
            Controls.Add(listEstado);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(gridPets);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormPets";
            Text = "FormPets";
            ((System.ComponentModel.ISupportInitialize)gridPets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView gridPets;
        private Label label1;
        private Label label3;
        private Label label2;
        private ListBox listEstado;
        private ListBox listCidade;
        private ListBox listPetshop;
        private Label label4;
    }
}