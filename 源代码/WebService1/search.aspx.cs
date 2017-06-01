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
	/// search 的摘要说明。
	/// </summary>
	public class search : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DropDownList DropDownList2;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Button Button1;
		protected C1.Web.C1WebChart.C1WebChart C1WebChart1;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.DropDownList DropDownList1;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.Label Label9;
		protected System.Web.UI.WebControls.Label Label13;
		protected System.Web.UI.WebControls.Label Label16;
		protected System.Web.UI.WebControls.Label Label17;
		protected System.Web.UI.WebControls.Label Label18;
		protected System.Web.UI.WebControls.DropDownList DropDownList3;
		protected System.Web.UI.WebControls.DropDownList DropDownList4;
		protected System.Web.UI.WebControls.DropDownList DropDownList5;
		protected System.Web.UI.WebControls.DropDownList DropDownList6;
		protected System.Web.UI.WebControls.DropDownList DropDownList7;
	
		public string s;
		protected C1.Web.C1WebChart.C1WebChart C1WebChart2;
		Class1 db1;
		private void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			if(!Page.IsPostBack)
			{
				/*string sql="select * from changjia";
				this.sqlDataAdapter1.SelectCommand.Connection=this.sqlConnection1;
				this.sqlDataAdapter1.SelectCommand.CommandText=sql;
				this.sqlConnection1.Open();
				this.sqlDataAdapter1.SelectCommand.ExecuteNonQuery();
				this.sqlConnection1.Close();

				this.dataSet11.Clear();
				this.sqlDataAdapter1.Fill(this.dataSet11,"changjia");

				for(int i=0;i<this.dataSet11.Tables["changjia"].Rows.Count;i++)
				{
					this.DropDownList1.Items.Add(new ListItem(this.dataSet11.Tables["changjia"].Rows[i]["厂家名称"].ToString()));
				}*/

				db1=new Class1();
				string sql="select * from sbname";
				db1.cleardata();
				db1.ExectueSQL("sbname",sql);

				for(int i=0;i<db1.getdata().Tables["sbname"].Rows.Count;i++)
				{
					this.DropDownList2.Items.Add(new ListItem(db1.getdata().Tables["sbname"].Rows[i]["设备名称"].ToString()));
				}
				
				DateTime date=DateTime.Now;
				for(int i=2000;i<=Int32.Parse(date.Year.ToString());i++)
				{
					this.DropDownList1.Items.Add(new ListItem(i.ToString()));
				}
				for(int i=1;i<=12;i++)
				{
					this.DropDownList3.Items.Add(new ListItem(i.ToString()));
				}
				for(int i=1;i<=31;i++)
				{
					this.DropDownList4.Items.Add(new ListItem(i.ToString()));
				}
				for(int i=2000;i<=Int32.Parse(date.Year.ToString());i++)
				{
					this.DropDownList5.Items.Add(new ListItem(i.ToString()));
				}
				for(int i=1;i<=12;i++)
				{
					this.DropDownList6.Items.Add(new ListItem(i.ToString()));
				}
				for(int i=1;i<=31;i++)
				{
					this.DropDownList7.Items.Add(new ListItem(i.ToString()));
				}
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
			this.C1WebChart1.DrawDataSeries += new C1.Win.C1Chart.DrawDataSeriesEventHandler(this.C1WebChart1_DrawDataSeries_1);
			this.C1WebChart2.DrawDataSeries += new C1.Win.C1Chart.DrawDataSeriesEventHandler(this.C1WebChart2_DrawDataSeries);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			string start,sb,end;
			//cj=this.DropDownList1.SelectedValue.ToString().Trim();
			sb=this.DropDownList2.SelectedValue.ToString().Trim();

			start=this.DropDownList1.SelectedValue.ToString().Trim()+"-"+this.DropDownList3.SelectedValue.ToString().Trim()+"-"+this.DropDownList4.SelectedValue.ToString().Trim();
            end=this.DropDownList5.SelectedValue.ToString().Trim()+"-"+this.DropDownList6.SelectedValue.ToString().Trim()+"-"+this.DropDownList7.SelectedValue.ToString().Trim();

			Service1 MyService=new Service1();
			s=MyService.guzhanglv(sb,start,end);
			double unit = 0;
			//C1WebChart1.Header.Text="";
			//C1WebChart1.Footer.Text="Chart 尾";
			//C1WebChart1.BackColor = Color.LightSteelBlue;
			//
			if(s.Length==0)return;
			//C1WebChart1.Reset();
			C1WebChart1.Visible=true;
			C1WebChart1.ImageFormat = System.Drawing.Imaging.ImageFormat.Png;
			C1WebChart1.ImageRenderMethod = ImageRenderMethodEnum.HttpHandler;
			this.GetPieData();

			C1WebChart2.Visible=true;
			C1WebChart2.ChartGroups.Group0.ChartType = Chart2DTypeEnum.Bar;
			C1WebChart2.ImageFormat = System.Drawing.Imaging.ImageFormat.Png;
			C1WebChart2.ImageRenderMethod = ImageRenderMethodEnum.HttpHandler;

			s=MyService.bilv(sb,start,end);
			this.SingleBarData();
			//C1WebChart1.ChartGroups.Group0.ChartType = Chart2DTypeEnum.Pie;
			

			
		}
		public void GetPieData()
		{
			// get dataset (from db or cache)
			//DataSet ds = GetDataSet();
    
			// filter the data
			//			DataView dv = new DataView(ds.Tables["Sales"]);
			//			dv.RowFilter = "ProductSales >= 40000";
			//			dv.Sort = "ProductSales";
			//		    
			// create an array of data points
			db1=new Class1();
			C1WebChart1.Legend.Visible = true;
			//this.AddAxisX();
			//this.AddAxisY();
			string sql="select * from changjia";
			db1.cleardata();
			db1.ExectueSQL("changjia",sql);

			int count=db1.getdata().Tables["changjia"].Rows.Count;
			PointF[] data = new PointF[count];
			for(int i=0;i<db1.getdata().Tables["changjia"].Rows.Count;i++)
			{
				int j=s.IndexOf(db1.getdata().Tables["changjia"].Rows[i]["厂家名称"].ToString(),0,s.Length);
				int l=s.IndexOf("%",j,s.Length-j);
				int m=s.IndexOf(":",j,l-j);
				string s1=s.Substring(m+1,l-m-1);
				float y=float.Parse(s1);
				data[i]=new PointF(i,y);
			}

			ChartDataSeriesCollection dscoll = C1WebChart1.ChartGroups[0].ChartData.SeriesList;			

			dscoll.Clear();

			C1WebChart1.ChartLabels.LabelsCollection.Clear();
            for(int i=0; i < data.Length; i++)
			{
				//ChartDataSeries series = C1WebChart1.ChartGroups[0].ChartData.SeriesList[i];
				//series.PointData.CopyDataIn(data);// 这里的data是PointF类型
				ChartDataSeries series = dscoll.AddNewSeries();
				series.PointData.Length = 1;
				series.Y[0] = data[i].Y;
				series.Label=db1.getdata().Tables["changjia"].Rows[i]["厂家名称"].ToString();



				//加标签
				C1.Win.C1Chart.Label lbl = C1WebChart1.ChartLabels.LabelsCollection.AddNewLabel();
				int j=s.IndexOf(db1.getdata().Tables["changjia"].Rows[i]["厂家名称"].ToString(),0,s.Length);
				int l=s.IndexOf("%",j,s.Length-j);
				int m=s.IndexOf(":",j,l-j);
				
				//float y=s.Substring(m+1,l-m-1);
				lbl.Text="";
				lbl.Text = s.Substring(m+1,l-m);
				lbl.Compass = LabelCompassEnum.Radial;
				lbl.Offset = 20;
				lbl.Connected = true;
				lbl.Visible = true;
				lbl.AttachMethod = AttachMethodEnum.DataIndex;
				AttachMethodData am = lbl.AttachMethodData;
				am.GroupIndex  = 0;
				am.SeriesIndex = i;
				am.PointIndex  = 0;

				//				C1WebChart1.ChartLabels.LabelsCollection.
				
				

			}

			///////C1WebChart1.ChartGroups[0].ChartData.SeriesList[0].Label="1数量";
			//C1WebChart1.ChartGroups[0].ChartData.SeriesList[1].Label="2质量";
			/*C1WebChart1.ChartGroups[0].ChartData.SeriesList[2].Label="3效益";
			C1WebChart1.ChartGroups[0].ChartData.SeriesList[3].Label="4效率";*/
			
			//C1WebChart1.ChartGroups.Group0.ChartData.SeriesList[0].LineStyle.Thickness = 100;
			///////////C1WebChart1.ChartGroups.Group0.Stacked=false;
			//C1WebChart1.ChartArea.PlotArea.GradientStyle=C1.Win.C1Chart.GradientStyleEnum.VerticalCenter;
			
		}
		public void SingleBarData()
		{
			//this.AddAxisY();


			//C1WebChart2.Legend.Visible=true;
			string sql="select * from changjia";
			db1.cleardata();
			db1.ExectueSQL("changjia",sql);

			Axis ax = C1WebChart2.ChartArea.AxisX;
			ax.ValueLabels.Clear();
			
			
			ax.AnnoMethod = AnnotationMethodEnum.ValueLabels;
			for(int i = 0; i < db1.getdata().Tables["changjia"].Rows.Count; i++)
			{
				//DataRowView drv = dv[i];
				ax.ValueLabels.Add(i, db1.getdata().Tables["changjia"].Rows[i]["厂家名称"].ToString());
			}
			try
			{
				ax.Max =2;
			}
			catch {}
			int count=db1.getdata().Tables["changjia"].Rows.Count;
			PointF[] data = new PointF[count];
			for(int i=0;i<db1.getdata().Tables["changjia"].Rows.Count;i++)
			{
				int j=s.IndexOf(db1.getdata().Tables["changjia"].Rows[i]["厂家名称"].ToString(),0,s.Length);
				int l=s.IndexOf("%",j,s.Length-j);
				int m=s.IndexOf(":",j,l-j);
				string s1=s.Substring(m+1,l-m-1);
				float y=float.Parse(s1);
				data[i]=new PointF(i,y);
			}
	
			ChartDataSeriesCollection dscoll = C1WebChart2.ChartGroups[0].ChartData.SeriesList;			

			dscoll.Clear();
			ChartDataSeries series = dscoll.AddNewSeries();
			series.PointData.CopyDataIn(data);// 这里的data是PointF类型
			C1WebChart2.ChartGroups.Group0.Stacked = false;
			C1WebChart2.ChartLabels.LabelsCollection.Clear();
			for(int i=0;i<db1.getdata().Tables["changjia"].Rows.Count;i++)
			{

				C1.Win.C1Chart.Label lbl = C1WebChart2.ChartLabels.LabelsCollection.AddNewLabel();
				int j=s.IndexOf(db1.getdata().Tables["changjia"].Rows[i]["厂家名称"].ToString(),0,s.Length);
				int l=s.IndexOf("%",j,s.Length-j);
				int m=s.IndexOf(":",j,l-j);
				
				//float y=s.Substring(m+1,l-m-1);
				lbl.Text="";
				lbl.Text = s.Substring(m+1,l-m);
				lbl.Compass = LabelCompassEnum.Radial;
				lbl.Offset = 20;
				lbl.Connected = true;
				lbl.Visible = true;
				lbl.AttachMethod = AttachMethodEnum.DataIndex;
				AttachMethodData am = lbl.AttachMethodData;
				am.GroupIndex  = 0;
				am.SeriesIndex = 0;
				am.PointIndex  = i;
			}			
				
		}
		private void C1WebChart1_DrawDataSeries_1(object sender, C1.Win.C1Chart.DrawDataSeriesEventArgs e)
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

		private void C1WebChart2_DrawDataSeries(object sender, C1.Win.C1Chart.DrawDataSeriesEventArgs e)
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
	}
}
