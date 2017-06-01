<%@ Page language="c#" Codebehind="Basicinfo.aspx.cs" AutoEventWireup="false" Inherits="html.Basicinfo" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Basicinfo</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
		<style type="text/css">
@import url( css/normal.css ); BODY { BACKGROUND-IMAGE: url(img/JDSJ029.jpg) }
		</style>
	</HEAD>
	<body leftmargin="0" topmargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table width="851" height="291" border="0" cellpadding="0" cellspacing="0">
				<tr>
					<td height="30" align="center" valign="middle" background="img/dl_bg.gif">&nbsp;<FONT face="隶书" size="5">基本设备信息管理表</FONT></td>
				</tr>
				<tr>
					<td height="72" align="center" valign="top"><table width="91%" height="72" border="0" cellpadding="0" cellspacing="0">
							<tr>
								<td height="24" colspan="6" align="left" class="font"><img src="img/dian.jpg" width="18" height="18">想查询某个具体设备？请输入查询条件&nbsp;：&nbsp;</td>
							</tr>
							<tr>
								<td width="136" height="25" align="center" class="font">&nbsp;</td>
								<td width="103" class="font2" style="WIDTH: 103px"><span class="font2" style="WIDTH: 103px"><span class="font2" style="WIDTH: 103px">实验室名称：</span></span></td>
								<td width="171" style="WIDTH: 171px">&nbsp;
									<asp:DropDownList id="DropDownList3" runat="server" AutoPostBack="True"></asp:DropDownList></td>
								<td width="83" class="font2" style="WIDTH: 83px"><span class="font2" style="WIDTH: 83px"><span class="font2" style="WIDTH: 83px">设备编号:</span></span></td>
								<td width="120">&nbsp;
									<asp:DropDownList id="DropDownList4" runat="server"></asp:DropDownList></td>
								<td width="162">
									<asp:ImageButton id="ImageButton1" runat="server" ImageUrl="img/search_m.gif"></asp:ImageButton></td>
							</tr>
							<tr>
								<td height="11" colspan="6" align="center" class="font">&nbsp;</td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td height="17" align="center" valign="top">&nbsp;</td>
				</tr>
				<tr>
					<td height="105" align="center" valign="top"><table width="91%" border="0" cellspacing="0" cellpadding="0">
							<tr>
								<td align="center">
									<asp:DataGrid ID="DataGrid1" runat="server" BorderColor="#CCCCFF" BorderStyle="None" BorderWidth="1px"
										BackColor="White" CellPadding="3" AutoGenerateColumns="False" Font-Size="Smaller" Font-Names="隶书"
										AllowPaging="True" Width="664px" PageSize="5">
										<selecteditemstyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></selecteditemstyle>
										<alternatingitemstyle BackColor="#F7F7F7"></alternatingitemstyle>
										<itemstyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></itemstyle>
										<headerstyle Font-Bold="True" ForeColor="#000066" BackColor="#88A2FF"></headerstyle>
										<footerstyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></footerstyle>
										<pagerstyle Visible="False" HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF"
											Mode="NumericPages"></pagerstyle>
									</asp:DataGrid></td>
							</tr>
							<tr>
								<td align="center"><table height="28" border="0" cellpadding="0" cellspacing="0">
										<tr>
											<td style="WIDTH: 450px"><asp:Button ID="Button1" runat="server" Text="添加新的基本设备" Height="20px"></asp:Button></td>
											<td>&nbsp;
												<asp:Button id="Button2" runat="server" Height="20px" Text="首页" ForeColor="Black"></asp:Button>
												<asp:Button id="Button3" runat="server" Height="20px" Text="上一页"></asp:Button>
												<asp:Button id="Button4" runat="server" Height="20px" Text="下一页"></asp:Button>
												<asp:Button id="Button5" runat="server" Height="20px" Text="末页"></asp:Button></td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
			<INPUT id="Hidden1" style="Z-INDEX: 101; LEFT: 256px; POSITION: absolute; TOP: 392px" type="hidden"
				name="Hidden1" runat="server">
		</form>
	</body>
</HTML>
