using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto3 {
    public partial class ExibirExcecoes1 : System.Web.UI.Page {
        string caminhoFisico = HttpContext.Current.Server.MapPath("~/Erros.txt");

        protected void Page_Load(object sender, EventArgs e) {
            Excecoes.Text = File.ReadAllText(caminhoFisico).Replace("\n", "<br>");
        }

        protected void Limpar_Click(object sender, EventArgs e) {
            File.WriteAllText(caminhoFisico, "");
            Excecoes.Text = "";
        }
    }
}