<%@ Page Title="" Language="C#" MasterPageFile="~/DCMSMasterPage.master" AutoEventWireup="true" CodeFile="NewPatient.aspx.cs" Inherits="NewPatient" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style2
        {
            width: 250px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:1000px;margin:0 auto;margin-top:auto;background-color:#ACFF67">
    <tr style="width:1000px;height:50px">
        <td class="style2">
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        </td>
        <td style="width:250px">
            <asp:TextBox ID="tbName" runat="server" style="width:140px"></asp:TextBox>
        </td>
        <td style="width:250px">
            <asp:CheckBox ID="cbBadCondition" runat="server" Text="Bad Condition" />
        </td>
        <td style="width:250px">
            <asp:CheckBox ID="cbGumBleeds" runat="server" Text="Gum Bleeds" />
        </td>
    </tr>
        <tr style="width:1000px;height:50px">
        <td class="style2">
            <asp:Label ID="Label2" runat="server" Text="Address"></asp:Label>
        </td>
        <td style="width:250px">
            <asp:TextBox ID="tbAdress" runat="server" style="width:140px"></asp:TextBox>
        </td>
        <td style="width:250px">
            <asp:CheckBox ID="cbToothLoose" runat="server" Text="Tooth Loose" />
        </td>
        <td style="width:250px">
            <asp:CheckBox ID="cbChestPain" runat="server" Text="Chest pain" />
        </td>
    </tr>
        <tr style="width:1000px;height:50px">
        <td class="style2">
            <asp:Label ID="Label3" runat="server" Text="Contact No"></asp:Label>
        </td>
        <td style="width:250px">
            <asp:TextBox ID="tbContactNo" runat="server" 
                Width="140px"></asp:TextBox>
        </td>
        <td style="width:250px">
            <asp:CheckBox ID="cbGumDisease" runat="server" Text="Gum Disease" />
        </td>
        <td style="width:250px">
            <asp:CheckBox ID="cbBadBreath" runat="server" Text="Bad Breath" />
        </td>
    </tr>
        <tr style="width:1000px;height:50px">
        <td class="style2">
            <asp:Label ID="Label4" runat="server" Text="Age"></asp:Label>
        </td>
        <td style="width:250px">
            <asp:TextBox ID="tbAge" runat="server" style="width:140px" 
                ontextchanged="tbAge_TextChanged"></asp:TextBox>
        </td>
        <td style="width:250px">
            <asp:CheckBox ID="cbJawpain" runat="server" Text="Jaw Pain" />
        </td>
        <td style="width:250px">
            <asp:CheckBox ID="cbBleedingTend" runat="server" Text="Bleeding Tend" />
        </td>
    </tr>
        <tr style="width:1000px;height:50px">
        <td class="style2">
            <asp:Label ID="Label5" runat="server" Text="Sex"></asp:Label>
        </td>
        <td style="width:250px">
            <asp:DropDownList ID="ddlSex" runat="server" style="width:140px">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td style="width:250px">
            <asp:CheckBox ID="cbHepatitis" runat="server" Text="Hepatitis" 
                 />
        </td>
        <td style="width:250px">
            <asp:CheckBox ID="cbHighBP" runat="server" Text="High BP" />
        </td>
    </tr>
        <tr style="width:1000px;height:50px">
        <td class="style2">
            <asp:Label ID="Label6" runat="server" Text="Marial Status"></asp:Label>
        </td>
        <td style="width:250px">
            <asp:DropDownList ID="ddlMarialStatus" runat="server" style="width:140px">
                <asp:ListItem>Married</asp:ListItem>
                <asp:ListItem>Unmarried</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td style="width:250px">
            <asp:CheckBox ID="cbDiabetes" runat="server" Text="Diabetes" />
        </td>
        <td style="width:250px">
            <asp:CheckBox ID="cbKidneyDisease" runat="server" Text="Kidney Disease" />
        </td>
    </tr>
        <tr style="width:1000px;height:50px">
        <td class="style2">
            <asp:Label ID="Label7" runat="server" Text="Occupation"></asp:Label>
        </td>
        <td style="width:250px">
            <asp:DropDownList ID="ddlOccupation" runat="server" style="width:140px">
                <asp:ListItem>Job</asp:ListItem>
                <asp:ListItem>Business</asp:ListItem>
                <asp:ListItem>Student</asp:ListItem>
                <asp:ListItem>Housewife</asp:ListItem>
                <asp:ListItem>Retired</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td style="width:250px">
            <asp:CheckBox ID="cbHeartTrouble" runat="server" Text="Heart Trouble" />
        </td>
        <td style="width:250px">
            <asp:CheckBox ID="cbLiverDisease" runat="server" Text="Liver Disease" />
        </td>
    </tr>
        <tr style="width:1000px;height:50px">
        <td class="style2">
            <asp:Label ID="Label8" runat="server" Text="Allergic to"></asp:Label>
        </td>
        <td style="width:250px">
            <asp:TextBox ID="tbAllergicTo" runat="server" style="width:140px" 
                ontextchanged="tbAllergicTo_TextChanged"></asp:TextBox>
        </td>
        <td style="width:250px">
            <asp:CheckBox ID="cbLungDisease" runat="server" Text="Lung Disease" />
        </td>
        <td style="width:250px">
            <asp:CheckBox ID="cbAsthma" runat="server" Text="Asthma" />
        </td>
    </tr>
        <tr style="width:1000px;height:50px">
        <td class="style2">
            <asp:Label ID="Label9" runat="server" Text="Pregnant"></asp:Label>
        </td>
        <td style="width:250px">
            <asp:TextBox ID="tbPregnant" runat="server" style="width:140px"></asp:TextBox>
        </td>
        <td style="width:250px">
            <asp:CheckBox ID="cbRheumatic" runat="server" Text="Rheumatic" />
        </td>
        <td style="width:250px">
            <asp:CheckBox ID="cbAIDS" runat="server" Text="AIDS" />
        </td>
    </tr>
        <tr style="width:1000px;height:50px">
        <td class="style2">
            <asp:Label ID="Label10" runat="server" Text="Medicine"></asp:Label>
        </td>
        <td style="width:250px">
            <asp:TextBox ID="tbMedicine" runat="server" style="width:140px"></asp:TextBox>
        </td>
        <td style="width:250px">
            <asp:CheckBox ID="cbAnemia" runat="server" Text="Anemia" />
        </td>
        <td style="width:250px">
            <asp:Button ID="Add" runat="server" Text="ADD" Width="129px" 
                onclick="Add_Click" />
        </td>
    </tr>
        <tr style="width:1000px;height:50px">
        <td class="style2">
            <asp:Label ID="Label11" runat="server" Text="Sensitivity To"></asp:Label>
        </td>
        <td style="width:250px">
            <asp:TextBox ID="tbSensitivityTo" runat="server" style="width:140px"></asp:TextBox>
        </td>
        <td style="width:250px"></td>
        <td style="width:250px">
            <asp:Button ID="Back" runat="server" Text="Back" Width="129px" 
                onclick="Back_Click" />
        </td>
    </tr>
</table>
</asp:Content>

