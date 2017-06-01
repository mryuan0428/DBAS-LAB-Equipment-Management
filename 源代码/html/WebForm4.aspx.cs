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
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Export.Xls;

namespace html
{
	/// <summary>
	/// WebForm4 的摘要说明。
	/// </summary>
	public class WebForm4 : System.Web.UI.Page
	{
		protected DataDynamics.ActiveReports.Web.WebViewer WebViewer1;
	
		Class1 db1;
		ActiveReport1 rpt=new ActiveReport1();
		protected System.Web.UI.HtmlControls.HtmlForm Form3;
		protected System.Web.UI.HtmlControls.HtmlForm Form2;
		protected System.Web.UI.WebControls.DropDownList DropDownList1;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.HtmlControls.HtmlInputHidden Hidden1;
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Web.UI.WebControls.LinkButton LinkButton1;
		//bool ifchanged=false;
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
			if(!Page.IsPostBack)
			{
				string sql1="select * from labname";
				db1.cleardata();
				db1.ExectueSQL("labname",sql1);

				for(int i=0;i<db1.getdata().Tables["labname"].Rows.Count;i++)
				{
					this.DropDownList1.Items.Add(new ListItem(db1.getdata().Tables["labname"].Rows[i]["实验室名"].ToString()));
				}	
				sql="select * from 基本信息";
				db1.cleardata();
				db1.ExectueSQL("基本信息",sql);

				this.WebViewer1.ClearCachedReport();
				rpt.SetDb(db1);
				//rpt.Restart();
				//rpt.DataSource=db1.getdata();
				rpt.DataMember="基本信息";
				rpt.Restart();
				this.WebViewer1.Report=rpt;
				this.WebViewer1.Visible=false;
				this.WebViewer1.Report=rpt;
				this.WebViewer1.Visible=true;
				this.Hidden1.Value="0";
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
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.LinkButton1.Click += new System.EventHandler(this.LinkButton1_Click);
			WebViewer1.Report = new html.ActiveReport1();
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			//this.WebViewer1.Report.Stop();
			this.Hidden1.Value="1";
			string sql="select * from 基本信息 where 实验室名='"+this.DropDownList1.SelectedValue+"'";
			db1.cleardata();
			db1.ExectueSQL("基本信息",sql);

			this.WebViewer1.ClearCachedReport();
			
			rpt.SetDb(db1);
			rpt.DataMember="基本信息";
			rpt.Run();
			
			this.WebViewer1.Report=rpt;
			this.WebViewer1.Visible=false;
			this.WebViewer1.Report=rpt;
			this.WebViewer1.Visible=true;
			
		}

		private void LinkButton1_Click(object sender, System.EventArgs e)
		{
			rpt=new ActiveReport1();
			string sql;
			if(this.Hidden1.Value=="0")
				sql="select * from 基本信息";
			else
				sql="select * from 基本信息 where 实验室名='"+this.DropDownList1.SelectedValue+"'";
			db1.cleardata();
			db1.ExectueSQL("基本信息",sql);

			this.WebViewer1.ClearCachedReport();
			
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

		private void Button2_Click(object sender, System.EventArgs e)
		{
			this.Hidden1.Value="0";
			rpt=new ActiveReport1();
			string sql="select * from 维护";

			db1.cleardata();
			db1.ExectueSQL("维护",sql);

			this.WebViewer1.ClearCachedReport();
			
			rpt.SetDb(db1);
			rpt.DataMember="维护";
			rpt.Run();
			
			this.WebViewer1.Report=rpt;
			this.WebViewer1.Visible=false;
			this.WebViewer1.Report=rpt;
			this.WebViewer1.Visible=true;
		}

	}
}
