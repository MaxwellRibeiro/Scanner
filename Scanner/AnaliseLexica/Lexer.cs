using Scanner.TabelaSimbolo;
using Scanner.PalavrasReservada;
using System;
using System.Text;

namespace Scanner.AnaliseLexica
{
    public class Lexer
    {
        private char peek;
        private char[] programafonte;
        private int i;

        TabelaSimbolos tabelaSimbolos;

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
                PalavrasReservada palavraReservada = new PalavrasReservada();

                StringBuilder lexema = new StringBuilder();
                do
                {
                    lexema.Append(peek);
                    nextChar();
                } while (Char.IsLetterOrDigit(peek));

                if (palavraReservada.isPalavraReservada(lexema.ToString()))
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
            if (Arrays.stream(InicioOperadores).anyMatch(Character.toString(peek)::equals))
            {
                StringBuilder lexema = new StringBuilder();
                lexema.append(peek);
                if (Character.toString(peek).equals("=") ||
                    Character.toString(peek).equals("!") ||
                    Character.toString(peek).equals(">") ||
                    Character.toString(peek).equals("<")
                )
                {
                    nextChar();
                    if (Character.toString(peek).equals("="))
                    {
                        lexema.append(peek);
                        nextChar();
                    }
                }
                else
                {
                    nextChar();
                }

                token = "<OP, " + lexema.toString() + ">";

                return token;
            }

            token = String.valueOf(peek);
            return token;
        }
    }
}
