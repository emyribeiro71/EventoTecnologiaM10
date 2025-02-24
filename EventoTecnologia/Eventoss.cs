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
    public partial class Eventoss : Form
    {
        public Eventoss()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxEventos.SelectedIndex;
            if (selectedIndex >= 0)
            {
                var evento = Dados.Eventos[selectedIndex];
                evento.Nome = txtNome.Text;
                evento.Data = dtpData.Value;
                evento.CapacidadeMax = int.Parse(dudNumMax.Text);
                MessageBox.Show("Evento atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
