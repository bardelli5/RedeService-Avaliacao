namespace RedeService
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listaNumeros1 = new RedeService.ListaNumeros();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grid1 = new RedeService.Grid();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.consultaCep1 = new RedeService.ConsultaCep();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.consultaBanco1 = new RedeService.ConsultaBanco();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.imagemBase641 = new RedeService.ImagemBase64();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.sobreMim1 = new RedeService.userControls.SobreMim();
            this.mensagemLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(915, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listaNumeros1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(841, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Q1 e Q2";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listaNumeros1
            // 
            this.listaNumeros1.Location = new System.Drawing.Point(0, 0);
            this.listaNumeros1.Name = "listaNumeros1";
            this.listaNumeros1.Size = new System.Drawing.Size(611, 352);
            this.listaNumeros1.TabIndex = 0;
            this.listaNumeros1.Load += new System.EventHandler(this.listaNumeros1_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grid1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(841, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Q3, Q4 e Q5";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grid1
            // 
            this.grid1.Location = new System.Drawing.Point(0, 0);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(768, 352);
            this.grid1.TabIndex = 0;
            this.grid1.Load += new System.EventHandler(this.grid1_Load);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.consultaCep1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(841, 379);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Q6";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // consultaCep1
            // 
            this.consultaCep1.Location = new System.Drawing.Point(-4, 0);
            this.consultaCep1.Name = "consultaCep1";
            this.consultaCep1.Size = new System.Drawing.Size(684, 349);
            this.consultaCep1.TabIndex = 0;
            this.consultaCep1.Load += new System.EventHandler(this.consultaCep1_Load);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.consultaBanco1);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(841, 379);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Q7";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // consultaBanco1
            // 
            this.consultaBanco1.Location = new System.Drawing.Point(0, 0);
            this.consultaBanco1.Name = "consultaBanco1";
            this.consultaBanco1.Size = new System.Drawing.Size(768, 352);
            this.consultaBanco1.TabIndex = 0;
            this.consultaBanco1.Load += new System.EventHandler(this.consultaBanco1_Load);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.imagemBase641);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(841, 379);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Q8";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // imagemBase641
            // 
            this.imagemBase641.Location = new System.Drawing.Point(6, 6);
            this.imagemBase641.Name = "imagemBase641";
            this.imagemBase641.Size = new System.Drawing.Size(692, 343);
            this.imagemBase641.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.sobreMim1);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(907, 472);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Sobre Mim";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // sobreMim1
            // 
            this.sobreMim1.Location = new System.Drawing.Point(3, 0);
            this.sobreMim1.Name = "sobreMim1";
            this.sobreMim1.Size = new System.Drawing.Size(920, 488);
            this.sobreMim1.TabIndex = 0;
            // 
            // mensagemLabel
            // 
            this.mensagemLabel.AutoSize = true;
            this.mensagemLabel.Location = new System.Drawing.Point(16, 9);
            this.mensagemLabel.Name = "mensagemLabel";
            this.mensagemLabel.Size = new System.Drawing.Size(38, 15);
            this.mensagemLabel.TabIndex = 1;
            this.mensagemLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 595);
            this.Controls.Add(this.mensagemLabel);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Avaliação .NET - Rede Service";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListaNumeros listaNumeros1;
        private TabPage tabPage2;
        private Label mensagemLabel;
        private Grid grid1;
        private TabPage tabPage3;
        private ConsultaCep consultaCep1;
        private TabPage tabPage4;
        private ConsultaBanco consultaBanco1;
        private TabPage tabPage5;
        private ImagemBase64 imagemBase641;
        private TabPage tabPage6;
        private userControls.SobreMim sobreMim1;
        }
}