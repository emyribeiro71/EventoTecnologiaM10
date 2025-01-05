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
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            int.TryParse(txb_Idade.Text, out int idade);
            EventoTec.InscreverParticipante(new Participante(txb_Nome.Text, idade, txb_Email.Text));
            MessageBox.Show("Inscrição realizada com sucesso!", "Inscrição", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.Close();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inscrição Cancelada", "Inscrição", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
