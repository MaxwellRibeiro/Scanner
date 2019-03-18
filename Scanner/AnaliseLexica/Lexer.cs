using Scanner.AnaliseLexica.PalavraReservada;
using Scanner.TabelaSimbolo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scanner.AnaliseLexica
{
    public class Lexer
    {
        private char peek;
        private char[] programafonte;
        private int i;

        private string[] InicioOperadores = {
            "+","-",
            "*","/",
            ">","<",
            "=","!"
        };
        
        public TabelaSimbolos tabelaSimbolos;

        public Lexer(char[] programa)
        {
            tabelaSimbolos = new TabelaSimbolos();
            programafonte = programa;
            init();
        }

        private void init()
        {
            i = 0;
            nextChar();
        }

        private void nextChar()
        {
            if (i < programafonte.Length)
            {
                peek = programafonte[i];
                i++;
            }
            else
            {
                peek = programafonte[programafonte.Length - 1];
            }
        }

        public String scan()
        {
            String token = "";

            //ignora espaço
            while (peek == ' ' || peek == '\t')
            {
                nextChar();
            }

            //Numero
            if (Char.IsDigit(peek))
            {
                int v = 0; //vai armezenar o valor do numero
                do
                {
                    v = 10 * v + Convert.ToInt32(peek.ToString(), 10);
                    nextChar();
                } while (Char.IsDigit(peek));
                token = "<NUM, " + v.ToString() + ">";
                return token;
            }

            //Identificador
            if (Char.IsLetter(peek))
            {
                PalavrasReservada palavrasReservada = new PalavrasReservada();

                StringBuilder lexema = new StringBuilder();
                do
                {
                    lexema.Append(peek);
                    nextChar();
                } while (Char.IsLetterOrDigit(peek));

                if (palavrasReservada.isPalavraReservada(lexema.ToString()))
                {
                    token = "<" + lexema.ToString() + ", " + lexema.ToString() + ">";
                }
                else
                {
                    token = "<ID, " + tabelaSimbolos.getIdSimbolo(lexema.ToString()) + ">";
                }

                return token;
            }

            //Operador
            if (InicioOperadores.FirstOrDefault(i => i == Char.ToString(peek)) != null)
            {
                StringBuilder lexema = new StringBuilder();
                lexema.Append(peek);
                if (Char.ToString(peek) == "=" ||
                    Char.ToString(peek) == "!" ||
                    Char.ToString(peek) == ">" ||
                    Char.ToString(peek) == "<" )
                {
                    nextChar();
                    if (Char.ToString(peek) == "=")
                    {
                        lexema.Append(peek);
                        nextChar();
                    }
                }
                else
                {
                    nextChar();
                }

                token = "<OP, " + lexema.ToString() + ">";

                return token;
            }

            token = peek.ToString();
            return token;
        }
    }
}
