namespace ProjSincronizaRh
{
    partial class CadastroFunc
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
            System.Windows.Forms.Label idFuncionarioLabel;
            System.Windows.Forms.Label nome_FuncionarioLabel;
            System.Windows.Forms.Label data_NascimentoLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label rgLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label tel_FixoLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label cargoLabel;
            System.Windows.Forms.Label departamentoLabel;
            System.Windows.Forms.Label salario_BaseLabel;
            System.Windows.Forms.Label data_AdmissaoLabel;
            this.panelTopologin = new System.Windows.Forms.Panel();
            this.btnminimize = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.bd_SincronizaDataSet2 = new ProjSincronizaRh.Bd_SincronizaDataSet2();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter = new ProjSincronizaRh.Bd_SincronizaDataSet2TableAdapters.FuncionarioTableAdapter();
            this.tableAdapterManager = new ProjSincronizaRh.Bd_SincronizaDataSet2TableAdapters.TableAdapterManager();
            this.materialScrollBar1 = new MaterialSkin.Controls.MaterialScrollBar();
            this.funcionarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.funcionarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.idFuncionarioLabel1 = new System.Windows.Forms.Label();
            this.nome_FuncionarioTextBox = new System.Windows.Forms.TextBox();
            this.data_NascimentoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.rgMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tel_FixoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.celularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cargoTextBox = new System.Windows.Forms.TextBox();
            this.departamentoTextBox = new System.Windows.Forms.TextBox();
            this.salario_BaseTextBox = new System.Windows.Forms.TextBox();
            this.data_AdmissaoMonthCalendar = new System.Windows.Forms.MonthCalendar();
            idFuncionarioLabel = new System.Windows.Forms.Label();
            nome_FuncionarioLabel = new System.Windows.Forms.Label();
            data_NascimentoLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            rgLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            tel_FixoLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            cargoLabel = new System.Windows.Forms.Label();
            departamentoLabel = new System.Windows.Forms.Label();
            salario_BaseLabel = new System.Windows.Forms.Label();
            data_AdmissaoLabel = new System.Windows.Forms.Label();
            this.panelTopologin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bd_SincronizaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingNavigator)).BeginInit();
            this.funcionarioBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idFuncionarioLabel
            // 
            idFuncionarioLabel.AutoSize = true;
            idFuncionarioLabel.BackColor = System.Drawing.Color.LightGray;
            idFuncionarioLabel.Location = new System.Drawing.Point(17, 59);
            idFuncionarioLabel.Name = "idFuncionarioLabel";
            idFuncionarioLabel.Size = new System.Drawing.Size(133, 25);
            idFuncionarioLabel.TabIndex = 0;
            idFuncionarioLabel.Text = "id Funcionário";
            // 
            // nome_FuncionarioLabel
            // 
            nome_FuncionarioLabel.AutoSize = true;
            nome_FuncionarioLabel.BackColor = System.Drawing.Color.LightGray;
            nome_FuncionarioLabel.Location = new System.Drawing.Point(17, 103);
            nome_FuncionarioLabel.Name = "nome_FuncionarioLabel";
            nome_FuncionarioLabel.Size = new System.Drawing.Size(154, 25);
            nome_FuncionarioLabel.TabIndex = 2;
            nome_FuncionarioLabel.Text = "Nome Completo";
            // 
            // data_NascimentoLabel
            // 
            data_NascimentoLabel.AutoSize = true;
            data_NascimentoLabel.BackColor = System.Drawing.Color.LightGray;
            data_NascimentoLabel.Location = new System.Drawing.Point(17, 155);
            data_NascimentoLabel.Name = "data_NascimentoLabel";
            data_NascimentoLabel.Size = new System.Drawing.Size(187, 25);
            data_NascimentoLabel.TabIndex = 4;
            data_NascimentoLabel.Text = "Data de Nascimento";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.BackColor = System.Drawing.Color.LightGray;
            sexoLabel.Location = new System.Drawing.Point(466, 158);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(58, 25);
            sexoLabel.TabIndex = 6;
            sexoLabel.Text = "Sexo:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.LightGray;
            emailLabel.Location = new System.Drawing.Point(362, 220);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(59, 25);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email";
            // 
            // rgLabel
            // 
            rgLabel.AutoSize = true;
            rgLabel.BackColor = System.Drawing.Color.LightGray;
            rgLabel.Location = new System.Drawing.Point(919, 163);
            rgLabel.Name = "rgLabel";
            rgLabel.Size = new System.Drawing.Size(35, 25);
            rgLabel.TabIndex = 10;
            rgLabel.Text = "Rg";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.BackColor = System.Drawing.Color.LightGray;
            cpfLabel.Location = new System.Drawing.Point(17, 212);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(42, 25);
            cpfLabel.TabIndex = 12;
            cpfLabel.Text = "Cpf";
            // 
            // tel_FixoLabel
            // 
            tel_FixoLabel.AutoSize = true;
            tel_FixoLabel.BackColor = System.Drawing.Color.LightGray;
            tel_FixoLabel.Location = new System.Drawing.Point(17, 269);
            tel_FixoLabel.Name = "tel_FixoLabel";
            tel_FixoLabel.Size = new System.Drawing.Size(76, 25);
            tel_FixoLabel.TabIndex = 14;
            tel_FixoLabel.Text = "Tel Fixo";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.BackColor = System.Drawing.Color.LightGray;
            celularLabel.Location = new System.Drawing.Point(362, 269);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(72, 25);
            celularLabel.TabIndex = 16;
            celularLabel.Text = "Celular";
            // 
            // cargoLabel
            // 
            cargoLabel.AutoSize = true;
            cargoLabel.BackColor = System.Drawing.Color.LightGray;
            cargoLabel.Location = new System.Drawing.Point(30, 409);
            cargoLabel.Name = "cargoLabel";
            cargoLabel.Size = new System.Drawing.Size(63, 25);
            cargoLabel.TabIndex = 18;
            cargoLabel.Text = "Cargo";
            // 
            // departamentoLabel
            // 
            departamentoLabel.AutoSize = true;
            departamentoLabel.BackColor = System.Drawing.Color.LightGray;
            departamentoLabel.Location = new System.Drawing.Point(576, 409);
            departamentoLabel.Name = "departamentoLabel";
            departamentoLabel.Size = new System.Drawing.Size(137, 25);
            departamentoLabel.TabIndex = 20;
            departamentoLabel.Text = "Departamento";
            // 
            // salario_BaseLabel
            // 
            salario_BaseLabel.AutoSize = true;
            salario_BaseLabel.BackColor = System.Drawing.Color.LightGray;
            salario_BaseLabel.Location = new System.Drawing.Point(30, 472);
            salario_BaseLabel.Name = "salario_BaseLabel";
            salario_BaseLabel.Size = new System.Drawing.Size(142, 25);
            salario_BaseLabel.TabIndex = 22;
            salario_BaseLabel.Text = "Salário Base R$";
            // 
            // data_AdmissaoLabel
            // 
            data_AdmissaoLabel.AutoSize = true;
            data_AdmissaoLabel.BackColor = System.Drawing.Color.LightGray;
            data_AdmissaoLabel.Location = new System.Drawing.Point(434, 472);
            data_AdmissaoLabel.Name = "data_AdmissaoLabel";
            data_AdmissaoLabel.Size = new System.Drawing.Size(167, 25);
            data_AdmissaoLabel.TabIndex = 24;
            data_AdmissaoLabel.Text = "Data de Admissão";
            // 
            // panelTopologin
            // 
            this.panelTopologin.BackColor = System.Drawing.Color.Silver;
            this.panelTopologin.Controls.Add(this.btnminimize);
            this.panelTopologin.Controls.Add(this.btnFechar);
            this.panelTopologin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopologin.Location = new System.Drawing.Point(0, 0);
            this.panelTopologin.Name = "panelTopologin";
            this.panelTopologin.Size = new System.Drawing.Size(1268, 36);
            this.panelTopologin.TabIndex = 2;
            // 
            // btnminimize
            // 
            this.btnminimize.BackColor = System.Drawing.Color.White;
            this.btnminimize.BackgroundImage = global::ProjSincronizaRh.Properties.Resources.fullscreen_exit_FILL0_wght400_GRAD0_opsz24;
            this.btnminimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnminimize.Location = new System.Drawing.Point(1166, 3);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(35, 30);
            this.btnminimize.TabIndex = 2;
            this.btnminimize.UseVisualStyleBackColor = false;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.White;
            this.btnFechar.BackgroundImage = global::ProjSincronizaRh.Properties.Resources.close_FILL0_wght400_GRAD0_opsz24;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Location = new System.Drawing.Point(1207, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(35, 30);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // bd_SincronizaDataSet2
            // 
            this.bd_SincronizaDataSet2.DataSetName = "Bd_SincronizaDataSet2";
            this.bd_SincronizaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            this.funcionarioBindingSource.DataSource = this.bd_SincronizaDataSet2;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FuncionarioTableAdapter = this.funcionarioTableAdapter;
            this.tableAdapterManager.LoginSistemaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjSincronizaRh.Bd_SincronizaDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // materialScrollBar1
            // 
            this.materialScrollBar1.Depth = 0;
            this.materialScrollBar1.Location = new System.Drawing.Point(1232, 119);
            this.materialScrollBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialScrollBar1.Name = "materialScrollBar1";
            this.materialScrollBar1.Orientation = MaterialSkin.Controls.MaterialScrollOrientation.Vertical;
            this.materialScrollBar1.Size = new System.Drawing.Size(10, 554);
            this.materialScrollBar1.TabIndex = 18;
            this.materialScrollBar1.Text = "materialScrollBar1";
            // 
            // funcionarioBindingNavigator
            // 
            this.funcionarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.funcionarioBindingNavigator.BackColor = System.Drawing.SystemColors.GrayText;
            this.funcionarioBindingNavigator.BackgroundImage = global::ProjSincronizaRh.Properties.Resources.Captura_de_tela_2023_10_25_165129;
            this.funcionarioBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.funcionarioBindingNavigator.BindingSource = this.funcionarioBindingSource;
            this.funcionarioBindingNavigator.CountItem = null;
            this.funcionarioBindingNavigator.DeleteItem = null;
            this.funcionarioBindingNavigator.ImageScalingSize = new System.Drawing.Size(26, 26);
            this.funcionarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.bindingNavigatorAddNewItem,
            this.funcionarioBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.funcionarioBindingNavigator.Location = new System.Drawing.Point(0, 36);
            this.funcionarioBindingNavigator.MoveFirstItem = null;
            this.funcionarioBindingNavigator.MoveLastItem = null;
            this.funcionarioBindingNavigator.MoveNextItem = null;
            this.funcionarioBindingNavigator.MovePreviousItem = null;
            this.funcionarioBindingNavigator.Name = "funcionarioBindingNavigator";
            this.funcionarioBindingNavigator.PositionItem = null;
            this.funcionarioBindingNavigator.Size = new System.Drawing.Size(1268, 33);
            this.funcionarioBindingNavigator.TabIndex = 4;
            this.funcionarioBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bindingNavigatorAddNewItem.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorAddNewItem.Image = global::ProjSincronizaRh.Properties.Resources._1891033_add_append_blue_cercle_create_icon;
            this.bindingNavigatorAddNewItem.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(130, 30);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripButton2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.Image = global::ProjSincronizaRh.Properties.Resources._216242_home_icon3;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(117, 30);
            this.toolStripButton2.Text = "Pagina Inicial";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // funcionarioBindingNavigatorSaveItem
            // 
            this.funcionarioBindingNavigatorSaveItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.funcionarioBindingNavigatorSaveItem.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcionarioBindingNavigatorSaveItem.Image = global::ProjSincronizaRh.Properties.Resources._8666542_save_icon1;
            this.funcionarioBindingNavigatorSaveItem.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.funcionarioBindingNavigatorSaveItem.Name = "funcionarioBindingNavigatorSaveItem";
            this.funcionarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(74, 30);
            this.funcionarioBindingNavigatorSaveItem.Text = "Salvar";
            this.funcionarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.funcionarioBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripButton1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = global::ProjSincronizaRh.Properties.Resources._4781838_cancel_close_delete_exit_logout_icon2;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(89, 30);
            this.toolStripButton1.Text = "Cancelar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::ProjSincronizaRh.Properties.Resources.Captura_de_tela_2023_10_25_172244;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(idFuncionarioLabel);
            this.groupBox1.Controls.Add(this.idFuncionarioLabel1);
            this.groupBox1.Controls.Add(nome_FuncionarioLabel);
            this.groupBox1.Controls.Add(this.nome_FuncionarioTextBox);
            this.groupBox1.Controls.Add(data_NascimentoLabel);
            this.groupBox1.Controls.Add(this.data_NascimentoMaskedTextBox);
            this.groupBox1.Controls.Add(sexoLabel);
            this.groupBox1.Controls.Add(this.sexoComboBox);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(rgLabel);
            this.groupBox1.Controls.Add(this.rgMaskedTextBox);
            this.groupBox1.Controls.Add(cpfLabel);
            this.groupBox1.Controls.Add(this.cpfMaskedTextBox);
            this.groupBox1.Controls.Add(tel_FixoLabel);
            this.groupBox1.Controls.Add(this.tel_FixoMaskedTextBox);
            this.groupBox1.Controls.Add(celularLabel);
            this.groupBox1.Controls.Add(this.celularMaskedTextBox);
            this.groupBox1.Controls.Add(cargoLabel);
            this.groupBox1.Controls.Add(this.cargoTextBox);
            this.groupBox1.Controls.Add(departamentoLabel);
            this.groupBox1.Controls.Add(this.departamentoTextBox);
            this.groupBox1.Controls.Add(salario_BaseLabel);
            this.groupBox1.Controls.Add(this.salario_BaseTextBox);
            this.groupBox1.Controls.Add(data_AdmissaoLabel);
            this.groupBox1.Controls.Add(this.data_AdmissaoMonthCalendar);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(46, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1155, 789);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar novo Funcionário";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.BackgroundImage = global::ProjSincronizaRh.Properties.Resources.Captura_de_tela_2023_10_24_221737;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(530, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 31);
            this.button3.TabIndex = 27;
            this.button3.Text = "Dados de Contrato";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.BackgroundImage = global::ProjSincronizaRh.Properties.Resources.Captura_de_tela_2023_10_24_221737;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(530, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 31);
            this.button2.TabIndex = 26;
            this.button2.Text = "Dados Pessoais";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // idFuncionarioLabel1
            // 
            this.idFuncionarioLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "idFuncionario", true));
            this.idFuncionarioLabel1.Location = new System.Drawing.Point(198, 61);
            this.idFuncionarioLabel1.Name = "idFuncionarioLabel1";
            this.idFuncionarioLabel1.Size = new System.Drawing.Size(178, 23);
            this.idFuncionarioLabel1.TabIndex = 1;
            this.idFuncionarioLabel1.Text = "label1";
            // 
            // nome_FuncionarioTextBox
            // 
            this.nome_FuncionarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Nome_Funcionario", true));
            this.nome_FuncionarioTextBox.Location = new System.Drawing.Point(194, 95);
            this.nome_FuncionarioTextBox.Name = "nome_FuncionarioTextBox";
            this.nome_FuncionarioTextBox.Size = new System.Drawing.Size(922, 33);
            this.nome_FuncionarioTextBox.TabIndex = 3;
            // 
            // data_NascimentoMaskedTextBox
            // 
            this.data_NascimentoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Data_Nascimento", true));
            this.data_NascimentoMaskedTextBox.Location = new System.Drawing.Point(248, 150);
            this.data_NascimentoMaskedTextBox.Mask = "00/00/0000";
            this.data_NascimentoMaskedTextBox.Name = "data_NascimentoMaskedTextBox";
            this.data_NascimentoMaskedTextBox.Size = new System.Drawing.Size(178, 33);
            this.data_NascimentoMaskedTextBox.TabIndex = 5;
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Sexo", true));
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.sexoComboBox.Location = new System.Drawing.Point(540, 150);
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(178, 33);
            this.sexoComboBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(452, 212);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(664, 33);
            this.emailTextBox.TabIndex = 9;
            // 
            // rgMaskedTextBox
            // 
            this.rgMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Rg", true));
            this.rgMaskedTextBox.Location = new System.Drawing.Point(970, 158);
            this.rgMaskedTextBox.Mask = "00.000.000-00";
            this.rgMaskedTextBox.Name = "rgMaskedTextBox";
            this.rgMaskedTextBox.Size = new System.Drawing.Size(146, 33);
            this.rgMaskedTextBox.TabIndex = 11;
            // 
            // cpfMaskedTextBox
            // 
            this.cpfMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Cpf", true));
            this.cpfMaskedTextBox.Location = new System.Drawing.Point(82, 204);
            this.cpfMaskedTextBox.Mask = "000.000.000-00";
            this.cpfMaskedTextBox.Name = "cpfMaskedTextBox";
            this.cpfMaskedTextBox.Size = new System.Drawing.Size(178, 33);
            this.cpfMaskedTextBox.TabIndex = 13;
            // 
            // tel_FixoMaskedTextBox
            // 
            this.tel_FixoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Tel_Fixo", true));
            this.tel_FixoMaskedTextBox.Location = new System.Drawing.Point(120, 261);
            this.tel_FixoMaskedTextBox.Mask = "(00) 0000-0000";
            this.tel_FixoMaskedTextBox.Name = "tel_FixoMaskedTextBox";
            this.tel_FixoMaskedTextBox.Size = new System.Drawing.Size(178, 33);
            this.tel_FixoMaskedTextBox.TabIndex = 15;
            // 
            // celularMaskedTextBox
            // 
            this.celularMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Celular", true));
            this.celularMaskedTextBox.Location = new System.Drawing.Point(452, 266);
            this.celularMaskedTextBox.Mask = "(00) 00000-0000";
            this.celularMaskedTextBox.Name = "celularMaskedTextBox";
            this.celularMaskedTextBox.Size = new System.Drawing.Size(178, 33);
            this.celularMaskedTextBox.TabIndex = 17;
            // 
            // cargoTextBox
            // 
            this.cargoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Cargo", true));
            this.cargoTextBox.Location = new System.Drawing.Point(120, 406);
            this.cargoTextBox.Name = "cargoTextBox";
            this.cargoTextBox.Size = new System.Drawing.Size(383, 33);
            this.cargoTextBox.TabIndex = 19;
            // 
            // departamentoTextBox
            // 
            this.departamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Departamento", true));
            this.departamentoTextBox.Location = new System.Drawing.Point(733, 401);
            this.departamentoTextBox.Name = "departamentoTextBox";
            this.departamentoTextBox.Size = new System.Drawing.Size(383, 33);
            this.departamentoTextBox.TabIndex = 21;
            // 
            // salario_BaseTextBox
            // 
            this.salario_BaseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Salario_Base", true));
            this.salario_BaseTextBox.Location = new System.Drawing.Point(209, 464);
            this.salario_BaseTextBox.Name = "salario_BaseTextBox";
            this.salario_BaseTextBox.Size = new System.Drawing.Size(178, 33);
            this.salario_BaseTextBox.TabIndex = 23;
            // 
            // data_AdmissaoMonthCalendar
            // 
            this.data_AdmissaoMonthCalendar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.data_AdmissaoMonthCalendar.DataBindings.Add(new System.Windows.Forms.Binding("SelectionRange", this.funcionarioBindingSource, "Data_Admissao", true));
            this.data_AdmissaoMonthCalendar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.data_AdmissaoMonthCalendar.Location = new System.Drawing.Point(633, 472);
            this.data_AdmissaoMonthCalendar.Name = "data_AdmissaoMonthCalendar";
            this.data_AdmissaoMonthCalendar.TabIndex = 25;
            this.data_AdmissaoMonthCalendar.TitleBackColor = System.Drawing.SystemColors.Highlight;
            this.data_AdmissaoMonthCalendar.TitleForeColor = System.Drawing.SystemColors.Highlight;
            this.data_AdmissaoMonthCalendar.TrailingForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // CadastroFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1268, 749);
            this.Controls.Add(this.materialScrollBar1);
            this.Controls.Add(this.funcionarioBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelTopologin);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CadastroFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroFunc";
            this.Load += new System.EventHandler(this.CadastroFunc_Load);
            this.panelTopologin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bd_SincronizaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingNavigator)).EndInit();
            this.funcionarioBindingNavigator.ResumeLayout(false);
            this.funcionarioBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTopologin;
        private System.Windows.Forms.Button btnminimize;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bd_SincronizaDataSet2 bd_SincronizaDataSet2;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private Bd_SincronizaDataSet2TableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private Bd_SincronizaDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator funcionarioBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton funcionarioBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idFuncionarioLabel1;
        private System.Windows.Forms.TextBox nome_FuncionarioTextBox;
        private System.Windows.Forms.MaskedTextBox data_NascimentoMaskedTextBox;
        private System.Windows.Forms.ComboBox sexoComboBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.MaskedTextBox rgMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cpfMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox tel_FixoMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox celularMaskedTextBox;
        private System.Windows.Forms.TextBox cargoTextBox;
        private System.Windows.Forms.TextBox departamentoTextBox;
        private System.Windows.Forms.TextBox salario_BaseTextBox;
        private System.Windows.Forms.MonthCalendar data_AdmissaoMonthCalendar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private MaterialSkin.Controls.MaterialScrollBar materialScrollBar1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}