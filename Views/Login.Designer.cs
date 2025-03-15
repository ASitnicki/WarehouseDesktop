namespace WarehouseDesktop.Views
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            splitContainer1 = new SplitContainer();
            resetCredentials = new LinkLabel();
            submitButton = new Button();
            keepCredentialsBox = new CheckBox();
            langFlagPL = new PictureBox();
            langFlagEN = new PictureBox();
            showPasswordBox = new PictureBox();
            passwordLabel = new Label();
            loginLabel = new Label();
            passwordTextBox = new TextBox();
            loginTextBox = new TextBox();
            panel1 = new Panel();
            loginLabelTop = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)langFlagPL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)langFlagEN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showPasswordBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(splitContainer1, "splitContainer1");
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(resetCredentials);
            splitContainer1.Panel2.Controls.Add(submitButton);
            splitContainer1.Panel2.Controls.Add(keepCredentialsBox);
            splitContainer1.Panel2.Controls.Add(langFlagPL);
            splitContainer1.Panel2.Controls.Add(langFlagEN);
            splitContainer1.Panel2.Controls.Add(showPasswordBox);
            splitContainer1.Panel2.Controls.Add(passwordLabel);
            splitContainer1.Panel2.Controls.Add(loginLabel);
            splitContainer1.Panel2.Controls.Add(passwordTextBox);
            splitContainer1.Panel2.Controls.Add(loginTextBox);
            // 
            // resetCredentials
            // 
            resources.ApplyResources(resetCredentials, "resetCredentials");
            resetCredentials.Name = "resetCredentials";
            resetCredentials.TabStop = true;
            resetCredentials.VisitedLinkColor = Color.Blue;
            resetCredentials.LinkClicked += resetCredentials_LinkClicked;
            // 
            // submitButton
            // 
            resources.ApplyResources(submitButton, "submitButton");
            submitButton.Name = "submitButton";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // keepCredentialsBox
            // 
            resources.ApplyResources(keepCredentialsBox, "keepCredentialsBox");
            keepCredentialsBox.Name = "keepCredentialsBox";
            keepCredentialsBox.UseVisualStyleBackColor = true;
            // 
            // langFlagPL
            // 
            langFlagPL.BackColor = Color.Crimson;
            resources.ApplyResources(langFlagPL, "langFlagPL");
            langFlagPL.Name = "langFlagPL";
            langFlagPL.TabStop = false;
            langFlagPL.Click += langFlagPL_Click;
            // 
            // langFlagEN
            // 
            langFlagEN.BackColor = Color.Navy;
            resources.ApplyResources(langFlagEN, "langFlagEN");
            langFlagEN.Name = "langFlagEN";
            langFlagEN.TabStop = false;
            langFlagEN.Click += langFlagEN_Click;
            // 
            // showPasswordBox
            // 
            showPasswordBox.BackColor = Color.Firebrick;
            resources.ApplyResources(showPasswordBox, "showPasswordBox");
            showPasswordBox.Name = "showPasswordBox";
            showPasswordBox.TabStop = false;
            showPasswordBox.Click += showPasswordBox_Click;
            // 
            // passwordLabel
            // 
            resources.ApplyResources(passwordLabel, "passwordLabel");
            passwordLabel.Name = "passwordLabel";
            // 
            // loginLabel
            // 
            resources.ApplyResources(loginLabel, "loginLabel");
            loginLabel.Name = "loginLabel";
            // 
            // passwordTextBox
            // 
            resources.ApplyResources(passwordTextBox, "passwordTextBox");
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.KeyDown += passwordTextBox_KeyPress;
            // 
            // loginTextBox
            // 
            resources.ApplyResources(loginTextBox, "loginTextBox");
            loginTextBox.Name = "loginTextBox";
            loginTextBox.KeyPress += loginTextBox_KeyPress;
            // 
            // panel1
            // 
            panel1.Controls.Add(loginLabelTop);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // loginLabelTop
            // 
            resources.ApplyResources(loginLabelTop, "loginLabelTop");
            loginLabelTop.Name = "loginLabelTop";
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Name = "LoginForm";
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)langFlagPL).EndInit();
            ((System.ComponentModel.ISupportInitialize)langFlagEN).EndInit();
            ((System.ComponentModel.ISupportInitialize)showPasswordBox).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label loginLabelTop;
        private SplitContainer splitContainer1;
        private PictureBox showPasswordBox;
        private Label passwordLabel;
        private Label loginLabel;
        private TextBox passwordTextBox;
        private TextBox loginTextBox;
        private PictureBox langFlagPL;
        private PictureBox langFlagEN;
        private LinkLabel resetCredentials;
        private Button submitButton;
        private CheckBox keepCredentialsBox;
    }
}