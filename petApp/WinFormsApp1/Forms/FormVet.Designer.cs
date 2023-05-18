namespace WinFormsApp1.Forms
{
    partial class FormVet
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
            label4 = new Label();
            listVet = new ListBox();
            listCidade = new ListBox();
            listEstado = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            gridPets = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)gridPets).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(252, 22);
            label4.Name = "label4";
            label4.Size = new Size(222, 28);
            label4.TabIndex = 23;
            label4.Text = "Tabela de Veterinários";
            // 
            // listVet
            // 
            listVet.Anchor = AnchorStyles.None;
            listVet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listVet.FormattingEnabled = true;
            listVet.ItemHeight = 21;
            listVet.Location = new Point(104, 164);
            listVet.Name = "listVet";
            listVet.Size = new Size(94, 25);
            listVet.TabIndex = 22;
            // 
            // listCidade
            // 
            listCidade.Anchor = AnchorStyles.None;
            listCidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listCidade.FormattingEnabled = true;
            listCidade.ItemHeight = 21;
            listCidade.Location = new Point(104, 135);
            listCidade.Name = "listCidade";
            listCidade.Size = new Size(94, 25);
            listCidade.TabIndex = 21;
            // 
            // listEstado
            // 
            listEstado.Anchor = AnchorStyles.None;
            listEstado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listEstado.FormattingEnabled = true;
            listEstado.ItemHeight = 21;
            listEstado.Location = new Point(104, 104);
            listEstado.Name = "listEstado";
            listEstado.Size = new Size(94, 25);
            listEstado.TabIndex = 20;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(5, 168);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 19;
            label2.Text = "Veterinários";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(40, 135);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 18;
            label3.Text = "Cidade";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(42, 104);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 17;
            label1.Text = "Estado";
            // 
            // gridPets
            // 
            gridPets.Anchor = AnchorStyles.None;
            gridPets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPets.Location = new Point(252, 53);
            gridPets.Name = "gridPets";
            gridPets.RowTemplate.Height = 25;
            gridPets.Size = new Size(536, 320);
            gridPets.TabIndex = 16;
            gridPets.CellContentClick += gridPets_CellContentClick;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(659, 379);
            button3.Name = "button3";
            button3.Size = new Size(129, 49);
            button3.TabIndex = 15;
            button3.Text = "Informações";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(457, 379);
            button2.Name = "button2";
            button2.Size = new Size(129, 49);
            button2.TabIndex = 14;
            button2.Text = "Enviar Pedido";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(252, 379);
            button1.Name = "button1";
            button1.Size = new Size(129, 49);
            button1.TabIndex = 13;
            button1.Text = "Contate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormVet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(listVet);
            Controls.Add(listCidade);
            Controls.Add(listEstado);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(gridPets);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormVet";
            Text = "FormVet";
            ((System.ComponentModel.ISupportInitialize)gridPets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private ListBox listVet;
        private ListBox listCidade;
        private ListBox listEstado;
        private Label label2;
        private Label label3;
        private Label label1;
        private DataGridView gridPets;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}