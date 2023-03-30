using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RedeService.model
{
    public class Banco
    {
        [JsonPropertyName("ispb")]
        public string _ispb { get; set; }
        [JsonPropertyName("name")]
        public string _name { get; set; }
        [JsonPropertyName("code")]
        public int? _code { get; set; }
        [JsonPropertyName("fullName")]
        public string _fullName { get; set; }

        public Banco(string ispb, string name, int code, string fullName)
        {
            _ispb = ispb;
            _name = name;
            _code = code;
            _fullName = fullName;
        }

        [JsonConstructor]
        public Banco() { }
    }
}
