using System;
using System.Collections.Generic;
using MetroFramework.Forms;
using Scanner.AnaliseLexica;
using Scanner.TabelaSimbolo;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Scanner
{
    public partial class Scanner : MetroForm
    {
        public char[] Programa
        {
            get => txtPrograma.Text.ToCharArray();
            set
            {
                txtPrograma.Text = "";
                foreach (var item in value)
                {
                    txtPrograma.Text += item;
                }
            }
        }

        public string ResultadoToken
        {
            get => txtResultadoToken.Text;
            set => txtResultadoToken.Text = value;
        }

        public List<Simbolo> ListaSimbolos
        {
            get => (List<Simbolo>)bdTabelaSimbolo.DataSource;
            set => bdTabelaSimbolo.DataSource = value;
        }

        public Scanner()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bdTabelaSimbolo.DataSource = new List<Simbolo>();

            openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Escolha o Arquivo de texto";
            openFileDialog.InitialDirectory = @"C:\Users\Maxwell\Documents\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            openFileDialog.DefaultExt = "txt";

        }

        private void btCompilar_Click(object sender, EventArgs e)
        {
            Lexer lex = new Lexer(Programa);
            ListaSimbolos = lex.tabelaSimbolos.simbolos;

            string token = ResultadoToken = "";
            while (token != "<DELIM, ;>")
            {
                token = lex.scan();
                ResultadoToken += token +"\n";
            }

            gridTabelaSimbolos.DataSource = ListaSimbolos;
        }

        private void lblLerTxt_Click(object sender, EventArgs e)
        {
            LerArquivoTexto();
        }

        private void pcLerTxt_Click(object sender, EventArgs e)
        {
            LerArquivoTexto();
        }

        private void LerArquivoTexto()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string text;
                var fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.Default))
                {
                    Programa = streamReader.ReadToEnd().ToCharArray();
                }
            }
        }
    }
}
