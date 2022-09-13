using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto3 {
    public partial class FaleConosco : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Enviar_Click(object sender, EventArgs e) {
            try {
                //VALIDAR OS DADOS
                if (NomeCompleto.Text.Trim() == "")
                    MensagemErro.Text = "Digite seu nome";
                else if (SeuEmail.Text.Trim() == "")
                    MensagemErro.Text = "Digite seu email";
                else if (Mensagem.Text.Trim() == "")
                    MensagemErro.Text = "Digite seu telefone";
                else {
                    NomeCompleto.Text = "";
                    SeuEmail.Text = "";
                    Mensagem.Text = "";
                    MensagemErro.Text = "";
                    MensagemSucesso.Text = "Email enviado com sucesso!";

                    //Montar pacote

                    var email = new MailMessage();
                    email.To.Add("contato@seudominio.com");
                    var from = new MailAddress("contato@seudominio.com");
                    email.From = from;
                    email.Subject = "Email enviado pelo form de contato";
                    email.Body = $"Dados enviados: \n" +
                        "Nome:{NomeCompleto.Text} \n" +
                        "Email:{SeuEmail.Text} \n" +
                        "Mensagem:{Mensagem.Text}";
                    email.IsBodyHtml = false;
                    //Enviar email
                    var smtp = new SmtpClient();
                    smtp.Host = "smtp.seudominio.com.br";
                    smtp.Credentials = new System.Net.NetworkCredential("contato@seudominio.com", "suasenha");
                    smtp.Send(email);
                }
            }
            catch (Exception ex) {
                MensagemSucesso.Text = "";
                MensagemErro.Text = "Erro ao tentar enviar email ";
                string conteudo = DateTime.Now.ToString() + " - " + ex.Message + "\n";
                //Rastreia métodos executados até o momento do errro
                conteudo += ex.StackTrace;
                //Source mostra o arquivo onde houve o erro
                conteudo += ex.Source;
                conteudo += "\n----------------------------------------------------\n";
                string caminhoFisico = HttpContext.Current.Server.MapPath("~/Erros.txt");

                System.IO.File.AppendAllText(caminhoFisico, conteudo);
            } 
        }
    }
}
