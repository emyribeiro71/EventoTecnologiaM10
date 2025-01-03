using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EventoTecnologia
{
    public class Evento
    {
        public const int CAPACIDADE_MIN = 15;

        public string Nome { get; set; }
        public DateTime Data { get; set; }

        int capacidadeMax;
        public int CapacidadeMax
        {
            get { return capacidadeMax; }
            set
            {
                if (IsValidCapacidadeMaxl(value))
                    capacidadeMax = value;
                else
                    capacidadeMax = CAPACIDADE_MIN;
            }
        }

        // Criação da lista de participantes na classe Evento
        public List<Participante> ListaParticipantes { get; private set; }

        
        public Evento(string _nome, DateTime _data, int _capacidadeMax, List<Participante> _participantesIniciais)
        {
            Nome = _nome;
            Data = _data;
            CapacidadeMax = _capacidadeMax;
            if (_participantesIniciais.Count<= CapacidadeMax)
                ListaParticipantes = _participantesIniciais;
            else
                ListaParticipantes = new List<Participante>();
        }

        public Evento(string _nome, DateTime _data, int _capacidadeMax): this(_nome, _data, _capacidadeMax, new List<Participante>())
        {
            
        }

        public static bool IsValidCapacidadeMaxl(int capacidade)
        {
            bool valido = true;

            if (capacidade < CAPACIDADE_MIN)
            {
                valido = false;
            }

            return valido;
        }

        // Implementação do método de inscrição (classe Evento), garantindo o limite máximo de participantes
        // Pode optar por colocar void e não informar se ouve ou não sucesso. 
        // Podia também devolver bool
        // Neste caso optou-se por devolver o total atual de participantes
        // O programador deve decidor qual a informação mais relevante a retornar
        public int InscreverParticipante(Participante participante)
        {
            if (participante == null) return -1;

            if (ListaParticipantes.Count < capacidadeMax)
                ListaParticipantes.Add(participante);
            else
                return -1;

            return ListaParticipantes.Count;
        } 
    }
}
