<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AracGirisSayfasi.aspx.cs" Inherits="otoparksistemi.AracGirisSayfasi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
        height: 219px;
    }
    .auto-style2 {
        width: 164px;
    }
    .auto-style3 {
        width: 164px;
        height: 34px;
    }
    .auto-style4 {
        height: 34px;
    }
    .auto-style5 {
        width: 100%;
        height: 227px;
        margin-top: 0px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style5">
    <tr>
        <td class="auto-style2">TC Kimlik Numarası:</td>
        <td>
            <asp:TextBox ID="t_tcno" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Adınız:</td>
        <td>
            <asp:TextBox ID="t_ad" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Soyadınız:</td>
        <td>
            <asp:TextBox ID="t_soyad" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Araç Tipiniz:</td>
        <td>
            <asp:TextBox ID="t_aractipi" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Araç Sınıfınız:</td>
        <td>
            <asp:TextBox ID="t_aracsinifi" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style3"></td>
        <td class="auto-style4">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Kayıt Ekle" />
        </td>
    </tr>
</table>
</asp:Content>
