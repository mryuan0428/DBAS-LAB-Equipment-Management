<%@ Register TagPrefix="c1webchart" Namespace="C1.Web.C1WebChart" Assembly="C1.Web.C1WebChart" %>
<%@ Page language="c#" Codebehind="jueceshijian.aspx.cs" AutoEventWireup="false" Inherits="WebService1.jueceshijian" %>
<%@ Register TagPrefix="c1webchart" Namespace="C1.Web.C1WebChart" Assembly="C1.Web.C1WebChart" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title></title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="normal.css" type="text/css" rel="stylesheet">
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
		<style type="text/css">
BODY { BACKGROUND-IMAGE: url(img/blank.gif); MARGIN: 0px }
		</style>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<table cellSpacing="0" cellPadding="0" width="850" border="0">
			<tr>
				<td height="484" align="center" valign="top">
					<form id="Form1" method="post" runat="server">
						<table width="721" height="628" border="1" cellPadding="0" cellSpacing="0" borderColor="#ccccff"
							background="img/bgyg1.gif">
							<tr>
								<td height="21" colSpan="2" class="font2">请选择所要统计的设备类别以及起始时间，然后单击确定，则会显示品牌故障率和具体品牌中的出故障率：</td>
							</tr>
							<tr>
								<td width="190" height="36" align="center"><span class="font3">设备类别:</span></td>
								<td width="525">
									<table cellSpacing="0" cellPadding="0" width="100%" border="0">
										<tr>
											<td width="325" style="WIDTH: 179px">&nbsp;
												<asp:dropdownlist id="DropDownList2" runat="server"></asp:dropdownlist>
											</td>
											<td width="299">&nbsp;
												<asp:Button ID="Button1" runat="server" Text="确定"></asp:Button></td>
										</tr>
									</table>
							  </td>
							</tr>
							<tr>
								<td height="35" align="center"><span class="font3">起始时间:</span></td>
								<td><span class="font3"><SPAN class="font3"><asp:dropdownlist id="DropDownList1" runat="server"></asp:dropdownlist></SPAN>年
										<asp:dropdownlist id="DropDownList3" runat="server"></asp:dropdownlist>月
										<asp:dropdownlist id="DropDownList4" runat="server"></asp:dropdownlist>日</span></td>
							</tr>
							<tr>
								<td height="34" align="center"><span class="font3">结束时间:</span></td>
								<td><span class="font3"><SPAN class="font3"><asp:dropdownlist id="DropDownList5" runat="server"></asp:dropdownlist></SPAN>年</span>
									<asp:dropdownlist id="DropDownList6" runat="server"></asp:dropdownlist><span class="font3">月</span>
									<asp:dropdownlist id="DropDownList7" runat="server"></asp:dropdownlist><span class="font3">日</span></td>
							</tr>
							<tr>
								<td height="250" align="center"><span class="font3">品牌故障率:</span>　</td>
								<td>&nbsp;
									<c1webchart:C1WebChart id="C1WebChart1" runat="server" Width="472px" Height="225px" Visible="False" SlidingExpiration="00:10:00"
										ImageFormat="Png">
										<Serializer Value="&lt;?xml version=&quot;1.0&quot;?&gt;
&lt;Chart2DPropBag Version=&quot;&quot;&gt;
  &lt;StyleCollection&gt;
    &lt;NamedStyle Name=&quot;PlotArea&quot; ParentName=&quot;Area&quot;&gt;
      &lt;StyleData&gt;Border=None,Black,1;&lt;/StyleData&gt;
    &lt;/NamedStyle&gt;
    &lt;NamedStyle Name=&quot;Legend&quot; ParentName=&quot;Legend.default&quot;&gt;
      &lt;StyleData /&gt;
    &lt;/NamedStyle&gt;
    &lt;NamedStyle Name=&quot;Footer&quot; ParentName=&quot;Control&quot;&gt;
      &lt;StyleData&gt;Border=None,Black,1;&lt;/StyleData&gt;
    &lt;/NamedStyle&gt;
    &lt;NamedStyle Name=&quot;Area&quot; ParentName=&quot;Area.default&quot;&gt;
      &lt;StyleData /&gt;
    &lt;/NamedStyle&gt;
    &lt;NamedStyle Name=&quot;Control&quot; ParentName=&quot;Control.default&quot;&gt;
      &lt;StyleData /&gt;
    &lt;/NamedStyle&gt;
    &lt;NamedStyle Name=&quot;AxisX&quot; ParentName=&quot;Area&quot;&gt;
      &lt;StyleData&gt;Rotation=Rotate0;Border=None,Transparent,1;AlignHorz=Center;BackColor=Transparent;Opaque=False;AlignVert=Bottom;&lt;/StyleData&gt;
    &lt;/NamedStyle&gt;
    &lt;NamedStyle Name=&quot;AxisY&quot; ParentName=&quot;Area&quot;&gt;
      &lt;StyleData&gt;Rotation=Rotate270;Border=None,Transparent,1;AlignHorz=Near;BackColor=Transparent;Opaque=False;AlignVert=Center;&lt;/StyleData&gt;
    &lt;/NamedStyle&gt;
    &lt;NamedStyle Name=&quot;LabelStyleDefault&quot; ParentName=&quot;LabelStyleDefault.default&quot;&gt;
      &lt;StyleData /&gt;
    &lt;/NamedStyle&gt;
    &lt;NamedStyle Name=&quot;Legend.default&quot; ParentName=&quot;Control&quot;&gt;
      &lt;StyleData&gt;Border=None,Black,1;Wrap=False;AlignVert=Top;&lt;/StyleData&gt;
    &lt;/NamedStyle&gt;
    &lt;NamedStyle Name=&quot;LabelStyleDefault.default&quot; ParentName=&quot;Control&quot;&gt;
      &lt;StyleData&gt;Border=None,Black,1;BackColor=Transparent;&lt;/StyleData&gt;
    &lt;/NamedStyle&gt;
    &lt;NamedStyle Name=&quot;Header&quot; ParentName=&quot;Control&quot;&gt;
      &lt;StyleData&gt;Border=None,Black,1;&lt;/StyleData&gt;
    &lt;/NamedStyle&gt;
    &lt;NamedStyle Name=&quot;Control.default&quot; ParentName=&quot;&quot;&gt;
      &lt;StyleData&gt;ForeColor=ControlText;Border=None,Black,1;BackColor=Control;&lt;/StyleData&gt;
    &lt;/NamedStyle&gt;
    &lt;NamedStyle Name=&quot;AxisY2&quot; ParentName=&quot;Area&quot;&gt;
      &lt;StyleData&gt;Rotation=Rotate90;Border=None,Transparent,1;AlignHorz=Far;BackColor=Transparent;AlignVert=Center;&lt;/StyleData&gt;
    &lt;/NamedStyle&gt;
    &lt;NamedStyle Name=&quot;Area.default&quot; ParentName=&quot;Control&quot;&gt;
      &lt;StyleData&gt;Border=None,Black,1;AlignVert=Top;&lt;/StyleData&gt;
    &lt;/NamedStyle&gt;
  &lt;/StyleCollection&gt;
  &lt;ChartGroupsCollection&gt;
    &lt;ChartGroup&gt;
      &lt;DataSerializer Hole=&quot;3.4028234663852886E+38&quot; DefaultSet=&quot;True&quot;&gt;
        &lt;DataSeriesCollection&gt;
          &lt;DataSeriesSerializer Offset=&quot;20&quot;&gt;
            &lt;LineStyle Color=&quot;DarkGoldenrod&quot; /&gt;
            &lt;SymbolStyle Color=&quot;Coral&quot; Shape=&quot;Box&quot; /&gt;
            &lt;SeriesLabel&gt;series 0&lt;/SeriesLabel&gt;
            &lt;X&gt;1;2;3;4;5&lt;/X&gt;
            &lt;Y&gt;20;22;19;24;25&lt;/Y&gt;
            &lt;Y1 /&gt;
            &lt;Y2 /&gt;
            &lt;Y3 /&gt;
            &lt;DataTypes&gt;Single;Single;Double;Double;Double&lt;/DataTypes&gt;
            &lt;DataFields&gt;;;;;&lt;/DataFields&gt;
            &lt;Tag /&gt;
          &lt;/DataSeriesSerializer&gt;
          &lt;DataSeriesSerializer Offset=&quot;20&quot;&gt;
            &lt;LineStyle Color=&quot;DarkGray&quot; /&gt;
            &lt;SymbolStyle Color=&quot;CornflowerBlue&quot; Shape=&quot;Dot&quot; /&gt;
            &lt;SeriesLabel&gt;series 1&lt;/SeriesLabel&gt;
            &lt;X&gt;1;2;3;4;5&lt;/X&gt;
            &lt;Y&gt;8;12;10;12;15&lt;/Y&gt;
            &lt;Y1 /&gt;
            &lt;Y2 /&gt;
            &lt;Y3 /&gt;
            &lt;DataTypes&gt;Single;Single;Double;Double;Double&lt;/DataTypes&gt;
            &lt;DataFields&gt;;;;;&lt;/DataFields&gt;
            &lt;Tag /&gt;
          &lt;/DataSeriesSerializer&gt;
          &lt;DataSeriesSerializer Offset=&quot;20&quot;&gt;
            &lt;LineStyle Color=&quot;DarkGreen&quot; /&gt;
            &lt;SymbolStyle Color=&quot;Cornsilk&quot; Shape=&quot;Tri&quot; /&gt;
            &lt;SeriesLabel&gt;series 2&lt;/SeriesLabel&gt;
            &lt;X&gt;1;2;3;4;5&lt;/X&gt;
            &lt;Y&gt;10;16;17;15;23&lt;/Y&gt;
            &lt;Y1 /&gt;
            &lt;Y2 /&gt;
            &lt;Y3 /&gt;
            &lt;DataTypes&gt;Single;Single;Double;Double;Double&lt;/DataTypes&gt;
            &lt;DataFields&gt;;;;;&lt;/DataFields&gt;
            &lt;Tag /&gt;
          &lt;/DataSeriesSerializer&gt;
          &lt;DataSeriesSerializer Offset=&quot;20&quot;&gt;
            &lt;LineStyle Color=&quot;DarkKhaki&quot; /&gt;
            &lt;SymbolStyle Color=&quot;Crimson&quot; Shape=&quot;Diamond&quot; /&gt;
            &lt;SeriesLabel&gt;series 3&lt;/SeriesLabel&gt;
            &lt;X&gt;1;2;3;4;5&lt;/X&gt;
            &lt;Y&gt;16;19;15;22;18&lt;/Y&gt;
            &lt;Y1 /&gt;
            &lt;Y2 /&gt;
            &lt;Y3 /&gt;
            &lt;DataTypes&gt;Single;Single;Double;Double;Double&lt;/DataTypes&gt;
            &lt;DataFields&gt;;;;;&lt;/DataFields&gt;
            &lt;Tag /&gt;
          &lt;/DataSeriesSerializer&gt;
        &lt;/DataSeriesCollection&gt;
      &lt;/DataSerializer&gt;
      &lt;Name&gt;Group1&lt;/Name&gt;
      &lt;Stacked&gt;False&lt;/Stacked&gt;
      &lt;ChartType&gt;Pie&lt;/ChartType&gt;
      &lt;Pie&gt;OtherOffset=0,Start=0&lt;/Pie&gt;
      &lt;Bar&gt;ClusterOverlap=0,ClusterWidth=50&lt;/Bar&gt;
      &lt;HiLoData&gt;FillFalling=True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=True&lt;/HiLoData&gt;
      &lt;Bubble&gt;EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5&lt;/Bubble&gt;
      &lt;Polar&gt;Degrees=True,PiRatioAnnotations=True,Start=0&lt;/Polar&gt;
      &lt;Radar&gt;Degrees=True,Filled=False,Start=0&lt;/Radar&gt;
      &lt;Visible&gt;True&lt;/Visible&gt;
      &lt;ShowOutline&gt;True&lt;/ShowOutline&gt;
    &lt;/ChartGroup&gt;
    &lt;ChartGroup&gt;
      &lt;DataSerializer Hole=&quot;3.4028234663852886E+38&quot; /&gt;
      &lt;Name&gt;Group2&lt;/Name&gt;
      &lt;Stacked&gt;False&lt;/Stacked&gt;
      &lt;ChartType&gt;XYPlot&lt;/ChartType&gt;
      &lt;Pie&gt;OtherOffset=0,Start=0&lt;/Pie&gt;
      &lt;Bar&gt;ClusterOverlap=0,ClusterWidth=50&lt;/Bar&gt;
      &lt;HiLoData&gt;FillFalling=True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=True&lt;/HiLoData&gt;
      &lt;Bubble&gt;EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5&lt;/Bubble&gt;
      &lt;Polar&gt;Degrees=True,PiRatioAnnotations=True,Start=0&lt;/Polar&gt;
      &lt;Radar&gt;Degrees=True,Filled=False,Start=0&lt;/Radar&gt;
      &lt;Visible&gt;True&lt;/Visible&gt;
      &lt;ShowOutline&gt;True&lt;/ShowOutline&gt;
    &lt;/ChartGroup&gt;
  &lt;/ChartGroupsCollection&gt;
  &lt;Header Compass=&quot;North&quot;&gt;
    &lt;Text /&gt;
  &lt;/Header&gt;
  &lt;Footer Compass=&quot;South&quot;&gt;
    &lt;Text /&gt;
  &lt;/Footer&gt;
  &lt;Legend Compass=&quot;East&quot; Visible=&quot;False&quot;&gt;
    &lt;Text /&gt;
  &lt;/Legend&gt;
  &lt;ChartArea Depth=&quot;20&quot; Rotation=&quot;45&quot; Elevation=&quot;45&quot; /&gt;
  &lt;Axes&gt;
    &lt;Axis Max=&quot;5&quot; Min=&quot;1&quot; UnitMajor=&quot;1&quot; UnitMinor=&quot;0.5&quot; AutoMajor=&quot;True&quot; AutoMinor=&quot;True&quot; AutoMax=&quot;True&quot; AutoMin=&quot;True&quot; _onTop=&quot;0&quot; Compass=&quot;South&quot;&gt;
      &lt;Text /&gt;
      &lt;GridMajor AutoSpace=&quot;True&quot; Color=&quot;LightGray&quot; Pattern=&quot;Dash&quot; /&gt;
      &lt;GridMinor AutoSpace=&quot;True&quot; Color=&quot;LightGray&quot; Pattern=&quot;Dash&quot; /&gt;
    &lt;/Axis&gt;
    &lt;Axis Max=&quot;26&quot; Min=&quot;8&quot; UnitMajor=&quot;2&quot; UnitMinor=&quot;1&quot; AutoMajor=&quot;True&quot; AutoMinor=&quot;True&quot; AutoMax=&quot;True&quot; AutoMin=&quot;True&quot; _onTop=&quot;0&quot; Compass=&quot;West&quot;&gt;
      &lt;Text /&gt;
      &lt;GridMajor AutoSpace=&quot;True&quot; Color=&quot;LightGray&quot; Pattern=&quot;Dash&quot; /&gt;
      &lt;GridMinor AutoSpace=&quot;True&quot; Color=&quot;LightGray&quot; Pattern=&quot;Dash&quot; /&gt;
    &lt;/Axis&gt;
    &lt;Axis Max=&quot;0&quot; Min=&quot;0&quot; UnitMajor=&quot;0&quot; UnitMinor=&quot;0&quot; AutoMajor=&quot;True&quot; AutoMinor=&quot;True&quot; AutoMax=&quot;True&quot; AutoMin=&quot;True&quot; _onTop=&quot;0&quot; Compass=&quot;East&quot;&gt;
      &lt;Text /&gt;
      &lt;GridMajor AutoSpace=&quot;True&quot; Color=&quot;LightGray&quot; Pattern=&quot;Dash&quot; /&gt;
      &lt;GridMinor AutoSpace=&quot;True&quot; Color=&quot;LightGray&quot; Pattern=&quot;Dash&quot; /&gt;
    &lt;/Axis&gt;
  &lt;/Axes&gt;
&lt;/Chart2DPropBag&gt;"></Serializer>
									</c1webchart:C1WebChart></td>
							</tr>
							<tr>
								<td height="250" class="font3">具体品牌中的出故障率：</td>
								<td>&nbsp;
									<c1webchart:C1WebChart id="C1WebChart2" runat="server" Visible="False" Height="224px" Width="400px">
										<Serializer Value="&lt;?xml version=&quot;1.0&quot;?&gt;
&lt;Chart2DPropBag Version=&quot;&quot;&gt;
  &lt;StyleCollection&gt;
    &lt;NamedStyle Name=&quot;PlotArea&quot; ParentName=&quot;Area&quot;&gt;
      &lt;StyleData&gt;Border=None,Black,1;&lt;/StyleData&gt;
    &lt;/NamedStyle&gt;
    &lt;NamedStyle Name=&quot;Legend&quot; ParentName=&quot;Legend.default&quot;&gt;
      &lt;StyleData /&gt;
    &lt;/NamedStyle&gt;
    &lt;NamedStyle Name=&quot;Footer&quot; ParentName=&quot;Control&quot;&gt;
      &lt;StyleData&gt;Border=None,Black,1;&lt;/StyleData&gt;
    &lt;/NamedStyle&gt;
    &lt;NamedStyle Name=&quot;AxisY2&quot; ParentName=&quot;Area&quot;&gt;
      &lt;StyleData&gt;Rotation=Rotate90;Border=None,Transparent,1;AlignHorz=Far;BackColor=Transparent;AlignVert=Center;&lt;/StyleData&gt;
    &lt;/NamedStyle&gt;
    &lt;NamedStyle Name=&quot;Area&quot; ParentName=&quot;Area.default&quot;&gt;
      &lt;StyleData /&gt;
    &lt;/NamedStyle&gt;
    &lt;NamedStyle Name=&quot;Control&quot; ParentName=&quot;Control.default&quot;&gt;
      &lt;StyleData /&gt;
    &lt;/NamedStyle&gt;
    &lt;NamedStyle Name=&quot;AxisX&quot; ParentName=&quot;Area&quot;&gt;
      &lt;StyleData&gt;Rotation=Rotate0;Border=None,Transparent,1;AlignHorz=Center;BackColor=Transparent;Opaque=False;AlignVert=Bottom;&lt;/StyleData&gt;
    &lt;/NamedStyle&gt;
    &lt;NamedStyle Name=&quot;AxisY&quot; ParentName=&quot;Area&quot;&gt;
      &lt;StyleData&gt;Rotation=Rotate270;Border=None,Transparent,1;AlignHorz=Near;BackColor=Transparent;Opaque=False;AlignVert=Center;&lt;/StyleData&gt;
    &lt;/NamedStyle&gt;
    &lt;NamedStyle Name=&quot;LabelStyleDefault&quot; ParentName=&quot;LabelStyleDefault.default&quot;&gt;
      &lt;StyleData /&gt;
    &lt;/NamedStyle&gt;
    &lt;NamedStyle Name=&quot;Legend.default&quot; ParentName=&quot;Control&quot;&gt;
      &lt;StyleData&gt;Border=None,Black,1;Wrap=False;AlignVert=Top;&lt;/StyleData&gt;
    &lt;/NamedStyle&gt;
    &lt;NamedStyle Name=&quot;LabelStyleDefault.default&quot; ParentName=&quot;Control&quot;&gt;
      &lt;StyleData&gt;Border=None,Black,1;BackColor=Transparent;&lt;/StyleData&gt;
    &lt;/NamedStyle&gt;
    &lt;NamedStyle Name=&quot;Header&quot; ParentName=&quot;Control&quot;&gt;
      &lt;StyleData&gt;Border=None,Black,1;&lt;/StyleData&gt;
    &lt;/NamedStyle&gt;
    &lt;NamedStyle Name=&quot;Control.default&quot; ParentName=&quot;&quot;&gt;
      &lt;StyleData&gt;ForeColor=ControlText;Border=None,Black,1;BackColor=Control;&lt;/StyleData&gt;
    &lt;/NamedStyle&gt;
    &lt;NamedStyle Name=&quot;Area.default&quot; ParentName=&quot;Control&quot;&gt;
      &lt;StyleData&gt;Border=None,Black,1;AlignVert=Top;&lt;/StyleData&gt;
    &lt;/NamedStyle&gt;
  &lt;/StyleCollection&gt;
  &lt;ChartGroupsCollection&gt;
    &lt;ChartGroup&gt;
      &lt;DataSerializer Hole=&quot;3.4028234663852886E+38&quot; DefaultSet=&quot;True&quot;&gt;
        &lt;DataSeriesCollection&gt;
          &lt;DataSeriesSerializer&gt;
            &lt;LineStyle Color=&quot;DarkGoldenrod&quot; /&gt;
            &lt;SymbolStyle Color=&quot;Coral&quot; Shape=&quot;Box&quot; /&gt;
            &lt;SeriesLabel&gt;series 0&lt;/SeriesLabel&gt;
            &lt;X&gt;1;2;3;4;5&lt;/X&gt;
            &lt;Y&gt;20;22;19;24;25&lt;/Y&gt;
            &lt;Y1 /&gt;
            &lt;Y2 /&gt;
            &lt;Y3 /&gt;
            &lt;DataTypes&gt;Single;Single;Double;Double;Double&lt;/DataTypes&gt;
            &lt;DataFields&gt;;;;;&lt;/DataFields&gt;
            &lt;Tag /&gt;
          &lt;/DataSeriesSerializer&gt;
          &lt;DataSeriesSerializer&gt;
            &lt;LineStyle Color=&quot;DarkGray&quot; /&gt;
            &lt;SymbolStyle Color=&quot;CornflowerBlue&quot; Shape=&quot;Dot&quot; /&gt;
            &lt;SeriesLabel&gt;series 1&lt;/SeriesLabel&gt;
            &lt;X&gt;1;2;3;4;5&lt;/X&gt;
            &lt;Y&gt;8;12;10;12;15&lt;/Y&gt;
            &lt;Y1 /&gt;
            &lt;Y2 /&gt;
            &lt;Y3 /&gt;
            &lt;DataTypes&gt;Single;Single;Double;Double;Double&lt;/DataTypes&gt;
            &lt;DataFields&gt;;;;;&lt;/DataFields&gt;
            &lt;Tag /&gt;
          &lt;/DataSeriesSerializer&gt;
          &lt;DataSeriesSerializer&gt;
            &lt;LineStyle Color=&quot;DarkGreen&quot; /&gt;
            &lt;SymbolStyle Color=&quot;Cornsilk&quot; Shape=&quot;Tri&quot; /&gt;
            &lt;SeriesLabel&gt;series 2&lt;/SeriesLabel&gt;
            &lt;X&gt;1;2;3;4;5&lt;/X&gt;
            &lt;Y&gt;10;16;17;15;23&lt;/Y&gt;
            &lt;Y1 /&gt;
            &lt;Y2 /&gt;
            &lt;Y3 /&gt;
            &lt;DataTypes&gt;Single;Single;Double;Double;Double&lt;/DataTypes&gt;
            &lt;DataFields&gt;;;;;&lt;/DataFields&gt;
            &lt;Tag /&gt;
          &lt;/DataSeriesSerializer&gt;
          &lt;DataSeriesSerializer&gt;
            &lt;LineStyle Color=&quot;DarkKhaki&quot; /&gt;
            &lt;SymbolStyle Color=&quot;Crimson&quot; Shape=&quot;Diamond&quot; /&gt;
            &lt;SeriesLabel&gt;series 3&lt;/SeriesLabel&gt;
            &lt;X&gt;1;2;3;4;5&lt;/X&gt;
            &lt;Y&gt;16;19;15;22;18&lt;/Y&gt;
            &lt;Y1 /&gt;
            &lt;Y2 /&gt;
            &lt;Y3 /&gt;
            &lt;DataTypes&gt;Single;Single;Double;Double;Double&lt;/DataTypes&gt;
            &lt;DataFields&gt;;;;;&lt;/DataFields&gt;
            &lt;Tag /&gt;
          &lt;/DataSeriesSerializer&gt;
        &lt;/DataSeriesCollection&gt;
      &lt;/DataSerializer&gt;
      &lt;Name&gt;Group1&lt;/Name&gt;
      &lt;Stacked&gt;False&lt;/Stacked&gt;
      &lt;ChartType&gt;XYPlot&lt;/ChartType&gt;
      &lt;Pie&gt;OtherOffset=0,Start=0&lt;/Pie&gt;
      &lt;Bar&gt;ClusterOverlap=0,ClusterWidth=50&lt;/Bar&gt;
      &lt;HiLoData&gt;FillFalling=True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=True&lt;/HiLoData&gt;
      &lt;Bubble&gt;EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5&lt;/Bubble&gt;
      &lt;Polar&gt;Degrees=True,PiRatioAnnotations=True,Start=0&lt;/Polar&gt;
      &lt;Radar&gt;Degrees=True,Filled=False,Start=0&lt;/Radar&gt;
      &lt;Visible&gt;True&lt;/Visible&gt;
      &lt;ShowOutline&gt;True&lt;/ShowOutline&gt;
    &lt;/ChartGroup&gt;
    &lt;ChartGroup&gt;
      &lt;DataSerializer Hole=&quot;3.4028234663852886E+38&quot; /&gt;
      &lt;Name&gt;Group2&lt;/Name&gt;
      &lt;Stacked&gt;False&lt;/Stacked&gt;
      &lt;ChartType&gt;XYPlot&lt;/ChartType&gt;
      &lt;Pie&gt;OtherOffset=0,Start=0&lt;/Pie&gt;
      &lt;Bar&gt;ClusterOverlap=0,ClusterWidth=50&lt;/Bar&gt;
      &lt;HiLoData&gt;FillFalling=True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=True&lt;/HiLoData&gt;
      &lt;Bubble&gt;EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5&lt;/Bubble&gt;
      &lt;Polar&gt;Degrees=True,PiRatioAnnotations=True,Start=0&lt;/Polar&gt;
      &lt;Radar&gt;Degrees=True,Filled=False,Start=0&lt;/Radar&gt;
      &lt;Visible&gt;True&lt;/Visible&gt;
      &lt;ShowOutline&gt;True&lt;/ShowOutline&gt;
    &lt;/ChartGroup&gt;
  &lt;/ChartGroupsCollection&gt;
  &lt;Header Compass=&quot;North&quot;&gt;
    &lt;Text /&gt;
  &lt;/Header&gt;
  &lt;Footer Compass=&quot;South&quot;&gt;
    &lt;Text /&gt;
  &lt;/Footer&gt;
  &lt;Legend Compass=&quot;East&quot; Visible=&quot;False&quot;&gt;
    &lt;Text /&gt;
  &lt;/Legend&gt;
  &lt;ChartArea /&gt;
  &lt;Axes&gt;
    &lt;Axis Max=&quot;5&quot; Min=&quot;1&quot; UnitMajor=&quot;1&quot; UnitMinor=&quot;0.5&quot; AutoMajor=&quot;True&quot; AutoMinor=&quot;True&quot; AutoMax=&quot;True&quot; AutoMin=&quot;True&quot; _onTop=&quot;0&quot; Compass=&quot;South&quot;&gt;
      &lt;Text /&gt;
      &lt;GridMajor AutoSpace=&quot;True&quot; Color=&quot;LightGray&quot; Pattern=&quot;Dash&quot; /&gt;
      &lt;GridMinor AutoSpace=&quot;True&quot; Color=&quot;LightGray&quot; Pattern=&quot;Dash&quot; /&gt;
    &lt;/Axis&gt;
    &lt;Axis Max=&quot;25&quot; Min=&quot;5&quot; UnitMajor=&quot;5&quot; UnitMinor=&quot;2.5&quot; AutoMajor=&quot;True&quot; AutoMinor=&quot;True&quot; AutoMax=&quot;True&quot; AutoMin=&quot;True&quot; _onTop=&quot;0&quot; Compass=&quot;West&quot;&gt;
      &lt;Text /&gt;
      &lt;GridMajor AutoSpace=&quot;True&quot; Color=&quot;LightGray&quot; Pattern=&quot;Dash&quot; /&gt;
      &lt;GridMinor AutoSpace=&quot;True&quot; Color=&quot;LightGray&quot; Pattern=&quot;Dash&quot; /&gt;
    &lt;/Axis&gt;
    &lt;Axis Max=&quot;0&quot; Min=&quot;0&quot; UnitMajor=&quot;0&quot; UnitMinor=&quot;0&quot; AutoMajor=&quot;True&quot; AutoMinor=&quot;True&quot; AutoMax=&quot;True&quot; AutoMin=&quot;True&quot; _onTop=&quot;0&quot; Compass=&quot;East&quot;&gt;
      &lt;Text /&gt;
      &lt;GridMajor AutoSpace=&quot;True&quot; Color=&quot;LightGray&quot; Pattern=&quot;Dash&quot; /&gt;
      &lt;GridMinor AutoSpace=&quot;True&quot; Color=&quot;LightGray&quot; Pattern=&quot;Dash&quot; /&gt;
    &lt;/Axis&gt;
  &lt;/Axes&gt;
&lt;/Chart2DPropBag&gt;"></Serializer>
									</c1webchart:C1WebChart></td>
							</tr>
					  </table>
					</form>
				</td>
			</tr>
		</table>
	</body>
</HTML>
