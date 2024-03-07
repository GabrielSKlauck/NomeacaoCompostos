using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomeacaoCompostos
{
    public class Nomeacao
    {
        public string GetFormulaMolecular(string molecula)
        {       
            Console.WriteLine(GetTipoPrefixo(molecula));
            return null;
        }

        private int GetTipoPrefixo(string molecula)
        {
            
            string prefixo;
            String linha = "";
            try
            {              
                StreamReader sr = new StreamReader("./ListaPrefixos.txt");                                 
                while (linha != null)
                {                                                        
                    linha = sr.ReadLine();
                    prefixo = linha.Substring(0, linha.IndexOf('-'));

                    if (molecula.StartsWith(prefixo))
                    {                                               
                        return (int)Int64.Parse(linha.Substring(linha.IndexOf('-')+1));
                    }
                }              
                sr.Close();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }           
            return 0;
        }
    }
}
