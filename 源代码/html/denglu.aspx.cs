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

namespace html
{
	/// <summary>
	/// denglu 的摘要说明。
	/// </summary>
	public class denglu : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.TextBox TextBox1;
		protected System.Web.UI.WebControls.TextBox TextBox2;
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Web.UI.WebControls.DropDownList DropDownList1;
		protected System.Web.UI.WebControls.Button Button1;
	
		Class1 db1;
		private void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			Session["name"]="";
			Session["pwd"]="";
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			Session["name"]=this.TextBox1.Text;
			Session["pwd"]=this.TextBox2.Text;
			string name=Session["name"].ToString();
			string id=Session["pwd"].ToString();
			db1=new Class1();
			if(this.DropDownList1.SelectedValue.ToString().Trim()=="管理员")
			{
				string sql="select * from admin where username='";
				sql+=name;
			
				sql+="' and password='";
				sql+=id;
				sql+="'";
				db1.cleardata();
				db1.ExectueSQL("admin",sql);

				if(db1.getdata().Tables["admin"].Rows.Count==0)
				{
					Response.Redirect("cuowu6.htm",true);
				}
			
				else
					Response.Redirect("Frameset2.htm");
			}
			else
			{
				string sql="select * from userid where name='";
				sql+=name;
			
				sql+="' and password='";
				sql+=id;
				sql+="'";
				db1.cleardata();
				db1.ExectueSQL("userid",sql);

				if(db1.getdata().Tables["userid"].Rows.Count==0)
				{
					Response.Redirect("cuowu1.htm",true);
				}
			
				Response.Redirect("Frameset3.htm");
			}
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("zhuce.aspx");
		}
	}
}
