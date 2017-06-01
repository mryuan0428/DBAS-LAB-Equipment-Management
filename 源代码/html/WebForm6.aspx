<%@ Page language="c#" Codebehind="WebForm6.aspx.cs" AutoEventWireup="false" Inherits="html.WebForm6" %>
<%@ Register TagPrefix="activereportsweb" Namespace="DataDynamics.ActiveReports.Web" Assembly="ActiveReports.Web, Version=3.0.0.1893, Culture=neutral, PublicKeyToken=cc4967777c49a3ff" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm6</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<style type="text/css">@import url( normal.css ); BODY { BACKGROUND-IMAGE: url(img/JDSJ029.jpg); MARGIN: 0px }
		</style>
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE height="250" cellSpacing="0" cellPadding="0" width="849" border="0">
				<TR>
					<TD vAlign="middle" align="center" background="img/dl_bg.gif" height="30"><FONT size="5" face="隶书">基本信息汇总报表</FONT></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 177px" vAlign="top" align="left" height="177">
						<table cellSpacing="0" cellPadding="0" width="88%" border="0">
							<tr>
								<td align="center"><TABLE id="Table2" style="WIDTH: 694px; HEIGHT: 89px" cellSpacing="1" cellPadding="1" width="694"
										border="0">
										<TR>
											<TD><IMG height="18" src="img/dian.jpg" width="18"><SPAN class="font">显示每个实验室的每种设备各有多少台，可以另存为Excel文件：</SPAN>
												</SPAN></TD>
										</TR>
										<TR>
											<TD align="left">&nbsp;
												<TABLE id="Table1" style="WIDTH: 376px; HEIGHT: 24px" cellSpacing="1" cellPadding="1" width="376"
													border="0">
													<TR>
														<TD class="font2" width="100"></TD>
														<TD><asp:linkbutton id="LinkButton1" runat="server" Font-Names="隶书">另存为</asp:linkbutton></TD>
													</TR>
												</TABLE>
											</TD>
										</TR>
									</TABLE>
								</td>
							</tr>
							<tr>
								<td align="center">
									<table cellSpacing="0" cellPadding="0" width="550" border="0">
										<tr>
											<td style="WIDTH: 253px" width="297">
												<ACTIVEREPORTSWEB:WEBVIEWER id="WebViewer1" runat="server" height="990px" width="692px" ForeColor="Black" BorderStyle="Solid"
													BackColor="Transparent" BorderColor="LightGray"></ACTIVEREPORTSWEB:WEBVIEWER></td>
											<td style="WIDTH: 227px" width="253"></td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
