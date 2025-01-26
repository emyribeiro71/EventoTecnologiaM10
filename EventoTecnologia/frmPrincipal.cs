using System.ComponentModel;
using System.Diagnostics;

namespace EventoTecnologia
{
    public partial class frmPrincipal : Form
    {
        public Evento EventoTec { get; private set; }

        public frmPrincipal()
        {
            InitializeComponent();
            EventoTec = Dados.EventoAtual;

            // Vincula o evento CheckedChanged
            ckbEvento.CheckedChanged += ckbEvento_CheckedChanged;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Sair da aplicação
            Application.Exit();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Alterar algumas propriedades da datagridView
            dgvEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEventos.MultiSelect = false;
            dgvEventos.RowHeadersVisible = false;
            dgvEventos.ReadOnly = true;
            dgvEventos.AllowUserToAddRows = false;
            dgvEventos.AllowUserToDeleteRows = false;
            dgvEventos.AllowUserToResizeRows = false;
            dgvEventos.AllowUserToResizeColumns = false;
            dgvEventos.AllowUserToOrderColumns = true;

            // Ler os dados do evento
            GetDados(Dados.EventoAtual);

            // Formatar os dados na DataGridView
            dgvEventos.Columns["Nome"].Width = 220;
            // Alterar a cor de fundo da coluna
            dgvEventos.Columns["Nome"].DefaultCellStyle.BackColor = Color.LightYellow;
            //dgvEventos.Columns["Nome"].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            dgvEventos.Columns["Idade"].Width = 56;
            dgvEventos.Columns["Email"].HeaderText = "E-mail";
            dgvEventos.Columns["Email"].Width = 180;


            // Para que o formulário receba a tecla pressionad
            KeyPreview = true;


            // Inicializa os campos como desativados
            txtNome.Enabled = false;
            dtpData.Enabled = false;
            dudNumMax.Enabled = false;
        }

        private void GetDados(Evento ev)
        {
            EventoTec = ev;

            // Exibição dos dados do evento
            txtNome.Text = ev.Nome;
            dtpData.Value = ev.Data.Date;
            dudNumMax.Text = ev.CapacidadeMax.ToString();
            // Desmarcar a CheckBox e desativar os campos
            ckbEvento.Checked = false;
            ckbEvento_CheckedChanged(null, null); // Chama o método para desativar campos

            // exibição da listagem de participantes na DataGridView
            // Permite vincular a lista de participantes na DataGridView
            // Outra alternativa era criar diretamente a BindingList na classe Evento
            dgvEventos.DataSource = new BindingList<Participante>(ev.ListaParticipantes);


            // Ordenar a lista de participantes por ordem alfabética
            //var participantesOrdenados = ev.ListaParticipantes.OrderBy(p => p.Nome).ToList();

            // Exibir a listagem de participantes na DataGridView
            //dgvEventos.DataSource = new BindingList<Participante>(participantesOrdenados);
        }

        private void btnInscrever_Click(object sender, EventArgs e)
        {
            Convidado form = new Convidado();
            if (form.ShowDialog() == DialogResult.OK) // Verifica se a inscrição foi bem-sucedida
            {
                GetDados(EventoTec); // Atualiza a lista de participantes
                MessageBox.Show("Inscrição realizada com sucesso!", "Inscrição", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Inscrição Cancelada", "Inscrição", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvEventos.SelectedRows.Count > 0)
            {
                Participante p = (Participante)dgvEventos.SelectedRows[0].DataBoundItem;
                string msg = "Remover o participante " + p.Nome + "?";
                DialogResult res = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//verifica se quer mesmo eliminar o participante
                if (res == DialogResult.Yes)
                    EventoTec.ListaParticipantes.Remove(p); // Remove o participante da lista
                GetDados(EventoTec); // Atualiza a DataGridView após remoção

            }
            if (dgvEventos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um participante para remover...", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (dgvEventos.Rows.Count > 0 && dgvEventos.SelectedRows.Count == 0)
                dgvEventos.Rows[dgvEventos.Rows.Count - 1].Selected = true;

        }
        public void AtualizarDataGridView()
        {
            dgvEventos.DataSource = null;
            dgvEventos.DataSource = new BindingList<Participante>(EventoTec.ListaParticipantes);

        }

        private void ckbEvento_CheckedChanged(object sender, EventArgs e)
        {
            // Ativa ou desativa os campos de edição com base na seleção da CheckBox
            txtNome.Enabled = ckbEvento.Checked;
            dtpData.Enabled = ckbEvento.Checked;
            dudNumMax.Enabled = ckbEvento.Checked;
        }

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                btnRemover.PerformClick();
            }
        }
    }
}
