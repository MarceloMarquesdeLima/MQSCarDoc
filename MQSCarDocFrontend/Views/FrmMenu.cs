using MQSCarDocFrontend.Views;
using System;
using System.Windows.Forms;

namespace MQSCarDocFrontend
{
    public partial class FrmMenu : Form
    {
        private int childFormNumber = 0;

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void impressãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCliente frmCadCliente = new FrmCadCliente();
            frmCadCliente.MdiParent = this;
            frmCadCliente.Show();
        }

        private void fonecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadFornecedor frmCadFornecedor = new FrmCadFornecedor();
            frmCadFornecedor.MdiParent = this;
            frmCadFornecedor.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void stBarNomeEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadMarca frmCadMarca = new FrmCadMarca();
            frmCadMarca.MdiParent = this;
            frmCadMarca.Show();
        }

        private void modeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadModelo frmCadModelo = new FrmCadModelo();
            frmCadModelo.MdiParent = this;
            frmCadModelo.Show();
        }

        private void tipoDeProcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadTpProcesso frmCadTpProcesso = new FrmCadTpProcesso();
            frmCadTpProcesso.MdiParent = this;
            frmCadTpProcesso.Show();
        }

        private void FrmMenu_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}
