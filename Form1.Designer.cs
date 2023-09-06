namespace HikBRAClient
{
    partial class app
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(app));
            this.headerMenu = new System.Windows.Forms.TabControl();
            this.BoxConfigLeitor = new System.Windows.Forms.TabPage();
            this.bttnInit = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Details = new System.Windows.Forms.TabPage();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelQuantErr = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelQuantImportErr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelPorcSuccess = new System.Windows.Forms.Label();
            this.LabelQuantImportSucess = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tab4 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sugestSolution = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.UserNotCreated = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BoxConsole = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.SelectTemplete = new System.Windows.Forms.ComboBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.SelectType = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.SelectCard = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.SelectNome = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.SelectId = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bttnImport = new System.Windows.Forms.Button();
            this.inputPathFile = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InputPass = new System.Windows.Forms.TextBox();
            this.InputUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NumericPort = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InputHost = new System.Windows.Forms.TextBox();
            this.Protocoll = new System.Windows.Forms.GroupBox();
            this.SelectProtocoll = new System.Windows.Forms.ComboBox();
            this.BoxAjuda = new System.Windows.Forms.TabPage();
            this.openFileDialog_escolheArquivo = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.headerMenu.SuspendLayout();
            this.BoxConfigLeitor.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Details.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.tab4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPort)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.Protocoll.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerMenu
            // 
            this.headerMenu.Controls.Add(this.BoxConfigLeitor);
            this.headerMenu.Controls.Add(this.BoxAjuda);
            this.headerMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.headerMenu.Location = new System.Drawing.Point(0, 0);
            this.headerMenu.Name = "headerMenu";
            this.headerMenu.SelectedIndex = 0;
            this.headerMenu.Size = new System.Drawing.Size(739, 617);
            this.headerMenu.TabIndex = 0;
            // 
            // BoxConfigLeitor
            // 
            this.BoxConfigLeitor.AutoScroll = true;
            this.BoxConfigLeitor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BoxConfigLeitor.Controls.Add(this.bttnInit);
            this.BoxConfigLeitor.Controls.Add(this.groupBox9);
            this.BoxConfigLeitor.Controls.Add(this.groupBox5);
            this.BoxConfigLeitor.Controls.Add(this.groupBox4);
            this.BoxConfigLeitor.Controls.Add(this.groupBox1);
            this.BoxConfigLeitor.Location = new System.Drawing.Point(4, 24);
            this.BoxConfigLeitor.Name = "BoxConfigLeitor";
            this.BoxConfigLeitor.Padding = new System.Windows.Forms.Padding(3);
            this.BoxConfigLeitor.Size = new System.Drawing.Size(731, 589);
            this.BoxConfigLeitor.TabIndex = 0;
            this.BoxConfigLeitor.Text = "Importar Usuário";
            // 
            // bttnInit
            // 
            this.bttnInit.Location = new System.Drawing.Point(594, 254);
            this.bttnInit.Name = "bttnInit";
            this.bttnInit.Size = new System.Drawing.Size(114, 27);
            this.bttnInit.TabIndex = 8;
            this.bttnInit.Text = "INICIAR";
            this.bttnInit.UseVisualStyleBackColor = true;
            this.bttnInit.Click += new System.EventHandler(this.bttnInit_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.Progress);
            this.groupBox9.Controls.Add(this.tabControl1);
            this.groupBox9.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox9.Location = new System.Drawing.Point(3, 287);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(727, 293);
            this.groupBox9.TabIndex = 7;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Log";
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(17, 20);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(697, 24);
            this.Progress.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Details);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(17, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(697, 241);
            this.tabControl1.TabIndex = 5;
            // 
            // Details
            // 
            this.Details.BackColor = System.Drawing.Color.Transparent;
            this.Details.Controls.Add(this.groupBox14);
            this.Details.Controls.Add(this.groupBox13);
            this.Details.Controls.Add(this.tab4);
            this.Details.Location = new System.Drawing.Point(4, 24);
            this.Details.Name = "Details";
            this.Details.Padding = new System.Windows.Forms.Padding(3);
            this.Details.Size = new System.Drawing.Size(689, 213);
            this.Details.TabIndex = 0;
            this.Details.Text = "Detalhes";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.label4);
            this.groupBox14.Controls.Add(this.LabelQuantErr);
            this.groupBox14.Location = new System.Drawing.Point(9, 127);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(177, 73);
            this.groupBox14.TabIndex = 11;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Sistema";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quant. erros:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // LabelQuantErr
            // 
            this.LabelQuantErr.AutoSize = true;
            this.LabelQuantErr.ForeColor = System.Drawing.Color.Crimson;
            this.LabelQuantErr.Location = new System.Drawing.Point(94, 17);
            this.LabelQuantErr.Name = "LabelQuantErr";
            this.LabelQuantErr.Size = new System.Drawing.Size(14, 16);
            this.LabelQuantErr.TabIndex = 8;
            this.LabelQuantErr.Text = "0";
            this.LabelQuantErr.Click += new System.EventHandler(this.LabelQuantErr_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label3);
            this.groupBox13.Controls.Add(this.LabelQuantImportErr);
            this.groupBox13.Controls.Add(this.label1);
            this.groupBox13.Controls.Add(this.LabelPorcSuccess);
            this.groupBox13.Controls.Add(this.LabelQuantImportSucess);
            this.groupBox13.Controls.Add(this.label2);
            this.groupBox13.Location = new System.Drawing.Point(9, 30);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(177, 73);
            this.groupBox13.TabIndex = 10;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Criação Usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuários não criado:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LabelQuantImportErr
            // 
            this.LabelQuantImportErr.AutoSize = true;
            this.LabelQuantImportErr.ForeColor = System.Drawing.Color.Crimson;
            this.LabelQuantImportErr.Location = new System.Drawing.Point(143, 49);
            this.LabelQuantImportErr.Name = "LabelQuantImportErr";
            this.LabelQuantImportErr.Size = new System.Drawing.Size(14, 16);
            this.LabelQuantImportErr.TabIndex = 7;
            this.LabelQuantImportErr.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuários criado:";
            // 
            // LabelPorcSuccess
            // 
            this.LabelPorcSuccess.AutoSize = true;
            this.LabelPorcSuccess.ForeColor = System.Drawing.Color.DarkGreen;
            this.LabelPorcSuccess.Location = new System.Drawing.Point(124, 17);
            this.LabelPorcSuccess.Name = "LabelPorcSuccess";
            this.LabelPorcSuccess.Size = new System.Drawing.Size(40, 16);
            this.LabelPorcSuccess.TabIndex = 5;
            this.LabelPorcSuccess.Text = "100%";
            // 
            // LabelQuantImportSucess
            // 
            this.LabelQuantImportSucess.AutoSize = true;
            this.LabelQuantImportSucess.ForeColor = System.Drawing.Color.DarkGreen;
            this.LabelQuantImportSucess.Location = new System.Drawing.Point(124, 33);
            this.LabelQuantImportSucess.Name = "LabelQuantImportSucess";
            this.LabelQuantImportSucess.Size = new System.Drawing.Size(14, 16);
            this.LabelQuantImportSucess.TabIndex = 6;
            this.LabelQuantImportSucess.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Taxa de sucesso:";
            // 
            // tab4
            // 
            this.tab4.Controls.Add(this.tabPage1);
            this.tab4.Controls.Add(this.tabPage3);
            this.tab4.Location = new System.Drawing.Point(192, 6);
            this.tab4.Name = "tab4";
            this.tab4.SelectedIndex = 0;
            this.tab4.Size = new System.Drawing.Size(487, 201);
            this.tab4.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.sugestSolution);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(479, 173);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sugestão de solução";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // sugestSolution
            // 
            this.sugestSolution.Location = new System.Drawing.Point(6, 6);
            this.sugestSolution.Multiline = true;
            this.sugestSolution.Name = "sugestSolution";
            this.sugestSolution.ReadOnly = true;
            this.sugestSolution.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sugestSolution.Size = new System.Drawing.Size(467, 164);
            this.sugestSolution.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.UserNotCreated);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(479, 173);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Usuário não criado";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // UserNotCreated
            // 
            this.UserNotCreated.Location = new System.Drawing.Point(6, 4);
            this.UserNotCreated.Multiline = true;
            this.UserNotCreated.Name = "UserNotCreated";
            this.UserNotCreated.ReadOnly = true;
            this.UserNotCreated.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UserNotCreated.Size = new System.Drawing.Size(467, 164);
            this.UserNotCreated.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.BoxConsole);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(689, 213);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Console";
            // 
            // BoxConsole
            // 
            this.BoxConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BoxConsole.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.BoxConsole.Location = new System.Drawing.Point(6, 9);
            this.BoxConsole.Multiline = true;
            this.BoxConsole.Name = "BoxConsole";
            this.BoxConsole.ReadOnly = true;
            this.BoxConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BoxConsole.Size = new System.Drawing.Size(676, 198);
            this.BoxConsole.TabIndex = 0;
            this.BoxConsole.Text = "@Ysh-rael";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox12);
            this.groupBox5.Controls.Add(this.groupBox11);
            this.groupBox5.Controls.Add(this.groupBox8);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox5.Location = new System.Drawing.Point(3, 154);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(722, 94);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Campos a serem preenchidos";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.SelectTemplete);
            this.groupBox12.Location = new System.Drawing.Point(593, 20);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(121, 50);
            this.groupBox12.TabIndex = 6;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Templete";
            // 
            // SelectTemplete
            // 
            this.SelectTemplete.FormattingEnabled = true;
            this.SelectTemplete.Location = new System.Drawing.Point(6, 21);
            this.SelectTemplete.Name = "SelectTemplete";
            this.SelectTemplete.Size = new System.Drawing.Size(109, 23);
            this.SelectTemplete.TabIndex = 0;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.SelectType);
            this.groupBox11.Location = new System.Drawing.Point(449, 20);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(127, 50);
            this.groupBox11.TabIndex = 5;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Tipo";
            // 
            // SelectType
            // 
            this.SelectType.FormattingEnabled = true;
            this.SelectType.Location = new System.Drawing.Point(6, 21);
            this.SelectType.Name = "SelectType";
            this.SelectType.Size = new System.Drawing.Size(115, 23);
            this.SelectType.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.SelectCard);
            this.groupBox8.Location = new System.Drawing.Point(303, 20);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(127, 50);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Cartao";
            // 
            // SelectCard
            // 
            this.SelectCard.Enabled = false;
            this.SelectCard.FormattingEnabled = true;
            this.SelectCard.Location = new System.Drawing.Point(6, 21);
            this.SelectCard.Name = "SelectCard";
            this.SelectCard.Size = new System.Drawing.Size(115, 23);
            this.SelectCard.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.SelectNome);
            this.groupBox7.Location = new System.Drawing.Point(156, 20);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(129, 50);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Nome";
            // 
            // SelectNome
            // 
            this.SelectNome.FormattingEnabled = true;
            this.SelectNome.Location = new System.Drawing.Point(6, 21);
            this.SelectNome.Name = "SelectNome";
            this.SelectNome.Size = new System.Drawing.Size(117, 23);
            this.SelectNome.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.SelectId);
            this.groupBox6.Location = new System.Drawing.Point(9, 20);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(129, 50);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ID";
            // 
            // SelectId
            // 
            this.SelectId.FormattingEnabled = true;
            this.SelectId.Location = new System.Drawing.Point(6, 21);
            this.SelectId.Name = "SelectId";
            this.SelectId.Size = new System.Drawing.Size(117, 23);
            this.SelectId.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bttnImport);
            this.groupBox4.Controls.Add(this.inputPathFile);
            this.groupBox4.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox4.Location = new System.Drawing.Point(351, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(379, 67);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Base de Dados";
            // 
            // bttnImport
            // 
            this.bttnImport.ForeColor = System.Drawing.Color.Black;
            this.bttnImport.Location = new System.Drawing.Point(289, 35);
            this.bttnImport.Name = "bttnImport";
            this.bttnImport.Size = new System.Drawing.Size(74, 28);
            this.bttnImport.TabIndex = 2;
            this.bttnImport.Text = "Buscar";
            this.bttnImport.UseVisualStyleBackColor = true;
            this.bttnImport.Click += new System.EventHandler(this.bttnImport_Click);
            // 
            // inputPathFile
            // 
            this.inputPathFile.Location = new System.Drawing.Point(6, 39);
            this.inputPathFile.Name = "inputPathFile";
            this.inputPathFile.ReadOnly = true;
            this.inputPathFile.Size = new System.Drawing.Size(277, 21);
            this.inputPathFile.TabIndex = 1;
            this.inputPathFile.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InputPass);
            this.groupBox1.Controls.Add(this.InputUser);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Protocoll);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leitor";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // InputPass
            // 
            this.InputPass.Location = new System.Drawing.Point(103, 99);
            this.InputPass.Name = "InputPass";
            this.InputPass.Size = new System.Drawing.Size(207, 21);
            this.InputPass.TabIndex = 7;
            this.InputPass.UseSystemPasswordChar = true;
            // 
            // InputUser
            // 
            this.InputUser.Location = new System.Drawing.Point(103, 72);
            this.InputUser.Name = "InputUser";
            this.InputUser.Size = new System.Drawing.Size(207, 21);
            this.InputUser.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(19, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(19, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Usuário";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NumericPort);
            this.groupBox3.Location = new System.Drawing.Point(239, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(78, 48);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Port";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // NumericPort
            // 
            this.NumericPort.Location = new System.Drawing.Point(6, 22);
            this.NumericPort.Name = "NumericPort";
            this.NumericPort.Size = new System.Drawing.Size(65, 21);
            this.NumericPort.TabIndex = 3;
            this.NumericPort.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.InputHost);
            this.groupBox2.Location = new System.Drawing.Point(97, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 49);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Host";
            // 
            // InputHost
            // 
            this.InputHost.Location = new System.Drawing.Point(6, 22);
            this.InputHost.Name = "InputHost";
            this.InputHost.Size = new System.Drawing.Size(124, 21);
            this.InputHost.TabIndex = 0;
            // 
            // Protocoll
            // 
            this.Protocoll.Controls.Add(this.SelectProtocoll);
            this.Protocoll.Location = new System.Drawing.Point(6, 17);
            this.Protocoll.Name = "Protocoll";
            this.Protocoll.Size = new System.Drawing.Size(85, 50);
            this.Protocoll.TabIndex = 1;
            this.Protocoll.TabStop = false;
            this.Protocoll.Text = "Protocoll";
            this.Protocoll.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // SelectProtocoll
            // 
            this.SelectProtocoll.Enabled = false;
            this.SelectProtocoll.FormattingEnabled = true;
            this.SelectProtocoll.Items.AddRange(new object[] {
            "HTTP",
            "HTTPS"});
            this.SelectProtocoll.Location = new System.Drawing.Point(6, 21);
            this.SelectProtocoll.Name = "SelectProtocoll";
            this.SelectProtocoll.Size = new System.Drawing.Size(74, 23);
            this.SelectProtocoll.TabIndex = 0;
            this.SelectProtocoll.Text = "HTTP";
            // 
            // BoxAjuda
            // 
            this.BoxAjuda.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BoxAjuda.Location = new System.Drawing.Point(4, 24);
            this.BoxAjuda.Name = "BoxAjuda";
            this.BoxAjuda.Padding = new System.Windows.Forms.Padding(3);
            this.BoxAjuda.Size = new System.Drawing.Size(731, 589);
            this.BoxAjuda.TabIndex = 1;
            this.BoxAjuda.Text = "Ajuda";
            this.BoxAjuda.Click += new System.EventHandler(this.BoxAjuda_Click);
            // 
            // openFileDialog_escolheArquivo
            // 
            this.openFileDialog_escolheArquivo.FileName = "openFileDialog_escolheArquivo";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(743, 621);
            this.Controls.Add(this.headerMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "app";
            this.Text = "Hik Client";
            this.headerMenu.ResumeLayout(false);
            this.BoxConfigLeitor.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Details.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.tab4.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericPort)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Protocoll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl headerMenu;
        private System.Windows.Forms.TabPage BoxConfigLeitor;
        private System.Windows.Forms.TabPage BoxAjuda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Protocoll;
        private System.Windows.Forms.ComboBox SelectProtocoll;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown NumericPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox InputHost;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bttnImport;
        private System.Windows.Forms.TextBox inputPathFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog_escolheArquivo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox SelectCard;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox SelectNome;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox SelectId;
        private System.Windows.Forms.Button bttnInit;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Details;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox BoxConsole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sugestSolution;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LabelQuantErr;
        private System.Windows.Forms.Label LabelQuantImportErr;
        private System.Windows.Forms.Label LabelQuantImportSucess;
        private System.Windows.Forms.Label LabelPorcSuccess;
        private System.Windows.Forms.TextBox InputPass;
        private System.Windows.Forms.TextBox InputUser;
        private System.Windows.Forms.TabControl tab4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox UserNotCreated;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.ComboBox SelectTemplete;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ComboBox SelectType;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox14;
    }
}

