<%@ Page Title="" Language="C#" MasterPageFile="~/PatientMasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:1100px;height:400px;margin:0 auto;background-image: url(Image/IndexBackground.png)">
        <tr>
            <td style="width:100px;height:125px;text-align:left"></td>
        </tr>
        <tr>
            <td style="width:100px;height:50px;text-align:left">
                <asp:Button ID="bAdmin" runat="server" Text="ADMIN" Height="50px" Width="223px" 
                    style="margin-left: 50px" BackColor="#33CCCC" BorderColor="#000066" 
                    BorderStyle="Groove" Font-Bold="True" Font-Names="Arial Black" 
                    Font-Size="Medium" ForeColor="White" onclick="bAdmin_Click" />
            </td>
        </tr>
        <tr>
            <td style="width:100px;height:50px;text-align:left">
                <asp:Button ID="bManageAppoinment" runat="server" Text="Manage Appointment" 
                    Height="50px" Width="223px" style="margin-left: 50px" BackColor="#33CCCC" 
                    BorderColor="#000066" BorderStyle="Groove" Font-Bold="True" 
                    Font-Names="Arial Black" Font-Size="X-Small" ForeColor="White" 
                    onclick="bManageAppoinment_Click" />
            </td>
        </tr>
        <tr>
            <td style="width:100px;height:50px;text-align:left">
                <asp:Button ID="bRegistration" runat="server" Text="Registration" Height="50px" 
                    Width="223px" style="margin-left: 50px" BackColor="#33CCCC" 
                    BorderColor="#000066" BorderStyle="Groove" Font-Bold="True" 
                    Font-Names="Arial Black" Font-Size="Medium" ForeColor="White" 
                    onclick="bRegistration_Click" />
            </td>
        </tr>
        <tr>
            <td style="width:100px;height:125px;text-align:left"></td>
        </tr>
    </table>
</asp:Content>

