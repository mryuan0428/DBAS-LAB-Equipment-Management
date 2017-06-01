<%@ Page language="c#" Codebehind="add5.aspx.cs" AutoEventWireup="false" Inherits="html.add5" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>add5</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
		<style type="text/css">
		@import url("css/normal.css");

BODY {
	MARGIN-TOP: 0px;
	MARGIN-LEFT: 0px;
	background-image: url(img/JDSJ029.jpg);
}
		</style>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table width="700" border="0" align="center" cellpadding="0" cellspacing="1" bordercolor="#CCCCFF" bgcolor="#CCCCFF">
				<tr>
					<td height="42" colspan="2" align="center" valign="middle" bgcolor="#FFFFFF" style="HEIGHT: 33px">&nbsp;<FONT size="5" face="隶书" class="font1">故障名称添加</FONT></td>
				</tr>
				<tr>
				  <td width="155" height="57" bgcolor="#FFFFFF">&nbsp;<FONT size="4" face="隶书" class="fontlishu"> 故障名称：</FONT></td>
					<td width="539" bgcolor="#FFFFFF">&nbsp;
						<asp:TextBox id="TextBox1" runat="server" Font-Names="隶书"></asp:TextBox><FONT face="宋体">&nbsp;&nbsp;&nbsp;
				  <asp:Button id="Button1" runat="server" Text="确定"></asp:Button></FONT></td>
				</tr>
		  </table>
		</form>
	</body>
</HTML>
