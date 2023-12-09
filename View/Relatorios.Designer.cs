namespace ProjSincronizaRh.View
{
    partial class Relatorios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.loginSistemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_SincronizaDataSet2 = new ProjSincronizaRh.Bd_SincronizaDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.loginSistemaTableAdapter = new ProjSincronizaRh.Bd_SincronizaDataSet2TableAdapters.LoginSistemaTableAdapter();
            this.funcionarioDataGridView = new System.Windows.Forms.DataGridView();
            this.idFeriasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtddiasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiantamento13DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicioPeriodoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fimPeriodoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_SincronizaDataSet4 = new ProjSincronizaRh.Bd_SincronizaDataSet4();
            this.feriasTableAdapter = new ProjSincronizaRh.Bd_SincronizaDataSet4TableAdapters.FeriasTableAdapter();
            this.tableAdapterManager = new ProjSincronizaRh.Bd_SincronizaDataSet4TableAdapters.TableAdapterManager();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.brnFerias = new System.Windows.Forms.Button();
            this.btnComprovantes = new System.Windows.Forms.Button();
            this.btnMudanca = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFuncionariosAtivos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loginSistemaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_SincronizaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_SincronizaDataSet4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginSistemaBindingSource
            // 
            this.loginSistemaBindingSource.DataMember = "LoginSistema";
            this.loginSistemaBindingSource.DataSource = this.bd_SincronizaDataSet2;
            // 
            // bd_SincronizaDataSet2
            // 
            this.bd_SincronizaDataSet2.DataSetName = "Bd_SincronizaDataSet2";
            this.bd_SincronizaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gerar novo Relatório:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(636, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecione a opção desejada*";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Funcionários Ativos",
            "Mudanças de Cargo",
            "Comprovantes de Pagamento",
            "Férias"});
            this.comboBox1.Location = new System.Drawing.Point(555, 200);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 29);
            this.comboBox1.TabIndex = 3;
            // 
            // loginSistemaTableAdapter
            // 
            this.loginSistemaTableAdapter.ClearBeforeFill = true;
            // 
            // funcionarioDataGridView
            // 
            this.funcionarioDataGridView.AllowUserToAddRows = false;
            this.funcionarioDataGridView.AutoGenerateColumns = false;
            this.funcionarioDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.funcionarioDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.funcionarioDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.funcionarioDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.funcionarioDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.funcionarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.funcionarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFeriasDataGridViewTextBoxColumn,
            this.qtddiasDataGridViewTextBoxColumn,
            this.adiantamento13DataGridViewTextBoxColumn,
            this.valorPagoDataGridViewTextBoxColumn,
            this.inicioPeriodoDataGridViewTextBoxColumn,
            this.fimPeriodoDataGridViewTextBoxColumn});
            this.funcionarioDataGridView.DataSource = this.feriasBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.funcionarioDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.funcionarioDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.funcionarioDataGridView.EnableHeadersVisualStyles = false;
            this.funcionarioDataGridView.GridColor = System.Drawing.SystemColors.HotTrack;
            this.funcionarioDataGridView.Location = new System.Drawing.Point(235, 238);
            this.funcionarioDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.funcionarioDataGridView.Name = "funcionarioDataGridView";
            this.funcionarioDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.funcionarioDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.funcionarioDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.funcionarioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.funcionarioDataGridView.Size = new System.Drawing.Size(533, 216);
            this.funcionarioDataGridView.TabIndex = 5;
            // 
            // idFeriasDataGridViewTextBoxColumn
            // 
            this.idFeriasDataGridViewTextBoxColumn.DataPropertyName = "idFerias";
            this.idFeriasDataGridViewTextBoxColumn.HeaderText = "id Ferias";
            this.idFeriasDataGridViewTextBoxColumn.Name = "idFeriasDataGridViewTextBoxColumn";
            this.idFeriasDataGridViewTextBoxColumn.ReadOnly = true;
            this.idFeriasDataGridViewTextBoxColumn.Width = 81;
            // 
            // qtddiasDataGridViewTextBoxColumn
            // 
            this.qtddiasDataGridViewTextBoxColumn.DataPropertyName = "Qtd_dias";
            this.qtddiasDataGridViewTextBoxColumn.HeaderText = "Qtd de Dias";
            this.qtddiasDataGridViewTextBoxColumn.Name = "qtddiasDataGridViewTextBoxColumn";
            this.qtddiasDataGridViewTextBoxColumn.Width = 96;
            // 
            // adiantamento13DataGridViewTextBoxColumn
            // 
            this.adiantamento13DataGridViewTextBoxColumn.DataPropertyName = "Adiantamento_13";
            this.adiantamento13DataGridViewTextBoxColumn.HeaderText = "Adiantamento 13°";
            this.adiantamento13DataGridViewTextBoxColumn.Name = "adiantamento13DataGridViewTextBoxColumn";
            this.adiantamento13DataGridViewTextBoxColumn.Width = 121;
            // 
            // valorPagoDataGridViewTextBoxColumn
            // 
            this.valorPagoDataGridViewTextBoxColumn.DataPropertyName = "Valor_Pago";
            this.valorPagoDataGridViewTextBoxColumn.HeaderText = "Valor Pago R$";
            this.valorPagoDataGridViewTextBoxColumn.Name = "valorPagoDataGridViewTextBoxColumn";
            this.valorPagoDataGridViewTextBoxColumn.Width = 95;
            // 
            // inicioPeriodoDataGridViewTextBoxColumn
            // 
            this.inicioPeriodoDataGridViewTextBoxColumn.DataPropertyName = "Inicio_Periodo";
            this.inicioPeriodoDataGridViewTextBoxColumn.HeaderText = "Inicio Férias";
            this.inicioPeriodoDataGridViewTextBoxColumn.Name = "inicioPeriodoDataGridViewTextBoxColumn";
            this.inicioPeriodoDataGridViewTextBoxColumn.Width = 96;
            // 
            // fimPeriodoDataGridViewTextBoxColumn
            // 
            this.fimPeriodoDataGridViewTextBoxColumn.DataPropertyName = "Fim_Periodo";
            this.fimPeriodoDataGridViewTextBoxColumn.HeaderText = "Fim Férias";
            this.fimPeriodoDataGridViewTextBoxColumn.Name = "fimPeriodoDataGridViewTextBoxColumn";
            this.fimPeriodoDataGridViewTextBoxColumn.Width = 88;
            // 
            // feriasBindingSource
            // 
            this.feriasBindingSource.DataMember = "Ferias";
            this.feriasBindingSource.DataSource = this.bd_SincronizaDataSet4;
            // 
            // bd_SincronizaDataSet4
            // 
            this.bd_SincronizaDataSet4.DataSetName = "Bd_SincronizaDataSet4";
            this.bd_SincronizaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feriasTableAdapter
            // 
            this.feriasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContaTableAdapter = null;
            this.tableAdapterManager.DependentesTableAdapter = null;
            this.tableAdapterManager.DescontosTableAdapter = null;
            this.tableAdapterManager.FeriasTableAdapter = this.feriasTableAdapter;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.Horas_TrabalhadasTableAdapter = null;
            this.tableAdapterManager.Mudanca_CargoTableAdapter = null;
            this.tableAdapterManager.RelatoriosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjSincronizaRh.Bd_SincronizaDataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(459, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Exibir Relatório :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(255, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.brnFerias);
            this.panel1.Controls.Add(this.btnComprovantes);
            this.panel1.Controls.Add(this.btnMudanca);
            this.panel1.Controls.Add(this.btnFuncionariosAtivos);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(235, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 98);
            this.panel1.TabIndex = 0;
            // 
            // brnFerias
            // 
            this.brnFerias.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.brnFerias.BackgroundImage = global::ProjSincronizaRh.Properties.Resources.Captura_de_tela_2023_10_24_2217372;
            this.brnFerias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brnFerias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brnFerias.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnFerias.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.brnFerias.Location = new System.Drawing.Point(320, 58);
            this.brnFerias.Name = "brnFerias";
            this.brnFerias.Size = new System.Drawing.Size(177, 29);
            this.brnFerias.TabIndex = 3;
            this.brnFerias.Text = "Férias";
            this.brnFerias.UseVisualStyleBackColor = false;
            // 
            // btnComprovantes
            // 
            this.btnComprovantes.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnComprovantes.BackgroundImage = global::ProjSincronizaRh.Properties.Resources.Captura_de_tela_2023_10_24_2217372;
            this.btnComprovantes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComprovantes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComprovantes.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprovantes.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnComprovantes.Location = new System.Drawing.Point(320, 12);
            this.btnComprovantes.Name = "btnComprovantes";
            this.btnComprovantes.Size = new System.Drawing.Size(177, 29);
            this.btnComprovantes.TabIndex = 2;
            this.btnComprovantes.Text = "Comprovantes \r\nde Pagamento";
            this.btnComprovantes.UseVisualStyleBackColor = false;
            // 
            // btnMudanca
            // 
            this.btnMudanca.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMudanca.BackgroundImage = global::ProjSincronizaRh.Properties.Resources.Captura_de_tela_2023_10_24_2217372;
            this.btnMudanca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMudanca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMudanca.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMudanca.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMudanca.Location = new System.Drawing.Point(36, 58);
            this.btnMudanca.Name = "btnMudanca";
            this.btnMudanca.Size = new System.Drawing.Size(177, 29);
            this.btnMudanca.TabIndex = 1;
            this.btnMudanca.Text = "Mudanças de Cargo";
            this.btnMudanca.UseVisualStyleBackColor = false;
            this.btnMudanca.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.BackgroundImage = global::ProjSincronizaRh.Properties.Resources._2849806_printer_copy_print_multimedia_icon4;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(235, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnFuncionariosAtivos
            // 
            this.btnFuncionariosAtivos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFuncionariosAtivos.BackgroundImage = global::ProjSincronizaRh.Properties.Resources.Captura_de_tela_2023_10_24_2217372;
            this.btnFuncionariosAtivos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFuncionariosAtivos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFuncionariosAtivos.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionariosAtivos.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnFuncionariosAtivos.Location = new System.Drawing.Point(36, 12);
            this.btnFuncionariosAtivos.Name = "btnFuncionariosAtivos";
            this.btnFuncionariosAtivos.Size = new System.Drawing.Size(177, 29);
            this.btnFuncionariosAtivos.TabIndex = 0;
            this.btnFuncionariosAtivos.Text = "Funcionários Ativos";
            this.btnFuncionariosAtivos.UseVisualStyleBackColor = false;
            // 
            // Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(884, 686);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.funcionarioDataGridView);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Relatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorios";
            this.Load += new System.EventHandler(this.Relatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginSistemaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_SincronizaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_SincronizaDataSet4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button brnFerias;
        private System.Windows.Forms.Button btnComprovantes;
        private System.Windows.Forms.Button btnMudanca;
        private System.Windows.Forms.Button btnFuncionariosAtivos;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bd_SincronizaDataSet2 bd_SincronizaDataSet2;
        private System.Windows.Forms.BindingSource loginSistemaBindingSource;
        private Bd_SincronizaDataSet2TableAdapters.LoginSistemaTableAdapter loginSistemaTableAdapter;
        private Bd_SincronizaDataSet4 bd_SincronizaDataSet4;
        private System.Windows.Forms.BindingSource feriasBindingSource;
        private Bd_SincronizaDataSet4TableAdapters.FeriasTableAdapter feriasTableAdapter;
        private Bd_SincronizaDataSet4TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView funcionarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFeriasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtddiasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiantamento13DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicioPeriodoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fimPeriodoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}