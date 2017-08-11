<%@ Page Title="" Language="C#" MasterPageFile="~/DCMSMasterPage.master" AutoEventWireup="true"  CodeFile="AddDoc.aspx.cs" Inherits="AddDoc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style2
        {
            height: 50px;
        }
    </style>
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
    <tr style="width:250px;height:50px">
        <td>
            <asp:Label ID="Label2" runat="server" Text="Salary"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tbSalary" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr style="width:250px;height:50px">
        <td>
            <asp:Button ID="Back" runat="server" Text="Back" Width="110px" onclick="Back_Click"/>
        </td>
        <td>
            <asp:Button ID="Confirm" runat="server" Text="Confirm" Width="110px" 
                onclick="Confirm_Click" />
        </td>
    </tr>
</table>

</asp:Content>

