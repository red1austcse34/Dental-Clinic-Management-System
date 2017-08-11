<%@ Page Title="" Language="C#" MasterPageFile="~/DCMSMasterPage.master" AutoEventWireup="true" CodeFile="Doctors.aspx.cs" Inherits="Doctors" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="Docs" runat="server" style="width:500px;margin:0 auto;margin-top:auto;background-color:#ACFF67"
    Font-Names="Forte" HorizontalAlign="Center">
    </asp:GridView>

    <table style="width:500px;margin:0 auto;margin-top:auto;background-color:#ACFF67">
        <tr style="width:250px;height:50px">
            <td>
                <asp:Button ID="Back" runat="server" Text="Back" onclick="Back_Click" />
            </td>
            <td>
                <asp:Button ID="Add" runat="server" Text="Add" onclick="Add_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

