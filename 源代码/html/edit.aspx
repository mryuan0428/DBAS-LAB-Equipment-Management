<%@ Page language="c#" Codebehind="edit.aspx.cs" AutoEventWireup="false" Inherits="html.edit" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>edit</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
		<style type="text/css">
@import url( css/normal.css ); BODY { BACKGROUND-IMAGE: url(img/JDSJ029.jpg) }
		</style>
	</HEAD>
	<body leftMargin="0" topMargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE style="WIDTH: 700px; HEIGHT: 288px" height="288" cellSpacing="1" cellPadding="0"
				width="700" align="center" bgColor="#ccccff" border="0">
				<tr>
					<td height="36" colSpan="2" align="center" vAlign="middle" bgcolor="#ffffff">&nbsp;<FONT size="5" face="隶书" class="font1">故障设备编辑</FONT></td>
				</tr>
				<tr>
					<td width="170" bgColor="#ffffff">&nbsp;<FONT face="隶书">设备编号：</FONT></td>
					<td width="530" bgColor="#ffffff" height="30">&nbsp;
						<asp:label id="Label1" runat="server" Font-Names="隶书">Label</asp:label></td>
				</tr>
				<tr>
					<td style="HEIGHT: 30px" bgColor="#ffffff">&nbsp;<FONT face="隶书">实验室名：</FONT></td>
					<td style="HEIGHT: 30px" bgColor="#ffffff" height="30">&nbsp;
						<asp:label id="Label2" runat="server" Font-Names="隶书">Label</asp:label></td>
				</tr>
				<tr>
					<td bgColor="#ffffff" style="HEIGHT: 28px">&nbsp;<FONT face="隶书">设备名称：</FONT></td>
					<td bgColor="#ffffff" style="HEIGHT: 28px">&nbsp;
						<asp:label id="Label4" runat="server" Font-Names="隶书">Label</asp:label></td>
				</tr>
				<tr>
					<td bgColor="#ffffff">
						<P>&nbsp;<FONT face="隶书">登记时间：</FONT></P>
					</td>
					<td bgColor="#ffffff">
						<table cellSpacing="0" cellPadding="0" width="400" border="0">
							<tr>
								<td>
									<asp:dropdownlist id="DropDownList1" runat="server"></asp:dropdownlist>年</td>
								<td><asp:dropdownlist id="DropDownList3" runat="server"></asp:dropdownlist>&nbsp;月</td>
								<td>&nbsp;
									<asp:dropdownlist id="DropDownList6" runat="server"></asp:dropdownlist>日</td>
								<td><asp:dropdownlist id="DropDownList2" runat="server" Font-Names="隶书">
										<asp:ListItem Value="上午">上午</asp:ListItem>
										<asp:ListItem Value="下午">下午</asp:ListItem>
									</asp:dropdownlist></td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td bgColor="#ffffff">&nbsp;<FONT face="隶书">经手人：</FONT></td>
					<td bgColor="#ffffff" height="30">&nbsp;
						<asp:textbox id="TextBox1" runat="server" Font-Names="隶书"></asp:textbox></td>
				</tr>
				<tr>
					<td style="HEIGHT: 30px" bgColor="#ffffff">&nbsp;<FONT face="隶书">故障部件：</FONT></td>
					<td style="HEIGHT: 30px" bgColor="#ffffff" height="30">&nbsp;
						<asp:dropdownlist id="DropDownList4" runat="server" Font-Names="隶书">
							<asp:ListItem Value="硬件">硬件</asp:ListItem>
							<asp:ListItem Value="软件">软件</asp:ListItem>
						</asp:dropdownlist></td>
				</tr>
				<tr>
					<td bgColor="#ffffff" style="HEIGHT: 31px">&nbsp;<FONT face="隶书">故障名称：</FONT></td>
					<td bgColor="#ffffff" style="HEIGHT: 31px">&nbsp;
						<asp:dropdownlist id="DropDownList5" runat="server" Font-Names="隶书"></asp:dropdownlist></td>
				</tr>
				<tr>
					<td bgColor="#ffffff">&nbsp;</td>
					<td bgColor="#ffffff"><asp:button id="Button1" runat="server" Text="确定"></asp:button></td>
				</tr>
			</TABLE>
		</form>
	</body>
</HTML>
