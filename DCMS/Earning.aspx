<%@ Page Title="" Language="C#" MasterPageFile="~/DCMSMasterPage.master" AutoEventWireup="true" CodeFile="Earning.aspx.cs" Inherits="Earning" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table style="width:500px;margin:0 auto;padding-top: 50px;background-color:#ACFF67">
    <tr>
        <td>
            <asp:GridView ID="Earn" runat="server" Width="500px" 
                onselectedindexchanged="Earn_SelectedIndexChanged">
            </asp:GridView>
        </td>
    </tr>
</table>
<table  style="width:500px;margin:0 auto;padding-top: 50px;background-color:#ACFF67">
    <tr>
        <td style="width:300px;">
            <asp:Label ID="Label1" runat="server" Text="Total" style="float: right;"></asp:Label>
        </td>
        <td style="width:200px;">
            <asp:TextBox ID="Total" runat="server" style="float: right;"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
        
        </td>
        <td>
            <asp:Button ID="Ok" runat="server" Text="OK" Width="100px" style="float:right;" 
                onclick="Ok_Click"/>
        </td>
    </tr>
</table>

</asp:Content>

