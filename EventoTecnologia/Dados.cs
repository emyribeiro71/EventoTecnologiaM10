using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoTecnologia
{
    static class Dados
    {
        // Também era possivel criar os dados no evento Load() do formulário principal, no entanto,
        // a criação da classe estática vai simplificar o acesso aos dados na fase 3
        
        public static Evento EventoAtual;
       
        static Dados()
        {
            // Criação de um evento pré-definido
            EventoAtual = new Evento("IA - Desafios e Ética", new DateTime(2025, 1, 10), 24);
            
            // Inscrição de participantes de exemplo
            EventoAtual.InscreverParticipante(new Participante("Carlos Almeida", 66, "carlos@gmail.com"));
            EventoAtual.InscreverParticipante(new Participante("Andreia Quintal", 30, "andreia@gmail.com"));
            EventoAtual.InscreverParticipante(new Participante("Teresa Marcelino", 35, "teresa@gmail.com"));
        }
    }
}
