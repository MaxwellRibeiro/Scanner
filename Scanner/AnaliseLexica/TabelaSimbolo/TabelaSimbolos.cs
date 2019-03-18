using System.Collections.Generic;
using System.Linq;

namespace Scanner.TabelaSimbolo
{
    public class TabelaSimbolos
    {
        private List<Simbolo> simbolos;

        public TabelaSimbolos()
        {
            simbolos = new List<Simbolo>();
        }

        public int getIdSimbolo(string token)
        {
            Simbolo simbolo = simbolos.FirstOrDefault(s => s.Nome == token);
            if(simbolo == null) simbolo = novoSimbolo(token);

            return simbolo.Id;
        }

        private int getNovoIdSimbolo()
        {
            return simbolos.Count() + 1;
        }

        private Simbolo novoSimbolo(string token)
        {
            Simbolo simbolo = new Simbolo(getNovoIdSimbolo(), token);
            simbolos.Add(simbolo);
            return simbolo;
        }
    }
}
