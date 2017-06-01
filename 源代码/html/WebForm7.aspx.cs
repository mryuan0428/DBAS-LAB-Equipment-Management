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
	/// WebForm7 的摘要说明。
	/// </summary>
	public class WebForm7 : System.Web.UI.Page
	{
		protected DataDynamics.ActiveReports.Web.WebViewer WebViewer1;
		protected System.Web.UI.WebControls.LinkButton LinkButton1;
		protected System.Web.UI.WebControls.DropDownList DropDownList1;
		protected System.Web.UI.WebControls.DropDownList DropDownList2;
		protected System.Web.UI.WebControls.DropDownList DropDownList3;
		protected System.Web.UI.WebControls.DropDownList DropDownList4;
		protected System.Web.UI.WebControls.DropDownList DropDownList5;
		protected System.Web.UI.WebControls.DropDownList DropDownList6;
		protected System.Web.UI.WebControls.DropDownList DropDownList7;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.HtmlControls.HtmlInputHidden Hidden1;
		protected System.Web.UI.WebControls.Button Button2;
	
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
			if(!Page.IsPostBack)
			{
				
				this.Hidden1.Value="0";
				sql="select * from labname";
				db1.cleardata();
				db1.ExectueSQL("labname",sql);

				for(int i=0;i<db1.getdata().Tables["labname"].Rows.Count;i++)
				{
					this.DropDownList1.Items.Add(new ListItem(db1.getdata().Tables["labname"].Rows[i]["实验室名"].ToString()));
				}

				for(int i=2000;i<=DateTime.Now.Year;i++)
				{
					this.DropDownList2.Items.Add(new ListItem(i.ToString()));
					this.DropDownList5.Items.Add(new ListItem(i.ToString()));
				}
				for(int i=1;i<=12;i++)
				{
					this.DropDownList3.Items.Add(new ListItem(i.ToString()));
					this.DropDownList6.Items.Add(new ListItem(i.ToString()));
				}
				for(int i=1;i<=31;i++)
				{
					this.DropDownList4.Items.Add(new ListItem(i.ToString()));
					this.DropDownList7.Items.Add(new ListItem(i.ToString()));
				}
				sql="select * from 维护";
				db1.cleardata();
				db1.ExectueSQL("维护",sql);

				this.WebViewer1.ClearCachedReport();
				ActiveReport3 rpt=new ActiveReport3();
				rpt.SetDb(db1);
				//rpt.Restart();
				//rpt.DataSource=db1.getdata();
				rpt.DataMember="维护";
				rpt.Restart();
				this.WebViewer1.Report=rpt;
				this.WebViewer1.Visible=false;
				this.WebViewer1.Report=rpt;
				this.WebViewer1.Visible=true;
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
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.LinkButton1.Click += new System.EventHandler(this.LinkButton1_Click);
			WebViewer1.Report = new html.ActiveReport3();
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void LinkButton1_Click(object sender, System.EventArgs e)
		{
			string sql;
			if(this.Hidden1.Value=="0")
				sql="select * from 维护";
			else
			{
				sql="select * from 维护 where 实验室名='"+this.DropDownList1.SelectedValue+"'";
				sql+=" and 登记日期 between '"+this.DropDownList2.SelectedValue+"-"+this.DropDownList3.SelectedValue+"-"+this.DropDownList4.SelectedValue;
				sql+="' and '"+this.DropDownList5.SelectedValue+"-"+this.DropDownList6.SelectedValue+"-"+this.DropDownList7.SelectedValue+"'";
			}
			db1.cleardata();
			db1.ExectueSQL("维护",sql);

			this.WebViewer1.ClearCachedReport();
			ActiveReport3 rpt=new ActiveReport3();
			rpt.SetDb(db1);
			//rpt.Restart();
			//rpt.DataSource=db1.getdata();
			rpt.DataMember="维护";
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

		private void Button1_Click(object sender, System.EventArgs e)
		{
			this.Hidden1.Value="1";
			ActiveReport3 rpt=new ActiveReport3();
			string sql="select * from 维护 where 实验室名='"+this.DropDownList1.SelectedValue+"'";
			sql+=" and 登记日期 between '"+this.DropDownList2.SelectedValue+"-"+this.DropDownList3.SelectedValue+"-"+this.DropDownList4.SelectedValue;
			sql+="' and '"+this.DropDownList5.SelectedValue+"-"+this.DropDownList6.SelectedValue+"-"+this.DropDownList7.SelectedValue+"'";

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

		private void Button2_Click(object sender, System.EventArgs e)
		{
			this.Hidden1.Value="0";
			ActiveReport3 rpt=new ActiveReport3();
			string sql="select * from 维护";

			db1.cleardata();
			db1.ExectueSQL("维护",sql);

			this.WebViewer1.ClearCachedReport();
			
			rpt.SetDb(db1);
			rpt.DataMember="维护";
			rpt.Run();
			
			this.WebViewer1.Report=rpt;
			
		}
	}
}
