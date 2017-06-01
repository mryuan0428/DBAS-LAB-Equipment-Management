<%@ Page language="c#" Codebehind="piliang.aspx.cs" AutoEventWireup="false" Inherits="html.piliang" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>piliang</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link href="css/normal.css" rel="stylesheet" type="text/css">
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
		<style type="text/css">
BODY { BACKGROUND-IMAGE: url(img/JDSJ029.jpg); MARGIN: 0px }
		</style>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<table width="851" border="0" cellspacing="0" cellpadding="0">
			<tr>
				<td width="851">
					<form id="Form1" method="post" runat="server">
						<table width="714" height="240" border="0" align="center" cellpadding="0" cellspacing="1"
							bordercolor="#ccccff" bgcolor="#ccccff" style="WIDTH: 714px; HEIGHT: 240px">
							<tr>
								<td height="37" colspan="4" align="center" bgcolor="#ffffff" class="font1"><FONT face="隶书" size="5">批量设备信息添加</FONT></td>
							</tr>
							<tr>
								<td width="144" bgcolor="#ffffff" style="HEIGHT: 31px"><FONT face="隶书" size="4"><span class="fontlishu">起始设备编号</span></FONT><span class="fontlishu">：</span></td>
								<td width="200" bgcolor="#ffffff" style="HEIGHT: 31px">&nbsp;
									<asp:TextBox id="TextBox1" runat="server"></asp:TextBox></td>
								<td width="171" bgcolor="#ffffff" class="fontlishu" style="HEIGHT: 31px"><FONT face="隶书" size="4">设备个数</FONT>：</td>
								<td width="189" bgcolor="#ffffff" style="HEIGHT: 31px">&nbsp;
									<asp:TextBox id="TextBox2" runat="server"></asp:TextBox></td>
							</tr>
							<tr>
								<td bgcolor="#ffffff" class="fontlishu" style="HEIGHT: 30px"><FONT face="隶书" size="4">设备名称</FONT>：</td>
								<td colspan="3" bgcolor="#ffffff" style="HEIGHT: 30px">&nbsp;
									<asp:DropDownList id="DropDownList1" runat="server"></asp:DropDownList></td>
							</tr>
							<tr>
								<td bgcolor="#ffffff" class="fontlishu" style="HEIGHT: 33px"><FONT face="隶书" size="4">实验室名</FONT>：</td>
								<td colspan="3" bgcolor="#ffffff" style="HEIGHT: 33px">&nbsp;
									<asp:DropDownList id="DropDownList2" runat="server"></asp:DropDownList></td>
							</tr>
							<tr>
								<td bgcolor="#ffffff" class="fontlishu" style="HEIGHT: 33px"><FONT face="隶书" size="4">厂家</FONT><SPAN class="fontlishu">：</SPAN>
								</td>
								<td colspan="3" bgcolor="#ffffff" style="HEIGHT: 33px">&nbsp;
									<asp:DropDownList id="DropDownList3" runat="server"></asp:DropDownList></td>
							</tr>
							<tr>
								<td bgcolor="#ffffff" style="HEIGHT: 33px"><span class="fontlishu"><FONT face="隶书" size="4">出厂日期</FONT><SPAN class="fontlishu">：</SPAN></span>
								</td>
								<td colspan="3" bgcolor="#ffffff" style="HEIGHT: 33px">&nbsp;
									<asp:TextBox id="TextBox3" runat="server"></asp:TextBox></td>
							</tr>
							<tr>
								<td bgcolor="#ffffff">&nbsp;</td>
								<td colspan="3" bgcolor="#ffffff">&nbsp;
									<asp:Button id="Button1" runat="server" Text="确定"></asp:Button></td>
							</tr>
						</table>
					</form>
				</td>
			</tr>
		</table>
	</body>
</HTML>
