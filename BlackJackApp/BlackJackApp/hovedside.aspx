<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hovedside.aspx.cs" Inherits="BlackJackApp.hovedside" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center;">
    
    <div style="height:inherit; width:inherit">  
        <img src="Images/bannerCasino.jpg" alt="Background"/>
        
    </div >

    <div id="divSelectPlayers" style="padding-top:5px; margin:5px;">
        <asp:Label ID="label_SelectPlayers" runat="server" 
            Text="Select 1-4 players : "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Width="50px"></asp:TextBox>
        <asp:Button ID="button_SelectPlayers" runat="server" Text="Start" 
            onclick="button_SelectPlayers_Click" />
    </div>    
    
    </div>
    </form>
</body>
</html>
