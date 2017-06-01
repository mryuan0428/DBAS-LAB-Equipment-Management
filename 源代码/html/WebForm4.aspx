<%@ Register TagPrefix="activereportsweb" Namespace="DataDynamics.ActiveReports.Web" Assembly="ActiveReports.Web, Version=3.0.0.1893, Culture=neutral, PublicKeyToken=cc4967777c49a3ff" %>
<%@ Page language="c#" Codebehind="WebForm4.aspx.cs" AutoEventWireup="false" Inherits="html.WebForm4" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm4</title>
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
					<TD vAlign="middle" align="center" background="img/dl_bg.gif" height="30"><FONT face="隶书" size="5">基本信息报表</FONT></TD>
				</TR>
				<TR>
					<TD class="font2" style="HEIGHT: 177px" vAlign="top" align="center" height="177">
						<table borderColor="#ccccff" cellSpacing="0" cellPadding="0" width="91%" align="left" border="0">
							<tr>
								<td align="center"><FONT face="宋体">
										<TABLE id="Table2" style="WIDTH: 731px; HEIGHT: 91px" cellSpacing="1" cellPadding="1" width="731"
											border="0">
											<TR>
												<TD><IMG height="18" src="img/dian.jpg" width="18"><SPAN class="font">请选择实验室名称,可以显示该实验室的基本信息的报表,并且可以另存为Excel：</SPAN>
													</SPAN></TD>
											</TR>
											<TR>
												<TD align="left">&nbsp;
													<TABLE id="Table1" style="WIDTH: 500px; HEIGHT: 24px" cellSpacing="1" cellPadding="1" width="448"
														border="0">
														<TR>
															<TD class="font2" width="100"></TD>
															<TD class="font2">实验室名称：</TD>
															<TD><asp:dropdownlist id="DropDownList1" runat="server"></asp:dropdownlist></TD>
															<TD><asp:button id="Button1" runat="server" Text="确定"></asp:button></TD>
															<TD>
																<asp:Button id="Button2" runat="server" Text="所有信息"></asp:Button></TD>
															<TD><asp:linkbutton id="LinkButton1" runat="server" Font-Names="隶书" Width="96px">另存为</asp:linkbutton></TD>
														</TR>
													</TABLE>
												</TD>
											</TR>
										</TABLE>
									</FONT>
								</td>
							</tr>
							<tr>
								<td align="center">
									<table cellSpacing="0" cellPadding="0" width="640" border="0">
										<tr>
											<td style="WIDTH: 253px" align="center" width="100%"><span></span><ACTIVEREPORTSWEB:WEBVIEWER id="WebViewer1" runat="server" BorderStyle="Solid" BackColor="Silver" BorderColor="Silver"
													ForeColor="Black" height="550px" width="719px"></ACTIVEREPORTSWEB:WEBVIEWER></td>
										</tr>
									</table>
									<INPUT id="Hidden1" type="hidden" name="Hidden1" runat="server">
								</td>
							</tr>
						</table>
					</TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
