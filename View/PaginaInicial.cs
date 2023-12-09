using MaterialSkin.Controls;
using ProjSincronizaRh.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjSincronizaRh
{
    public partial class PaginaInicial : Form
    {
        public PaginaInicial()
        {
            InitializeComponent();
        }

        private void lblVisaogeral_Click(object sender, EventArgs e)
        {

        }

        private void btnsugestao3_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja mesmo sair ?", "Sincroniza", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
             Application.Exit();
            }
            
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            //minimizar
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            Funcionarios funcionarios = new Funcionarios();
            funcionarios.TopLevel = false;
            funcionarios.Dock = DockStyle.Fill;
            panelCentro.Controls.Clear();//limpa o painel
            panelCentro.Controls.Add(funcionarios);// adiciona o from no painel
            funcionarios.Show();
            panelSelecao.Top = btnFuncionarios.Top;


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair da conta ?", "Sincroniza", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
             Login login = new Login();
                login.Hide();
                login.Show();
            }
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            PaginaInicial inicial = new PaginaInicial();
            inicial.Show();
        }

        private void panelCentro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnsugestao1_Click(object sender, EventArgs e)
        {
            CadastroFunc novo1 = new CadastroFunc();
            novo1.Hide();
            novo1.Show();

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            Relatorios relatorios = new Relatorios();
            relatorios.TopLevel = false;
            relatorios.Dock = DockStyle.Fill;
            panelCentro.Controls.Clear();//limpa o painel
            panelCentro.Controls.Add(relatorios);// adiciona o from no painel
            relatorios.Show();
            panelSelecao.Top = btnRelatorios.Top;
        }

        private void btnRelogiodePonto_Click(object sender, EventArgs e)
        {
            panelSelecao.Top = btnRelogiodePonto.Top;
        }

        private void btnFolhaSalarial_Click(object sender, EventArgs e)
        {
            panelSelecao.Top = btnFolhaSalarial.Top;
        }
    }
}
