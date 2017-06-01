<%@ Page language="c#" Codebehind="denglu.aspx.cs" AutoEventWireup="false" Inherits="html.denglu" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>首都师范大学信息工程学院实验室设备管理系统登录界面</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
		<style type="text/css">
BODY { MARGIN-TOP: 0px; BACKGROUND-IMAGE: url(img/blank.gif) }
		</style>
		<link href="css/normal.css" rel="stylesheet" type="text/css">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table width="778" border="0" align="center" cellpadding="0" cellspacing="0">
				<tr>
					<td height="60" valign="top"><img src="file:///C:\Inetpub\wwwroot\data\html\img\top.gif" width="778" height="100"></td>
				</tr>
				<tr>
					<td width="778" height="403" align="center" background="img/bgyg1.gif" bgcolor="#f7f7f7"><table width="550" height="245" border="0" cellpadding="0" cellspacing="0">
							<tr>
								<td width="413" height="43" align="center" valign="middle" class="font1" style="HEIGHT: 43px"><img src="file:///C:\Inetpub\wwwroot\data\html\img\登陆.gif" width="554" height="50" style="WIDTH: 554px; HEIGHT: 50px"></td>
							</tr>
							<tr>
								<td height="163" align="center" valign="middle"><table width="400" height="115" border="1" cellpadding="0" cellspacing="0" class="form1"
										id="TABLE1" style="WIDTH: 262px;      HEIGHT: 75px">
										<tr>
											<td width="167" height="25" align="center" class="font" style="WIDTH:167px">
												用户名：
											</td>
											<td width="231"><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
										</tr>
										<tr>
											<td width="167" height="25" align="center" class="font" style="WIDTH:167px">密 码：</td>
											<td><asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox></td>
										</tr>
										<tr>
											<td height="25" align="center" class="font" style="WIDTH: 167px">
												用户身份：</td>
											<td height="29" align="left" style="WIDTH: 167px"><label>
													<asp:DropDownList id="DropDownList1" runat="server">
														<asp:ListItem Value="管理员">管理员</asp:ListItem>
														<asp:ListItem Value="用户">用户</asp:ListItem>
													</asp:DropDownList>
												</label>
											</td>
										</tr>
										<tr>
											<td height="25" align="center" style="WIDTH: 167px"><span class="font1" style="WIDTH: 167px">
													<asp:Button ID="Button1" runat="server" Text="登录"></asp:Button>
												</span>
											</td>
											<td height="29" align="center" style="WIDTH: 167px"><span class="font1" style="WIDTH: 167px"><span class="font1" style="WIDTH: 167px">
														<asp:Button ID="Button2" runat="server" Text="注册"></asp:Button>
													</span></span>
											</td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td width="778" height="74" align="center" valign="middle" background="img/bg-d.jpg">
						<table width="500" height="67" border="0" cellpadding="0" cellspacing="0">
							<tr>
								<td align="center" valign="middle" class="font" style="HEIGHT: 15px"></td>
							</tr>
							<tr>
								<td align="center" valign="middle"><FONT color="#000033"></FONT>
								</td>
							</tr>
							<tr>
								<td align="center" valign="middle" class="font"></td>
							</tr>
							<tr>
								<td align="center" valign="middle" class="font"></td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
