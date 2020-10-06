<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="calculator2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
    <script src="modernizer-1.5.js"></script>
    <link rel="stylesheet" href="calculator2.css" title="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="displayLbl" runat="server" Width="200px"></asp:Label>
        </div>
        <p>
            <asp:Button ID="btnSeven" runat="server" OnClick="btnSeven_Click" Text="7" Width="50px" />
            <asp:Button ID="btnEight" runat="server" OnClick="btnEight_Click" Text="8" Width="50px" />
            <asp:Button ID="btnNine" runat="server" OnClick="btnNine_Click" Text="9" Width="50px" />
            <asp:Button ID="btnDivide" runat="server" OnClick="btnDivide_Click" Text="/" Width="50px" />
        </p>
        <asp:Button ID="btnFour" runat="server" OnClick="btnFour_Click" Text="4" Width="50px" />
        <asp:Button ID="btnFive" runat="server" OnClick="btnFive_Click" Text="5" Width="50px" />
        <asp:Button ID="btnSix" runat="server" OnClick="btnSix_Click" Text="6" Width="50px" />
        <asp:Button ID="btnMultiply" runat="server" OnClick="btnMultiply_Click" Text="*" Width="50px" />
        <p>
            <asp:Button ID="btnOne" runat="server" OnClick="btnOne_Click" Text="1" Width="50px" />
            <asp:Button ID="btnTwo" runat="server" OnClick="btnTwo_Click" Text="2" Width="50px" />
            <asp:Button ID="btnThree" runat="server" OnClick="btnThree_Click" Text="3" Width="50px" />
            <asp:Button ID="btnMinus" runat="server" OnClick="btnMinus_Click" Text="-" Width="50px" />
        </p>
        <asp:Button ID="btnZero" runat="server" OnClick="btnZero_Click" Text="0" Width="100px" />
        <asp:Button ID="btnEqual" runat="server" OnClick="btnEquals_Click" Text="=" Width="50px" />
        <asp:Button ID="btnPlus" runat="server" OnClick="btnPlus_Click" Text="+" Width="50px" />
        <p>
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" Width="100px" />
            <asp:Button ID="btnRecall" runat="server" Text="Recall" Width="100px" OnClick="btnRecall_Click" />
        </p>
        <asp:Label ID="recallLbl" runat="server" Width="200px"></asp:Label>

    </form>
    </body>
</html>
