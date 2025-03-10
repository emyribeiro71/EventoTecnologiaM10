using System.ComponentModel;
using System.Diagnostics;

namespace EventoTecnologia
{
    public partial class frmPrincipal : Form
    {
        // Propriedade que armazena o evento atual
        public Evento EventoTec { get; private set; }
        public List<Evento> Eventos { get; private set; }

        // Construtor da classe frmPrincipal. Inicializa os componentes
        public frmPrincipal()
        {
            InitializeComponent();
            Eventos = new List<Evento>();
            this.FormClosing += new FormClosingEventHandler(frmPrincipal_FormClosing);

        }

        // Evento de clique no botão Sair.
        private void btnSair_Click(object sender, EventArgs e)
        {
            // Sair da aplicação
            Application.Exit();
        }

        // Evento de carregamento do formulário. Inicializa configurações e exibe os dados do evento.


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Alterar algumas propriedades da datagridView
            dgvParticipantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParticipantes.MultiSelect = false;
            dgvParticipantes.RowHeadersVisible = false;
            dgvParticipantes.ReadOnly = true;
            dgvParticipantes.AllowUserToAddRows = false;
            dgvParticipantes.AllowUserToDeleteRows = false;
            dgvParticipantes.AllowUserToResizeRows = false;
            dgvParticipantes.AllowUserToResizeColumns = false;
            dgvParticipantes.AllowUserToOrderColumns = true;


            // Formatar os dados na DataGridView
            dgvParticipantes.Columns["Nome"].Width = 220;

            // Alterar a cor de fundo da coluna
            dgvParticipantes.Columns["Nome"].DefaultCellStyle.BackColor = Color.LightYellow;

            //dgvEventos.Columns["Nome"].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            dgvParticipantes.Columns["Idade"].Width = 56;
            dgvParticipantes.Columns["Email"].HeaderText = "E-mail";
            dgvParticipantes.Columns["Email"].Width = 180;


            // Para que o formulário receba a tecla pressionada
            KeyPreview = true;


            // Inicializa os campos como desativados
            txtNome.Enabled = false;
            dtpData.Enabled = false;
            dudNumMax.Enabled = false;

            // Preencher o ComboBox com eventos
            foreach (var evento in Dados.Eventos)
            {
                cmbEventos.Items.Add(evento.Nome);
            }
            cmbEventos.SelectedIndexChanged += cmbEventos_SelectedIndexChanged;
        }

        // Método que carrega os dados do evento na interface
        private void GetDados(Evento ev)
        {
            EventoTec = ev;

            // Exibição dos dados do evento
            txtNome.Text = ev.Nome;
            dtpData.Value = ev.Data.Date;
            dudNumMax.Text = ev.CapacidadeMax.ToString();


            // exibição da listagem de participantes na DataGridView
            // Permite vincular a lista de participantes na DataGridView
            // Outra alternativa era criar diretamente a BindingList na classe Evento
            dgvParticipantes.DataSource = new BindingList<Participante>(ev.ListaParticipantes);


            // Ordenar a lista de participantes por ordem alfabética
            //var participantesOrdenados = ev.ListaParticipantes.OrderBy(p => p.Nome).ToList();

            // Exibir a listagem de participantes na DataGridView
            //dgvEventos.DataSource = new BindingList<Participante>(participantesOrdenados);
        }


        private void btnInscrever_Click(object sender, EventArgs e)
        {
            // Abre o formulário de inscrição
            Convidado form = new Convidado();
            if (form.ShowDialog() == DialogResult.OK) // Verifica se a inscrição foi bem-sucedida
            {
                GetDados(EventoTec); // Atualiza a lista de participantes
                Dados.SalvarEventos(); // Salva os eventos após a inscrição
                MessageBox.Show("Inscrição realizada com sucesso!", "Inscrição", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Inscrição Cancelada", "Inscrição", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnRemover_Click(object sender, EventArgs e)
        {
            // Verifica se há uma linha selecionada na DataGridView
            if (dgvParticipantes.SelectedRows.Count > 0)
            {
                Participante p = (Participante)dgvParticipantes.SelectedRows[0].DataBoundItem;
                string msg = "Remover o participante " + p.Nome + "?";
                DialogResult res = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//verifica se quer mesmo eliminar o participante
                if (res == DialogResult.Yes)
                    EventoTec.ListaParticipantes.Remove(p); // Remove o participante da lista
                GetDados(EventoTec); // Atualiza a DataGridView após remoção

                Dados.SalvarEventos(); // Salva os eventos no arquivo binário
            }
            if (dgvParticipantes.SelectedRows.Count == 0)
            {
                // Exibe uma mensagem caso nenhum participante tenha sido selecionado
                MessageBox.Show("Selecione um participante para remover...", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Se não houver linha selecionada, seleciona a última linha automaticamente
            if (dgvParticipantes.Rows.Count > 0 && dgvParticipantes.SelectedRows.Count == 0)
                dgvParticipantes.Rows[dgvParticipantes.Rows.Count - 1].Selected = true;

        }

        public void AtualizarDataGridView()
        {
            // Remove os dados da DataGridView
            dgvParticipantes.DataSource = null;

            // A fonte de dados muda para outra BindingList baseada na lista de participantes garantindo que a DataGridView é atualizada
            dgvParticipantes.DataSource = new BindingList<Participante>(EventoTec.ListaParticipantes);

        }





        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                //permite eliminar um participante com a tecla delete
                btnRemover.PerformClick();
            }

        }

        private void cmbEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cmbEventos.SelectedIndex;
            if (selectedIndex >= 0)
            {
                GetDados(Dados.Eventos[selectedIndex]);
            }
        }

        private void btnNewEvent_Click(object sender, EventArgs e)
        {
            Eventoss formEvento = new Eventoss();
            if (formEvento.ShowDialog() == DialogResult.OK)
            {
                // Atualizar a lista de eventos no ComboBox ou DataGridView
                AtualizarEventos();
            }
        }

        private void btnEditarEvent_Click(object sender, EventArgs e)
        {
            if (cmbEventos.SelectedIndex >= 0)
            {
                Evento eventoSelecionado = Dados.Eventos[cmbEventos.SelectedIndex];
                Eventoss formEvento = new Eventoss(eventoSelecionado);
                if (formEvento.ShowDialog() == DialogResult.OK)
                {
                    // Atualizar a lista de eventos no ComboBox ou DataGridView
                    AtualizarEventos();
                }
            }
            else
            {
                MessageBox.Show("Selecione um evento para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AtualizarEventos()
        {
            cmbEventos.Items.Clear();
            foreach (var evento in Dados.Eventos)
            {
                cmbEventos.Items.Add(evento.Nome);
            }
            if (cmbEventos.Items.Count > 0)
                cmbEventos.SelectedIndex = 0; // Seleciona o primeiro evento por padrão
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dados.SalvarEventos(); // Salva os eventos ao fechar o formulário
        }
    }
}
