using System;
using MetroFramework.Forms;

namespace Scanner
{
    public partial class Scanner : MetroForm
    {

        public char[] Programa
        {
            get => txtPrograma.Text.ToCharArray();
            set => txtPrograma.Text = value.ToString();
        }

        public Scanner()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void btCompilar_Click(object sender, EventArgs e)
        {

        }
    }
}
