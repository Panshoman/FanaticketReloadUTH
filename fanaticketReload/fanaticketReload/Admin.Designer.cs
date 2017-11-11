namespace fanaticketReload_Desktop
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.btnUpdate1 = new System.Windows.Forms.Button();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbNivel = new System.Windows.Forms.ComboBox();
            this.lbNivel = new System.Windows.Forms.Label();
            this.cbExt = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbDepa = new System.Windows.Forms.ComboBox();
            this.TxbPass = new System.Windows.Forms.TextBox();
            this.txbCorreo = new System.Windows.Forms.TextBox();
            this.txbTel = new System.Windows.Forms.TextBox();
            this.txbApM = new System.Windows.Forms.TextBox();
            this.txbApP = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbNick = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbApP = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbDepa = new System.Windows.Forms.Label();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.lbExt = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.lbApM = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stsId = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsName = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsIdArea = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsArea = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsIp = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToOrderColumns = true;
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column13,
            this.Column10,
            this.Column11});
            this.dgvUsuarios.Location = new System.Drawing.Point(232, 63);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(768, 499);
            this.dgvUsuarios.TabIndex = 1;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Login ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 163;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Password";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Apeliido Paterno";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Apellido Materno";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Telefono";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Extension Tel";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Correo";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "Departamento";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Nivel";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Visible = false;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Estatus";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Imagen";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Visible = false;
            // 
            // btnDelete1
            // 
            this.btnDelete1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete1.BackgroundImage")));
            this.btnDelete1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete1.FlatAppearance.BorderSize = 0;
            this.btnDelete1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnDelete1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete1.Location = new System.Drawing.Point(225, 7);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(54, 42);
            this.btnDelete1.TabIndex = 104;
            this.btnDelete1.UseVisualStyleBackColor = false;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete1_Click);
            // 
            // btnUpdate1
            // 
            this.btnUpdate1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate1.BackgroundImage")));
            this.btnUpdate1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate1.FlatAppearance.BorderSize = 0;
            this.btnUpdate1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnUpdate1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate1.Location = new System.Drawing.Point(165, 7);
            this.btnUpdate1.Name = "btnUpdate1";
            this.btnUpdate1.Size = new System.Drawing.Size(54, 42);
            this.btnUpdate1.TabIndex = 103;
            this.btnUpdate1.UseVisualStyleBackColor = false;
            this.btnUpdate1.Click += new System.EventHandler(this.btnUpdate1_Click);
            // 
            // btnAdd1
            // 
            this.btnAdd1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd1.BackgroundImage")));
            this.btnAdd1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd1.FlatAppearance.BorderSize = 0;
            this.btnAdd1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAdd1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd1.Location = new System.Drawing.Point(105, 7);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(54, 42);
            this.btnAdd1.TabIndex = 102;
            this.btnAdd1.UseVisualStyleBackColor = false;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(839, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(54, 42);
            this.btnDelete.TabIndex = 101;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(779, 7);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(54, 42);
            this.btnUpdate.TabIndex = 100;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(719, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(54, 42);
            this.btnAdd.TabIndex = 99;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // cbNivel
            // 
            this.cbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNivel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Items.AddRange(new object[] {
            "ADMINITRADOR",
            "SOPORTE",
            "USUARIO"});
            this.cbNivel.Location = new System.Drawing.Point(99, 377);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(127, 24);
            this.cbNivel.TabIndex = 11;
            // 
            // lbNivel
            // 
            this.lbNivel.AutoSize = true;
            this.lbNivel.BackColor = System.Drawing.Color.Transparent;
            this.lbNivel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNivel.ForeColor = System.Drawing.Color.White;
            this.lbNivel.Location = new System.Drawing.Point(18, 382);
            this.lbNivel.Name = "lbNivel";
            this.lbNivel.Size = new System.Drawing.Size(38, 16);
            this.lbNivel.TabIndex = 129;
            this.lbNivel.Text = "Nivel";
            // 
            // cbExt
            // 
            this.cbExt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExt.Location = new System.Drawing.Point(99, 230);
            this.cbExt.Name = "cbExt";
            this.cbExt.Size = new System.Drawing.Size(127, 24);
            this.cbExt.TabIndex = 6;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cbStatus.Location = new System.Drawing.Point(99, 316);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(127, 24);
            this.cbStatus.TabIndex = 9;
            // 
            // cbDepa
            // 
            this.cbDepa.AllowDrop = true;
            this.cbDepa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepa.FormattingEnabled = true;
            this.cbDepa.Items.AddRange(new object[] {
            "INFORMATICA",
            "ESCOLAR",
            "DAE"});
            this.cbDepa.Location = new System.Drawing.Point(99, 287);
            this.cbDepa.Name = "cbDepa";
            this.cbDepa.Size = new System.Drawing.Size(127, 24);
            this.cbDepa.TabIndex = 8;
            // 
            // TxbPass
            // 
            this.TxbPass.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbPass.Location = new System.Drawing.Point(99, 347);
            this.TxbPass.Name = "TxbPass";
            this.TxbPass.PasswordChar = '*';
            this.TxbPass.Size = new System.Drawing.Size(127, 23);
            this.TxbPass.TabIndex = 10;
            // 
            // txbCorreo
            // 
            this.txbCorreo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCorreo.Location = new System.Drawing.Point(99, 260);
            this.txbCorreo.Name = "txbCorreo";
            this.txbCorreo.Size = new System.Drawing.Size(127, 23);
            this.txbCorreo.TabIndex = 7;
            this.txbCorreo.Leave += new System.EventHandler(this.txbCorreo_Leave);
            // 
            // txbTel
            // 
            this.txbTel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTel.Location = new System.Drawing.Point(99, 202);
            this.txbTel.Name = "txbTel";
            this.txbTel.Size = new System.Drawing.Size(127, 23);
            this.txbTel.TabIndex = 5;
            this.txbTel.Leave += new System.EventHandler(this.txbTel_Leave);
            // 
            // txbApM
            // 
            this.txbApM.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApM.Location = new System.Drawing.Point(99, 169);
            this.txbApM.Name = "txbApM";
            this.txbApM.Size = new System.Drawing.Size(127, 23);
            this.txbApM.TabIndex = 4;
            this.txbApM.Leave += new System.EventHandler(this.txbApM_Leave);
            // 
            // txbApP
            // 
            this.txbApP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApP.Location = new System.Drawing.Point(99, 135);
            this.txbApP.Name = "txbApP";
            this.txbApP.Size = new System.Drawing.Size(127, 23);
            this.txbApP.TabIndex = 3;
            this.txbApP.Leave += new System.EventHandler(this.txbApP_Leave);
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(99, 106);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(127, 23);
            this.txbName.TabIndex = 2;
            this.txbName.Leave += new System.EventHandler(this.txbName_Leave);
            // 
            // txbNick
            // 
            this.txbNick.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNick.Location = new System.Drawing.Point(99, 77);
            this.txbNick.Name = "txbNick";
            this.txbNick.Size = new System.Drawing.Size(127, 23);
            this.txbNick.TabIndex = 1;
            this.txbNick.Leave += new System.EventHandler(this.txbNick_Leave);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(18, 109);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(57, 16);
            this.lbName.TabIndex = 128;
            this.lbName.Text = "Nombre";
            // 
            // lbApP
            // 
            this.lbApP.AutoSize = true;
            this.lbApP.BackColor = System.Drawing.Color.Transparent;
            this.lbApP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApP.ForeColor = System.Drawing.Color.White;
            this.lbApP.Location = new System.Drawing.Point(18, 129);
            this.lbApP.Name = "lbApP";
            this.lbApP.Size = new System.Drawing.Size(63, 32);
            this.lbApP.TabIndex = 127;
            this.lbApP.Text = "Apellido \r\nPaterno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(93, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 126;
            this.label9.Text = "Imagen";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.BackColor = System.Drawing.Color.Transparent;
            this.lbPass.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.ForeColor = System.Drawing.Color.White;
            this.lbPass.Location = new System.Drawing.Point(18, 350);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(71, 16);
            this.lbPass.TabIndex = 125;
            this.lbPass.Text = "Password";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.White;
            this.lbStatus.Location = new System.Drawing.Point(18, 321);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(57, 16);
            this.lbStatus.TabIndex = 124;
            this.lbStatus.Text = "Estatus";
            // 
            // lbDepa
            // 
            this.lbDepa.AutoSize = true;
            this.lbDepa.BackColor = System.Drawing.Color.Transparent;
            this.lbDepa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepa.ForeColor = System.Drawing.Color.White;
            this.lbDepa.Location = new System.Drawing.Point(18, 292);
            this.lbDepa.Name = "lbDepa";
            this.lbDepa.Size = new System.Drawing.Size(40, 16);
            this.lbDepa.TabIndex = 123;
            this.lbDepa.Text = "Area";
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lbCorreo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorreo.ForeColor = System.Drawing.Color.White;
            this.lbCorreo.Location = new System.Drawing.Point(18, 263);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(52, 16);
            this.lbCorreo.TabIndex = 122;
            this.lbCorreo.Text = "Correo";
            // 
            // lbExt
            // 
            this.lbExt.AutoSize = true;
            this.lbExt.BackColor = System.Drawing.Color.Transparent;
            this.lbExt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExt.ForeColor = System.Drawing.Color.White;
            this.lbExt.Location = new System.Drawing.Point(18, 234);
            this.lbExt.Name = "lbExt";
            this.lbExt.Size = new System.Drawing.Size(70, 16);
            this.lbExt.TabIndex = 120;
            this.lbExt.Text = "Extensión";
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.BackColor = System.Drawing.Color.Transparent;
            this.lbTel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTel.ForeColor = System.Drawing.Color.White;
            this.lbTel.Location = new System.Drawing.Point(18, 205);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(63, 16);
            this.lbTel.TabIndex = 118;
            this.lbTel.Text = "Telefono";
            // 
            // lbApM
            // 
            this.lbApM.AutoSize = true;
            this.lbApM.BackColor = System.Drawing.Color.Transparent;
            this.lbApM.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApM.ForeColor = System.Drawing.Color.White;
            this.lbApM.Location = new System.Drawing.Point(18, 166);
            this.lbApM.Name = "lbApM";
            this.lbApM.Size = new System.Drawing.Size(63, 32);
            this.lbApM.TabIndex = 117;
            this.lbApM.Text = "Apellido\r\nMaterno\r\n";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.Color.White;
            this.lbLogin.Location = new System.Drawing.Point(18, 80);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(59, 16);
            this.lbLogin.TabIndex = 114;
            this.lbLogin.Text = "Login Id";
            // 
            // pbUser
            // 
            this.pbUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbUser.BackgroundImage")));
            this.pbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(62, 423);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(114, 139);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 130;
            this.pbUser.TabStop = false;
            this.pbUser.Click += new System.EventHandler(this.pbUser_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 131;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1010, 73);
            this.pictureBox1.TabIndex = 132;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(949, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 42);
            this.btnExit.TabIndex = 133;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(899, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(45, 42);
            this.btnCancel.TabIndex = 134;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Black;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsId,
            this.stsName,
            this.stsIdArea,
            this.stsArea,
            this.stsTime,
            this.stsIp});
            this.statusStrip1.Location = new System.Drawing.Point(0, 566);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 135;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stsId
            // 
            this.stsId.Name = "stsId";
            this.stsId.Size = new System.Drawing.Size(17, 17);
            this.stsId.Text = "id";
            this.stsId.Visible = false;
            // 
            // stsName
            // 
            this.stsName.ForeColor = System.Drawing.SystemColors.Control;
            this.stsName.Name = "stsName";
            this.stsName.Size = new System.Drawing.Size(37, 17);
            this.stsName.Text = "name";
            // 
            // stsIdArea
            // 
            this.stsIdArea.Name = "stsIdArea";
            this.stsIdArea.Size = new System.Drawing.Size(15, 17);
            this.stsIdArea.Text = "A";
            this.stsIdArea.Visible = false;
            // 
            // stsArea
            // 
            this.stsArea.ForeColor = System.Drawing.SystemColors.Control;
            this.stsArea.Name = "stsArea";
            this.stsArea.Size = new System.Drawing.Size(29, 17);
            this.stsArea.Text = "area";
            // 
            // stsTime
            // 
            this.stsTime.BackColor = System.Drawing.Color.Black;
            this.stsTime.ForeColor = System.Drawing.SystemColors.Control;
            this.stsTime.Name = "stsTime";
            this.stsTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stsTime.Size = new System.Drawing.Size(927, 17);
            this.stsTime.Spring = true;
            this.stsTime.Text = "time";
            this.stsTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stsIp
            // 
            this.stsIp.ForeColor = System.Drawing.SystemColors.Control;
            this.stsIp.Name = "stsIp";
            this.stsIp.Size = new System.Drawing.Size(17, 17);
            this.stsIp.Text = "ip";
            this.stsIp.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 588);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.cbNivel);
            this.Controls.Add(this.lbNivel);
            this.Controls.Add(this.cbExt);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbDepa);
            this.Controls.Add(this.TxbPass);
            this.Controls.Add(this.txbCorreo);
            this.Controls.Add(this.txbTel);
            this.Controls.Add(this.txbApM);
            this.Controls.Add(this.txbApP);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbNick);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbApP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbDepa);
            this.Controls.Add(this.lbCorreo);
            this.Controls.Add(this.lbExt);
            this.Controls.Add(this.lbTel);
            this.Controls.Add(this.lbApM);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.btnDelete1);
            this.Controls.Add(this.btnUpdate1);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnDelete1;
        private System.Windows.Forms.Button btnUpdate1;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbNivel;
        private System.Windows.Forms.Label lbNivel;
        private System.Windows.Forms.ComboBox cbExt;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbDepa;
        private System.Windows.Forms.TextBox TxbPass;
        private System.Windows.Forms.TextBox txbCorreo;
        private System.Windows.Forms.TextBox txbTel;
        private System.Windows.Forms.TextBox txbApM;
        private System.Windows.Forms.TextBox txbApP;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbNick;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbApP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbDepa;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.Label lbExt;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label lbApM;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stsId;
        private System.Windows.Forms.ToolStripStatusLabel stsName;
        private System.Windows.Forms.ToolStripStatusLabel stsIdArea;
        private System.Windows.Forms.ToolStripStatusLabel stsArea;
        private System.Windows.Forms.ToolStripStatusLabel stsTime;
        private System.Windows.Forms.ToolStripStatusLabel stsIp;
        private System.Windows.Forms.Timer timer1;
    }
}