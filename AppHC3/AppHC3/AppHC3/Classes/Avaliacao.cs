using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Runtime.CompilerServices;

namespace AppHC3.Classes
{
    class Avaliacao
    {
       public int IdAvaliacao { get; set; }
       public int IDProfissionalDeSaude { get; set; }
       public string Topico { get; set; }
       public int NivelAvaliado { get; set; }
       public string Comentario { get; set; } 
       public char TeveContato { get; set; }
       public string StatusAvaliacao { get; set; }

    }
}
