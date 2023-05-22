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
            panelMenu = new Panel();
            buttonCalendar = new Button();
            buttonVet = new Button();
            buttonPetshop = new Button();
            buttonPets = new Button();
            buttonHome = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            panelTitle = new Panel();
            LblTitle = new Label();
            panelDesk = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(52, 52, 76);
            panelMenu.Controls.Add(buttonCalendar);
            panelMenu.Controls.Add(buttonVet);
            panelMenu.Controls.Add(buttonPetshop);
            panelMenu.Controls.Add(buttonPets);
            panelMenu.Controls.Add(buttonHome);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 577);
            panelMenu.TabIndex = 0;
            // 
            // buttonCalendar
            // 
            buttonCalendar.Dock = DockStyle.Top;
            buttonCalendar.FlatAppearance.BorderSize = 0;
            buttonCalendar.FlatStyle = FlatStyle.Flat;
            buttonCalendar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCalendar.ForeColor = Color.Gainsboro;
            buttonCalendar.Location = new Point(0, 368);
            buttonCalendar.Name = "buttonCalendar";
            buttonCalendar.Size = new Size(220, 70);
            buttonCalendar.TabIndex = 5;
            buttonCalendar.Text = "Calendario";
            buttonCalendar.UseVisualStyleBackColor = true;
            buttonCalendar.Click += buttonCalendar_Click;
            // 
            // buttonVet
            // 
            buttonVet.Dock = DockStyle.Top;
            buttonVet.FlatAppearance.BorderSize = 0;
            buttonVet.FlatStyle = FlatStyle.Flat;
            buttonVet.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVet.ForeColor = Color.Gainsboro;
            buttonVet.Location = new Point(0, 298);
            buttonVet.Name = "buttonVet";
            buttonVet.Size = new Size(220, 70);
            buttonVet.TabIndex = 4;
            buttonVet.Text = "Veterinarios";
            buttonVet.UseVisualStyleBackColor = true;
            buttonVet.Click += buttonVet_Click;
            // 
            // buttonPetshop
            // 
            buttonPetshop.Dock = DockStyle.Top;
            buttonPetshop.FlatAppearance.BorderSize = 0;
            buttonPetshop.FlatStyle = FlatStyle.Flat;
            buttonPetshop.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPetshop.ForeColor = Color.Gainsboro;
            buttonPetshop.Location = new Point(0, 228);
            buttonPetshop.Name = "buttonPetshop";
            buttonPetshop.Size = new Size(220, 70);
            buttonPetshop.TabIndex = 3;
            buttonPetshop.Text = "Petshop";
            buttonPetshop.UseVisualStyleBackColor = true;
            buttonPetshop.Click += buttonPetshop_Click;
            // 
            // buttonPets
            // 
            buttonPets.Dock = DockStyle.Top;
            buttonPets.FlatAppearance.BorderSize = 0;
            buttonPets.FlatStyle = FlatStyle.Flat;
            buttonPets.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPets.ForeColor = Color.Gainsboro;
            buttonPets.Location = new Point(0, 158);
            buttonPets.Name = "buttonPets";
            buttonPets.Size = new Size(220, 70);
            buttonPets.TabIndex = 2;
            buttonPets.Text = "Pets";
            buttonPets.UseVisualStyleBackColor = true;
            buttonPets.Click += buttonPets_Click;
            // 
            // buttonHome
            // 
            buttonHome.Dock = DockStyle.Top;
            buttonHome.FlatAppearance.BorderSize = 0;
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHome.ForeColor = Color.Gainsboro;
            buttonHome.Location = new Point(0, 88);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(220, 70);
            buttonHome.TabIndex = 1;
            buttonHome.Text = "Home";
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonHome_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(32, 32, 53);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 88);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(67, 26);
            label1.Name = "label1";
            label1.Size = new Size(82, 37);
            label1.TabIndex = 0;
            label1.Text = "Pétis";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(0, 150, 136);
            panelTitle.Controls.Add(LblTitle);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(220, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(804, 88);
            panelTitle.TabIndex = 1;
            // 
            // LblTitle
            // 
            LblTitle.Anchor = AnchorStyles.None;
            LblTitle.AutoSize = true;
            LblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblTitle.ForeColor = Color.White;
            LblTitle.Location = new Point(348, 26);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(77, 30);
            LblTitle.TabIndex = 0;
            LblTitle.Text = "HOME";
            // 
            // panelDesk
            // 
            panelDesk.Dock = DockStyle.Fill;
            panelDesk.Location = new Point(220, 88);
            panelDesk.Name = "panelDesk";
            panelDesk.Size = new Size(804, 489);
            panelDesk.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 577);
            Controls.Add(panelDesk);
            Controls.Add(panelTitle);
            Controls.Add(panelMenu);
            Name = "Form1";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button buttonHome;
        private Button buttonCalendar;
        private Button buttonVet;
        private Button buttonPetshop;
        private Button buttonPets;
        private Label label1;
        private Panel panelTitle;
        private Label LblTitle;
        private Panel panelDesk;
    }
}