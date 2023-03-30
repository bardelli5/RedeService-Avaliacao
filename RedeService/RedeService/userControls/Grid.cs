using RedeService.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedeService
{
    public partial class Grid : UserControl
    {
        public Grid()
        {
            InitializeComponent();
        }

        private void criarJsonButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<ClsTeste> lista = new List<ClsTeste>();

                for (int i = 1; i <= 100; i++)
                {
                    lista.Add(new ClsTeste(i, DateTime.Now.ToString()));
                }

                string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true, IncludeFields = true });
                File.WriteAllText("data.json", json);

                OnMessageChangeRequest(new ChangeMessageEventArgs(Enums.Messages.JSON_SALVO, Enums.MessageColors.SUCCESS));
            }
            catch (IOException ex)
            {
                OnMessageChangeRequest(new ChangeMessageEventArgs(Enums.Messages.ERRO_AO_SALVAR_JSON, Enums.MessageColors.ERROR, ex));
            }
        }

        private void carregarGridButton_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText("data.json");
            List<ClsTeste>? data = JsonSerializer.Deserialize<List<ClsTeste>>(json, new JsonSerializerOptions { IncludeFields = true });

            if (data != null)
            {
                dataGridView.ColumnCount = 2;
                dataGridView.Columns[0].Name = "Codigo";
                dataGridView.Columns[1].Name = "Descrição";

                data.ForEach(data => {
                    string[] row = { data._codigo.ToString(), data._descricao.ToString() };
                    dataGridView.Rows.Add(row);
                });
                OnMessageChangeRequest(new ChangeMessageEventArgs(Enums.Messages.GRID_CRIADO, Enums.MessageColors.SUCCESS));
            } else
            {
                OnMessageChangeRequest(new ChangeMessageEventArgs(Enums.Messages.ERRO_AO_CRIAR_GRID, Enums.MessageColors.ERROR));
            }
        }

        protected virtual void OnMessageChangeRequest(ChangeMessageEventArgs e)
        {
            EventHandler<ChangeMessageEventArgs> handler = ChangeMessage;
            if (handler != null)
            {
                handler(this, e);
            }
        }


        public event EventHandler<ChangeMessageEventArgs> ChangeMessage;
    }
}
