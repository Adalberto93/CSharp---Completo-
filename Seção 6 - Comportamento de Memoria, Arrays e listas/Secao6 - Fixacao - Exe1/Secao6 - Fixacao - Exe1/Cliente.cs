namespace Secao6___Fixacao___Exe1
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Cliente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        public override string ToString()
        {
            return Nome
                 + ", "
                 + Email;
        }
    }
}
