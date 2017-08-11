<%@ Page Title="" Language="C#" MasterPageFile="~/DCMSMasterPage.master" AutoEventWireup="true" CodeFile="DentalHistory.aspx.cs" Inherits="DentalHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:500px;margin:0 auto;margin-top:auto;background-color:#ACFF67">
    <tr style="width:250px;">
        <td class="style2">
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
        </td>
    </tr>
    </table>
    <asp:GridView ID="Hist" runat="server" style="width:500px;margin:0 auto;margin-top:auto;background-color:#ACFF67"
    Font-Names="Forte" HorizontalAlign="Center">
    </asp:GridView>

    <table style="width:500px;margin:0 auto;margin-top:auto;background-color:#ACFF67">
        <tr style="width:250px;height:50px">
            <td>
                <asp:Button ID="Back" runat="server" Text="Ok" onclick="Ok_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
