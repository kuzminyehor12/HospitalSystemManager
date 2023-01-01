using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HospitalSystemManager.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(Button))
                {
                    ctrl.BackColor = AuthorizationForm.themeColor;
                }
                else if ((ctrl.GetType() == typeof(Label) || ctrl.GetType() == typeof(LinkLabel)) && ctrl != label1)
                {
                    ctrl.ForeColor = AuthorizationForm.ChangeColorBrightness(AuthorizationForm.themeColor, -0.3);
                }
            }
        }

        public static void ActivateButton(object btnSender)
        {
            if (btnSender != null)
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

        private void button1_MouseHover(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            ToDefaultButtonState(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AuthorizationForm auth = new AuthorizationForm();
            auth.Show();
        }


        private bool IsEmailValid(string email)
        {
            Regex correctEmailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return correctEmailRegex.IsMatch(email);
        }
    }
}
