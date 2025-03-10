using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace EventoTecnologia
{
    static class Dados
    {
        public static List<Evento> Eventos { get; private set; }

        static Dados()
        {
            Eventos = new List<Evento>();
            CarregarEventos(); // Carrega eventos ao iniciar
        }

        public static void SalvarEventos()
        {
            using (FileStream stream = new FileStream("eventos.bin", FileMode.Create))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, Eventos);
            }
        }

        public static void CarregarEventos()
        {
            if (File.Exists("eventos.bin"))
            {
                using (FileStream stream = new FileStream("eventos.bin", FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    Eventos = (List<Evento>)formatter.Deserialize(stream);
                }
            }
            else
            {
                // Se o arquivo não existir, inicializa com eventos padrão
                Eventos = new List<Evento>
            {
                new Evento("IA - Desafios e Ética", new DateTime(2025, 1, 10), 24),
                new Evento("Tecnologia e Inovação", new DateTime(2025, 2, 15), 30)
            };

                // Inscrição de participantes de exemplo para o primeiro evento
                Eventos[0].InscreverParticipante(new Participante("Carlos Almeida", 66, "carlos@gmail.com"));
                Eventos[0].InscreverParticipante(new Participante("Andreia Quintal", 30, "andreia@gmail.com"));
                Eventos[0].InscreverParticipante(new Participante("Teresa Marcelino", 35, "teresa@gmail.com"));
            }
        }
    }
}
  