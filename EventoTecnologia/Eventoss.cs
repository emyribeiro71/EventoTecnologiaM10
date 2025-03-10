using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventoTecnologia
{
    public partial class Eventoss : Form
    {
        public Evento EventoAtual { get; set; }
        public Eventoss(Evento evento = null)
        {
            InitializeComponent();
            EventoAtual = evento;

            if (EventoAtual != null)
            {
                // Preencher os campos com os dados do evento existente
                txtNome.Text = EventoAtual.Nome;
                dtpData.Value = EventoAtual.Data;
                nudCapacidade.Value = EventoAtual.CapacidadeMax;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O nome do evento é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (EventoAtual == null)
            {
                // Criar um novo evento
                Evento novoEvento = new Evento(txtNome.Text, dtpData.Value, (int)nudCapacidade.Value);
                Dados.Eventos.Add(novoEvento);
            }
            else
            {
                // Atualizar o evento existente
                EventoAtual.Nome = txtNome.Text;
                EventoAtual.Data = dtpData.Value;
                EventoAtual.CapacidadeMax = (int)nudCapacidade.Value;
            }

            Dados.SalvarEventos(); // Salva os eventos no arquivo binário

            this.DialogResult = DialogResult.OK; // Indica que a operação foi bem-sucedida
            this.Close(); // Fecha o formulário
        }

        private void Eventoss_Load(object sender, EventArgs e)
        {
            errorProvider1.ContainerControl = this;
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if (txtNome.Text == "")
            {
                // O email contém erros 
                e.Cancel = true; // Cancelar a operação. Não dar autorização para fechar a janela
                txtNome.SelectAll();
                errorProvider1.SetError(txtNome, "Nome inválido...");

            }
            else
            {
                // O email está correto
                e.Cancel = false; // Tudo OK, dar autorização para a janela fechar
                // Limpar a mensagem de erro
                errorProvider1.SetError(txtNome, string.Empty);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Indica que a operação foi cancelada
            this.Close(); // Fecha o formulário
        }
    }
}
