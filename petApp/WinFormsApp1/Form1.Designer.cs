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
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelLogo.SuspendLayout();
            panelTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(52, 52, 76);
            panelMenu.Controls.Add(pictureBox5);
            panelMenu.Controls.Add(pictureBox4);
            panelMenu.Controls.Add(pictureBox3);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(pictureBox2);
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
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources._64287691;
            pictureBox5.Location = new Point(12, 368);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(77, 70);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._88115;
            pictureBox4.Location = new Point(12, 298);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(77, 70);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._1642972;
            pictureBox3.Location = new Point(12, 228);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(77, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._103717;
            pictureBox1.Location = new Point(12, 158);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._25694;
            pictureBox2.Location = new Point(12, 88);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // buttonCalendar
            // 
            buttonCalendar.Anchor = AnchorStyles.None;
            buttonCalendar.FlatAppearance.BorderSize = 0;
            buttonCalendar.FlatStyle = FlatStyle.Flat;
            buttonCalendar.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCalendar.ForeColor = Color.Gainsboro;
            buttonCalendar.Location = new Point(0, 368);
            buttonCalendar.Name = "buttonCalendar";
            buttonCalendar.Size = new Size(220, 70);
            buttonCalendar.TabIndex = 5;
            buttonCalendar.Text = "Calendario";
            buttonCalendar.TextAlign = ContentAlignment.MiddleRight;
            buttonCalendar.UseVisualStyleBackColor = true;
            buttonCalendar.Click += buttonCalendar_Click;
            // 
            // buttonVet
            // 
            buttonVet.Dock = DockStyle.Top;
            buttonVet.FlatAppearance.BorderSize = 0;
            buttonVet.FlatStyle = FlatStyle.Flat;
            buttonVet.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonVet.ForeColor = Color.Gainsboro;
            buttonVet.Location = new Point(0, 298);
            buttonVet.Name = "buttonVet";
            buttonVet.Size = new Size(220, 70);
            buttonVet.TabIndex = 4;
            buttonVet.Text = "Veterinarios";
            buttonVet.TextAlign = ContentAlignment.MiddleRight;
            buttonVet.UseVisualStyleBackColor = true;
            buttonVet.Click += buttonVet_Click;
            // 
            // buttonPetshop
            // 
            buttonPetshop.Dock = DockStyle.Top;
            buttonPetshop.FlatAppearance.BorderSize = 0;
            buttonPetshop.FlatStyle = FlatStyle.Flat;
            buttonPetshop.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPetshop.ForeColor = Color.Gainsboro;
            buttonPetshop.Location = new Point(0, 228);
            buttonPetshop.Name = "buttonPetshop";
            buttonPetshop.Size = new Size(220, 70);
            buttonPetshop.TabIndex = 3;
            buttonPetshop.Text = "Petshop";
            buttonPetshop.TextAlign = ContentAlignment.MiddleRight;
            buttonPetshop.UseVisualStyleBackColor = true;
            buttonPetshop.Click += buttonPetshop_Click;
            // 
            // buttonPets
            // 
            buttonPets.Dock = DockStyle.Top;
            buttonPets.FlatAppearance.BorderSize = 0;
            buttonPets.FlatStyle = FlatStyle.Flat;
            buttonPets.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPets.ForeColor = Color.Gainsboro;
            buttonPets.Location = new Point(0, 158);
            buttonPets.Name = "buttonPets";
            buttonPets.Size = new Size(220, 70);
            buttonPets.TabIndex = 2;
            buttonPets.Text = "Pets";
            buttonPets.TextAlign = ContentAlignment.MiddleRight;
            buttonPets.UseVisualStyleBackColor = true;
            buttonPets.Click += buttonPets_Click;
            // 
            // buttonHome
            // 
            buttonHome.Dock = DockStyle.Top;
            buttonHome.FlatAppearance.BorderSize = 0;
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHome.ForeColor = Color.Gainsboro;
            buttonHome.Location = new Point(0, 88);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(220, 70);
            buttonHome.TabIndex = 1;
            buttonHome.Text = "Home";
            buttonHome.TextAlign = ContentAlignment.MiddleRight;
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
            label1.Location = new Point(113, 26);
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
            LblTitle.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblTitle.ForeColor = Color.White;
            LblTitle.Location = new Point(348, 26);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(79, 30);
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
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
    }
}