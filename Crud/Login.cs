using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace Crud
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var _login = ConfigurationManager.AppSettings["login"];
            var _password = ConfigurationManager.AppSettings["senha"];

            string login = txtLogin.Text;
            string password = txtSenha.Text;

            if (login != _login || password != _password)
            {
                MessageBox.Show("Usuário ou Senha inválido");
                txtLogin.Clear();
                txtSenha.Clear();
                txtLogin.Focus();
                
            }
            else
            {
                var Cadastro = new frmCadastroCliente();
                var result = Cadastro.ShowDialog();
                this.Close();
            }
        }
    }
}
