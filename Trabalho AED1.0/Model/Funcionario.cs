using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Trabalho_AED1._0.Model
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public string Cargo { get; set; }
        public string CpfGestor { get; set; }


    }
}
