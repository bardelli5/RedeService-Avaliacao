namespace RedeService
{
    partial class ConsultaCep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaCep));
            label1 = new Label();
            label2 = new Label();
            cepTextField = new TextBox();
            button1 = new Button();
            resultadoBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 32);
            label1.Name = "label1";
            label1.Size = new Size(633, 45);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 105);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Insira o CEP:";
            // 
            // cepTextField
            // 
            cepTextField.Location = new Point(111, 102);
            cepTextField.Name = "cepTextField";
            cepTextField.Size = new Size(100, 23);
            cepTextField.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(217, 102);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // resultadoBox
            // 
            resultadoBox.Location = new Point(33, 141);
            resultadoBox.Multiline = true;
            resultadoBox.Name = "resultadoBox";
            resultadoBox.ReadOnly = true;
            resultadoBox.Size = new Size(364, 175);
            resultadoBox.TabIndex = 4;
            // 
            // ConsultaCep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(resultadoBox);
            Controls.Add(button1);
            Controls.Add(cepTextField);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConsultaCep";
            Size = new Size(706, 355);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox cepTextField;
        private Button button1;
        private TextBox resultadoBox;
    }
}
