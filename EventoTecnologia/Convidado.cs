using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventoTecnologia
{
    public partial class Convidado : Form
    {

        public Evento EventoTec { get; set; }
        public Convidado()
        {
            InitializeComponent();
            EventoTec = Dados.EventoAtual;

            // Define os botões de aceitação e cancelamento
            AcceptButton = btn_ok;
            CancelButton = btn_cancelar;
            btn_cancelar.CausesValidation = false;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            // Forçar a validação de todos os controles
            if (!ValidateChildren())
            {
                // Impede a janela fechar se encontrar erros
                DialogResult = DialogResult.None;
                return; // Sair, uma vez que ocorreu erro nos dados e não pretendemos atualizar os dados na propriedade Emp

            }


            int.TryParse(txb_Idade.Text, out int idade);
            EventoTec.InscreverParticipante(new Participante(txb_Nome.Text, idade, txb_Email.Text)); // Inscreve o participante no evento

            this.DialogResult = DialogResult.OK; // Retorna resultado OK


        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            //fecha a janela
            this.Close();
        }

        private void txb_Nome_Validating(object sender, CancelEventArgs e)
        {
            if (txb_Nome.Text == "")
            {
                // O email contém erros 
                e.Cancel = true; // Cancelar a operação. Não dar autorização para fechar a janela
                txb_Nome.SelectAll();
                errorProvider.SetError(txb_Nome, "Nome inválido...");

            }
            else
            {
                // O email está correto
                e.Cancel = false; // Tudo OK, dar autorização para a janela fechar
                // Limpar a mensagem de erro
                errorProvider.SetError(txb_Nome, string.Empty);
            }
        }

        private void Convidado_Load(object sender, EventArgs e)
        {
            errorProvider.ContainerControl = this;
        }

        private void txb_Idade_TextChanged(object sender, CancelEventArgs e)
        {

        }
        private void txtCampoVazio_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // sender é o control que chamou o evento
            TextBox control = (TextBox)sender;

            if (control.Text.Length == 0) // se erro
            {
                e.Cancel = true;
                // Para correta menssagem, a propriedade Tag do controlo deve ser inicializada com o nome do campo
                errorProvider.SetError(control, "Campo " + control.Tag.ToString() + " obrigatório...");
            }
            else
            {
                e.Cancel = false;
                // Limpa a mensagem de erro
                errorProvider.SetError(control, string.Empty);
            }

        }

        private void txb_Idade_Validating(object sender, CancelEventArgs e)
        {
            int.TryParse(txb_Idade.Text, out int idade);
            if (Participante.IsValidIdade(idade))
            {
                // A idade está correta
                e.Cancel = false; // Tudo OK, dar autorização para a janela fechar
                                  // Limpar a mensagem de erro
                errorProvider.SetError(txb_Idade, string.Empty);
            }
            else if (txb_Idade.Text == "")
            {
                // A idade contém erros 
                e.Cancel = true; // Cancelar a operação. Não dar autorização para fechar a janela
                txb_Idade.SelectAll();
                errorProvider.SetError(txb_Idade, "Idade inválida...");
            }
        }

        private void txb_Email_Validating(object sender, CancelEventArgs e)
        {
            if (Participante.IsValidEmail(txb_Email.Text))
            {
                // o email está correta
                e.Cancel = false; // Tudo OK, dar autorização para a janela fechar
                // Limpar a mensagem de erro
                errorProvider.SetError(txb_Email, string.Empty);
            }
            else if (txb_Email.Text == "")
            {
                // O email contém erros 
                e.Cancel = true; // Cancelar a operação. Não dar autorização para fechar a janela
                txb_Email.SelectAll();
                errorProvider.SetError(txb_Email, "Email inválida...");
            }
        }
    }
}
