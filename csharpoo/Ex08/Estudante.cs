namespace Ex08
{
    internal class Estudante
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Estudante(string nome, string mail)
        {
            Nome = nome;
            Email = mail;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
