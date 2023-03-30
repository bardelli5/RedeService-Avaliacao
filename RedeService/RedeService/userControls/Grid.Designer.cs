namespace RedeService
{
    partial class Grid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grid));
            label1 = new Label();
            dataGridView = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            criarJsonButton = new Button();
            carregarGridButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 15);
            label1.Name = "label1";
            label1.Size = new Size(728, 45);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView.Location = new Point(24, 156);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(500, 181);
            dataGridView.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 71);
            label2.Name = "label2";
            label2.Size = new Size(463, 15);
            label2.TabIndex = 2;
            label2.Text = "4. Grave a lista do item 3, em um arquivo de nome data.json na pasta raiz da aplicação.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 99);
            label3.Name = "label3";
            label3.Size = new Size(483, 15);
            label3.TabIndex = 3;
            label3.Text = "5. Crie um Grid, leia o arquivo data.json que foi gravado, e mostre os dados no Grid criado.";
            // 
            // criarJsonButton
            // 
            criarJsonButton.Location = new Point(24, 127);
            criarJsonButton.Name = "criarJsonButton";
            criarJsonButton.Size = new Size(247, 23);
            criarJsonButton.TabIndex = 4;
            criarJsonButton.Text = "Criar Arquivo JSON";
            criarJsonButton.UseVisualStyleBackColor = true;
            criarJsonButton.Click += criarJsonButton_Click;
            // 
            // carregarGridButton
            // 
            carregarGridButton.Location = new Point(277, 127);
            carregarGridButton.Name = "carregarGridButton";
            carregarGridButton.Size = new Size(247, 23);
            carregarGridButton.TabIndex = 5;
            carregarGridButton.Text = "Carregar Grid";
            carregarGridButton.UseVisualStyleBackColor = true;
            carregarGridButton.Click += carregarGridButton_Click;
            // 
            // Grid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(carregarGridButton);
            Controls.Add(criarJsonButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView);
            Controls.Add(label1);
            Name = "Grid";
            Size = new Size(757, 381);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView;
        private Label label2;
        private Label label3;
        private Button criarJsonButton;
        private Button carregarGridButton;
    }
}
