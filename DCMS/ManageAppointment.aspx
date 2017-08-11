<%@ Page Title="" Language="C#" MasterPageFile="~/PatientMasterPage.master" AutoEventWireup="true" CodeFile="ManageAppointment.aspx.cs" Inherits="ManageAppointment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:1100px;height:400px;margin:0 auto;background-image: url(Image/MABackground.jpg)">
        <tr>
            <td style="width:100px;height:125px;text-align:left"></td>
        </tr>
        <tr>
            <td style="width:220px"></td>
            <td style="width:220px"></td>
            <td style="width:220px">
                <asp:Button ID="bGetA" runat="server" Text="Get Appointment" Height="50px" 
                    Width="205px" style="margin-left: 50px" BackColor="#33CCCC" 
                    BorderColor="#000066" BorderStyle="Groove" Font-Bold="True" 
                    Font-Names="Arial Black" Font-Size="Small" ForeColor="White" 
                    onclick="bGetA_Click" />
            </td>
            <td style="width:220px">
                <asp:Button ID="bModifyA" runat="server" Text="Modify Appointment" 
                    Height="50px" Width="230px" style="margin-left: 5px" BackColor="#33CCCC" 
                    BorderColor="#000066" BorderStyle="Groove" Font-Bold="True" 
                    Font-Names="Arial Black" Font-Size="Small" ForeColor="White" 
                    onclick="bModifyA_Click" />
            </td>
            <td style="width:220px"></td>
        </tr>
        <tr>
            <td style="width:100px;height:50px;text-align:left">
            </td>
        </tr>
        <tr>
            <td style="width:100px;height:50px;text-align:left">
            </td>
        </tr>
        <tr>
            <td style="width:100px;height:125px;text-align:left"></td>
        </tr>
    </table>
</asp:Content>

