﻿namespace App08.UI;

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
        label1 = new Label();
        label2 = new Label();
        textBoxUsername = new TextBox();
        textBoxPassword = new TextBox();
        buttonLogin = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(37, 27);
        label1.Name = "label1";
        label1.Size = new Size(60, 15);
        label1.TabIndex = 0;
        label1.Text = "Username";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(37, 59);
        label2.Name = "label2";
        label2.Size = new Size(57, 15);
        label2.TabIndex = 1;
        label2.Text = "Password";
        // 
        // textBoxUsername
        // 
        textBoxUsername.Location = new Point(131, 24);
        textBoxUsername.Name = "textBoxUsername";
        textBoxUsername.Size = new Size(253, 23);
        textBoxUsername.TabIndex = 2;
        // 
        // textBoxPassword
        // 
        textBoxPassword.Location = new Point(131, 56);
        textBoxPassword.Name = "textBoxPassword";
        textBoxPassword.Size = new Size(253, 23);
        textBoxPassword.TabIndex = 3;
        // 
        // buttonLogin
        // 
        buttonLogin.Location = new Point(309, 102);
        buttonLogin.Name = "buttonLogin";
        buttonLogin.Size = new Size(75, 23);
        buttonLogin.TabIndex = 4;
        buttonLogin.Text = "Login";
        buttonLogin.UseVisualStyleBackColor = true;
        buttonLogin.Click += buttonLogin_Click;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(427, 149);
        Controls.Add(buttonLogin);
        Controls.Add(textBoxPassword);
        Controls.Add(textBoxUsername);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "LoginForm";
        Text = "LoginForm";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox textBoxUsername;
    private TextBox textBoxPassword;
    private Button buttonLogin;
}