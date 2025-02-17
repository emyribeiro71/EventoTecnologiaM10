using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EventoTecnologia
{
    public class Evento
    {
        //constante que determina a capacidade mínima de participantes
        public const int CAPACIDADE_MIN = 15;

        // Propriedade para o nome do evento
        public string Nome { get; set; }

        // Propriedade para a data do evento
        public DateTime Data { get; set; }

        int capacidadeMax;

        // propriedade para Quando a capacidade máxima é definida, verifica se o valor é válido
        public int CapacidadeMax
        {
            get { return capacidadeMax; }
            set
            {
                // Verifica se a capacidade máxima é válida, caso contrário, usa o valor mínimo
                if (IsValidCapacidadeMaxl(value))
                    capacidadeMax = value;
                else
                    capacidadeMax = CAPACIDADE_MIN;
            }
        }

        // Criação da lista de participantes na classe Evento
        public BindingList<Participante> ListaParticipantes { get; private set; }

        // Construtor que inicializa o evento com nome, data, capacidade máxima e participantes iniciais
        public Evento(string _nome, DateTime _data, int _capacidadeMax, BindingList<Participante> _participantesIniciais)
        {
            Nome = _nome;
            Data = _data;
            CapacidadeMax = _capacidadeMax;

            // Verifica se o número de participantes iniciais não ultrapassa a capacidade máxima
            if (_participantesIniciais.Count<= CapacidadeMax)
                ListaParticipantes = _participantesIniciais;
            else
                ListaParticipantes = new BindingList<Participante>();
        }

        // Construtor que cria o evento sem participantes iniciais
        public Evento(string _nome, DateTime _data, int _capacidadeMax): this(_nome, _data, _capacidadeMax, new BindingList<Participante>())
        {
            
        }

        // Método estático para validar a capacidade máxima do evento
        public static bool IsValidCapacidadeMaxl(int capacidade)
        {
            bool valido = true;

            // Verifica se a capacidade fornecida é menor que a capacidade mínima
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
            // Se o participante for nulo, retorna -1 indicando falha
            if (participante == null) return -1;

            // Verifica se a quantidade de participantes não ultrapassou a capacidade máxima
            if (ListaParticipantes.Count < capacidadeMax)
                ListaParticipantes.Add(participante);// Adiciona o participante
            else
                return -1;// Retorna -1 se a capacidade máxima foi atingida

            return ListaParticipantes.Count;// Retorna o número total de participantes após a inscrição
        } 
    }
}
