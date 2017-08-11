<%@ Page Title="" Language="C#" MasterPageFile="~/PatientMasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:500px;margin:0 auto;margin-top:auto;background-color:#C0C0C0">
    <tr style="width:500px;height:50px">
        <td style="width:250px">
            <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
        </td>
        <td style="width:250px">
            <asp:TextBox ID="USER" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr style="width:500px;height:50px">
        <td style="width:250px">
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        </td>
        <td style="width:250px">
            <asp:TextBox ID="PASS" TextMode="Password" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr style="width:500px;height:50px">
        <td></td>
        <td style="width:250px">
            <asp:Button ID="Log" runat="server" Text="Login" onclick="Log_Click" />
        </td>
    </tr>
</table>
</asp:Content>

