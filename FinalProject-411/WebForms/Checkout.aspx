<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="FinalProject_411.WebForms.Checkout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CheckoutStyle.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 349px;
        }
        .auto-style3 {
            width: 349px;
            text-align: center;
        }
        .auto-style4 {
            text-align: center;
        }
    </style>
</head>
<body style="width: 621px">
    <form id="form1" runat="server">
    <div>
    
        <asp:ListBox ID="productListBox" runat="server" Height="179px" Width="619px" AutoPostBack="True" OnSelectedIndexChanged="productListBox_SelectedIndexChanged"></asp:ListBox>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Change Quantity:
                    <asp:TextBox ID="quantityTxtBx" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:Button ID="changeQuantity" runat="server" Text="Change Quantity" OnClick="changeQuantity_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="payBttn" runat="server" Text="Pay" OnClick="payBttn_Click" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="exitBttn" runat="server" Text="Exit" OnClick="exitBttn_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="priceLabel" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
