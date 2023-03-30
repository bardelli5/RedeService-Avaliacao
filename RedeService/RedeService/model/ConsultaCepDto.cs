using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RedeService.model
{
    public class ConsultaCepDto
    {
        [JsonPropertyName("bairro")]
        public string _bairro { get; set; }
        [JsonPropertyName("cep")]
        public string _cep { get; set; }
        [JsonPropertyName("cidade")]
        public string _cidade { get; set; }
        [JsonPropertyName("complemento2")]
        public string _complemento2 { get; set; }
        [JsonPropertyName("end")]
        public string _end { get; set; }
        [JsonPropertyName("uf")]
        public string _uf { get; set; }

        public ConsultaCepDto() { }

        public ConsultaCepDto(string bairro, string cep, string cidade, string complemento2, string end, string uf)
        {
            _bairro = bairro;
            _cep = cep;
            _cidade = cidade;
            _complemento2 = complemento2;
            _end = end;
            _uf = uf;
        }
    }
}
