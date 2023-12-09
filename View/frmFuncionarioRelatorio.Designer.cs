namespace ProjSincronizaRh.View
{
    partial class frmFuncionarioRelatorio
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bd_SincronizaDataSet3 = new ProjSincronizaRh.Bd_SincronizaDataSet3();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter = new ProjSincronizaRh.Bd_SincronizaDataSet3TableAdapters.FuncionarioTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.bd_SincronizaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bd_SincronizaDataSet3
            // 
            this.bd_SincronizaDataSet3.DataSetName = "Bd_SincronizaDataSet3";
            this.bd_SincronizaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            this.funcionarioBindingSource.DataSource = this.bd_SincronizaDataSet3;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.funcionarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjSincronizaRh.View.RelatorioFunc1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1252, 687);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmFuncionarioRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 687);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmFuncionarioRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFuncionarioRelatorio";
            this.Load += new System.EventHandler(this.frmFuncionarioRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_SincronizaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bd_SincronizaDataSet3 bd_SincronizaDataSet3;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private Bd_SincronizaDataSet3TableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}