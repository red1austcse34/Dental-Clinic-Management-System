<%@ Page Title="" Language="C#" MasterPageFile="~/DCMSMasterPage.master" AutoEventWireup="true" CodeFile="MedicineCenter.aspx.cs" Inherits="MedicineCenter" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="Inventory" runat="server" style="width:500px;margin:0 auto;margin-top:auto;background-color:#ACFF67"
        onselectedindexchanged="GridView1_SelectedIndexChanged" 
    Font-Names="Forte" HorizontalAlign="Center">
    </asp:GridView>

    <table style="width:500px;margin:0 auto;margin-top:auto;background-color:#ACFF67">
        <tr style="width:250px;height:50px">
            <td>
                <asp:Button ID="Back" runat="server" Text="Back" onclick="Back_Click" />
            </td>
            <td>
                <asp:Button ID="Update" runat="server" Text="Update" onclick="Update_Click" />
            </td>
            <td>
                <asp:Button ID="Add" runat="server" Text="Add" onclick="Add_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

