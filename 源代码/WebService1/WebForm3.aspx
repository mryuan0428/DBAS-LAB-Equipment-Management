<%@ Page language="c#" Codebehind="WebForm3.aspx.cs" AutoEventWireup="false" Inherits="WebService1.WebForm3" %>
<%@ Register TagPrefix="c1webchart" Namespace="C1.Web.C1WebChart" Assembly="C1.Web.C1WebChart" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm3</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:DropDownList id="DropDownList1" style="Z-INDEX: 101; LEFT: 40px; POSITION: absolute; TOP: 32px"
				runat="server"></asp:DropDownList>
			<asp:DropDownList id="DropDownList2" style="Z-INDEX: 102; LEFT: 144px; POSITION: absolute; TOP: 32px"
				runat="server"></asp:DropDownList>
			<asp:Button id="Button1" style="Z-INDEX: 103; LEFT: 232px; POSITION: absolute; TOP: 32px" runat="server"
				Text="Button"></asp:Button>
			<C1WebChart:C1WebChart id="C1WebChart1" style="Z-INDEX: 104; LEFT: 32px; POSITION: absolute; TOP: 72px"
				runat="server" Width="496px" Height="224px"></C1WebChart:C1WebChart><INPUT id="Hidden1" style="Z-INDEX: 105; LEFT: 128px; POSITION: absolute; TOP: 304px" type="hidden"
				name="Hidden1" runat="server">
			<asp:Button id="Button2" style="Z-INDEX: 106; LEFT: 312px; POSITION: absolute; TOP: 32px" runat="server"
				Text="Button"></asp:Button>
		</form>
	</body>
</HTML>
