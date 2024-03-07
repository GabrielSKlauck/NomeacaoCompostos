using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomeacaoCompostos
{
    public class Principal
    {
        public static void Main(string[] args)
        {
            Nomeacao nomeacao = new Nomeacao();
            Console.WriteLine(nomeacao.GetFormulaMolecular("etano"));
        }
    }
}
