<%@ Page Title="" Language="C#" MasterPageFile="~/DCMSMasterPage.master" AutoEventWireup="true" CodeFile="SearchAddPatient.aspx.cs" Inherits="SearchAddPatient" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:500px;margin:0 auto;margin-top:auto;background-color:#ACFF67">
    <tr style="width:500px;height:50px">
        <td style="width:250px">
            <asp:Label ID="Label1" runat="server" Text="Contact No"></asp:Label>
        </td>
        <td style="width:250px">
            <asp:TextBox ID="tbSearchContactNo" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr style="width:500px;height:50px">
        <td style="width:250px"></td>
        <td style="width:250px">
            <asp:Button ID="Search" runat="server" Text="Search" Width="87px" 
                onclick="Search_Click" />
        </td>
    </tr>
    <tr style="width:500px;height:50px">
        <td>
            <asp:Button ID="add" runat="server" Text="Add New Patient" 
                onclick="add_Click" />
        </td>
        <td style="width:250px">
            <asp:Button ID="Back" runat="server" Text="Back" Width="82px" 
                onclick="Back_Click" />
        </td>
        <td>
            <asp:Button ID="list" runat="server" Text="Patient List" 
                onclick="list_Click" />
        </td>
    </tr>
</table>
</asp:Content>

