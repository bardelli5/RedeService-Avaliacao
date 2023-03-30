using RedeService.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RedeService
{
    public partial class ConsultaCep : UserControl
    {
        static HttpClient client = new HttpClient();

        public ConsultaCep()
        {
            InitializeComponent();
        }

        private async Task<ConsultaCepDto?> ConsumirApi(String cep)
        {
            string requestUri = "https://apphom.correios.com.br/SigepMasterJPA/AtendeClienteService/AtendeCliente";
            string body = @"<x:Envelope
                    xmlns:x=""http://schemas.xmlsoap.org/soap/envelope/""
                    xmlns:cli=""http://cliente.bean.master.sigep.bsb.correios.com.br/"">
                    <x:Header/>
                    <x:Body>
                        <cli:consultaCEP>
                            <cep>" + cep + @"</cep>
                            </cli:consultaCEP>
                        </x:Body>
                    </x:Envelope>";
            StringContent stringContent = new StringContent(body, Encoding.Default, "text/xml");
            HttpResponseMessage response = await client.PostAsync(requestUri, stringContent);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                XDocument xdoc = XDocument.Parse(responseBody);

                ConsultaCepDto dto = new ConsultaCepDto(
                    xdoc.Descendants("bairro").First().Value,
                    xdoc.Descendants("cep").First().Value,
                    xdoc.Descendants("cidade").First().Value,
                    xdoc.Descendants("complemento2").First().Value,
                    xdoc.Descendants("end").First().Value,
                    xdoc.Descendants("uf").First().Value
                );

                OnMessageChangeRequest(new ChangeMessageEventArgs(Enums.Messages.API_CHAMADA, Enums.MessageColors.SUCCESS));
                return dto;
            }
            else
            {
                OnMessageChangeRequest(new ChangeMessageEventArgs(Enums.Messages.ERRO_AO_CHAMAR_API, Enums.MessageColors.ERROR));
            }

            return null;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            resultadoBox.Text = string.Empty;
            ConsultaCepDto? cep = await ConsumirApi(cepTextField.Text);

            if (cep != null)
            {
                resultadoBox.Text = JsonSerializer.Serialize(cep, new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                    WriteIndented = true
                });
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
