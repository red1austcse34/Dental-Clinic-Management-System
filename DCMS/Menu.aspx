<%@ Page Title="" Language="C#" MasterPageFile="~/DCMSMasterPage.master" AutoEventWireup="true" CodeFile="Menu.aspx.cs" Inherits="Menu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:500px;margin:0 auto;margin-top:auto;background-color:#ACFF67">
    <tr style="width:500px;height:50px">
        <td style="width:250px">
            <asp:Button ID="Pinfo" runat="server" Text="Patient Info" Width="213px" 
                onclick="Pinfo_Click" />
        </td>
        <td style="width:250px">
            <asp:Button ID="Earn" runat="server" Text="Earnings And Expenses Info" 
                Width="213px" onclick="Earn_Click" />
        </td>
    </tr>
        <tr style="width:500px;height:50px">
        <td style="width:250px">
            <asp:Button ID="addTreatment" runat="server" Text="Add Treatment" Height="25px" 
                Width="213px" onclick="addTreat_Click" />
        </td>
        <td style="width:250px">
            <asp:Button ID="medCen" runat="server" Text="Medicine Center" Width="213px" 
                onclick="medCen_Click" />
        </td>
    </tr>
        <tr style="width:500px;height:50px">
        <td style="width:250px">
            <asp:Button ID="addUser" runat="server" Text="Add User" Width="213px" 
                onclick="addUser_Click" />
        </td>
        <td style="width:250px">
            <asp:Button ID="PassChange" runat="server" Text="Change Password" Width="213px" 
                onclick="PassChange_Click" />
        </td>
    </tr>
    <tr style="width:500px;height:50px">
        <td style="width:250px">
            <asp:Button ID="Doc" runat="server" Width="213px" 
                Text="Doctors" onclick="Doc_Click" />
        </td>
        <td style="width:250px">
            <asp:Button ID="UpDoc" runat="server" Text="Update Doctors" Width="213px" 
                onclick="UpDoc_Click" />
        </td>
    </tr>
        <tr style="width:500px;height:50px">
        <td style="width:250px">
            <asp:Button ID="Appointment" runat="server" Width="213px" 
                Text="Manage Appointments" onclick="Appointment_Click" />
        </td>
        <td style="width:250px">
            <asp:Button ID="signOut" runat="server" Text="Sign Out" Width="213px" 
                onclick="signOut_Click" />
        </td>
    </tr>
</table>
</asp:Content>

