<%@ Page Title="" Language="C#" MasterPageFile="~/DCMSMasterPage.master" AutoEventWireup="true" CodeFile="ShowPatientDetails.aspx.cs" Inherits="ShowPatientDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table style="width:500px;margin:0 auto;margin-top:auto;background-color:#ACFF67">
    <tr style="width:250px;height:50px">
        <td>
            <asp:Label ID="Name" runat="server" Text="Name"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr style="width:250px;height:50px">
        <td>
            <asp:Label ID="Label2" runat="server" Text="Address"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tbAddress" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr style="width:250px;height:50px">
        <td>
            <asp:Label ID="Label3" runat="server" Text="Contact No"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tbContactNo" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr style="width:250px;height:50px">
        <td>
            <asp:Label ID="Label4" runat="server" Text="Age"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tbAge" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr style="width:250px;height:50px">
        <td>
            <asp:Label ID="Label5" runat="server" Text="Sex"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tbSex" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr style="width:250px;height:50px">
        <td>
            <asp:Label ID="Label6" runat="server" Text="Marital Status"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tbMaritalStatus" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr style="width:250px;height:50px">
        <td>
            <asp:Label ID="Label7" runat="server" Text="Occupation"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tbOccupation" runat="server"></asp:TextBox>
        </td>
    </tr>
    </table>
    <table style="width:500px;margin:0 auto;margin-top:auto;background-color:#ACFF67">
        <tr>
            <td>
                <textarea id="MedInfo" cols="45" rows="10" runat="server"></textarea>
            </td>
        </tr>
    </table>
        <table style="width:500px;margin:0 auto;margin-top:auto;background-color:#ACFF67">
        <tr>
            <td>
                <asp:Button ID="History" runat="server" Text="History" Width="110px" 
                    onclick="History_Click" />
            </td>
            <td>
                <asp:Button ID="Update" runat="server" Text="Update" Width="110px" 
                    onclick="Update_Click" />
            </td>
            <td>
                <asp:Button ID="Proceed" runat="server" Text="Pay" Width="111px" 
                    onclick="Proceed_Click" />
            </td>
        </tr>
    </table>
    <table style="width:500px;margin:0 auto;margin-top:auto;background-color:#ACFF67">
        <tr>
            <td>
                <asp:Button ID="Back" runat="server" Text="Back" Width="110px" 
                    onclick="Back_Click" />
            </td>
        </tr>
    </table>

</asp:Content>

