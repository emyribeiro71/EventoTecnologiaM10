using System.Net.Mail;

namespace EventoTecnologia
{
    [Serializable]
    public class Participante
    {
        // Propriedade para o nome do participante
        public string Nome { get; set; }

        int idade;

        // Propriedade para a idade do participante
        // Quando a idade é definida, verifica se ela é válida
        public int Idade
        {
            get { return idade; }
            set
            {
                // Verifica se a idade é válida, caso contrário, define a idade como 0
                if (IsValidIdade(value))
                    idade = value;
                else
                    idade = 0;
            }
        }

        string email = "";

        // Propriedade para o email do participante
        // Quando o email é definido, valida se é um email válido
        public string Email
        {
            get { return email; }
            set
            {
                // Verifica se o email é válido, caso contrário, define como uma string vazia
                if (IsValidEmail(value))
                    email = value;
                else
                    email = "";
            }
        }

        // Construtor que inicializa o participante com nome, idade e email
        public Participante(string _nome, int _idade, string _email)
        {
            Nome = _nome;
            Idade = _idade;
            Email = _email;
        }

        // Construtor que assume idade 16 caso não seja fornecida
        public Participante(string _nome, string _email) : this(_nome, 16, _email)
        {

        }

        // Método estático para validar o email fornecido
        public static bool IsValidEmail(string email)
        {
            bool valido = true;

            try
            {
                // Tenta criar um objeto MailAddress, o que valida o formato do email
                MailAddress aux = new MailAddress(email);
            }
            catch (Exception)
            {
                // Se ocorrer uma exceção, significa que o email não é válido
                valido = false;
            }

            return valido;
        }

        // Método estático para validar a idade fornecida
        public static bool IsValidIdade(int idade)
        {
            bool valido = true;
            // Verifica se a idade é inferior a 16 anos
            if (idade < 16)
            {
                valido = false;// Idade inválida se for menor que 16
            }

            return valido;
        }
    }
}
