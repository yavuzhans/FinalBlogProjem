﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YorumGuncelle.aspx.cs" Inherits="FinalOdevimP.AdminSayfalar.YorumGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" class="form-group">
        
        
        <asp:TextBox ID="TextBox1" runat="server" Cssclass="form-control" placeholder="Blog Başlık" Enabled="false"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" Cssclass="form-control" placeholder="Kullanıcı Adı"></asp:TextBox>
        <br />
        
        <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" placeholder="Yorum İçerik" TextMode="MultiLine" Height="100px"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-success" OnClick="Button1_Click"  />
        </form>
</asp:Content>
