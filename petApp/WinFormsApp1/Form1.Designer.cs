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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonCalendar = new System.Windows.Forms.Button();
            this.buttonVet = new System.Windows.Forms.Button();
            this.buttonPetshop = new System.Windows.Forms.Button();
            this.buttonPets = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.panelDesk = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.buttonCalendar);
            this.panelMenu.Controls.Add(this.buttonVet);
            this.panelMenu.Controls.Add(this.buttonPetshop);
            this.panelMenu.Controls.Add(this.buttonPets);
            this.panelMenu.Controls.Add(this.buttonHome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 577);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonCalendar
            // 
            this.buttonCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCalendar.FlatAppearance.BorderSize = 0;
            this.buttonCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalendar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCalendar.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCalendar.Location = new System.Drawing.Point(0, 368);
            this.buttonCalendar.Name = "buttonCalendar";
            this.buttonCalendar.Size = new System.Drawing.Size(220, 70);
            this.buttonCalendar.TabIndex = 5;
            this.buttonCalendar.Text = "Calendario";
            this.buttonCalendar.UseVisualStyleBackColor = true;
            this.buttonCalendar.Click += new System.EventHandler(this.buttonCalendar_Click);
            // 
            // buttonVet
            // 
            this.buttonVet.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVet.FlatAppearance.BorderSize = 0;
            this.buttonVet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonVet.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonVet.Location = new System.Drawing.Point(0, 298);
            this.buttonVet.Name = "buttonVet";
            this.buttonVet.Size = new System.Drawing.Size(220, 70);
            this.buttonVet.TabIndex = 4;
            this.buttonVet.Text = "Veterinarios";
            this.buttonVet.UseVisualStyleBackColor = true;
            this.buttonVet.Click += new System.EventHandler(this.buttonVet_Click);
            // 
            // buttonPetshop
            // 
            this.buttonPetshop.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPetshop.FlatAppearance.BorderSize = 0;
            this.buttonPetshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPetshop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPetshop.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPetshop.Location = new System.Drawing.Point(0, 228);
            this.buttonPetshop.Name = "buttonPetshop";
            this.buttonPetshop.Size = new System.Drawing.Size(220, 70);
            this.buttonPetshop.TabIndex = 3;
            this.buttonPetshop.Text = "Petshop";
            this.buttonPetshop.UseVisualStyleBackColor = true;
            this.buttonPetshop.Click += new System.EventHandler(this.buttonPetshop_Click);
            // 
            // buttonPets
            // 
            this.buttonPets.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPets.FlatAppearance.BorderSize = 0;
            this.buttonPets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPets.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPets.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPets.Location = new System.Drawing.Point(0, 158);
            this.buttonPets.Name = "buttonPets";
            this.buttonPets.Size = new System.Drawing.Size(220, 70);
            this.buttonPets.TabIndex = 2;
            this.buttonPets.Text = "Pets";
            this.buttonPets.UseVisualStyleBackColor = true;
            this.buttonPets.Click += new System.EventHandler(this.buttonPets_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonHome.Location = new System.Drawing.Point(0, 88);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(220, 70);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(53)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 88);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "nome da empresa";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitle.Controls.Add(this.LblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(804, 88);
            this.panelTitle.TabIndex = 1;
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(348, 26);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(77, 30);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "HOME";
            // 
            // panelDesk
            // 
            this.panelDesk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesk.Location = new System.Drawing.Point(220, 88);
            this.panelDesk.Name = "panelDesk";
            this.panelDesk.Size = new System.Drawing.Size(804, 489);
            this.panelDesk.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 577);
            this.Controls.Add(this.panelDesk);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

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