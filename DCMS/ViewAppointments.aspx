<%@ Page Title="" Language="C#" MasterPageFile="~/DCMSMasterPage.master" AutoEventWireup="true" CodeFile="ViewAppointments.aspx.cs" Inherits="ViewAppointments" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table style="width:500px;margin:0 auto;padding-top: 5px;background-color:#ACFF67">
    <tr>
        <td>
            <asp:GridView ID="AppList" runat="server" Width="494px">
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="Update" runat="server" Text="Update" Width="100px" 
                onclick="Update_Click" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="Back" runat="server" Text="Back" Width="100px" 
                onclick="Back_Click" />
        </td>
    </tr>
</table>

</asp:Content>

