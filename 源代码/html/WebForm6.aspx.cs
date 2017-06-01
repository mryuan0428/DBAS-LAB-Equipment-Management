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
using DataDynamics.ActiveReports.Export.Xls;

namespace html
{
	/// <summary>
	/// WebForm6 的摘要说明。
	/// </summary>
	public class WebForm6 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.LinkButton LinkButton1;
		protected DataDynamics.ActiveReports.Web.WebViewer WebViewer1;
	
		Class1 db1;
		private void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			string name=Session["name"].ToString();
			string id=Session["pwd"].ToString();
			//Response.Write(name+id);
			db1=new Class1();
			string sql="select * from admin where username='";
			sql+=name;
			
			sql+="' and password='";
			sql+=id;
			sql+="'";
			db1.cleardata();
			db1.ExectueSQL("admin",sql);

			if(db1.getdata().Tables["admin"].Rows.Count==0)
			{
				sql="select * from userid where name='"+name+"' and password='"+id+"'";
				db1.cleardata();
				db1.ExectueSQL("userid",sql);
				if(db1.getdata().Tables["userid"].Rows.Count==0)
					Response.Redirect("cuowu1.htm");
			}
			sql="select * from 基本信息 order by 实验室名,设备名称";
			db1.cleardata();
			db1.ExectueSQL("基本信息",sql);

			this.WebViewer1.ClearCachedReport();
			ActiveReport2 rpt=new ActiveReport2();
			rpt.SetDb(db1);
			rpt.DataMember="基本信息";
			rpt.Restart();
			this.WebViewer1.Report=rpt;
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
			this.LinkButton1.Click += new System.EventHandler(this.LinkButton1_Click);
			WebViewer1.Report = new html.ActiveReport2();
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void LinkButton1_Click(object sender, System.EventArgs e)
		{
			db1=new Class1();
			string sql="select * from 基本信息 order by 实验室名,设备名称";
			db1.cleardata();
			db1.ExectueSQL("基本信息",sql);

			this.WebViewer1.ClearCachedReport();
			ActiveReport2 rpt=new ActiveReport2();
			rpt.SetDb(db1);
			rpt.DataMember="基本信息";
			rpt.Run();
			Response.ContentType = "application/x-msexcel";
			Response.AddHeader("content-disposition", "inline; filename=MyXLS.xls");
			XlsExport xls=new XlsExport();
			System.IO.MemoryStream memStream=new System.IO.MemoryStream();
			xls.RemoveVerticalSpace = true;
			xls.Export(rpt.Document, memStream);
			Response.BinaryWrite(memStream.ToArray());
			Response.End();
		}
	}
}
