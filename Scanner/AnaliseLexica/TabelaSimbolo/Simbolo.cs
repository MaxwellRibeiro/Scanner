using System;

namespace Scanner.TabelaSimbolo
{
    public class Simbolo
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Simbolo(int id, String nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
