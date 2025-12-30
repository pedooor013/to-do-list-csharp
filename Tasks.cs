using System;

namespace Program
{
    class Tasks
    {
        public string Nome;
        public string Descricao;
        public DateTime DataCriacao;
        public DateTime Prazo;
        public bool Eh_Concluida;

        public int DiasTermino()
        {
            TimeSpan diferencaDatas = Prazo - DataCriacao;

            return diferencaDatas.Days;
        }
        public Tasks(string nome, string descricao, DateTime dataCriacao, DateTime prazo)
        {
            Nome = nome;
            Descricao = descricao;
            DataCriacao = dataCriacao;
            Prazo = prazo;
            Eh_Concluida = false;
        }
    }
}
