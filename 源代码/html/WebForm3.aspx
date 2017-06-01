<%@ Page language="c#" Codebehind="WebForm3.aspx.cs" AutoEventWireup="false" Inherits="html.WebForm3" %>
<%@ Register TagPrefix="iewc" Namespace="Microsoft.Web.UI.WebControls" Assembly="Microsoft.Web.UI.WebControls, Version=1.0.2.226, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm3</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<FONT face="宋体">
				<iewc:TreeView id="TreeView1" style="Z-INDEX: 101; LEFT: 24px; POSITION: absolute; TOP: 32px" runat="server">
					<iewc:TreeNode Text="故障设备管理">
						<iewc:TreeNode NavigateUrl="sbgl.aspx" Text="故障设备管理" Target="main">
							<iewc:TreeNode NavigateUrl="add.aspx" Text="故障设备添加" Target="main"></iewc:TreeNode>
						</iewc:TreeNode>
					</iewc:TreeNode>
				</iewc:TreeView></FONT>
		</form>
	</body>
</HTML>
