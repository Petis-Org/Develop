namespace WinFormsApp1.Forms.FormsSecundar
{
    partial class controlPetshopRequest
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
            textPreco = new TextBox();
            comboServ = new ComboBox();
            label4 = new Label();
            comboAnimal = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            comboQuant = new ComboBox();
            lblQuant = new Label();
            comboMarca = new ComboBox();
            button1 = new Button();
            lblMarc = new Label();
            comboMed = new ComboBox();
            lblMed = new Label();
            comboBrinquedos = new ComboBox();
            lblBrinq = new Label();
            SuspendLayout();
            // 
            // textPreco
            // 
            textPreco.Location = new Point(331, 275);
            textPreco.Name = "textPreco";
            textPreco.ReadOnly = true;
            textPreco.Size = new Size(152, 23);
            textPreco.TabIndex = 38;
            // 
            // comboServ
            // 
            comboServ.Anchor = AnchorStyles.None;
            comboServ.DropDownHeight = 80;
            comboServ.DropDownWidth = 90;
            comboServ.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboServ.FormattingEnabled = true;
            comboServ.IntegralHeight = false;
            comboServ.Items.AddRange(new object[] { "Ração", "Banho e tosa", "Cauterização", "Penteados", "Hidratações", "Terapias", "Adestramento", "Brinquedos", "Medicamentos", "Odontologia" });
            comboServ.Location = new Point(331, 138);
            comboServ.Name = "comboServ";
            comboServ.Size = new Size(152, 29);
            comboServ.TabIndex = 37;
            comboServ.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(369, 114);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 36;
            label4.Text = "Serviço";
            // 
            // comboAnimal
            // 
            comboAnimal.Anchor = AnchorStyles.None;
            comboAnimal.DropDownHeight = 80;
            comboAnimal.DropDownWidth = 90;
            comboAnimal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboAnimal.FormattingEnabled = true;
            comboAnimal.IntegralHeight = false;
            comboAnimal.Items.AddRange(new object[] { "Cachorro", "Gato", "Coelho", "Cobra", "Macaco", "Jabuti", "Tartaruga", "Cágado" });
            comboAnimal.Location = new Point(331, 199);
            comboAnimal.Name = "comboAnimal";
            comboAnimal.Size = new Size(152, 29);
            comboAnimal.TabIndex = 35;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(369, 175);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 34;
            label3.Text = "Animal";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(379, 251);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 33;
            label2.Text = "Preço";
            // 
            // comboQuant
            // 
            comboQuant.Anchor = AnchorStyles.None;
            comboQuant.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboQuant.FormattingEnabled = true;
            comboQuant.Location = new Point(173, 199);
            comboQuant.Name = "comboQuant";
            comboQuant.Size = new Size(152, 29);
            comboQuant.TabIndex = 32;
            comboQuant.Visible = false;
            // 
            // lblQuant
            // 
            lblQuant.Anchor = AnchorStyles.None;
            lblQuant.AutoSize = true;
            lblQuant.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuant.Location = new Point(201, 175);
            lblQuant.Name = "lblQuant";
            lblQuant.Size = new Size(91, 21);
            lblQuant.TabIndex = 31;
            lblQuant.Text = "Quantidade";
            lblQuant.Visible = false;
            // 
            // comboMarca
            // 
            comboMarca.Anchor = AnchorStyles.None;
            comboMarca.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboMarca.FormattingEnabled = true;
            comboMarca.Location = new Point(173, 138);
            comboMarca.Name = "comboMarca";
            comboMarca.Size = new Size(152, 29);
            comboMarca.TabIndex = 30;
            comboMarca.Visible = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(331, 304);
            button1.Name = "button1";
            button1.Size = new Size(152, 39);
            button1.TabIndex = 29;
            button1.Text = "Confirma";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblMarc
            // 
            lblMarc.Anchor = AnchorStyles.None;
            lblMarc.AutoSize = true;
            lblMarc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarc.Location = new Point(219, 114);
            lblMarc.Name = "lblMarc";
            lblMarc.Size = new Size(53, 21);
            lblMarc.TabIndex = 28;
            lblMarc.Text = "Marca";
            lblMarc.Visible = false;
            // 
            // comboMed
            // 
            comboMed.Anchor = AnchorStyles.None;
            comboMed.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboMed.FormattingEnabled = true;
            comboMed.Location = new Point(489, 138);
            comboMed.Name = "comboMed";
            comboMed.Size = new Size(152, 29);
            comboMed.TabIndex = 40;
            comboMed.Visible = false;
            // 
            // lblMed
            // 
            lblMed.Anchor = AnchorStyles.None;
            lblMed.AutoSize = true;
            lblMed.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMed.Location = new Point(505, 114);
            lblMed.Name = "lblMed";
            lblMed.Size = new Size(112, 21);
            lblMed.TabIndex = 39;
            lblMed.Text = "Medicamentos";
            lblMed.Visible = false;
            // 
            // comboBrinquedos
            // 
            comboBrinquedos.Anchor = AnchorStyles.None;
            comboBrinquedos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBrinquedos.FormattingEnabled = true;
            comboBrinquedos.Location = new Point(489, 199);
            comboBrinquedos.Name = "comboBrinquedos";
            comboBrinquedos.Size = new Size(152, 29);
            comboBrinquedos.TabIndex = 42;
            comboBrinquedos.Visible = false;
            // 
            // lblBrinq
            // 
            lblBrinq.Anchor = AnchorStyles.None;
            lblBrinq.AutoSize = true;
            lblBrinq.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBrinq.Location = new Point(518, 175);
            lblBrinq.Name = "lblBrinq";
            lblBrinq.Size = new Size(89, 21);
            lblBrinq.TabIndex = 41;
            lblBrinq.Text = "Brinquedos";
            lblBrinq.Visible = false;
            // 
            // controlPetshopRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBrinquedos);
            Controls.Add(lblBrinq);
            Controls.Add(comboMed);
            Controls.Add(lblMed);
            Controls.Add(textPreco);
            Controls.Add(comboServ);
            Controls.Add(label4);
            Controls.Add(comboAnimal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboQuant);
            Controls.Add(lblQuant);
            Controls.Add(comboMarca);
            Controls.Add(button1);
            Controls.Add(lblMarc);
            Name = "controlPetshopRequest";
            Load += controlPetshopRequest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textPreco;
        private ComboBox comboServ;
        private Label label4;
        private ComboBox comboAnimal;
        private Label label3;
        private Label label2;
        private ComboBox comboQuant;
        private Label lblQuant;
        private ComboBox comboMarca;
        private Button button1;
        private Label lblMarc;
        private ComboBox comboMed;
        private Label lblMed;
        private ComboBox comboBrinquedos;
        private Label lblBrinq;
    }
}