using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Runtime.Serialization.Json;
using Trabalho_AED1._0.Model;

namespace Trabalho_AED1._0{
    public class Funcionarios
    {

        private static string FILE_NAME = "SaidaCadastro.json";

        public List<Funcionario> Items { get; set; }

        public Funcionarios()
        {
            Items = new List<Funcionario>();
        }

        public void SalvaCadastro(Funcionario funcionario)
        {
            Items.Add(funcionario);

            string json = JsonSerializer<Funcionarios>.ToJson(this);
            File.WriteAllText(FILE_NAME, json);

        }

        

    }
}
//add funcinario na lista
//Serializar funcionario
//salvar txt