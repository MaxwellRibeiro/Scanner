using System.Linq;

namespace Scanner.AnaliseLexica.PalavraReservada
{
    public class PalavrasReservada
    {
        private string[] palavrasReservadas = { "program", "int", "string", "double", "float", "if", "else", "while", "for", "end" };

        public PalavrasReservada() { }

        public PalavrasReservada(string[] palavrasReservadas)
        {
            this.palavrasReservadas = palavrasReservadas;
        }

        public bool isPalavraReservada(string palavra)
        {
            return palavrasReservadas.FirstOrDefault(p => p == palavra) != null;
        }
    }
}
