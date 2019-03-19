using Scanner.AnaliseLexica.PalavraReservada;
using Scanner.TabelaSimbolo;
using System;
using System.Linq;
using System.Text;

namespace Scanner.AnaliseLexica
{
    public class Lexer : BaseLexer
    {
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

            //ignorar
            while (peek == ' ' || peek == '\t' || peek == '\r' || peek == '\n')
            {
                nextChar();
            }
            
            #region Identificador e Palavra Reservada

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
                    token = "<Palavra reservada, " + lexema.ToString() + ">";
                }
                else
                {
                    token = "<ID, " + tabelaSimbolos.getIdSimbolo(lexema.ToString()) + ">";
                }

                return token;
            }

            #endregion

            #region Numero

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

            #endregion

            #region Texto entre “”

            if (peek.ToString() == "“")
            {
                StringBuilder lexema = new StringBuilder();
                do
                {
                    lexema.Append(peek);
                    nextChar();
                } while (peek.ToString() != "”");
                lexema.Append(peek);
                nextChar();

                token = "<LITERAL, " + lexema.ToString() + ">";

                return token;
            }

            #endregion

            #region Operador

            if (BaseOperadores.FirstOrDefault(i => i == Char.ToString(peek)) != null)
            {
                StringBuilder lexema = new StringBuilder();
                lexema.Append(peek);
                if (Char.ToString(peek) == "=" || Char.ToString(peek) == ">" || Char.ToString(peek) == "<")
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

                token = "<RELOP, " + lexema.ToString() + ">";

                return token;
            }

            #endregion

            #region Delimitadores

            if (Delimitadores.FirstOrDefault(i => i == Char.ToString(peek)) != null)
            {
                StringBuilder lexema = new StringBuilder();
                lexema.Append(peek);
                nextChar();

                token = "<DELIM, " + lexema.ToString() + ">";

                return token;
            }

            #endregion

            token = peek.ToString();
            return token;
        }
    }
}
