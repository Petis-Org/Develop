using static WinFormsApp1.Theme;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // privates
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activateForm;

        // Construtor
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
                    panelTitle.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(52, 52, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            ActivateButton(btnSender);
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesk.Controls.Add(childForm);
            this.panelDesk.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            LblTitle.Text = childForm.Text;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new Forms.FormPets(), sender);
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new Forms.FormPetshop(), sender);
        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new Forms.FormVet(), sender);
        //}

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new Forms.FormCalendar(), sender);
        //}

        private void buttonHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHome(), sender);
        }

        private void buttonPets_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormPets(), sender);
        }

        private void buttonPetshop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormPetshop(), sender);
        }

        private void buttonVet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormVet(), sender);
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCalendar(), sender);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //OpenChildForm(new Forms.FormHome(), sender);
        }
    }
}