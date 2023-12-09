using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjSincronizaRh.View
{
    public partial class Funcionarios : Form
    {
        public Funcionarios()
        {
            InitializeComponent();

        }

        private void funcionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.funcionarioBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bd_SincronizaDataSet2);
                //tableAdapterManager.Enable=false;   
                MessageBox.Show("Dados Salvos com Sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro verifique os valores informados...");

            }

        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bd_SincronizaDataSet2.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.bd_SincronizaDataSet2.Funcionario);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.funcionarioTableAdapter.FillBy(this.bd_SincronizaDataSet2.Funcionario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma a Exclusão do registro ?", "Sincroniza", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    funcionarioBindingSource.RemoveCurrent();
                    funcionarioTableAdapter.Update(bd_SincronizaDataSet2.Funcionario);
                    //funcionarioBindingSource.RemoveCurrent();
                    //funcionarioTableAdapter.Update(bd_SincronizaDataSet2.Funcionario);
                }

            }
            catch (Exception)
            {
                funcionarioTableAdapter.Fill(bd_SincronizaDataSet2.Funcionario);
                MessageBox.Show("Registro não pode ser Excluído");
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            funcionarioBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroFunc novocadastro = new CadastroFunc();
            novocadastro.Hide();
            novocadastro.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PaginaInicial voltarpara = new PaginaInicial();
            voltarpara.Hide();
            voltarpara.Show();
        }

        private void funcionarioBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma a Exclusão do registro ?", "Sincroniza", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    funcionarioBindingSource.RemoveCurrent();
                    funcionarioTableAdapter.Update(bd_SincronizaDataSet2.Funcionario);
                    //funcionarioBindingSource.RemoveCurrent();
                    //funcionarioTableAdapter.Update(bd_SincronizaDataSet2.Funcionario);
                }

            }
            catch (Exception)
            {
                funcionarioTableAdapter.Fill(bd_SincronizaDataSet2.Funcionario);
                MessageBox.Show("Registro não pode ser Excluído");
            }
        }

        private void funcionarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PaginaInicial voltar2 = new PaginaInicial();
            voltar2.Hide();
            voltar2.Show();
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

        private void txtProcurar_TextChanged(object sender, EventArgs e)
        {
            //funcionarioBindingSource.Filter = "NomeFunc like '%" + txtProcurar.Text + "%'";
            try
            {
                string filtro = txtProcurar.Text.Trim();

                if (string.IsNullOrEmpty(filtro))
                {
                    // Se o campo de pesquisa estiver vazio, exibir todos os dados
                    funcionarioBindingSource.RemoveFilter();
                }
                else
                {
                    // Filtrar os dados com base no texto inserido no campo de pesquisa
                    string expressao = string.Format("Sexo LIKE '%{0}%' OR Nome_Funcionario LIKE '%{0}%' OR Departamento LIKE '%{0}%' OR Cargo LIKE '%{0}%'", filtro);
                    funcionarioBindingSource.Filter = expressao;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao filtrar dados: {ex.Message}", "Sincroniza", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            frmFuncionarioRelatorio nvorelatorio = new frmFuncionarioRelatorio();
           
            nvorelatorio.ShowDialog();

        }
    }
}

     



