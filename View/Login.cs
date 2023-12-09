using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjSincronizaRh
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtUsuario.Select();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUsuario.Text.Equals("Gestor") && txtSenha.Text.Equals("teste2023")) //se credenciais forem corretas faça:
                {
                    //MessageBox.Show("Login Válido!", "Sincroniza");
                    PaginaInicial paginaInicial = new PaginaInicial();
                    paginaInicial.Hide();
                    paginaInicial.Show();
                }
                else //se credenciais não forem corretas faça:
                {
                    MessageBox.Show("Usuário ou senha incorretos, Verifique os valores informados!", "Sincroniza", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
               
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair ?", "Sincroniza", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            //minimizar
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBoasvindas_Click(object sender, EventArgs e)
        {

        }
    }
}
