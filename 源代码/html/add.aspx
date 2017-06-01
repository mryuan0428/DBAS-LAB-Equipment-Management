<%@ Page language="c#" Codebehind="add.aspx.cs" AutoEventWireup="false" Inherits="html.add" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>add</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
		<style type="text/css">
@import url( css/normal.css ); BODY { BACKGROUND-IMAGE: url(img/JDSJ029.jpg) }
		</style>
	</HEAD>
	<body leftmargin="0" topmargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table width="100%" border="0" cellpadding="0" cellspacing="0">
				<tr>
					<td valign="top"><table width="826" height="206" border="0" align="center" cellpadding="0" cellspacing="1"
							bgcolor="#ccccff" style="WIDTH: 826px; HEIGHT: 206px">
							<tr>
								<td height="36" colspan="4" align="center" valign="middle" bgcolor="#ffffff">&nbsp;<FONT size="5" face="隶书" class="font1">故障设备添加</FONT></td>
							</tr>
							<tr>
								<td width="125" bgcolor="#ffffff" class="lishu" style="HEIGHT: 36px">&nbsp;&nbsp;&nbsp;<FONT face="隶书" size="4">设备编号</FONT>：</td>
								<td width="226" bgcolor="#ffffff" style="HEIGHT: 36px">&nbsp;
									<asp:DropDownList ID="DropDownList1" runat="server" Font-Names="隶书"></asp:DropDownList></td>
								<td width="135" bgcolor="#ffffff" class="lishu" style="HEIGHT: 36px">&nbsp;&nbsp;&nbsp;<FONT face="隶书" size="4">故障部件</FONT>：</td>
								<td width="335" bgcolor="#ffffff" style="HEIGHT: 36px">&nbsp;
									<asp:DropDownList id="DropDownList5" runat="server" Font-Names="隶书">
										<asp:ListItem Value="硬件">硬件</asp:ListItem>
										<asp:ListItem Value="软件">软件</asp:ListItem>
									</asp:DropDownList></td>
							</tr>
							<tr>
								<td height="31" bgcolor="#ffffff" class="lishu" style="HEIGHT: 31px">&nbsp;&nbsp;&nbsp;<FONT face="隶书" size="4">设备名称</FONT>：</td>
								<td bgcolor="#ffffff" style="HEIGHT: 31px">&nbsp;
									<asp:DropDownList id="DropDownList2" runat="server" Font-Names="隶书" AutoPostBack="True"></asp:DropDownList></td>
								<td bgcolor="#ffffff" style="HEIGHT: 31px">&nbsp; <span class="lishu"><FONT face="隶书" size="4">
											故障类型</FONT>：</span></td>
								<td bgcolor="#ffffff" style="HEIGHT: 31px">&nbsp;
									<asp:DropDownList id="DropDownList6" runat="server" Font-Names="隶书"></asp:DropDownList></td>
							</tr>
							<tr>
								<td height="35" bgcolor="#ffffff">&nbsp;<span class="lishu"><FONT face="隶书" size="4">&nbsp;实验室名称</FONT>：</span></td>
								<td bgcolor="#ffffff">&nbsp;
									<asp:DropDownList id="DropDownList10" runat="server" Font-Names="隶书" AutoPostBack="True"></asp:DropDownList></td>
								<td bgcolor="#ffffff">&nbsp; <span class="lishu"><FONT face="隶书" size="4">登记日期</FONT>：</span></td>
								<td bgcolor="#ffffff"><table width="100%" border="0" cellspacing="0" cellpadding="0">
										<tr>
											<td><font face="隶书" size="2">
													<asp:DropDownList id="DropDownList3" runat="server" Font-Names="隶书"></asp:DropDownList>
													年</font></td>
											<td><font face="隶书" size="2">
													<asp:DropDownList id="DropDownList8" runat="server" Font-Names="隶书"></asp:DropDownList>月</font></td>
											<td><font face="隶书" size="2">
													<asp:DropDownList id="DropDownList9" runat="server" Font-Names="隶书"></asp:DropDownList>日</font></td>
											<td><asp:DropDownList ID="DropDownList4" runat="server" Font-Names="隶书">
													<asp:ListItem Value="上午">上午</asp:ListItem>
													<asp:ListItem Value="下午">下午</asp:ListItem>
													<asp:ListItem Value="晚上">晚上</asp:ListItem>
												</asp:DropDownList></td>
										</tr>
									</table>
								</td>
							</tr>
							<tr>
								<td height="39" bgcolor="#ffffff">&nbsp;<span class="lishu"><FONT face="隶书" size="4">&nbsp;经手人</FONT>：</span></td>
								<td bgcolor="#ffffff">&nbsp;
									<asp:DropDownList id="DropDownList7" runat="server" Font-Names="隶书" Visible="False"></asp:DropDownList>
									<asp:Label id="Label1" runat="server" Visible="False">Label</asp:Label></td>
								<td colspan="2" bgcolor="#ffffff">&nbsp;
									<asp:Button id="Button1" runat="server" Text="确定"></asp:Button></td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
