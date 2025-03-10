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

        // Evento de clique no bot�o Sair.
        private void btnSair_Click(object sender, EventArgs e)
        {
            // Sair da aplica��o
            Application.Exit();
        }

        // Evento de carregamento do formul�rio. Inicializa configura��es e exibe os dados do evento.


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


            // Para que o formul�rio receba a tecla pressionada
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

        // M�todo que carrega os dados do evento na interface
        private void GetDados(Evento ev)
        {
            EventoTec = ev;

            // Exibi��o dos dados do evento
            txtNome.Text = ev.Nome;
            dtpData.Value = ev.Data.Date;
            dudNumMax.Text = ev.CapacidadeMax.ToString();


            // exibi��o da listagem de participantes na DataGridView
            // Permite vincular a lista de participantes na DataGridView
            // Outra alternativa era criar diretamente a BindingList na classe Evento
            dgvParticipantes.DataSource = new BindingList<Participante>(ev.ListaParticipantes);


            // Ordenar a lista de participantes por ordem alfab�tica
            //var participantesOrdenados = ev.ListaParticipantes.OrderBy(p => p.Nome).ToList();

            // Exibir a listagem de participantes na DataGridView
            //dgvEventos.DataSource = new BindingList<Participante>(participantesOrdenados);
        }


        private void btnInscrever_Click(object sender, EventArgs e)
        {
            // Abre o formul�rio de inscri��o
            Convidado form = new Convidado();
            if (form.ShowDialog() == DialogResult.OK) // Verifica se a inscri��o foi bem-sucedida
            {
                GetDados(EventoTec); // Atualiza a lista de participantes
                Dados.SalvarEventos(); // Salva os eventos ap�s a inscri��o
                MessageBox.Show("Inscri��o realizada com sucesso!", "Inscri��o", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Inscri��o Cancelada", "Inscri��o", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnRemover_Click(object sender, EventArgs e)
        {
            // Verifica se h� uma linha selecionada na DataGridView
            if (dgvParticipantes.SelectedRows.Count > 0)
            {
                Participante p = (Participante)dgvParticipantes.SelectedRows[0].DataBoundItem;
                string msg = "Remover o participante " + p.Nome + "?";
                DialogResult res = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//verifica se quer mesmo eliminar o participante
                if (res == DialogResult.Yes)
                    EventoTec.ListaParticipantes.Remove(p); // Remove o participante da lista
                GetDados(EventoTec); // Atualiza a DataGridView ap�s remo��o

                Dados.SalvarEventos(); // Salva os eventos no arquivo bin�rio
            }
            if (dgvParticipantes.SelectedRows.Count == 0)
            {
                // Exibe uma mensagem caso nenhum participante tenha sido selecionado
                MessageBox.Show("Selecione um participante para remover...", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Se n�o houver linha selecionada, seleciona a �ltima linha automaticamente
            if (dgvParticipantes.Rows.Count > 0 && dgvParticipantes.SelectedRows.Count == 0)
                dgvParticipantes.Rows[dgvParticipantes.Rows.Count - 1].Selected = true;

        }

        public void AtualizarDataGridView()
        {
            // Remove os dados da DataGridView
            dgvParticipantes.DataSource = null;

            // A fonte de dados muda para outra BindingList baseada na lista de participantes garantindo que a DataGridView � atualizada
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
                cmbEventos.SelectedIndex = 0; // Seleciona o primeiro evento por padr�o
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dados.SalvarEventos(); // Salva os eventos ao fechar o formul�rio
        }
    }
}
