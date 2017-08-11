<%@ Page Title="" Language="C#" MasterPageFile="~/DCMSMasterPage.master" AutoEventWireup="true" CodeFile="AutomatedBill.aspx.cs" Inherits="AutomatedBill" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:500px;margin:0 auto;margin-top:auto;background-color:#ACFF67">
    <tr style="width:500px;height:50px">
        <td style="width:250px">
            <asp:Label ID="Label1" runat="server" Text="Patient ID"></asp:Label>
        </td>
        <td style="width:250px">
            <asp:TextBox ID="tbPatientID" runat="server" style="width:120px" 
                ontextchanged="tbPatientID_TextChanged"></asp:TextBox>
        </td>
    </tr>
    <tr style="width:500px;height:50px">
        <td style="width:250px">
            <asp:Label ID="Label5" runat="server" Text="Doctor ID"></asp:Label>
        </td>
        <td style="width:250px">
            <asp:TextBox ID="tbDocID" runat="server" style="width:120px"></asp:TextBox>
        </td>
    </tr>
    <tr style="width:500px;height:50px">
        <td style="width:250px">
            <asp:Label ID="Label2" runat="server" Text="Treatment"></asp:Label>
        </td>
        <td style="width:250px">
            <asp:DropDownList ID="ddlTreatment" runat="server" style="width:120px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr style="width:500px;height:50px">
        <td style="width:250px">
            <asp:Label ID="Label3" runat="server" Text="Tooth"></asp:Label>
        </td>
        <td style="width:250px">
            <asp:TextBox ID="tbTooth" runat="server" style="width:120px"></asp:TextBox>
        </td>
    </tr>
    <tr style="width:500px;height:50px">
        <td style="width:250px">
            <asp:Label ID="Label4" runat="server" Text="Number Of Tooth"></asp:Label>
        </td>
        <td style="width:250px">
            <asp:TextBox ID="tbNumOfTooth" runat="server" style="width:120px"></asp:TextBox>
        </td>
    </tr>
    <tr style="width:500px;height:50px">
        <td style="width:250px">
            <asp:Label ID="Label6" runat="server" Text="Cost"></asp:Label>
        </td>
        <td style="width:250px">
            <asp:TextBox ID="tbCost" runat="server" style="width:120px"></asp:TextBox>
        </td>
    </tr>
    <tr style="width:500px;height:50px">
        <td style="width:166px">
            <asp:Button ID="Calculate" runat="server" Text="Calculate" onclick="Calculate_Click" />
        </td>
        <td style="width:167px">
            <asp:Button ID="Pay" runat="server" Text="Pay" onclick="Pay_Click" />
        </td>
        <td style="width:167px">
            <asp:Button ID="Back" runat="server" Text="Back" onclick="Back_Click" />
        </td>
    </tr>
</table>
</asp:Content>

