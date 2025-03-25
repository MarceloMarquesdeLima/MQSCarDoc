namespace MQSCarDocFrontend
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeProcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impressãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detransToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarProcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturamentoNFSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lançamentoCtasÀPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baixaCtasÀPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaCtasÀPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioParaBancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stBarPrincipal = new System.Windows.Forms.StatusStrip();
            this.stBarNomeEmpresa = new System.Windows.Forms.ToolStripStatusLabel();
            this.stEspacoNome = new System.Windows.Forms.ToolStripStatusLabel();
            this.stBarUsuário = new System.Windows.Forms.ToolStripStatusLabel();
            this.stBarSemTexto = new System.Windows.Forms.ToolStripStatusLabel();
            this.stDtaHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.stBarPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.toolsMenu,
            this.windowsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNovo,
            this.toolStripSeparator3,
            this.configuraçõesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(66, 20);
            this.fileMenu.Text = "Cadastro";
            // 
            // tsNovo
            // 
            this.tsNovo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoaToolStripMenuItem,
            this.veículosToolStripMenuItem,
            this.tipoDeProcessoToolStripMenuItem});
            this.tsNovo.Image = ((System.Drawing.Image)(resources.GetObject("tsNovo.Image")));
            this.tsNovo.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsNovo.Name = "tsNovo";
            this.tsNovo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsNovo.Size = new System.Drawing.Size(195, 22);
            this.tsNovo.Text = "Nova Cadastro";
            this.tsNovo.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // pessoaToolStripMenuItem
            // 
            this.pessoaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.fonecedorToolStripMenuItem});
            this.pessoaToolStripMenuItem.Name = "pessoaToolStripMenuItem";
            this.pessoaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.pessoaToolStripMenuItem.Text = "Pessoa";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // fonecedorToolStripMenuItem
            // 
            this.fonecedorToolStripMenuItem.Name = "fonecedorToolStripMenuItem";
            this.fonecedorToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.fonecedorToolStripMenuItem.Text = "Fonecedor";
            this.fonecedorToolStripMenuItem.Click += new System.EventHandler(this.fonecedorToolStripMenuItem_Click);
            // 
            // veículosToolStripMenuItem
            // 
            this.veículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeloToolStripMenuItem,
            this.marcaToolStripMenuItem});
            this.veículosToolStripMenuItem.Name = "veículosToolStripMenuItem";
            this.veículosToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.veículosToolStripMenuItem.Text = "Veículos";
            // 
            // modeloToolStripMenuItem
            // 
            this.modeloToolStripMenuItem.Name = "modeloToolStripMenuItem";
            this.modeloToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.modeloToolStripMenuItem.Text = "Modelo";
            this.modeloToolStripMenuItem.Click += new System.EventHandler(this.modeloToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // tipoDeProcessoToolStripMenuItem
            // 
            this.tipoDeProcessoToolStripMenuItem.Name = "tipoDeProcessoToolStripMenuItem";
            this.tipoDeProcessoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.tipoDeProcessoToolStripMenuItem.Text = "Tipo de Processo";
            this.tipoDeProcessoToolStripMenuItem.Click += new System.EventHandler(this.tipoDeProcessoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(192, 6);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impressãoToolStripMenuItem,
            this.detransToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // impressãoToolStripMenuItem
            // 
            this.impressãoToolStripMenuItem.Name = "impressãoToolStripMenuItem";
            this.impressãoToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.impressãoToolStripMenuItem.Text = "Impressão";
            this.impressãoToolStripMenuItem.Click += new System.EventHandler(this.impressãoToolStripMenuItem_Click);
            // 
            // detransToolStripMenuItem
            // 
            this.detransToolStripMenuItem.Name = "detransToolStripMenuItem";
            this.detransToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.detransToolStripMenuItem.Text = "Detran";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.exitToolStripMenuItem.Text = "Sai&r";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.cancelarProcessoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(71, 20);
            this.editMenu.Text = "Processos";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.undoToolStripMenuItem.Text = "Incluir Processo";
            // 
            // cancelarProcessoToolStripMenuItem
            // 
            this.cancelarProcessoToolStripMenuItem.Name = "cancelarProcessoToolStripMenuItem";
            this.cancelarProcessoToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.cancelarProcessoToolStripMenuItem.Text = "Canc&elar Processo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.redoToolStripMenuItem.Text = "Consultar Processo";
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.faturamentoNFSEToolStripMenuItem});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(87, 20);
            this.toolsMenu.Text = "Faturamento";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.optionsToolStripMenuItem.Text = "Ordem de Serviço";
            // 
            // faturamentoNFSEToolStripMenuItem
            // 
            this.faturamentoNFSEToolStripMenuItem.Name = "faturamentoNFSEToolStripMenuItem";
            this.faturamentoNFSEToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.faturamentoNFSEToolStripMenuItem.Text = "Faturamento NFSE";
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.cascadeToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(74, 20);
            this.windowsMenu.Text = "Financeiro";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lançamentoCtasÀPagarToolStripMenuItem,
            this.baixaCtasÀPagarToolStripMenuItem,
            this.consultaCtasÀPagarToolStripMenuItem,
            this.envioParaBancoToolStripMenuItem});
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.newWindowToolStripMenuItem.Text = "Contas a Pagar";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // lançamentoCtasÀPagarToolStripMenuItem
            // 
            this.lançamentoCtasÀPagarToolStripMenuItem.Name = "lançamentoCtasÀPagarToolStripMenuItem";
            this.lançamentoCtasÀPagarToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.lançamentoCtasÀPagarToolStripMenuItem.Text = "Lançamento Ctas à Pagar";
            // 
            // baixaCtasÀPagarToolStripMenuItem
            // 
            this.baixaCtasÀPagarToolStripMenuItem.Name = "baixaCtasÀPagarToolStripMenuItem";
            this.baixaCtasÀPagarToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.baixaCtasÀPagarToolStripMenuItem.Text = "Baixa Ctas à Pagar";
            // 
            // consultaCtasÀPagarToolStripMenuItem
            // 
            this.consultaCtasÀPagarToolStripMenuItem.Name = "consultaCtasÀPagarToolStripMenuItem";
            this.consultaCtasÀPagarToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.consultaCtasÀPagarToolStripMenuItem.Text = "Consulta Ctas à Pagar";
            // 
            // envioParaBancoToolStripMenuItem
            // 
            this.envioParaBancoToolStripMenuItem.Name = "envioParaBancoToolStripMenuItem";
            this.envioParaBancoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.envioParaBancoToolStripMenuItem.Text = "Envio para Banco";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.cascadeToolStripMenuItem.Text = "Contas a Receber";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(50, 20);
            this.helpMenu.Text = "Ajuda";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(125, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.aboutToolStripMenuItem.Text = "&Sobre ... ...";
            // 
            // stBarPrincipal
            // 
            this.stBarPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stBarNomeEmpresa,
            this.stEspacoNome,
            this.stBarUsuário,
            this.stBarSemTexto,
            this.stDtaHora});
            this.stBarPrincipal.Location = new System.Drawing.Point(0, 659);
            this.stBarPrincipal.Name = "stBarPrincipal";
            this.stBarPrincipal.Size = new System.Drawing.Size(1084, 22);
            this.stBarPrincipal.TabIndex = 2;
            this.stBarPrincipal.Text = "StatusStrip";
            // 
            // stBarNomeEmpresa
            // 
            this.stBarNomeEmpresa.Name = "stBarNomeEmpresa";
            this.stBarNomeEmpresa.Size = new System.Drawing.Size(370, 17);
            this.stBarNomeEmpresa.Text = "MQS CarDoc - Sistema de Gestão para Despachantes Veícular              ";
            this.stBarNomeEmpresa.Click += new System.EventHandler(this.stBarNomeEmpresa_Click);
            // 
            // stEspacoNome
            // 
            this.stEspacoNome.Name = "stEspacoNome";
            this.stEspacoNome.Size = new System.Drawing.Size(40, 17);
            this.stEspacoNome.Text = "           ";
            this.stEspacoNome.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // stBarUsuário
            // 
            this.stBarUsuário.Name = "stBarUsuário";
            this.stBarUsuário.Size = new System.Drawing.Size(179, 17);
            this.stBarUsuário.Text = "Marcelo                                           ";
            // 
            // stBarSemTexto
            // 
            this.stBarSemTexto.Name = "stBarSemTexto";
            this.stBarSemTexto.Size = new System.Drawing.Size(58, 17);
            this.stBarSemTexto.Text = "                 ";
            this.stBarSemTexto.Click += new System.EventHandler(this.toolStripStatusLabel1_Click_1);
            // 
            // stDtaHora
            // 
            this.stDtaHora.Name = "stDtaHora";
            this.stDtaHora.Size = new System.Drawing.Size(231, 17);
            this.stDtaHora.Text = "                          24 de Março de 2025 - 22:36";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 681);
            this.Controls.Add(this.stBarPrincipal);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MQS Doccar - Sistema para Despachante DETRAN";
            this.Load += new System.EventHandler(this.FrmMenu_Load_1);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.stBarPrincipal.ResumeLayout(false);
            this.stBarPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip stBarPrincipal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel stBarNomeEmpresa;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem tsNovo;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem pessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impressãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detransToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cancelarProcessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturamentoNFSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lançamentoCtasÀPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baixaCtasÀPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaCtasÀPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioParaBancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel stBarUsuário;
        private System.Windows.Forms.ToolStripStatusLabel stEspacoNome;
        private System.Windows.Forms.ToolStripStatusLabel stBarSemTexto;
        private System.Windows.Forms.ToolStripStatusLabel stDtaHora;
        private System.Windows.Forms.ToolStripMenuItem tipoDeProcessoToolStripMenuItem;
    }
}



