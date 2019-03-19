using Scanner.TabelaSimbolo;

namespace Scanner.AnaliseLexica
{
    public class BaseLexer
    {
        protected char peek;
        protected char[] programafonte;
        protected int i;

        protected string[] BaseOperadores = {
            "+","-",
            "*","/",
            ">","<",
            "=","!"
        };

        protected string[] Delimitadores = {
            "{","}",
            "(",")",
            ";"
        };

        public TabelaSimbolos tabelaSimbolos;
    }
}
