using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plusik;

namespace Plusik
{
    public partial class LoginForm : Form
    {
        public static string login = "";
        public LoginForm()
        {
            InitializeComponent();
        }

        private bool LoginCheck()
        {
            if (textBoxLogin.Text.Length > 10)
            {
                MessageBox.Show("Too long");
                textBoxLogin.Text = "";
                return false;
                
            }
            if (textBoxLogin.Text == "") return false;
            for (int i = 0; i < textBoxLogin.Text.Length; i++)
            {
                if (textBoxLogin.Text[i] < 'A' || textBoxLogin.Text[i] > 'z')
                {
                    textBoxLogin.Text = "";
                    return false;
                }
            }
            return true;
        }

        private void TextBoxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (LoginCheck())
                {
                    login = textBoxLogin.Text;
                    this.Close();
                }
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (LoginCheck())
            {
                login = textBoxLogin.Text;
                this.Close();
            }
        }
    }
}
