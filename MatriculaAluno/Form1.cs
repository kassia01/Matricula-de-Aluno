using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaAluno
{
    public partial class FormEscolaNatacao : Form
    {
        public FormEscolaNatacao()
        {
            InitializeComponent();
        }

        private void txtUltimoAniversario_Enter(object sender, EventArgs e)
        {
            if (txtAnoNascimento.Text.Trim().Length < 4)
            {
                MessageBox.Show("É preciso informar o ANO DE NASCIMENTO com 4 dígitos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnoNascimento.Focus();
            }
        }

        private void txtUltimoAniversario_Validating(object sender, CancelEventArgs e)
        {
            if (txtUltimoAniversario.Text != String.Empty && Convert.ToInt32(txtUltimoAniversario.Text) <= Convert.ToInt32(txtAnoNascimento.Text))
            {
                MessageBox.Show("O ANO DO ÚLTIMO ANIVERSÁRIO deve ser superior ao do ANO DO NASCIMENTO", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void btnClassficar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == String.Empty || txtAnoNascimento.Text == String.Empty || txtUltimoAniversario.Text == String.Empty)
            {
                MessageBox.Show("Todos os dados solicitados devem ser informados.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //TimeSpan tsQuantidadeDias = DateTime.Now.Date();
            else
            {
                int idade = Convert.ToInt32(txtUltimoAniversario.Text) - Convert.ToInt32(txtAnoNascimento.Text);

                if (idade > 17)
                {
                    lblCategoriaResposta.Text = "Adulto";
                }
                else if (idade > 13)
                {
                    lblCategoriaResposta.Text = "Juvenil B";
                }
                else if (idade > 10)
                {
                    lblCategoriaResposta.Text = "Juvenil A";
                }
                else if (idade > 7)
                {
                    lblCategoriaResposta.Text = "Infantil B";
                }
                else if (idade >= 5)
                {
                    lblCategoriaResposta.Text = "Infantil A";
                }
                else
                { lblCategoriaResposta.Text = "Não existe categoria"; }
            }
        }

        private void txtUltimoAniversario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

