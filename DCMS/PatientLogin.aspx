<%@ Page Title="" Language="C#" MasterPageFile="~/PatientMasterPage.master" AutoEventWireup="true" CodeFile="PatientLogin.aspx.cs" Inherits="PatientLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:600px;height:300px;margin:0 auto;margin-top:auto;background-color:#66FFFF">
        <tr style="height:60px">
            <td></td>
        </tr>
        <tr style="height:60px">
            <td>
                <asp:Label ID="Label2" runat="server" style="text-align:center;margin-left:210px" Text="Welcome To Patient Area" Font-Bold="True" Font-Names="Bernard MT Condensed" Font-Size="X-Large" Font-Underline="False" ForeColor="White"></asp:Label>
            </td>
        </tr>
        <tr style="width:500px;height:60px">
            <td style="width:250px">
                <asp:TextBox ID="CONTACT" placeholder="Contact Number" style="text-align:center;margin-left:175px" Width="250px" Height="40px" runat="server" Font-Bold="True" Font-Names="Arial Unicode MS" BackColor="#CCFFFF" Font-Size="X-Small" ></asp:TextBox>
            </td>
       </tr>
        <tr style="width:500px;height:60px">
            <td style="width:250px">
                <asp:TextBox ID="ID" placeholder="Patient ID" style="text-align:center;margin-left:175px" Width="250px" Height="40px" runat="server" Font-Bold="True" Font-Names="Arial Unicode MS" Font-Size="X-Small" BackColor="#CCFFFF" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr style="width:500px;height:60px">
            <td style="width:250px">
                <asp:Button ID="Log" style="margin-left:175px" Width="257px" Height="40px" 
                    runat="server" Text="Login" Font-Bold="True" Font-Names="Arial Unicode MS" 
                    Font-Size="Medium" ForeColor="Aqua" BackColor="White" onclick="Log_Click" />
            </td>
         </tr>
        <tr style="height:60px">
            <td></td>
        </tr>
        <tr>
            <td></td>
        </tr>
</table>
</asp:Content>

