<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShoppingPlazaForm.aspx.cs" Inherits="FinalProject_411.WebForms.ShoppingPlazaForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="shoppingplazastyle.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 370px;
        }
        .auto-style3 {
            width: 80px;
        }
        .auto-style4 {
            width: 111px;
        }
        .auto-style5 {
            width: 217px;
        }
    </style>
</head>
<body>
    <h1>Here you make your selections. You can select one book title and one DVD title.</h1>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Books</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="bookSelectionDropDown" runat="server" Width="339px" OnSelectedIndexChanged="bookSelectionDropDown_SelectedIndexChanged" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
                <td class="auto-style4">Quantity</td>
                <td class="auto-style5">
                    <asp:TextBox ID="bookQuantityTxtBx" runat="server"></asp:TextBox>
                </td>
                <td>Price of Book:
                    <asp:Label ID="bookPriceLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">DVDs</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="dvdSelectionDropDown" runat="server" Width="339px" OnSelectedIndexChanged="dvdSelectionDropDown_SelectedIndexChanged" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
                <td class="auto-style4">Quantity</td>
                <td class="auto-style5">
                    <asp:TextBox ID="dvdQuantityTxtBx" runat="server"></asp:TextBox>
                </td>
                <td>Price of DVD:
                    <asp:Label ID="dvdPriceLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="messageLabel" runat="server"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="addBttn" runat="server" Text="Add" Width="82px" OnClick="addBttn_Click" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="checkoutBttn" runat="server" Text="Checkout" OnClick="checkoutBttn_Click" />
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td>
                    <asp:Button ID="exitBttn" runat="server" Text="Exit" Width="82px" OnClick="exitBttn_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
