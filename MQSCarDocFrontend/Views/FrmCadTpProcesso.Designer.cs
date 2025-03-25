namespace MQSCarDocFrontend.Views
{
    partial class FrmCadTpProcesso
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
            this.pnlTpCadastroSeervico = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dtvCadTpServico = new System.Windows.Forms.DataGridView();
            this.pnlTpCadastroSeervico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCadTpServico)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTpCadastroSeervico
            // 
            this.pnlTpCadastroSeervico.BackColor = System.Drawing.Color.Silver;
            this.pnlTpCadastroSeervico.Controls.Add(this.button4);
            this.pnlTpCadastroSeervico.Controls.Add(this.button3);
            this.pnlTpCadastroSeervico.Controls.Add(this.button2);
            this.pnlTpCadastroSeervico.Controls.Add(this.button1);
            this.pnlTpCadastroSeervico.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTpCadastroSeervico.Location = new System.Drawing.Point(0, 0);
            this.pnlTpCadastroSeervico.Name = "pnlTpCadastroSeervico";
            this.pnlTpCadastroSeervico.Size = new System.Drawing.Size(717, 59);
            this.pnlTpCadastroSeervico.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(8, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(109, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(210, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 49);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.Location = new System.Drawing.Point(311, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 49);
            this.button4.TabIndex = 3;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dtvCadTpServico
            // 
            this.dtvCadTpServico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvCadTpServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvCadTpServico.Location = new System.Drawing.Point(0, 197);
            this.dtvCadTpServico.Name = "dtvCadTpServico";
            this.dtvCadTpServico.Size = new System.Drawing.Size(717, 173);
            this.dtvCadTpServico.TabIndex = 1;
            // 
            // FrmCadTpProcesso
            // 
            this.ClientSize = new System.Drawing.Size(717, 368);
            this.Controls.Add(this.dtvCadTpServico);
            this.Controls.Add(this.pnlTpCadastroSeervico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmCadTpProcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Tipo de Serviço DETRAN";
            this.Load += new System.EventHandler(this.FrmCadTpProcesso_Load);
            this.pnlTpCadastroSeervico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvCadTpServico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtInscEstadual;
        private System.Windows.Forms.Label lblInscEstadual;
        private System.Windows.Forms.CheckBox cbkPessoaFisica;
        private System.Windows.Forms.CheckBox cbkPessoaJuridica;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dgvListaModelo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel pnlMenuCadModelo;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel pnlTpCadastroSeervico;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dtvCadTpServico;
    }
}