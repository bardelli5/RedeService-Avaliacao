using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RedeService.model
{
    public class ClsTeste
    {
        public int _codigo {  get; set; }
        public string _descricao { get; set; }

        public ClsTeste(int codigo, string descricao)
        {
            _codigo = codigo;
            _descricao = descricao;
        }

        [JsonConstructor]
        public ClsTeste() { }
    }
}
