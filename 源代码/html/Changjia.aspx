<%@ Page language="c#" Codebehind="Changjia.aspx.cs" AutoEventWireup="false" Inherits="html.Changjia" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Changjia</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
	</HEAD>
	<body leftMargin="0" background="img/JDSJ029.jpg" topMargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table height="195" cellSpacing="0" cellPadding="0" width="851" border="0">
				<tr>
					<td vAlign="middle" align="center" width="851" background="img/dl_bg.gif" height="30"><FONT face="隶书" size="5">厂家基本信息</FONT></td>
				</tr>
				<tr>
					<td vAlign="top" align="center">
						<table cellSpacing="0" cellPadding="0" width="100%" border="0">
							<tr>
								<td align="center"><asp:datagrid id="DataGrid1" runat="server" BorderColor="#CCCCFF" BorderStyle="None" BorderWidth="1px"
										BackColor="White" CellPadding="3" AutoGenerateColumns="False" PageSize="5" AllowPaging="True" Font-Size="Smaller"
										Font-Names="隶书" Width="496px">
										<SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
										<AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
										<ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
										<HeaderStyle Font-Bold="True" ForeColor="#000066" BackColor="#88A2FF"></HeaderStyle>
										<FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
										<PagerStyle Visible="False" HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF"
											Mode="NumericPages"></PagerStyle>
									</asp:datagrid></td>
							</tr>
							<tr>
								<td align="center">
									<table height="23" cellSpacing="0" cellPadding="0" width="69%" border="0">
										<tr>
											<td style="WIDTH: 349px" width="353"><span>&nbsp;&nbsp;&nbsp;&nbsp;
													<asp:button id="Button1" runat="server" Text="添加"></asp:button></span></td>
											<td style="WIDTH: 214px" width="227"><asp:button id="Button2" runat="server" Text="首页" Height="20px"></asp:button><asp:button id="Button3" runat="server" Text="上一页" Height="20px"></asp:button><asp:button id="Button4" runat="server" Text="下一页" Height="20px"></asp:button><asp:button id="Button5" runat="server" Text="末页" Height="20px"></asp:button></td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td align="center" height="23">&nbsp;</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
