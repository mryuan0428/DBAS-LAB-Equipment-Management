using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using C1.Web.C1WebChart;
using C1.Web.C1WebChartBase;
using C1.Win.C1Chart;

namespace WebService1
{
	/// <summary>
	/// yiyuceer 的摘要说明。
	/// </summary>
	public class yiyuceer : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DropDownList DropDownList1;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.DropDownList DropDownList2;
		protected C1.Web.C1WebChart.C1WebChart C1WebChart1;
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Web.UI.HtmlControls.HtmlForm Form1;
	
		Class1 db1;
		protected System.Web.UI.HtmlControls.HtmlInputHidden Hidden1;
		protected System.Web.UI.WebControls.TextBox TextBox1;
		protected System.Web.UI.WebControls.RegularExpressionValidator RegularExpressionValidator1;
		string s;
		private void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			db1=new Class1();
			if(!Page.IsPostBack)
			{
				string sql1="select * from changjia";
				db1.cleardata();
				db1.ExectueSQL("changjia",sql1);

				for(int i=0;i<db1.getdata().Tables["changjia"].Rows.Count;i++)
				{
					this.DropDownList1.Items.Add(new ListItem(db1.getdata().Tables["changjia"].Rows[i]["厂家名称"].ToString()));
				}

				sql1="select * from changjia where 厂家名称='"+this.DropDownList1.SelectedValue.ToString()+"'";
				db1.cleardata();
				db1.ExectueSQL("changjia",sql1);

				string cj=db1.getdata().Tables["changjia"].Rows[0]["厂家id"].ToString();

				sql1="select * from sbname";
				db1.cleardata();
				db1.ExectueSQL("sbname",sql1);

				for(int i=0;i<db1.getdata().Tables["sbname"].Rows.Count;i++)
				{
					this.DropDownList2.Items.Add(new ListItem(db1.getdata().Tables["sbname"].Rows[i]["设备名称"].ToString()));
				}
				Session["index"]="0";
			}
		}

		#region Web 窗体设计器生成的代码
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{    
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.C1WebChart1.DrawDataSeries += new C1.Win.C1Chart.DrawDataSeriesEventHandler(this.C1WebChart1_DrawDataSeries);
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			Class1 db2;
			db2=new Class1();
			C1WebChart1.Visible=true;
			C1WebChart1.ChartGroups.Group0.ChartType = Chart2DTypeEnum.Bar;
			C1WebChart1.ImageFormat = System.Drawing.Imaging.ImageFormat.Png;
			C1WebChart1.ImageRenderMethod = ImageRenderMethodEnum.HttpHandler;
			//this.GetPieData();
			Service1 MyService=new Service1();
			string sb=this.DropDownList2.SelectedValue;
			string cj=this.DropDownList1.SelectedValue;
			s=MyService.gzttwo(sb,cj,this.TextBox1.Text);

			if(s=="")
				return;
			//this.Label1.Text=s;
			string sql1="select * from changjia where 厂家名称='"+this.DropDownList1.SelectedValue.ToString()+"'";
			db1.cleardata();
			db1.ExectueSQL("changjia",sql1);

			cj=db1.getdata().Tables["changjia"].Rows[0]["厂家id"].ToString();

			sql1="select * from sbname where 设备名称='"+this.DropDownList2.SelectedValue.ToString()+"'";
			db1.cleardata();
			db1.ExectueSQL("sbname",sql1);

			sb=db1.getdata().Tables["sbname"].Rows[0]["设备名称id"].ToString();

			sql1="select * from basicinfo where 设备id in (select 设备id from info group by 设备id having count(*) between "+this.TextBox1.Text+" and "+(Int32.Parse(this.TextBox1.Text)+1).ToString()+") and 设备名称id="+sb+" and 厂家id="+cj;
			db1.cleardata();
			db1.ExectueSQL("basicinfo",sql1); 


			Axis ax = C1WebChart1.ChartArea.AxisX;
			ax.ValueLabels.Clear();
			
			int i,l;
			ax.AnnoMethod = AnnotationMethodEnum.ValueLabels;
			Session["index"]="0";
			for(i = 0+10*Int32.Parse(Session["index"].ToString()),l=0; i < db1.getdata().Tables["basicinfo"].Rows.Count&&l<10; i++,l++)
			{
				//DataRowView drv = dv[i];
				ax.ValueLabels.Add(i, db1.getdata().Tables["basicinfo"].Rows[i]["设备编号"].ToString());
			}
			try
			{
				//ax.Max =db1.getdata().Tables["basicinfo"].Rows.Count;
			}
			catch {}

			int count=db1.getdata().Tables["basicinfo"].Rows.Count;
			PointF[] data = new PointF[count];
			C1WebChart1.ChartLabels.LabelsCollection.Clear();
			for(i = 0+10*Int32.Parse(Session["index"].ToString()),l=0; i < db1.getdata().Tables["basicinfo"].Rows.Count&&l<10; i++,l++)
			{
				sql1="select * from info where 设备id="+db1.getdata().Tables["basicinfo"].Rows[i]["设备id"].ToString();
				db2.cleardata();
				db2.ExectueSQL("info",sql1);

				DateTime t=DateTime.Parse(db2.getdata().Tables["info"].Rows[0]["登记日期"].ToString());
				int k=s.IndexOf("年",0,s.Length);
				int year=Int32.Parse(s.Substring(0,k));
				int j=s.IndexOf("月",k,s.Length-k);
				int month=Int32.Parse(s.Substring(k+1,j-k-1));
				int day=Int32.Parse(s.Substring(j+1,s.Length-j-2));
				int year1=year+t.Year;
				int month1=month+t.Month;
				int day1=day+t.Day;
				if((month1==1||month1==3||month1==5||month1==7||month1==8||month1==10||month1==12)&&day1>31)
				{
					day1=day1-31;
					month1++;
				}
				else if((month1==4||month1==6||month1==9||month1==11)&&day1>30)
				{
					day1=day1-30;
					month1++;
				}
				else if(((year%4==0&&year%100!=0)||(year%400==0))&&month1==2&&day1>29)
				{
					day1=day1-29;
					month1++;
				}
				else if(month1==2&&day1>28)
				{
					day1=day1-28;
					month1++;
				}
				if(month1>12)
				{
					month1=month1-12;
					year1++;
				}
				DateTime t2=new DateTime(2006,1,1);
				DateTime t1=new DateTime(year1,month1,day1);
				TimeSpan ts=t1-t2;
				float y=float.Parse(string.Format("{0:F0}",ts.TotalDays.ToString()));
				data[i]=new PointF(i,y);
				C1.Win.C1Chart.Label lbl = C1WebChart1.ChartLabels.LabelsCollection.AddNewLabel();

				lbl.Text="";
				//int f=Int32.Parse(ts.TotalDays.ToString());
				
				lbl.Text = t1.ToString("yy-MM-dd");
				lbl.Compass = LabelCompassEnum.Radial;
				lbl.Compass = LabelCompassEnum.North;
				lbl.Connected = true;
				lbl.Visible = true;
				lbl.AttachMethod = AttachMethodEnum.DataIndex;
				AttachMethodData am = lbl.AttachMethodData;
				am.GroupIndex  = 0;
				am.SeriesIndex = 0;
				am.PointIndex  = i;

			}
	
			ChartDataSeriesCollection dscoll = C1WebChart1.ChartGroups[0].ChartData.SeriesList;			

			dscoll.Clear();
			ChartDataSeries series = dscoll.AddNewSeries();
			series.PointData.CopyDataIn(data);// 这里的data是PointF类型
			C1WebChart1.ChartGroups.Group0.Stacked = false;
			Session["index"]=(Int32.Parse(Session["index"].ToString())+1).ToString();
		}

		private void C1WebChart1_DrawDataSeries(object sender, C1.Win.C1Chart.DrawDataSeriesEventArgs e)
		{
			C1.Win.C1Chart.ChartDataSeries ds = (ChartDataSeries)sender;

			Color clr1 = ds.LineStyle.Color;

			Color clr2 = ds.SymbolStyle.Color;

			if(e.Bounds.Size.Height > 0 && e.Bounds.Size.Width > 0)
			{

				System.Drawing.Drawing2D.LinearGradientBrush lgb =

					new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, clr1, clr2, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);

				e.Brush = lgb;

			}
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			Class1 db2=new Class1();
			C1WebChart1.Visible=true;
			C1WebChart1.ChartGroups.Group0.ChartType = Chart2DTypeEnum.Bar;
			C1WebChart1.ImageFormat = System.Drawing.Imaging.ImageFormat.Png;
			C1WebChart1.ImageRenderMethod = ImageRenderMethodEnum.HttpHandler;
			//this.GetPieData();
			Service1 MyService=new Service1();
			string sb=this.DropDownList2.SelectedValue;
			string cj=this.DropDownList1.SelectedValue;
			s=MyService.gzttwo(sb,cj,this.TextBox1.Text);

			if(s=="")
				return;
			//this.Label1.Text=s;
			string sql1="select * from changjia where 厂家名称='"+this.DropDownList1.SelectedValue.ToString()+"'";
			db1.cleardata();
			db1.ExectueSQL("changjia",sql1);

			cj=db1.getdata().Tables["changjia"].Rows[0]["厂家id"].ToString();

			sql1="select * from sbname where 设备名称='"+this.DropDownList2.SelectedValue.ToString()+"'";
			db1.cleardata();
			db1.ExectueSQL("sbname",sql1);

			sb=db1.getdata().Tables["sbname"].Rows[0]["设备名称id"].ToString();

			sql1="select * from basicinfo where 设备id in (select 设备id from info group by 设备id having count(*) between "+this.TextBox1.Text+" and "+(Int32.Parse(this.TextBox1.Text)+1).ToString()+") and 设备名称id="+sb+" and 厂家id="+cj;
			db1.cleardata();
			db1.ExectueSQL("basicinfo",sql1); 


			Axis ax = C1WebChart1.ChartArea.AxisX;
			ax.ValueLabels.Clear();
			
			int i,l;
			ax.AnnoMethod = AnnotationMethodEnum.ValueLabels;
			for(i = 0+10*Int32.Parse(Session["index"].ToString()),l=0; i < db1.getdata().Tables["basicinfo"].Rows.Count&&l<10; i++,l++)
			{
				//DataRowView drv = dv[i];
				ax.ValueLabels.Add(l, db1.getdata().Tables["basicinfo"].Rows[i]["设备编号"].ToString());
			}
			try
			{
				//ax.Max =db1.getdata().Tables["basicinfo"].Rows.Count;
			}
			catch {}

			int count=db1.getdata().Tables["basicinfo"].Rows.Count;
			PointF[] data = new PointF[count];
			C1WebChart1.ChartLabels.LabelsCollection.Clear();
			for(i = 0+10*Int32.Parse(Session["index"].ToString()),l=0; i < db1.getdata().Tables["basicinfo"].Rows.Count&&l<10; i++,l++)
			{
				sql1="select * from info where 设备id="+db1.getdata().Tables["basicinfo"].Rows[i]["设备id"].ToString();
				//db1.cleardata();
				db2.cleardata();
				db2.ExectueSQL("info",sql1);

				DateTime t=DateTime.Parse(db2.getdata().Tables["info"].Rows[0]["登记日期"].ToString());
				int k=s.IndexOf("年",0,s.Length);
				int year=Int32.Parse(s.Substring(0,k));
				int j=s.IndexOf("月",k,s.Length-k);
				int month=Int32.Parse(s.Substring(k+1,j-k-1));
				int day=Int32.Parse(s.Substring(j+1,s.Length-j-2));
				int year1=year+t.Year;
				int month1=month+t.Month;
				int day1=day+t.Day;
				if(month1>12)
				{
					month1=month1-12;
					year1++;
				}
				if((month1==1||month1==3||month1==5||month1==7||month1==8||month1==10||month1==12)&&day1>31)
				{
					day1=day1-31;
					month1++;
				}
				else if((month1==4||month1==6||month1==9||month1==11)&&day1>30)
				{
					day1=day1-30;
					month1++;
				}
				else if(((year%4==0&&year%100!=0)||(year%400==0))&&month1==2&&day1>29)
				{
					day1=day1-29;
					month1++;
				}
				else if(month1==2&&day1>28)
				{
					day1=day1-28;
					month1++;
				}
				if(month1>12)
				{
					month1=month1-12;
					year1++;
				}
				DateTime t2=new DateTime(2006,1,1);
				DateTime t1=new DateTime(year1,month1,day1);
				TimeSpan ts=t1-t2;
				float y=float.Parse(string.Format("{0:F0}",ts.TotalDays.ToString()));
				data[l]=new PointF(l,y);
				C1.Win.C1Chart.Label lbl = C1WebChart1.ChartLabels.LabelsCollection.AddNewLabel();

				lbl.Text="";
				//int f=Int32.Parse(ts.TotalDays.ToString());
				
				lbl.Text = t1.ToString("yy-MM-dd");
				lbl.Compass = LabelCompassEnum.North;
				lbl.Connected = true;
				lbl.Visible = true;
				lbl.AttachMethod = AttachMethodEnum.DataIndex;
				AttachMethodData am = lbl.AttachMethodData;
				am.GroupIndex  = 0;
				am.SeriesIndex = 0;
				am.PointIndex  = l;

			}
	
			ChartDataSeriesCollection dscoll = C1WebChart1.ChartGroups[0].ChartData.SeriesList;			

			dscoll.Clear();
			ChartDataSeries series = dscoll.AddNewSeries();
			series.PointData.CopyDataIn(data);// 这里的data是PointF类型
			C1WebChart1.ChartGroups.Group0.Stacked = false;
			Session["index"]=(Int32.Parse(Session["index"].ToString())+1).ToString();
		}
	}
}
