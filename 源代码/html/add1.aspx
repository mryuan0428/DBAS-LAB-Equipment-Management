<%@ Page language="c#" Codebehind="add1.aspx.cs" AutoEventWireup="false" Inherits="html.add1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>add1</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
	</HEAD>
	<body leftmargin="0" topmargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table width="692" height="176" border="0" cellpadding="0" cellspacing="0" background="img/bgyg.gif">
				<tr>
					<td height="30" colspan="4" align="center" valign="middle" background="img/dl_bg.gif">&nbsp;<FONT face="隶书" size="5">故障设备添加表</FONT></td>
				</tr>
				<tr>
					<td width="120" style="HEIGHT: 47px">&nbsp;</td>
					<td width="215" height="100" style="HEIGHT: 47px">&nbsp;
						<asp:DropDownList ID=DropDownList1 runat="server" DataSource='<%# DataBinder.Eval(dataSet11, "Tables[basicinfo].DefaultView.[0].设备编号") %>' AutoPostBack="True">
						</asp:DropDownList></td>
					<td width="127" style="HEIGHT: 47px">&nbsp;</td>
					<td width="230" style="HEIGHT: 47px">&nbsp;
						<asp:DropDownList id="DropDownList5" runat="server">
							<asp:ListItem Value="硬件">硬件</asp:ListItem>
							<asp:ListItem Value="软件">软件</asp:ListItem>
						</asp:DropDownList></td>
				</tr>
				<tr>
					<td height="41" style="HEIGHT: 25px">&nbsp;</td>
					<td style="HEIGHT: 25px">&nbsp;
						<asp:DropDownList id="DropDownList2" runat="server"></asp:DropDownList></td>
					<td style="HEIGHT: 25px">&nbsp;</td>
					<td style="HEIGHT: 25px">&nbsp;
						<asp:DropDownList id="DropDownList6" runat="server"></asp:DropDownList></td>
				</tr>
				<tr>
					<td height="35">&nbsp;</td>
					<td>&nbsp;
						<asp:Label id="Label2" runat="server" Width="96px">Label</asp:Label></td>
					<td>&nbsp;</td>
					<td>&nbsp;
						<asp:Label id="Label1" runat="server">=Date(Now)</asp:Label>
						<asp:DropDownList id="DropDownList4" runat="server">
							<asp:ListItem Value="上午">上午</asp:ListItem>
							<asp:ListItem Value="下午">下午</asp:ListItem>
						</asp:DropDownList></td>
				</tr>
				<tr>
					<td height="39">&nbsp;</td>
					<td>&nbsp;
						<asp:DropDownList id="DropDownList7" runat="server"></asp:DropDownList></td>
					<td colspan="2">&nbsp;
						<asp:Button id="Button1" runat="server" Text="确定"></asp:Button></td>
				</tr>
		  </table>
		</form>
	</body>
</HTML>
