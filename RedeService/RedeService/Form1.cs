using System.Runtime.CompilerServices;
using RedeService.Enums;
using RedeService.model;

namespace RedeService
{
    public partial class Form1 : Form
    {
        private Label _mensagemLabel;

        public Form1()
        {
            InitializeComponent();

            this._mensagemLabel = this.mensagemLabel;
            _mensagemLabel.Text = "Pronto para começar!";
            _mensagemLabel.ForeColor = Color.ForestGreen;
        }

        private void listaNumeros1_Load(object sender, EventArgs e)
        {
            ListaNumeros listaNumeros = (ListaNumeros)sender;
            listaNumeros.ChangeMessage += OnChangeMessageRequest;
        }

        private void grid1_Load(object sender, EventArgs e)
        {
            Grid grid = (Grid)sender;
            grid.ChangeMessage += OnChangeMessageRequest;
        }

        private void consultaCep1_Load(object sender, EventArgs e)
        {
            ConsultaCep consultaCep = (ConsultaCep)sender;
            consultaCep.ChangeMessage += OnChangeMessageRequest;
        }

        private void consultaBanco1_Load(object sender, EventArgs e)
        {
            ConsultaBanco consultaBanco = (ConsultaBanco)sender;
            consultaBanco.ChangeMessage += OnChangeMessageRequest;
        }

        public void OnChangeMessageRequest(object sender, ChangeMessageEventArgs e)
        {
            if (e.ErrorMessage != null)
                _mensagemLabel.Text = e.Mensagem.GetMessage() + e.ErrorMessage;
            else
                _mensagemLabel.Text = e.Mensagem.GetMessage();

            _mensagemLabel.ForeColor = e.NewColor.GetColor();
        }

    }
}