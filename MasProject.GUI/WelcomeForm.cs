using System.Windows.Forms;
using System;
using MasProject.DAL.Models;
namespace MasProject.GUI
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            buttonsPanel.Size = new System.Drawing.Size(Convert.ToInt32(Math.Round(buttonsPanel.Parent.Width * 0.6, 0)),
                                                        Convert.ToInt32(Math.Round(buttonsPanel.Parent.Height * 0.2, 0)));
            buttonsPanel.Left = (buttonsPanel.Parent.Width - buttonsPanel.Width) / 2;
            loginButton.Top = (loginButton.Parent.Height - loginButton.Height) / 2;
            signUpButton.Top = (signUpButton.Parent.Height - signUpButton.Height) / 2;
            loginButton.Left = (loginButton.Parent.Width - loginButton.Width) / 4;
            signUpButton.Left = (signUpButton.Parent.Width - signUpButton.Width) * 3 / 4;
        }

        private void LogInForm_Resize(object sender, System.EventArgs e)
        {
            Init();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var form = new LogInForm(this);
            form.ShowDialog();
        }
        public void LogInUser(User user)
        {
            var form = new MainForm(user, this);
            //form.FormClosed += (s, args) => this.Close();
            //form.Hide
            form.Show();
            this.Hide();
        }
    }
}