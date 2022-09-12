<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="FaleConosco.aspx.cs" Inherits="Projeto3.FaleConosco" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="margin-top-60">
        <div class="row">
            <div class="col-6">
                <div class="box border margin-right-20">
                    <h2>Fale Conosco</h2>
                    <asp:Label ID="MensagemSucesso" ForeColor="Green" Font-Size="16px" runat="server"></asp:Label>
                    <asp:Label ID="MensagemErro" ForeColor="Red" Font-Size="16px" runat="server"></asp:Label>
                    <label>Digite seu nome</label>
                    <asp:TextBox ID="NomeCompleto" MaxLength="60" PlaceHolder="Nome sobrenome" runat="server"></asp:TextBox>
                    <label>E-Mail</label>
                    <asp:TextBox ID="SeuEmail" PlaceHolder="email@example.com" MaxLength="255" runat="server"></asp:TextBox>
                    <label>Mensage</label>
                    <asp:TextBox ID="Mensagem" PlaceHolder="Mensagem..." MaxLength="256" TextMode="MultiLine" Rows="6" runat="server"></asp:TextBox>
                    <asp:Button ID="Enviar" CssClass="" onClick="Enviar_Click" runat="server" Text="Enviar" />
                </div>
            </div>
            <div class="col-6">
                <div class="margin-top-60 margin-right-20">
                    <iframe style="border-radius:10px" src="https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d14718.767977128833!2d-47.3501613!3d-22.7396868!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xffb368bd91ea12ae!2sFatec%20Americana%20-%20Faculdade%20de%20Tecnologia%20de%20Americana%20Ministro%20Ralph%20Biasi!5e0!3m2!1spt-BR!2sbr!4v1662490834415!5m2!1spt-BR!2sbr" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
