using System.ComponentModel;

namespace MasProject.GUI
{
    partial class WelcomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.signUpButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.msgPanel = new System.Windows.Forms.Panel();
            this.WeclomeMessageLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.msgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.Controls.Add(this.buttonsPanel);
            this.mainPanel.Controls.Add(this.msgPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 450);
            this.mainPanel.TabIndex = 0;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttonsPanel.Controls.Add(this.signUpButton);
            this.buttonsPanel.Controls.Add(this.loginButton);
            this.buttonsPanel.Location = new System.Drawing.Point(216, 229);
            this.buttonsPanel.MinimumSize = new System.Drawing.Size(340, 95);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(367, 95);
            this.buttonsPanel.TabIndex = 2;
            // 
            // signUpButton
            // 
            this.signUpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signUpButton.Location = new System.Drawing.Point(235, 35);
            this.signUpButton.MaximumSize = new System.Drawing.Size(75, 23);
            this.signUpButton.MinimumSize = new System.Drawing.Size(75, 23);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(75, 23);
            this.signUpButton.TabIndex = 1;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.Location = new System.Drawing.Point(59, 34);
            this.loginButton.MaximumSize = new System.Drawing.Size(75, 23);
            this.loginButton.MinimumSize = new System.Drawing.Size(75, 23);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Log in";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // msgPanel
            // 
            this.msgPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.msgPanel.Controls.Add(this.WeclomeMessageLabel);
            this.msgPanel.Location = new System.Drawing.Point(139, 77);
            this.msgPanel.Name = "msgPanel";
            this.msgPanel.Size = new System.Drawing.Size(560, 122);
            this.msgPanel.TabIndex = 1;
            // 
            // WeclomeMessageLabel
            // 
            this.WeclomeMessageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeclomeMessageLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeclomeMessageLabel.Location = new System.Drawing.Point(0, 0);
            this.WeclomeMessageLabel.Name = "WeclomeMessageLabel";
            this.WeclomeMessageLabel.Size = new System.Drawing.Size(560, 122);
            this.WeclomeMessageLabel.TabIndex = 0;
            this.WeclomeMessageLabel.Text = "Welcome to the airport flight reservation system";
            this.WeclomeMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "WelcomeForm";
            this.Text = "Welcome Page";
            this.Resize += new System.EventHandler(this.LogInForm_Resize);
            this.mainPanel.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.msgPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label WeclomeMessageLabel;
        private System.Windows.Forms.Panel msgPanel;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Button loginButton;
    }
}