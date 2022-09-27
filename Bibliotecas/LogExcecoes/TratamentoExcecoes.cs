using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LogExcecoes
{   /// <summary>
    /// Classe para catalogar exceções
    /// </summary>
    public class TratamentoExcecoes
    {
        string caminhoFisico = HttpContext.Current.Server.MapPath("~/Erros.txt");
   
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ex">Recebe uma Exception como parametro</param>
        public void SalvarExececoes(Exception ex) {
            string conteudo = DateTime.Now.ToString() + " - " + ex.Message + "\n";
            //Rastreia métodos executados até o momento do errro
            conteudo += ex.StackTrace;
            //Source mostra o arquivo onde houve o erro
            conteudo += ex.Source;
            conteudo += "\n----------------------------------------------------\n";
            System.IO.File.AppendAllText(caminhoFisico, conteudo);
        }
        /// <summary>
        /// Ler todas as exceções no log
        /// </summary>
        /// <returns></returns>
        public string LerExcecoes() {
            return File.ReadAllText(caminhoFisico).Replace("\n", "<br>");    
        }
        /// <summary>
        /// Limpar o log do exceções
        /// </summary>
        public void LimparExcecoes() {
            File.WriteAllText(caminhoFisico, "");
        }
    }
}
