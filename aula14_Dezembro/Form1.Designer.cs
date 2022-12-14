namespace aula14_Dezembro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputSenha = new System.Windows.Forms.TextBox();
            this.labelMensagem = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputSenha
            // 
            this.inputSenha.Location = new System.Drawing.Point(119, 167);
            this.inputSenha.Name = "inputSenha";
            this.inputSenha.Size = new System.Drawing.Size(204, 20);
            this.inputSenha.TabIndex = 0;
            this.inputSenha.TextChanged += new System.EventHandler(this.inputSenha_TextChanged);
            this.inputSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VerificaCaracter);
            // 
            // labelMensagem
            // 
            this.labelMensagem.AutoSize = true;
            this.labelMensagem.Location = new System.Drawing.Point(116, 242);
            this.labelMensagem.Name = "labelMensagem";
            this.labelMensagem.Size = new System.Drawing.Size(35, 13);
            this.labelMensagem.TabIndex = 1;
            this.labelMensagem.Text = "label1";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.Black;
            this.buttonLimpar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.ForeColor = System.Drawing.Color.Lime;
            this.buttonLimpar.Location = new System.Drawing.Point(367, 139);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(140, 48);
            this.buttonLimpar.TabIndex = 2;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 478);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.labelMensagem);
            this.Controls.Add(this.inputSenha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputSenha;
        private System.Windows.Forms.Label labelMensagem;
        private System.Windows.Forms.Button buttonLimpar;
    }
}

