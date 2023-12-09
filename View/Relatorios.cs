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
    public partial class Relatorios : Form
    {
        public Relatorios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Relatorios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bd_SincronizaDataSet4.Ferias'. Você pode movê-la ou removê-la conforme necessário.
            this.feriasTableAdapter.Fill(this.bd_SincronizaDataSet4.Ferias);
            // TODO: esta linha de código carrega dados na tabela 'bd_SincronizaDataSet2.LoginSistema'. Você pode movê-la ou removê-la conforme necessário.
            this.loginSistemaTableAdapter.Fill(this.bd_SincronizaDataSet2.LoginSistema);

    
        }

        private void crystalOpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.feriasTableAdapter.FillBy(this.bd_SincronizaDataSet4.Ferias);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
