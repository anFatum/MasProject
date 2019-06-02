﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasProject.DAL;
using MasProject.DAL.Models;

namespace MasProject.GUI
{
    public partial class LogInForm : Form
    {
        private WelcomeForm _welcomeForm;
        public LogInForm(WelcomeForm welcomeForm)
        {
            _welcomeForm = welcomeForm;
            InitializeComponent();
            AlignElementsPosition();
        }

        private void ProceedButton_Click(object sender, EventArgs e)
        {
            User user = null;
            try
            {
                user = DatabaseHelper.LoginUser(emailBox.Text, passwordBox.Text);
                this.Close();
                _welcomeForm.LogInUser(user);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
