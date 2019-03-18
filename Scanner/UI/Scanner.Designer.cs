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
            this.txtPrograma = new System.Windows.Forms.RichTextBox();
            this.gbPrograma = new System.Windows.Forms.GroupBox();
            this.btCompilar = new MetroFramework.Controls.MetroButton();
            this.gbPrograma.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPrograma
            // 
            this.txtPrograma.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrograma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrograma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrograma.Location = new System.Drawing.Point(3, 16);
            this.txtPrograma.Name = "txtPrograma";
            this.txtPrograma.Size = new System.Drawing.Size(478, 415);
            this.txtPrograma.TabIndex = 3;
            this.txtPrograma.Text = "";
            // 
            // gbPrograma
            // 
            this.gbPrograma.Controls.Add(this.txtPrograma);
            this.gbPrograma.Location = new System.Drawing.Point(23, 63);
            this.gbPrograma.Name = "gbPrograma";
            this.gbPrograma.Size = new System.Drawing.Size(484, 434);
            this.gbPrograma.TabIndex = 4;
            this.gbPrograma.TabStop = false;
            this.gbPrograma.Text = " Programa ";
            // 
            // btCompilar
            // 
            this.btCompilar.Location = new System.Drawing.Point(432, 503);
            this.btCompilar.Name = "btCompilar";
            this.btCompilar.Size = new System.Drawing.Size(75, 23);
            this.btCompilar.TabIndex = 5;
            this.btCompilar.Text = "Compilar";
            this.btCompilar.Click += new System.EventHandler(this.btCompilar_Click);
            // 
            // Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 533);
            this.Controls.Add(this.btCompilar);
            this.Controls.Add(this.gbPrograma);
            this.MaximizeBox = false;
            this.Name = "Scanner";
            this.Text = "Scanner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPrograma.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtPrograma;
        private System.Windows.Forms.GroupBox gbPrograma;
        private MetroFramework.Controls.MetroButton btCompilar;
    }
}

