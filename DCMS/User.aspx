<%@ Page Title="" Language="C#" MasterPageFile="~/DCMSMasterPage.master" AutoEventWireup="true" CodeFile="User.aspx.cs" Inherits="User" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width:500px;margin:0 auto;margin-top:auto;background-color:#ACFF67">
    <tr style="width:500px;height:50px">
        <td style="width:250px">
            <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
        </td>
        <td style="width:250px">
            <asp:TextBox ID="Name" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr style="width:500px;height:50px">
        <td style="width:250px">
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        </td>
        <td style="width:250px">
            <asp:TextBox ID="Pass" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr style="width:500px;height:50px">
        <td style="width:250px">
            <asp:Label ID="Label3" runat="server" Text="Confirm Password"></asp:Label>
        </td>
        <td style="width:250px">
            <asp:TextBox ID="CPass" runat="server" TextMode=Password></asp:TextBox>
        </td>
    </tr>
    <tr style="width:500px;height:50px">
        <td style="width:250px">
            <asp:Button ID="Confirm" runat="server" Text="Confirm" 
                onclick="Confirm_Click" />
        </td>
        <td style="width:250px">
            <asp:Button ID="Back" runat="server" Text="Back" onclick="Back_Click" />
        </td>
    </tr>
</table>
</asp:Content>

