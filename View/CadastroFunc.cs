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
    public partial class CadastroFunc : Form
    {
        public CadastroFunc()
        {
            InitializeComponent();
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
            this.WindowState = FormWindowState.Minimized;
        }

        private void funcionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.funcionarioBindingSource.EndEdit();
                //funcionarioTableAdapter.Update(this.bd_SincronizaDataSet2.Funcionario);
                tableAdapterManager.UpdateAll(this.bd_SincronizaDataSet2);
                groupBox1.Enabled = false;
                MessageBox.Show("Dados Salvos com Sucesso!", "Sincroniza");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro verifique os valores informados...", "Sincroniza");

            }

        }

        private void CadastroFunc_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bd_SincronizaDataSet2.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.bd_SincronizaDataSet2.Funcionario);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           PaginaInicial pagina = new PaginaInicial();
            pagina.Hide();
            pagina.Show();


            // Funcionarios voltar1 = new Funcionarios();
            //voltar1.Hide();
            //voltar1.Show();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            funcionarioBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            PaginaInicial pagina = new PaginaInicial();
            pagina.Hide();
            pagina.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
