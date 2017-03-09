<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            width: 14px;
        }
        .auto-style4 {
            height: 23px;
            width: 14px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:RadioButtonList ID="rbForm" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem Value="1">Laat formulier zien</asp:ListItem>
            <asp:ListItem Value="2">Verberg formulier</asp:ListItem>
        </asp:RadioButtonList>
    <asp:Panel ID="Panel1" runat="server" Visible="false">

        <h1>Wie ben je?</h1>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Naam:</td>
                <td>
                    <asp:TextBox ID="txtNaam" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Geslacht:</td>
                <td>
                    <asp:RadioButtonList ID="rbGeslacht" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="M">Man</asp:ListItem>
                        <asp:ListItem Value="V">Vrouw</asp:ListItem>
                        <asp:ListItem Value="A">Anders</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Hobby:</td>
                <td class="auto-style2">
                    <asp:CheckBoxList ID="chkHobby" runat="server">
                        <asp:ListItem Value="1">Gamen</asp:ListItem>
                        <asp:ListItem Value="2">Programmeren</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Opleiding:</td>
                <td>
                    <asp:DropDownList ID="cbOpleiding" runat="server">
                        <asp:ListItem Value="1">VMBO</asp:ListItem>
                        <asp:ListItem Value="2">HAVO</asp:ListItem>
                        <asp:ListItem Value="3">VWO</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="btnMaakKaart" runat="server" Text="Maak persoon aan" OnClick="btnMaakKaart_Click" />
                </td>
                <td class="auto-style2"></td>
            </tr>
        </table>
    
    </asp:Panel>
    </form>
</body>
</html>
