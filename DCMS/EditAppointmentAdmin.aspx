<%@ Page Title="" Language="C#" MasterPageFile="~/DCMSMasterPage.master" AutoEventWireup="true" CodeFile="EditAppointmentAdmin.aspx.cs" Inherits="EditAppointmentAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style2
        {
            height: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table style="width:500px;margin:0 auto;margin-top:auto;background-color:#ACFF67">
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Patient ID"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tbPatientID" runat="server" Width="150px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
            <asp:Button ID="Search" runat="server" Text="Search" Width="100px" 
                style="margin-left: 50px;" onclick="Search_Click" />
        </td>
    </tr>
    <tr>
        <td>
            <textarea id="Appoint" cols="45" rows="10" runat="server"></textarea>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="Patient's Name"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="tbPatientName" runat="server" Width="150px" ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style2">
            <asp:Label ID="Label3" runat="server" Text="Doctor's Name"></asp:Label>
        </td>
        <td class="style2">
            <asp:DropDownList
                ID="ddlDoctor" runat="server" Width="150px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label4" runat="server" Text="Date"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlDate" runat="server" Width="150px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label5" runat="server" Text="Time"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlTime" runat="server" Width="150px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="Fetch" runat="server" Text="Fetch" Width="100px" 
                style="margin-left: 50px;" onclick="Fetch_Click"/>
        </td>
        <td>
            <asp:Button ID="Update" runat="server" Text="Update" Width="100px"  
                style="margin-left: 50px;" onclick="Update_Click"/>
        </td>
        <td>
            <asp:Button ID="Button3" runat="server" Text="Delete" Width="100px" 
                style="margin-left: 50px;" onclick="Button3_Click"/>
        </td>
    </tr>
</table>
<table style="width:500px;margin:0 auto;padding-top: 50px;background-color:#ACFF67">
    <tr>
        <td>
            <asp:Button ID="Button4" runat="server" Text="Back" Width="100px" 
                style="margin-left:247px" onclick="Button4_Click"/>
        </td>
    </tr>
</table>

</asp:Content>

