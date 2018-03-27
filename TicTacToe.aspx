<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TicTacToe.aspx.cs" Inherits="TicTacToeHW2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style/TicTacToe.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server"> 
     <!-- Required for AJAX partial page load functionality.  Must be placed BEFORE the first update panel. -->
    <asp:ScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server">
    </asp:ScriptManager>
        <div id="topRow">
            <asp:Button ID="SignIn" runat="server" Text="Login" OnClick="SignIn_Click"></asp:Button>
            <asp:Button ID="About" runat="server" Text="About" OnClick="About_Click"></asp:Button>
            <asp:Button ID="TicTacToe" runat="server" Text="TicTacToe" OnClick="TicTacToe_Click"></asp:Button>
        </div>
        <div id="middleRow" >
             <asp:TextBox runat="server" ID="progressText"  CssClass="txt" Text="You do not have access to this game. " ReadOnly="true" ></asp:TextBox>
             <p id="LoginLink" runat="server">Please Click <a href="Default.aspx">here</a> to login</p>
        </div>        

        <div id="container" runat="server" Visible="false">
            <div class="right bottom game"><asp:button id="btn1" runat="server" CssClass="btn" OnClick="Btn1_Click"></asp:button><asp:image runat="server" id="x_1" CssClass="x_o" imageurl="Content/X.PNG" Visible="false"/><asp:image runat="server" id="o_1" CssClass="x_o" imageurl="Content/O.PNG" Visible="false"/></div>
            <div class="left bottom right game"><asp:button id="btn2" runat="server"  CssClass="btn" OnClick="Btn2_Click" ></asp:button><asp:image runat="server" id="x_2" CssClass="x_o" imageurl="Content/X.PNG" Visible="false"/><asp:image runat="server" id="o_2" CssClass="x_o" imageurl="Content/O.PNG" Visible="false"/></div>
            <div class="bottom left game"><asp:button id="btn3" runat="server" CssClass="btn" OnClick="Btn3_Click" ></asp:button><asp:image runat="server" id="x_3" CssClass="x_o" imageurl="Content/X.PNG" Visible="false"/><asp:image runat="server" id="o_3" CssClass="x_o" imageurl="Content/O.PNG" Visible="false"/></div>
      

            <div class="top bottom right game"><asp:button id="btn4" runat="server" CssClass="btn" OnClick="Btn4_Click"  ></asp:button><asp:image runat="server" id="x_4" CssClass="x_o"  imageurl="Content/X.PNG" Visible="false"/><asp:image runat="server" id="o_4" CssClass="x_o" imageurl="Content/O.PNG" Visible="false"/></div>
            <div class="top bottom left right game" ><asp:button id="btn5" runat="server" CssClass="btn" OnClick="Btn5_Click"></asp:button><asp:image runat="server" id="x_5" CssClass="x_o" imageurl="Content/X.PNG" Visible="false"/><asp:image runat="server" id="o_5" CssClass="x_o" imageurl="Content/O.PNG" Visible="false"/></div>
            <div class="top left bottom game"><asp:button id="btn6" runat="server" CssClass="btn" OnClick="Btn6_Click" ></asp:button><asp:image runat="server" id="x_6" CssClass="x_o" imageurl="Content/X.PNG" Visible="false"/><asp:image runat="server" id="o_6" CssClass="x_o" imageurl="Content/O.PNG" Visible="false"/></div>
            
            <div class="top right game"><asp:button id="btn7" runat="server" CssClass="btn" OnClick="Btn7_Click" ></asp:button><asp:image runat="server" id="x_7" CssClass="x_o" imageurl="Content/X.PNG" Visible="false"/><asp:image runat="server" id="o_7" CssClass="x_o" imageurl="Content/O.PNG" Visible="false"/></div>
            <div class="left top right game"><asp:button id="btn8" runat="server" CssClass="btn" OnClick="Btn8_Click" ></asp:button><asp:image runat="server" id="x_8" CssClass="x_o" imageurl="Content/X.PNG" Visible="false"/><asp:image runat="server" id="o_8" CssClass="x_o" imageurl="Content/O.PNG" Visible="false"/></div>
            <div class="top left game"><asp:button id="btn9" runat="server" CssClass="btn" OnClick="Btn9_Click" ></asp:button><asp:image runat="server" id="x_9" CssClass="x_o" imageurl="Content/X.PNG" Visible="false"/><asp:image runat="server" id="o_9" CssClass="x_o" imageurl="Content/O.PNG" Visible="false"/></div>
       
        </div>
    </form>
</body>
</html>
