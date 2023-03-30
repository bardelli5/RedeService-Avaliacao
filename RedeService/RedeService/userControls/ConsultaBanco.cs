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
    public partial class ConsultaBanco : UserControl
    {
        const string uri = "https://brasilapi.com.br/api/banks/v1";
        static HttpClient client = new HttpClient();

        public ConsultaBanco()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            HttpResponseMessage msg = await client.GetAsync(uri);

            if (msg.IsSuccessStatusCode)
            {
                string bodyStr = await msg.Content.ReadAsStringAsync();

                List<Banco>? bancos = JsonSerializer.Deserialize<List<Banco>>(bodyStr, new JsonSerializerOptions { IncludeFields = true });

                if (bancos != null)
                {
                    dataGridView.ColumnCount = 4;
                    dataGridView.Columns[0].Name = "ISPB";
                    dataGridView.Columns[1].Name = "Nome";
                    dataGridView.Columns[2].Name = "Código";
                    dataGridView.Columns[3].Name = "Nome Completo";

                    bancos.ForEach(banco =>
                    {
                        string[] row = { banco._ispb, banco._name, banco._code.ToString(), banco._fullName };
                        dataGridView.Rows.Add(row);
                    });

                    OnMessageChangeRequest(new ChangeMessageEventArgs(Enums.Messages.API_CHAMADA, Enums.MessageColors.SUCCESS));
                }
            } else
            {
                OnMessageChangeRequest(new ChangeMessageEventArgs(Enums.Messages.ERRO_AO_CHAMAR_API, Enums.MessageColors.ERROR));
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
