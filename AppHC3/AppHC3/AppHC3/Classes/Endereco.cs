using System;
using System.Collections.Generic;
using System.Text;

namespace AppHC3.Classes
{
    class Endereco
    {
        public int IdEndereco { get; set; }
        public int CEP { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Localidade { get; set; }
    }
}
