using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RedeService.Enums;

namespace RedeService
{
    public partial class ListaNumeros : UserControl
    {
        private List<int> _listaNumeros { get; set; }
        private string _campoNumero { get; set; }

        private bool _mostrarBotaoGravar { get; set; }

        public ListaNumeros()
        {
            InitializeComponent();

            _listaNumeros = new List<int>();
            _mostrarBotaoGravar = false;

            gravarListaBotao.Visible = false;
            abrirArquivoButton.Visible = false;
        }

        private void botaoAdicionar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(_campoNumero, out _))
            {
                _listaNumeros.Add(int.Parse(_campoNumero));
                _listaNumeros.Sort();

                if (!_mostrarBotaoGravar)
                {
                    _mostrarBotaoGravar = !_mostrarBotaoGravar;
                    MostrarBotaoGravar();
                }

                numerosListView.BeginUpdate();
                numerosListView.Items.Clear();

                _listaNumeros.ForEach(delegate (int n)
                {
                    numerosListView.Items.Add(n.ToString());
                });

                numerosListView.EndUpdate();
                _campoNumero = string.Empty;
            }
            else
            {
                OnMessageChangeRequest(new ChangeMessageEventArgs(Messages.NUMERO_NAO_INFORMADO, MessageColors.ERROR));
            }

            numeroTextBox.Text = string.Empty;
        }

        private void MostrarBotaoGravar()
        {
            gravarListaBotao.Visible = true;
        }

        private void MostrarBotaoAbrir()
        {
            abrirArquivoButton.Visible = true;
        }

        protected virtual void OnMessageChangeRequest(ChangeMessageEventArgs e)
        {
            EventHandler<ChangeMessageEventArgs> handler = ChangeMessage;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void numeroTextBox_TextChanged(object sender, EventArgs e)
        {
            _campoNumero = numeroTextBox.Text;
        }

        private void gravarListaBotao_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(Application.StartupPath + "numeros_ordenar.txt"))
                {
                    _listaNumeros.ForEach(numero =>
                    {
                        writer.WriteLine(numero.ToString());
                    });
                }

                OnMessageChangeRequest(new ChangeMessageEventArgs(Messages.LISTA_SALVA, MessageColors.SUCCESS));

                MostrarBotaoAbrir();
            }
            catch (IOException ex)
            {
                OnMessageChangeRequest(new ChangeMessageEventArgs(Messages.ERRO_AO_SALVAR_LISTA, MessageColors.ERROR, ex));
            }

        }

        private void abrirArquivoButton_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", Application.StartupPath + "numeros_ordenar.txt");
        }

        public event EventHandler<ChangeMessageEventArgs> ChangeMessage;
    }
}
