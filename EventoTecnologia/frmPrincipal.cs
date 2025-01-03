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
           
        }

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
            dgvEventos.DataSource = new BindingList<Participante>(ev.ListaParticipantes);
        }
    }
}
