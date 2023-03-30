namespace RedeService.userControls
    {
    partial class SobreMim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SobreMim));
            this.Apresentacao = new System.Windows.Forms.Label();
            this.FotoPerfil = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.link_Linkedin = new System.Windows.Forms.LinkLabel();
            this.link_Github = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Apresentacao
            // 
            this.Apresentacao.AutoSize = true;
            this.Apresentacao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Apresentacao.Location = new System.Drawing.Point(381, 163);
            this.Apresentacao.Name = "Apresentacao";
            this.Apresentacao.Size = new System.Drawing.Size(125, 22);
            this.Apresentacao.TabIndex = 0;
            this.Apresentacao.Text = "Hello, World!";
            // 
            // FotoPerfil
            // 
            this.FotoPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FotoPerfil.Image = ((System.Drawing.Image)(resources.GetObject("FotoPerfil.Image")));
            this.FotoPerfil.Location = new System.Drawing.Point(53, 34);
            this.FotoPerfil.Name = "FotoPerfil";
            this.FotoPerfil.Size = new System.Drawing.Size(159, 163);
            this.FotoPerfil.TabIndex = 2;
            this.FotoPerfil.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-171, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1186, 128);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(766, 80);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(320, 377);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(516, 377);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // link_Linkedin
            // 
            this.link_Linkedin.AutoSize = true;
            this.link_Linkedin.Location = new System.Drawing.Point(351, 388);
            this.link_Linkedin.Name = "link_Linkedin";
            this.link_Linkedin.Size = new System.Drawing.Size(52, 15);
            this.link_Linkedin.TabIndex = 7;
            this.link_Linkedin.TabStop = true;
            this.link_Linkedin.Text = "Linkedin";
            this.link_Linkedin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Linkedin_LinkClicked);
            // 
            // link_Github
            // 
            this.link_Github.AutoSize = true;
            this.link_Github.Location = new System.Drawing.Point(547, 388);
            this.link_Github.Name = "link_Github";
            this.link_Github.Size = new System.Drawing.Size(45, 15);
            this.link_Github.TabIndex = 8;
            this.link_Github.TabStop = true;
            this.link_Github.Text = "GitHub";
            this.link_Github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Github_LinkClicked);
            // 
            // SobreMim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.link_Github);
            this.Controls.Add(this.link_Linkedin);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Apresentacao);
            this.Controls.Add(this.FotoPerfil);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SobreMim";
            this.Size = new System.Drawing.Size(960, 539);
            ((System.ComponentModel.ISupportInitialize)(this.FotoPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private Label Apresentacao;
        private PictureBox FotoPerfil;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private LinkLabel link_Linkedin;
        private LinkLabel link_Github;
        }
    }
