using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalSystemManager
{
    public partial class AuthorizationForm : Form
    {
        public static Color themeColor { get; set; }

        public AuthorizationForm()
        {
            InitializeComponent();
            themeColor = label1.BackColor;
        }

        private void OpenChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.authorizePanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        public static Color ChangeColorBrightness(Color color, double factor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if(factor < 0)
            {
                factor++;
                red *= factor;
                green *= factor;
                blue *= factor;
            }
            else
            {
                red = (255 - red) * factor + red;
                green = (255 - green) * factor + green;
                blue = (255 - blue) * factor + blue;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ValidationForm());
        }
    }
}
