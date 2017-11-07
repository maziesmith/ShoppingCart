<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WelcomePage.aspx.cs" Inherits="FinalProject_411.WelcomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="WebForms/site.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 177px;
        }
        .auto-style3 {
            margin-left: 30px;
        }
    </style>
</head>
<body>
    <h1>Welcome to the Shopping Plaza!</h1>
    <form id="form1" runat="server">
    <div>
    <p>Here you can purchase books and DVDs. Simply follow the instructions provided below:</p>
        <ol type="1"> 
            <li>Select the book and enter the quantity. Click Add.</li> 
            <li>Select the DVD and enter the quantity. CLick Add.</li> 
            <li>To check out, click Check-out</li>
            <li>To close the application, click Exit. You will lose your selections.</li> 
            <li>In the check out screen, revise the quantities if you wish to. If you do, click Edit.</li>
            <li>To place final order, click Pay.</li>
            <li>To close the application, Click Exit. You will lose your selection.</li>
        </ol> 

    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="shopBttn" runat="server" Text="Go to Shopping Plaza" Width="178px" OnClick="shopBttn_Click" />
                </td>
                <td>
                    <asp:Button ID="exitBttn" runat="server" CssClass="auto-style3" ForeColor="#CC0000" Text="Exit" Width="101px" OnClick="exitBttn_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
