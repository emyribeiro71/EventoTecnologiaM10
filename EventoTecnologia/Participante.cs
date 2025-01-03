using System.Net.Mail;

namespace EventoTecnologia
{
    public class Participante
    {
        public string Nome { get; set; }

        int idade;
        public int Idade
        {
            get { return idade; }
            set
            {
                if (IsValidIdade(value))
                    idade = value;
                else
                    idade = 0;
            }
        }

        string email = "";
        public string Email
        {
            get { return email; }
            set
            {
                if (IsValidEmail(value))
                    email = value;
                else
                    email = "";
            }
        }

        public Participante(string _nome, int _idade, string _email)
        {
            Nome = _nome;
            Idade = _idade;
            Email = _email;
        }

        public Participante(string _nome, string _email) : this(_nome, 16, _email)
        {

        }

        public static bool IsValidEmail(string email)
        {
            bool valido = true;

            try
            {
                MailAddress aux = new MailAddress(email);
            }
            catch (Exception)
            {
                valido = false;
            }

            return valido;
        }

        public static bool IsValidIdade(int idade)
        {
            bool valido = true;

            if (idade < 16)
            {
                valido = false;
            }

            return valido;
        }
    }
}
