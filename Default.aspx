<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TicTacToeHW2.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>"Welcome to the Tic Tac Toe Game"</title>
    <link href="Style/login.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <!-- Required for AJAX partial page load functionality.  Must be placed BEFORE the first update panel. -->
    <asp:ScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server">
    </asp:ScriptManager>
        <div id="header">
            <asp:Button ID="SignIn" runat="server" Text="Login" OnClick="SignIn_Click"></asp:Button>
            <asp:Button ID="About" runat="server" Text="About" OnClick="About_Click"></asp:Button>
            <asp:Button ID="TicTacToe" runat="server" Text="TicTacToe" OnClick="TicTacToe_Click"></asp:Button>
        </div>
        <div id="primary">
            <h1>Welcome to the Tic Tac Toe game!</h1>
            <h2 id="reg_text" runat="server">Register or Login to Play the game</h2>
            <asp:Button ID="logout" runat="server" Text="Log Out" OnClick="Logout_Click" Visible="false"/>
            <asp:Login ID="Login" runat="server" DestinationPageUrl="~/TicTacToe.aspx" OnAuthenticate="Login_Authenticate1"></asp:Login>
            <p id="p1" runat="server">Click <a href="Public.aspx">here</a> for general information</p>
        </div>
        <div>
            <asp:Label ID="tryAgain" CssClass="tryAgain" runat="server" Text="Username and password do not match. Please try again !" Visible="false" ></asp:Label>
        </div>
        <div>
            <asp:Label ID="status" runat="server"></asp:Label>
        </div>
    </form>  
</body>
</html>
