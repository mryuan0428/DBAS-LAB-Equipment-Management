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
	/// WebForm1 的摘要说明。
	/// </summary>
	public class shijianxulie : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.DropDownList DropDownList1;
		protected System.Web.UI.WebControls.Button Button1;
		protected C1.Web.C1WebChart.C1WebChart C1WebChart1;
	
		Class1 db1;
		private void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			db1=new Class1();
			
			if(!Page.IsPostBack)
			{
				
				string sql="select * from sbname";
				db1.cleardata();
				db1.ExectueSQL("sbname",sql);

				for(int i=0;i<db1.getdata().Tables["sbname"].Rows.Count;i++)
				{
					this.DropDownList1.Items.Add(new ListItem(db1.getdata().Tables["sbname"].Rows[i]["设备名称"].ToString()));
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			LinkList l=new LinkList();
			Service1 MyService=new Service1();
			
			l=MyService.Time(this.DropDownList1.SelectedValue.ToString());
			LNode n1=new LNode();
			LNode n2=new LNode();
			n2=n1=l.first.next;
			
			string sql="select * from changjia";
			db1.cleardata();
			db1.ExectueSQL("changjia",sql);
			
			int max=db1.getdata().Tables["changjia"].Rows.Count;
			PointF [][]data=new PointF[max][];
			for(int i=0;i<max;i++)
				data[i]=new PointF[14];
			for(int i=max-1;i>=0;i--)
			{
				//n1=n2;
				for(int j=13;j>=0;j--)
				{
					data[i][j]=new PointF(j,float.Parse(n1.GetData()));
					n1=n1.GetNext();
				}
			}

			/*string s="";
			for(int i=0;i<max;i++)
				for(int j=0;j<14;j++)
					s+=data[i][j].ToString()+",";
			this.Label1.Text=s;*/

			C1WebChart1.Visible=true;
			//C1WebChart1.Header.Text="Chart 头";
			//C1WebChart1.Footer.Text="Chart 尾";
			//C1WebChart1.BackColor = Color.LightSteelBlue;
			//
			C1WebChart1.ImageFormat = System.Drawing.Imaging.ImageFormat.Png;
			C1WebChart1.ImageRenderMethod = ImageRenderMethodEnum.HttpHandler;
			C1WebChart1.ChartGroups.Group0.ChartType = Chart2DTypeEnum.XYPlot;
			//C1WebChart1.Header.Visible= true;
			//C1WebChart1.Header.Text = "折线图";

			C1WebChart1.Legend.Visible = true;
			this.AddAxisX();  //X轴
				
			//for(int i=0; i < 1; i++) //如果是双条,则显示
			//{
			//ChartDataSeries series = C1WebChart1.ChartGroups[0].ChartData.SeriesList[0];
			//series.PointData.CopyDataIn(data);// 这里的data是PointF类型
			//series.FitType = C1.Win.C1Chart.FitTypeEnum.Spline;
			//}
			ChartDataSeriesCollection dscoll = C1WebChart1.ChartGroups[0].ChartData.SeriesList;			

			dscoll.Clear();
			for(int i=0; i < max; i++)
			{
				ChartDataSeries series = dscoll.AddNewSeries();
				series.PointData.Length = 10;
				series.PointData.CopyDataIn(data[i]);// 这里的data是PointF类型
				series.LineStyle.Thickness = 1;
				/*ChartDataSeries series1 = dscoll.AddNewSeries();
				series1.PointData.Length = 10;
				series1.PointData.CopyDataIn(data1);// 这里的data是PointF类型
				series1.LineStyle.Thickness = 1;*/
			}
			for(int i=0;i<max;i++)
			{
				C1WebChart1.ChartGroups[0].ChartData.SeriesList[i].Label=db1.getdata().Tables["changjia"].Rows[i]["厂家名称"].ToString();
			}
			//C1WebChart1.ChartGroups[0].ChartData.SeriesList[1].Label="2质量";
			/*C1WebChart1.ChartGroups[0].ChartData.SeriesList[2].Label="3效益";
			C1WebChart1.ChartGroups[0].ChartData.SeriesList[3].Label="4效率";*/
			
			
			//C1WebChart1.ChartArea.PlotArea.GradientStyle=C1.Win.C1Chart.GradientStyleEnum.VerticalCenter;
			//this.CRM_Operater_xisX();  //X轴


			//this.CRM_Operater_xisY();  //Y轴
			//this.CRM_Operater_xisX();  //X轴
			//CRM_AddY_Value();
			
		}
		public void AddAxisX()
		{
			
			
			// label x axis with product names
			Axis ax = C1WebChart1.ChartArea.AxisX;
			ax.ValueLabels.Clear();
			
			
			ax.AnnoMethod = AnnotationMethodEnum.ValueLabels;
			DateTime dt=DateTime.Now;
			int month1=dt.Month;
			int month=month1;
			for(int i = 0; i < 12; i++)
			{
				//DataRowView drv = dv[i];
				month=month1+i;
				if(month>12)
					month=month-12;
				ax.ValueLabels.Add(i, (month).ToString()+"月");
			}
			ax.ValueLabels.Add(12,"本月");
			ax.ValueLabels.Add(13,"下月");
			try
			{
				//ax.Max = 10 - .5;
			}
			catch {}
			
		}

	}
}
