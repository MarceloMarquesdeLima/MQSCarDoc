namespace MQSGestaoBackend.Validate
{
    public class ValidaPessoa
    {
        private void ValidateCbk()
        {
            if (cbkPessoaFisica.Checked)
            {
                cbkPessoaFisica.Enabled = cbkPessoaFisica.Checked;
                cbkPessoaJuridica.Enabled = false;
                txtCnpj.Enabled = false;
                txtInscEstadual.Enabled = false;
                txtCpf.Enabled = true;
                txtRg.Enabled = true;
            }
            else
            {
                cbkPessoaJuridica.Enabled = cbkPessoaJuridica.Checked;
                cbkPessoaFisica.Enabled = false;
                txtCnpj.Enabled = true;
                txtInscEstadual.Enabled = true;
                txtCpf.Enabled = false;
                txtRg.Enabled = false;
            }
        }
    }
}
