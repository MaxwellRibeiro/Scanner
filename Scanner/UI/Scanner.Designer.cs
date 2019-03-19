namespace Scanner
{
    partial class Scanner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scanner));
            this.gbPrograma = new System.Windows.Forms.GroupBox();
            this.txtPrograma = new System.Windows.Forms.TextBox();
            this.btCompilar = new MetroFramework.Controls.MetroButton();
            this.gbToken = new System.Windows.Forms.GroupBox();
            this.txtResultadoToken = new System.Windows.Forms.RichTextBox();
            this.gbTabelaSimbolo = new System.Windows.Forms.GroupBox();
            this.gridTabelaSimbolos = new System.Windows.Forms.DataGridView();
            this.bdTabelaSimbolo = new System.Windows.Forms.BindingSource(this.components);
            this.pcLerTxt = new System.Windows.Forms.PictureBox();
            this.lblLerTxt = new MetroFramework.Controls.MetroLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbPrograma.SuspendLayout();
            this.gbToken.SuspendLayout();
            this.gbTabelaSimbolo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTabelaSimbolos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTabelaSimbolo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcLerTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPrograma
            // 
            this.gbPrograma.Controls.Add(this.txtPrograma);
            this.gbPrograma.Location = new System.Drawing.Point(23, 63);
            this.gbPrograma.Name = "gbPrograma";
            this.gbPrograma.Size = new System.Drawing.Size(562, 392);
            this.gbPrograma.TabIndex = 4;
            this.gbPrograma.TabStop = false;
            this.gbPrograma.Text = " Programa ";
            // 
            // txtPrograma
            // 
            this.txtPrograma.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrograma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrograma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrograma.Location = new System.Drawing.Point(3, 16);
            this.txtPrograma.Multiline = true;
            this.txtPrograma.Name = "txtPrograma";
            this.txtPrograma.Size = new System.Drawing.Size(556, 373);
            this.txtPrograma.TabIndex = 0;
            // 
            // btCompilar
            // 
            this.btCompilar.Location = new System.Drawing.Point(510, 461);
            this.btCompilar.Name = "btCompilar";
            this.btCompilar.Size = new System.Drawing.Size(75, 23);
            this.btCompilar.TabIndex = 5;
            this.btCompilar.Text = "Compilar";
            this.btCompilar.Click += new System.EventHandler(this.btCompilar_Click);
            // 
            // gbToken
            // 
            this.gbToken.Controls.Add(this.txtResultadoToken);
            this.gbToken.Location = new System.Drawing.Point(588, 63);
            this.gbToken.Name = "gbToken";
            this.gbToken.Size = new System.Drawing.Size(345, 389);
            this.gbToken.TabIndex = 5;
            this.gbToken.TabStop = false;
            this.gbToken.Text = " Token ";
            // 
            // txtResultadoToken
            // 
            this.txtResultadoToken.BackColor = System.Drawing.SystemColors.Window;
            this.txtResultadoToken.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultadoToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResultadoToken.Location = new System.Drawing.Point(3, 16);
            this.txtResultadoToken.Name = "txtResultadoToken";
            this.txtResultadoToken.ReadOnly = true;
            this.txtResultadoToken.Size = new System.Drawing.Size(339, 370);
            this.txtResultadoToken.TabIndex = 3;
            this.txtResultadoToken.Text = "";
            // 
            // gbTabelaSimbolo
            // 
            this.gbTabelaSimbolo.Controls.Add(this.gridTabelaSimbolos);
            this.gbTabelaSimbolo.Location = new System.Drawing.Point(936, 63);
            this.gbTabelaSimbolo.Name = "gbTabelaSimbolo";
            this.gbTabelaSimbolo.Size = new System.Drawing.Size(305, 389);
            this.gbTabelaSimbolo.TabIndex = 6;
            this.gbTabelaSimbolo.TabStop = false;
            this.gbTabelaSimbolo.Text = "Tabela de Símbolos ";
            // 
            // gridTabelaSimbolos
            // 
            this.gridTabelaSimbolos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTabelaSimbolos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridTabelaSimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTabelaSimbolos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTabelaSimbolos.GridColor = System.Drawing.SystemColors.Window;
            this.gridTabelaSimbolos.Location = new System.Drawing.Point(3, 16);
            this.gridTabelaSimbolos.Name = "gridTabelaSimbolos";
            this.gridTabelaSimbolos.ReadOnly = true;
            this.gridTabelaSimbolos.Size = new System.Drawing.Size(299, 370);
            this.gridTabelaSimbolos.TabIndex = 0;
            // 
            // pcLerTxt
            // 
            this.pcLerTxt.Image = ((System.Drawing.Image)(resources.GetObject("pcLerTxt.Image")));
            this.pcLerTxt.Location = new System.Drawing.Point(23, 461);
            this.pcLerTxt.Name = "pcLerTxt";
            this.pcLerTxt.Size = new System.Drawing.Size(28, 23);
            this.pcLerTxt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcLerTxt.TabIndex = 7;
            this.pcLerTxt.TabStop = false;
            this.pcLerTxt.Click += new System.EventHandler(this.pcLerTxt_Click);
            // 
            // lblLerTxt
            // 
            this.lblLerTxt.AutoSize = true;
            this.lblLerTxt.Location = new System.Drawing.Point(54, 461);
            this.lblLerTxt.Name = "lblLerTxt";
            this.lblLerTxt.Size = new System.Drawing.Size(130, 19);
            this.lblLerTxt.TabIndex = 8;
            this.lblLerTxt.Text = "Ler Arquivo de Texto";
            this.lblLerTxt.Click += new System.EventHandler(this.lblLerTxt_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 491);
            this.Controls.Add(this.lblLerTxt);
            this.Controls.Add(this.pcLerTxt);
            this.Controls.Add(this.gbTabelaSimbolo);
            this.Controls.Add(this.gbToken);
            this.Controls.Add(this.btCompilar);
            this.Controls.Add(this.gbPrograma);
            this.MaximizeBox = false;
            this.Name = "Scanner";
            this.Text = "Scanner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPrograma.ResumeLayout(false);
            this.gbPrograma.PerformLayout();
            this.gbToken.ResumeLayout(false);
            this.gbTabelaSimbolo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTabelaSimbolos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTabelaSimbolo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcLerTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbPrograma;
        private MetroFramework.Controls.MetroButton btCompilar;
        private System.Windows.Forms.GroupBox gbToken;
        private System.Windows.Forms.RichTextBox txtResultadoToken;
        private System.Windows.Forms.GroupBox gbTabelaSimbolo;
        private System.Windows.Forms.DataGridView gridTabelaSimbolos;
        private System.Windows.Forms.BindingSource bdTabelaSimbolo;
        private System.Windows.Forms.PictureBox pcLerTxt;
        private MetroFramework.Controls.MetroLabel lblLerTxt;
        private System.Windows.Forms.TextBox txtPrograma;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

