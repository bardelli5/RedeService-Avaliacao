namespace RedeService
    {
    partial class ImagemBase64
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
            {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImagemBase64));
            this.label1 = new System.Windows.Forms.Label();
            this.resultadoBase64Box = new System.Windows.Forms.TextBox();
            this.Btn_DownloadEGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(669, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // resultadoBase64Box
            // 
            this.resultadoBase64Box.Location = new System.Drawing.Point(19, 140);
            this.resultadoBase64Box.Multiline = true;
            this.resultadoBase64Box.Name = "resultadoBase64Box";
            this.resultadoBase64Box.ReadOnly = true;
            this.resultadoBase64Box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultadoBase64Box.Size = new System.Drawing.Size(529, 205);
            this.resultadoBase64Box.TabIndex = 2;
            // 
            // Btn_DownloadEGravar
            // 
            this.Btn_DownloadEGravar.Location = new System.Drawing.Point(19, 111);
            this.Btn_DownloadEGravar.Name = "Btn_DownloadEGravar";
            this.Btn_DownloadEGravar.Size = new System.Drawing.Size(160, 23);
            this.Btn_DownloadEGravar.TabIndex = 3;
            this.Btn_DownloadEGravar.Text = "Baixar Imagem e Gravar";
            this.Btn_DownloadEGravar.UseVisualStyleBackColor = true;
            this.Btn_DownloadEGravar.Click += new System.EventHandler(this.Btn_DownloadEGravar_Click);
            // 
            // ImagemBase64
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_DownloadEGravar);
            this.Controls.Add(this.resultadoBase64Box);
            this.Controls.Add(this.label1);
            this.Name = "ImagemBase64";
            this.Size = new System.Drawing.Size(718, 432);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private Label label1;
        private TextBox resultadoBase64Box;
        private Button Btn_DownloadEGravar;
        }
    }
