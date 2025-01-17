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
            int.TryParse(txb_Idade.Text, out int idade);
            EventoTec.InscreverParticipante(new Participante(txb_Nome.Text, idade, txb_Email.Text)); // Inscreve o participante no evento

            this.DialogResult = DialogResult.OK; // Retorna resultado OK
            this.Close();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
           //fecha a janela
            this.Close();
        }

       
    }
}
