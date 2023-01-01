using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalSystemManager.Forms
{
    public partial class ValidationForm : Form
    {
        public ValidationForm()
        {
            InitializeComponent();
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control ctrl in this.Controls)
            {
                if(ctrl.GetType() == typeof(Button))
                {
                    ctrl.BackColor = AuthorizationForm.themeColor;
                }
                else if(ctrl.GetType() == typeof(Label))
                {
                    ctrl.ForeColor = AuthorizationForm.ChangeColorBrightness(AuthorizationForm.themeColor, -0.3);
                }
            }
        }
        public static void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                Button hoveredButton = (Button)btnSender;
                hoveredButton.BackColor = AuthorizationForm.ChangeColorBrightness(AuthorizationForm.themeColor, 0.4);
            }
        }

        public static void ToDefaultButtonState(object btnSender) 
        {
            Button isLeftButton = (Button)btnSender;
            isLeftButton.BackColor = AuthorizationForm.themeColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActiveForm.Hide();

            RegisterForm register = new RegisterForm();
            register.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActiveForm.Hide();

            DoctorMenuForm menu = new DoctorMenuForm();
            menu.Show();
        }

        private void registerBtn_MouseHover(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void logInBtn_MouseHover(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void registerBtn_MouseLeave(object sender, EventArgs e)
        {
            ToDefaultButtonState(sender);
        }

        private void logInBtn_MouseLeave(object sender, EventArgs e)
        {
            ToDefaultButtonState(sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
