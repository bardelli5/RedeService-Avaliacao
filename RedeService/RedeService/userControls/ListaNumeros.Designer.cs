namespace RedeService
{
    partial class ListaNumeros
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
            numeroTextBox = new TextBox();
            botaoAdicionar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numerosListView = new ListBox();
            gravarListaBotao = new Button();
            abrirArquivoButton = new Button();
            SuspendLayout();
            // 
            // numeroTextBox
            // 
            numeroTextBox.ForeColor = SystemColors.WindowText;
            numeroTextBox.Location = new Point(150, 119);
            numeroTextBox.Name = "numeroTextBox";
            numeroTextBox.Size = new Size(100, 23);
            numeroTextBox.TabIndex = 0;
            numeroTextBox.TextChanged += numeroTextBox_TextChanged;
            // 
            // botaoAdicionar
            // 
            botaoAdicionar.Location = new Point(256, 119);
            botaoAdicionar.Name = "botaoAdicionar";
            botaoAdicionar.Size = new Size(75, 23);
            botaoAdicionar.TabIndex = 1;
            botaoAdicionar.Text = "Adicionar";
            botaoAdicionar.UseVisualStyleBackColor = true;
            botaoAdicionar.Click += botaoAdicionar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 122);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 3;
            label1.Text = "Insira um número:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 17);
            label2.Name = "label2";
            label2.Size = new Size(555, 15);
            label2.TabIndex = 4;
            label2.Text = "1. Faça a aplicação permitir a digitação de números e mostre esses números em tela de forma ordenada.\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 45);
            label3.Name = "label3";
            label3.Size = new Size(525, 30);
            label3.TabIndex = 5;
            label3.Text = "2. Agora grave os números visualizados cada 1 em uma linha em um arquivo texto na pasta raiz da\r\n    aplicação de nome numeros_ordenar.txt.";
            // 
            // numerosListView
            // 
            numerosListView.FormattingEnabled = true;
            numerosListView.ItemHeight = 15;
            numerosListView.Location = new Point(40, 148);
            numerosListView.Name = "numerosListView";
            numerosListView.Size = new Size(363, 184);
            numerosListView.TabIndex = 6;
            // 
            // gravarListaBotao
            // 
            gravarListaBotao.Location = new Point(481, 198);
            gravarListaBotao.Name = "gravarListaBotao";
            gravarListaBotao.Size = new Size(95, 23);
            gravarListaBotao.TabIndex = 7;
            gravarListaBotao.Text = "Gravar Lista";
            gravarListaBotao.UseVisualStyleBackColor = true;
            gravarListaBotao.Click += gravarListaBotao_Click;
            // 
            // abrirArquivoButton
            // 
            abrirArquivoButton.Location = new Point(481, 227);
            abrirArquivoButton.Name = "abrirArquivoButton";
            abrirArquivoButton.Size = new Size(95, 23);
            abrirArquivoButton.TabIndex = 8;
            abrirArquivoButton.Text = "Abrir Arquivo";
            abrirArquivoButton.UseVisualStyleBackColor = true;
            abrirArquivoButton.Click += abrirArquivoButton_Click;
            // 
            // ListaNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(abrirArquivoButton);
            Controls.Add(gravarListaBotao);
            Controls.Add(numerosListView);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(botaoAdicionar);
            Controls.Add(numeroTextBox);
            Name = "ListaNumeros";
            Size = new Size(663, 346);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numeroTextBox;
        private Button botaoAdicionar;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox numerosListView;
        private Button gravarListaBotao;
        private Button abrirArquivoButton;
    }
}
