<%@ Page language="c#" Codebehind="edit3.aspx.cs" AutoEventWireup="false" Inherits="html.edit3" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>edit3</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
	<style type="text/css">
<!--
@import url("css/normal.css");
.STYLE2 {color: #000000; font-weight: normal;}
body {
	background-image: url(img/JDSJ029.jpg);
}
-->
    </style>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table width="700" height="157" border="0" align="center" cellpadding="0" cellspacing="1" bordercolor="#CCCCFF" bgcolor="#ccccff">
				<tr>
					<td height="30" colspan="2" align="center" valign="middle" bgcolor="#FFFFFF">&nbsp;<FONT size="5" face="隶书" class="font1">用户基本信息修改</FONT></td>
				</tr>
				<tr>
				  <td bgcolor="#FFFFFF" style="WIDTH: 106px">&nbsp;&nbsp;<span class="STYLE2"><FONT face="隶书" size="4">原始密码</FONT></span><span class="fontlishu">：</span></td>
					<td bgcolor="#FFFFFF">&nbsp;
						<asp:TextBox id="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
						<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="密码不能为空"
							Font-Names="隶书"></asp:RequiredFieldValidator>
				  <asp:RegularExpressionValidator id="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="密码必须是6位以上的数字"
							ValidationExpression="[0-9]{6,}" Font-Names="隶书"></asp:RegularExpressionValidator></td>
				</tr>
				<tr>
					<td bgcolor="#FFFFFF" style="WIDTH: 106px">&nbsp;<span class="STYLE2"><FONT face="隶书" size="4"> 新密码</FONT></span><span class="fontlishu">：</span></td>
					<td bgcolor="#FFFFFF">&nbsp;
						<asp:TextBox id="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
						<asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="密码不能为空"
							Font-Names="隶书"></asp:RequiredFieldValidator>
				  <asp:RegularExpressionValidator id="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="密码必须是6位以上的数字"
							ValidationExpression="[0-9]{6,}" Font-Names="隶书"></asp:RegularExpressionValidator></td>
				</tr>
				<tr>
					<td bgcolor="#FFFFFF" style="WIDTH: 106px">&nbsp;<span class="STYLE2"><FONT face="隶书" size="4">确认新密码</FONT></span><span class="fontlishu">：</span></td>
					<td bgcolor="#FFFFFF">&nbsp;
						<asp:TextBox id="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
						<asp:RequiredFieldValidator id="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="密码不能为空"
							Font-Names="隶书"></asp:RequiredFieldValidator>
				  <asp:CompareValidator id="CompareValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="新密码必须一致"
							ControlToCompare="TextBox2" Font-Names="隶书"></asp:CompareValidator></td>
				</tr>
				<tr>
					<td height="31" bgcolor="#FFFFFF" style="WIDTH: 106px">&nbsp;</td>
					<td bgcolor="#FFFFFF">&nbsp;
				  <asp:Button id="Button1" runat="server" Text="确定"></asp:Button></td>
				</tr>
		  </table>
		</form>
</body>
</HTML>
