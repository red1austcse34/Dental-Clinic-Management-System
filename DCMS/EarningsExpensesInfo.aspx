<%@ Page Title="" Language="C#" MasterPageFile="~/DCMSMasterPage.master" AutoEventWireup="true" CodeFile="EarningsExpensesInfo.aspx.cs" Inherits="EarningsExpensesInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:500px;margin:0 auto;margin-top:auto;background-color:#ACFF67">
    <tr style="width:500px;height:50px">
        <td style="width:250px">
            <asp:Label ID="Label1" runat="server" Text="Year"></asp:Label>
        </td>
        <td style="width:250px">
            <asp:TextBox ID="tbYear" runat="server" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
        </td>
    </tr>
    <tr style="width:500px;height:50px">
        <td style="width:250px">
            <asp:Label ID="Label2" runat="server" Text="Month"></asp:Label>
        </td>
        <td style="width:250px">
            <asp:DropDownList ID="ddlMonth" runat="server" 
                onselectedindexchanged="ddlMonth_SelectedIndexChanged">
                <asp:ListItem>January</asp:ListItem>
                <asp:ListItem>February</asp:ListItem>
                <asp:ListItem>March</asp:ListItem>
                <asp:ListItem>April</asp:ListItem>
                <asp:ListItem>May</asp:ListItem>
                <asp:ListItem>June</asp:ListItem>
                <asp:ListItem>July</asp:ListItem>
                <asp:ListItem>August</asp:ListItem>
                <asp:ListItem>September</asp:ListItem>
                <asp:ListItem>October</asp:ListItem>
                <asp:ListItem>November</asp:ListItem>
                <asp:ListItem>December</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr style="width:500px;height:50px">
        <td style="width:250px">
            <asp:Button ID="Search" runat="server" Text="Search" onclick="Search_Click" />
        </td>
        <td style="width:250px">
            <asp:Button ID="Back" runat="server" Text="Back" onclick="Back_Click" />
        </td>
    </tr>
</table>
</asp:Content>

