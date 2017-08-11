<%@ Page Title="" Language="C#" MasterPageFile="~/PatientMasterPage.master" AutoEventWireup="true" CodeFile="GetAppointment.aspx.cs" Inherits="GetAppointment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:1100px;height:400px;margin:0 auto;background-image: url(Image/GABackground.png)">
        <tr>
            <td style="width:100px;height:125px;text-align:left"></td>
        </tr>
        <tr>
            <td style="width:100px;height:50px;text-align:right;">
                <asp:Label ID="Label1" runat="server" Text="Date" Font-Bold="True" Font-Names="Agency FB" Font-Size="Large"></asp:Label>
            </td>
            <td>

                <asp:DropDownList ID="ddlDate" runat="server" style="margin-left:10px" 
                    Height="25px" Width="150px" Font-Bold="True" Font-Names="Agency FB" 
                    Font-Size="Medium" onselectedindexchanged="ddlDate_SelectedIndexChanged" 
                    ontextchanged="ddlDate_SelectedIndexChanged">
                </asp:DropDownList>

            </td>
        </tr>
        <tr>
            <td style="width:100px;height:50px;text-align:right">
                <asp:Label ID="Label2" runat="server" Text="Doctor" Font-Bold="True" Font-Names="Agency FB" Font-Size="Large"></asp:Label>
            </td>
            <td>

                <asp:DropDownList ID="ddlDoctor" runat="server" style="margin-left:10px" 
                    Height="25px" Width="150px" Font-Bold="True" Font-Names="Agency FB" 
                    Font-Size="Medium" onselectedindexchanged="ddlDoctor_SelectedIndexChanged" 
                    ontextchanged="ddlDoctor_SelectedIndexChanged">
                </asp:DropDownList>

            </td>
        </tr>
        <tr>
            <td style="width:100px;height:50px;text-align:right">
                <asp:Label ID="Label3" runat="server" Text="Time" Font-Bold="True" Font-Names="Agency FB" Font-Size="Large"></asp:Label>
            </td>
            <td>

                <asp:DropDownList ID="ddlTime" runat="server" style="margin-left:10px" Height="25px" Width="150px" Font-Bold="True" Font-Names="Agency FB" Font-Size="Medium">
                </asp:DropDownList>

            </td>
        </tr>
        <tr>
            <td style="width:100px;height:125px;text-align:left">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Back" BorderColor="#66FFFF" 
                    BorderStyle="Groove" Font-Bold="True" Font-Names="Agency FB" Font-Size="Medium" 
                    onclick="Button2_Click" /> &nbsp &nbsp &nbsp 
                <asp:Button ID="Check" runat="server" Text="Check" BorderColor="#66FFFF" 
                    BorderStyle="Groove" Font-Bold="True" Font-Names="Agency FB" 
                    Font-Size="Medium" onclick="Check_Click" />
                &nbsp &nbsp &nbsp
                <asp:Button ID="Ok" runat="server" Text="OK" BorderColor="#66FFFF" 
                    BorderStyle="Groove" Font-Bold="True" Font-Names="Agency FB" Font-Size="Medium" 
                    onclick="Ok_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

