<%@ Page language="c#" Codebehind="add3.aspx.cs" AutoEventWireup="false" Inherits="html.add3" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>add3</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
		<style type="text/css">
		@import url( css/normal.css ); BODY { MARGIN-TOP: 0px; BACKGROUND-IMAGE: url(img/JDSJ029.jpg); MARGIN-LEFT: 0px }
		</style>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table width="700" height="240" border="0" align="center" cellpadding="0" cellspacing="1"
				bordercolor="#ccccff" bgcolor="#ccccff" style="WIDTH: 700px; HEIGHT: 240px">
				<tr>
					<td colspan="2" align="center" valign="middle" bgcolor="#ffffff" class="font1" style="HEIGHT: 32px">&nbsp;<FONT face="隶书" size="5">基本设备信息添加</FONT></td>
				</tr>
				<tr>
					<td height="34" bgcolor="#ffffff" style="WIDTH: 139px; HEIGHT: 34px">&nbsp;<span class="fontlishu">
							<FONT face="隶书" size="4">设备编号</FONT>：</span></td>
					<td width="559" bgcolor="#ffffff" style="HEIGHT: 34px">&nbsp;
						<asp:TextBox id="TextBox1" runat="server" Font-Names="宋体-方正超大字符集"></asp:TextBox></td>
				</tr>
				<tr>
					<td bgcolor="#ffffff" style="WIDTH: 139px; HEIGHT: 32px">&nbsp; <span class="fontlishu">
							<FONT face="隶书" size="4">设备名称</FONT>：</span></td>
					<td bgcolor="#ffffff" style="HEIGHT: 32px">&nbsp;
						<asp:DropDownList id="DropDownList1" runat="server" Font-Names="宋体"></asp:DropDownList></td>
				</tr>
				<tr>
					<td height="34" bgcolor="#ffffff" style="WIDTH: 139px; HEIGHT: 34px">&nbsp; <FONT face="隶书" size="4">
							实验室名</FONT>：</td>
					<td bgcolor="#ffffff" style="HEIGHT: 34px">&nbsp;
						<asp:DropDownList id="DropDownList2" runat="server" Font-Names="宋体"></asp:DropDownList></td>
				</tr>
				<tr>
					<td bgcolor="#ffffff" style="WIDTH: 139px">&nbsp; <FONT face="隶书" size="4">厂家</FONT><span class="fontlishu">：</span></td>
					<td bgcolor="#ffffff">&nbsp;
						<asp:DropDownList id="DropDownList3" runat="server" Font-Names="宋体"></asp:DropDownList></td>
				</tr>
				<tr>
					<td height="31" bgcolor="#ffffff" style="WIDTH: 139px; HEIGHT: 31px">&nbsp; <FONT face="隶书" size="4">
							出厂日期</FONT><span class="fontlishu">：</span></td>
					<td bgcolor="#ffffff" style="HEIGHT: 31px">&nbsp;
						<asp:TextBox id="TextBox2" runat="server" Font-Names="宋体"></asp:TextBox></td>
				</tr>
				<tr>
					<td bgcolor="#ffffff" style="WIDTH: 139px">&nbsp;
						<asp:Button id="Button1" runat="server" Text="确定"></asp:Button></td>
					<td bgcolor="#ffffff">&nbsp;</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
