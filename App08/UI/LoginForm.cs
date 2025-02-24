using App08.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App08.UI;
public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void buttonLogin_Click(object sender, EventArgs e)
    {
        AuthService authService = new();
        //var authService2 = new AuthService();
        var (result, msg) =  authService.Login(textBoxUsername.Text, textBoxPassword.Text);
        if (!result)
        {
            MessageBox.Show(msg);
        }

        Hide();
        var frm = new Form1();
        frm.ShowDialog();
        Close();
    }
}
