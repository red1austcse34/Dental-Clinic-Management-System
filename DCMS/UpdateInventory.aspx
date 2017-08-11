<%@ Page Title="" Language="C#" MasterPageFile="~/DCMSMasterPage.master" AutoEventWireup="true" CodeFile="UpdateInventory.aspx.cs" Inherits="UpdateInventory" %>

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
    <tr style="width:250px;height:50px">
        <td>
            <asp:Label ID="Label3" runat="server" Text="ID"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tbID" runat="server" ontextchanged="tbID_TextChanged" 
                ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr style="width:250px;">
        <td class="style2">
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        </td>
        <td class="style2">
            <asp:DropDownList ID="ddlName" runat="server" Height="18px" 
                onselectedindexchanged="ddlName_SelectedIndexChanged" Width="169px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr style="width:250px;height:50px">
        <td>
            <asp:Label ID="Label4" runat="server" Text="Quantity"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tbQuantity" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr style="width:250px;height:50px">
        <td>
            <asp:Label ID="Label2" runat="server" Text="Price"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tbPrice" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr style="width:250px;height:50px">
        <td>
            <asp:Label ID="Label5" runat="server" Text="Supplier"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tbSupplier" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr style="width:250px;height:50px">
        <td>
            <asp:Button ID="Back" runat="server" Text="Back" Width="110px" onclick="Back_Click"/>
        </td>
        <td>
            <asp:Button ID="Fetch" runat="server" Text="Fetch" Width="110px" 
                onclick="Fetch_Click"/>
        </td>
        <td>
            <asp:Button ID="Confirm" runat="server" Text="Confirm" Width="110px" 
                onclick="Confirm_Click" />
        </td>
    </tr>
</table>

</asp:Content>
